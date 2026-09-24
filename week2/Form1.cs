using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // creating variable to store input data
           string name,studentID, department,semester,fullinfo;

            // assign variable to user input
            name = txtname.Text;
            studentID = txtstudentid.Text;
            department = txtdepartment.Text;
            semester = txtsemester.Text;

            //process concatenation
           fullinfo= name + "," + studentID +","+ department +","+semester;

            //display the output

            lbloutput.Text = fullinfo;





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear
            txtname.Text = "";
            txtstudentid.Clear();
            txtdepartment.Text = string.Empty;
            txtsemester.Text = string.Empty;
            lbloutput.Text = string.Empty;

                

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }
    }
}
