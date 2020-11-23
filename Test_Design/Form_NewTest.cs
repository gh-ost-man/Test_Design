using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLib;

namespace Test_Design
{
    public partial class Form_NewTest : Form
    {
        int qtyQuestion = 0;
        int qtyAnswers = 0;
        int cntQ = 0;
        int cntA = 1;

        List<QuestionCL> questions = new List<QuestionCL>();
        List<AnswerCL> answers = new List<AnswerCL>();
        TestCL testCL;

        public Form_NewTest()
        {
            InitializeComponent();
        }

        public Form_NewTest(TestCL testCL, int qty)
        {
            InitializeComponent();

            this.testCL = testCL;
            this.qtyQuestion = qty;

            btn_Next.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            groupBox_Question.Text = $"Question: {cntQ + 1}";
            if (cntQ == qtyQuestion) { btn_Save.Enabled = true; return; }

            QuestionCL question = new QuestionCL();
            question.Question = textBox_Question.Text;
            question.Answers = answers;

            questions.Add(question);

            Clear();

            cntQ++;
            btn_Next.Enabled = false;
            button_OK.Enabled = true;
        }

        private void Clear()
        {
            textBox_Answer.Text = string.Empty;
            textBox_Question.Text = string.Empty;
            numericUpDown1.Value = 0;
            checkBox_IsRight.Checked = false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0) { MessageBox.Show("Enter qty of answers", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);return ; }
            if (String.IsNullOrEmpty(textBox_Answer.Text)) { MessageBox.Show("Enter answer", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);return ; }

            qtyAnswers = (int)numericUpDown1.Value;

            groupBox_Answer.Text = $"Answer: {cntA+1}";

            if (cntA == qtyAnswers)
            {
                btn_Next.Enabled = true;
                cntA = 1;
                button_OK.Enabled = false;
                textBox_Answer.Text = string.Empty;
                groupBox_Answer.Text = $"Answer: {cntA+1}";

                return;
            }


            bool isRight = false;
            isRight = checkBox_IsRight.Checked;

            AnswerCL answerCL = new AnswerCL(textBox_Answer.Text, isRight);
            answers.Add(answerCL);

            textBox_Answer.Text = string.Empty;
            checkBox_IsRight.Checked = false;

            cntA++;

            this.Text = $"{cntA} {qtyAnswers}";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_FileName.Text))
            {
                MessageBox.Show("Enter file name","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return; 
            }

            testCL.Questions = questions;


            ListTestCL.SerializeTestCL(textBox_FileName.Text,testCL);

            MessageBox.Show("File saved");


        }
    }
}
