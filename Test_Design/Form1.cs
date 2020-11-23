using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLib;

namespace Test_Design
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_NetTest_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_NameOfAuthor.Text) ||String.IsNullOrEmpty(textBox_NameOfAuthor.Text) || numericUpDown1.Value==0)
            {
                MessageBox.Show("Fill all fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            TestCL test = new TestCL();
            test.Author = textBox_NameOfAuthor.Text;
            test.TestName = textBox_NameOfTest.Text;


            Form_NewTest newTest = new Form_NewTest(test,(int)numericUpDown1.Value);
            newTest.ShowDialog();
        }
    }
}
