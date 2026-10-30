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

namespace close_file
{
    public partial class Form1 : Form
    {
        // File location
        string filePath = Path.Combine(Application.StartupPath, "myfile.doc");

        public Form1()
        {
            InitializeComponent();
        }

        // Read Lines
        private void btnreadlines_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    listbox.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found! Please click Write File first.");
            }
        }

        // Read All Lines
        private void btnreadAlllines_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    listbox.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found! Please click Write File first.");
            }
        }

        // Read Block
        private void btnreadblock_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();

            if (File.Exists(filePath))
            {
                using (StreamReader input_file = File.OpenText(filePath))
                {
                    char[] buffer = new char[5];
                    int count;

                    while ((count = input_file.ReadBlock(buffer, 0, 5)) > 0)
                    {
                        listbox.Items.Add(new string(buffer, 0, count));
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found! Please click Write File first.");
            }
        }

        // Write File
        private void btnwrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter lines = File.CreateText(filePath))
            {
                lines.WriteLine("Introduction to Computer Studies");
                lines.WriteLine("Welcome to Programming Class");
                lines.WriteLine("Department of Information Technology");
                lines.WriteLine("Learning File Handling in C#");
            }

            MessageBox.Show("File successfully created and written!");
        }

        // Delete Items (Text Only)
        private void btndeleteitems_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");

                listbox.Items.Clear();

                MessageBox.Show("All text deleted successfully!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        // Delete File
        private void btndeletefile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                listbox.Items.Clear();

                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        // Delete The File
        private void btndeletethefile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                listbox.Items.Clear();

                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        // Clear ListBox
        private void btnclear_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnwrite_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnreadblock_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}