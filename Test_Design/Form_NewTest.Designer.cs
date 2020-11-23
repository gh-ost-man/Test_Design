namespace Test_Design
{
    partial class Form_NewTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Question = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Answer = new System.Windows.Forms.GroupBox();
            this.checkBox_IsRight = new System.Windows.Forms.CheckBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.groupBox_Question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox_Answer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Question
            // 
            this.groupBox_Question.Controls.Add(this.numericUpDown1);
            this.groupBox_Question.Controls.Add(this.label2);
            this.groupBox_Question.Controls.Add(this.textBox_Question);
            this.groupBox_Question.Controls.Add(this.label1);
            this.groupBox_Question.Location = new System.Drawing.Point(143, 21);
            this.groupBox_Question.Name = "groupBox_Question";
            this.groupBox_Question.Size = new System.Drawing.Size(509, 97);
            this.groupBox_Question.TabIndex = 0;
            this.groupBox_Question.TabStop = false;
            this.groupBox_Question.Text = "Question";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qty answers";
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(87, 29);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(416, 20);
            this.textBox_Question.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // groupBox_Answer
            // 
            this.groupBox_Answer.Controls.Add(this.checkBox_IsRight);
            this.groupBox_Answer.Controls.Add(this.button_OK);
            this.groupBox_Answer.Controls.Add(this.textBox_Answer);
            this.groupBox_Answer.Controls.Add(this.label3);
            this.groupBox_Answer.Location = new System.Drawing.Point(143, 151);
            this.groupBox_Answer.Name = "groupBox_Answer";
            this.groupBox_Answer.Size = new System.Drawing.Size(517, 155);
            this.groupBox_Answer.TabIndex = 1;
            this.groupBox_Answer.TabStop = false;
            this.groupBox_Answer.Text = "Answers";
            // 
            // checkBox_IsRight
            // 
            this.checkBox_IsRight.AutoSize = true;
            this.checkBox_IsRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_IsRight.Location = new System.Drawing.Point(58, 55);
            this.checkBox_IsRight.Name = "checkBox_IsRight";
            this.checkBox_IsRight.Size = new System.Drawing.Size(59, 17);
            this.checkBox_IsRight.TabIndex = 3;
            this.checkBox_IsRight.Text = "IsRight";
            this.checkBox_IsRight.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(58, 90);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(58, 29);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(432, 20);
            this.textBox_Answer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Answer";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(143, 312);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(143, 394);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(143, 368);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(255, 20);
            this.textBox_FileName.TabIndex = 4;
            // 
            // Form_NewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.groupBox_Answer);
            this.Controls.Add(this.groupBox_Question);
            this.Name = "Form_NewTest";
            this.Text = "Form_NewTest";
            this.groupBox_Question.ResumeLayout(false);
            this.groupBox_Question.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox_Answer.ResumeLayout(false);
            this.groupBox_Answer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Question;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Answer;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.CheckBox checkBox_IsRight;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox textBox_FileName;
    }
}