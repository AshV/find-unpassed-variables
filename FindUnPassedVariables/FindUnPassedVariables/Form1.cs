using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace FindUnPassedVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkUploadSchema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Filter = "Xml Schemas|*.xsd";
            objOpenFileDialog.FilterIndex = 0;
            DialogResult result = objOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.Copy(objOpenFileDialog.FileName, "sample.xsd", true);
                chkSchema.Enabled = chkSchema.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkSchema.Enabled = File.Exists("sample.xsd") ? true : false;
        }

        private void lnkTCFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            objOpenFileDialog.Filter = "TestCase File|*.tc";
            objOpenFileDialog.FilterIndex = 0;
            DialogResult result = objOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.Copy(objOpenFileDialog.FileName, "sample.tc", true);
                chkSchema.Enabled = chkSchema.Checked = true;
                StartParse();
            }

        }

        private void StartParse()
        {
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;
                settings.IgnoreWhitespace = true;
                if (File.Exists("sample.xsd"))
                {
                    XmlSchema schema = null;
                    using (XmlReader reader = XmlReader.Create("sample.xsd"))
                    {
                        schema = XmlSchema.Read(reader, null);
                    }
                    settings.ValidationType = ValidationType.Schema;
                    settings.Schemas.Add(schema);
                }

                using (XmlReader reader = XmlReader.Create("sample.tc", settings))
                {
                    while (reader.Read()) ;
                }
                Parsing objParsing = new Parsing();
                Comparing objComparing = new Comparing();
                lblResult.Text = objComparing.Comparison(objParsing.Parse()).Length > 0 ? "\n" + objComparing.Comparison(objParsing.Parse()) + "\n\n" : "\nAll Variables Are Properly Passed.\n\n";
            }
            catch (XmlException xe)
            {
                lblResult.Text = "Either XML Schema or Provided XML File in Invalid";
                lblResult.Text += xe.Message;
            }
            catch (XmlSchemaValidationException xe)
            {
                lblResult.Text = "Given XML file Having Syntax Error Against Provided Schema Please Check By Opening in Visual Studio.";
                lblResult.Text += xe.Message;
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("sample.tc", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(f))
            {
                sw.Write(textBox1.Text);
            }
            StartParse();
        }
    }
}