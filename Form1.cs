using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracer
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void ContactTracingForm_Load(object sender, EventArgs e)
        {

        }

        private void TelephoneTitle_Click(object sender, EventArgs e)
        {

        }

        private void TelNoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTracingForm_Load_1(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            TextWriter CT = new StreamWriter(@"D:\COLLEGE FILES\ContactTracer\Contact-Tracer\Contact-Tracer\ContactTracerData.txt");

            CT.WriteLine("First Name:" + FirstNameTB.Text);
            CT.WriteLine("Last Name:" + LastNameTB.Text);
            CT.WriteLine("Age:" + AgeTB.Text);
            CT.WriteLine("Sex:" + SexTB.Text);
            CT.WriteLine("Email:" + EmailTB.Text);
            CT.WriteLine("Address:" + AddressTB.Text);
            CT.WriteLine("Cellphone Number:" + CellNoTB.Text);
            CT.WriteLine("Telephone Number:" + TelNoTB.Text);

            CT.Close();
       
            MessageBox.Show("Would you like to view the gathered data?", "ATTENTION!", MessageBoxButtons.YesNo);
            {
                if (MessageBox.Show("Would you like to view the gathered data?", "ATTENTION!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
                if (MessageBox.Show("Would you like to view the gathered data?", "ATTENTION!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Visible = false;
                    Form2 F2 = new Form2();
                    F2.Show();

                
                }


            }
        }
    }
}
