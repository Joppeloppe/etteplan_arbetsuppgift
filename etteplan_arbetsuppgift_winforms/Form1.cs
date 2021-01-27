using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace etteplan_arbetsuppgift_winforms
{
    public partial class Form1 : Form
    {
        public List<TranslationUnit> TranslationUnits { get; private set; }

        private string FilePath { get; set; }
        private string FilePathToHTML { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a FileDialog to browse for an XML file to use.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                textBoxFileName.Text = FilePath;
            }
        }

        /// <summary>
        /// Generates the HTML file, with the translations from the XML file
        /// selected from Browse or pasted path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxLog.Text += "Starting...\n";
                SetTranslationUnitFromXML(FilePath);

                textBoxLog.Text += "Creating new HTML file...\n";
                string content = File.ReadAllText(@"..\..\Resources\html_prefix.txt");

                foreach (var transUnit in TranslationUnits)
                {
                    content += String.Format("\t\t\t<tr>\n" +
                                                "\t\t\t\t<td> {0} </td>\n" +
                                                "\t\t\t\t<td> {1} </td>\n" +
                                                "\t\t\t\t<td> {2} </td>\n" +
                                            "\t\t\t</tr>\n", transUnit.Id, transUnit.Source, transUnit.Target);
                }

                content += File.ReadAllText(@"..\..\Resources\html_suffix.txt");

                // Creates the path to the XML file, and creates the new HTML file there.
                string[] sub = FilePath.Split('\\');
                string pathToXml = string.Empty;
                for (int i = 0; i < sub.Length-1; i++)
                {
                    pathToXml += sub[i] + '\\';
                }
                FilePathToHTML = pathToXml + "result.html";
                File.WriteAllText(FilePathToHTML, content);

                textBoxLog.Text += "DONE!\n";
                buttonResult.Enabled = true;
            }
            catch (Exception ex)
            {
                textBoxLog.Text += "\nError creating HTML!\n";
                textBoxLog.Text += ex.Message;
            }
        }

        /// <summary>
        /// Reads an XML file from Resources folder and adds them to the TranslationUnits list.
        /// </summary>
        /// <param name="filename">Name of the XML file located in Resources folder to be read.</param>
        /// This will need to be looked over if the formatting of the XML file is changed.
        private void SetTranslationUnitFromXML(string filename)
        {
            textBoxLog.Text += "Fetching XML...\n";
            try
            {
                XElement xelement = XElement.Load(filename);

                //TODO Change if formatting of XML file is different.
                // Several .Elements() for nested XML file, this returns an array of the elements in <body>
                IEnumerable<XElement> transUnits = xelement.Elements().Elements().Elements();
                
                if (TranslationUnits == null) TranslationUnits = new List<TranslationUnit>();

                foreach (var unit in transUnits)
                {
                    if (unit.Name == "trans-unit")
                    {
                        TranslationUnit transUnit = new TranslationUnit();

                        transUnit.Id = int.Parse(unit.Attribute("id").Value);
                        transUnit.Source = unit.Element("source").Value;
                        transUnit.Target = unit.Element("target").Value;

                        TranslationUnits.Add(transUnit);
                        //Console.WriteLine(transUnit.Id + ": " + transUnit.Source + " - " + transUnit.Target);
                    }
                }
                textBoxLog.Text += "Xml fetched successfully!\n";
            }
            catch (Exception ex)
            {
                textBoxLog.Text += "\nError loading XML!\n";
                textBoxLog.Text += ex.Message;
            }

        }

        /// <summary>
        /// Opens the generated HTML file in the default web browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResult_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FilePathToHTML);
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            FilePath = textBoxFileName.Text;
        }
    }
}