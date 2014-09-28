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

namespace StudentStoreApp
{
    public partial class StudentStoreApp : Form
    {
        private string fileLocation = @"studentName.txt";
        public StudentStoreApp()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(fileNameTextBox.Text);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            fileNameTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            listBox1.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                
                string aLine = aStreamReader.ReadLine();
                listBox1.Items.Add(aLine);

                //textBox2.Text = textBox2.Text + aLine + "\n";
            }
            
            aStreamReader.Close();
        }

    }
}
