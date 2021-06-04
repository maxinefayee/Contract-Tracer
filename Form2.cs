using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string link = @"D:\COLLEGE FILES\ContactTracer\Contact-Tracer\Contact-Tracer\ContactTracerData.txt";
            StreamReader file = new StreamReader(link);
            string CTData = file.ReadToEnd();
            ShowData.Text = CTData.ToString();
            file.Close();
        }
    }
}
