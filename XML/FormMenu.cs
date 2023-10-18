using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Microsoft.SqlServer.Management.Smo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace XML
{
    public partial class FormMenu : Form
    {
        private string default_folder_path = @"C:\Users\hoduc\source\repos\XML";
        public FormMenu()
        {
            InitializeComponent();
            panelConvert.Visible = true;
            panelXMLTable.Visible = false;
            panelXMLDOM.Visible = false;
        }

        private void rbConvert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConvert.Checked)
            {
                rbTable.Checked = rbDOM.Checked = false;
                panelXMLTable.Visible = false;
                panelXMLDOM.Visible = false;
                panelConvert.Visible = true;
            }
        }

        private void rbTable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTable.Checked)
            {
                rbConvert.Checked = rbDOM.Checked = false;
                panelConvert.Visible = false;
                panelXMLDOM.Visible = false;
                panelXMLTable.Visible = true;
            }
        }

        private void rbDOM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDOM.Checked)
            {
                rbTable.Checked = rbConvert.Checked = false;
                panelXMLTable.Visible = false;
                panelConvert.Visible = false;
                panelXMLDOM.Visible = true;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Read and convert from table to xml file
            DataTable dt;
            dt = new DataTable("Element");

            String sql = tbQuery.Text;
            SqlCommand command = new SqlCommand(sql, Program.cnn);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);

            //Write it to XML file
            string createFileName = "XML " + DateTime.UtcNow.ToString("yyyy-MM-dd HH-mm-ss");
            String path = default_folder_path + @"\" + createFileName + ".xml";
            dt.WriteXml(path);

            //Show result to screen
            string readFile = File.ReadAllText(path);
            tbXML.Text = readFile;
        }

        private void btnXMLTable_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = default_folder_path;
            openFileDialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }

            DataSet dataSet = new DataSet();
            dataSet.ReadXml(txtFilePath.Text);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = default_folder_path;
            openFileDialog.Filter = "XML File (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }

            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNode xmlnode;
            FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.ChildNodes[1];
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            TreeNode tNode;
            tNode = treeView1.Nodes[0];
            AddNode(xmlnode, tNode);
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }
    }
}
