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
            StreamWriter CT = new StreamWriter(Application.StartupPath + "ContactTracerData.txt");

            CT.WriteLine(FirstNameTitle + ":" + FirstNameTB);
            CT.WriteLine(LastNameTitle + ":" + LastNameTB);
            CT.WriteLine(AgeTitle + ":" + AgeTB);
            CT.WriteLine(SexTitle + ":" + SexTB);
            CT.WriteLine(EmailLabel + ":" + EmailTB);
            CT.WriteLine(AddressLAbel + ":" + AddressTB);
            CT.WriteLine(CellphoneTitle + ":" + CellNoTB);
            CT.WriteLine(TelephoneTitle + ":" + TelNoTB);
        }   
    }
}
