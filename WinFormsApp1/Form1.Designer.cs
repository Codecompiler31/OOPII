namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtRoll = new TextBox();
            txtId = new TextBox();
            txtSemester = new TextBox();
            txtBlood = new TextBox();
            rbtnmale = new RadioButton();
            rbtnfemale = new RadioButton();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 29);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Registration Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 105);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "Student's Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 148);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 2;
            label3.Text = "Roll";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 187);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 3;
            label4.Text = "Regestration ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 226);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 4;
            label5.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 261);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 5;
            label6.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 302);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 6;
            label7.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new Point(239, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 23);
            txtName.TabIndex = 7;
            // 
            // txtRoll
            // 
            txtRoll.Location = new Point(239, 140);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(312, 23);
            txtRoll.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(239, 184);
            txtId.Name = "txtId";
            txtId.Size = new Size(312, 23);
            txtId.TabIndex = 7;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(239, 218);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(312, 23);
            txtSemester.TabIndex = 7;
            // 
            // txtBlood
            // 
            txtBlood.Location = new Point(239, 253);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(312, 23);
            txtBlood.TabIndex = 7;
            // 
            // rbtnmale
            // 
            rbtnmale.AutoSize = true;
            rbtnmale.Location = new Point(245, 306);
            rbtnmale.Name = "rbtnmale";
            rbtnmale.Size = new Size(51, 19);
            rbtnmale.TabIndex = 8;
            rbtnmale.TabStop = true;
            rbtnmale.Text = "Male";
            rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtnfemale
            // 
            rbtnfemale.AutoSize = true;
            rbtnfemale.Location = new Point(400, 306);
            rbtnfemale.Name = "rbtnfemale";
            rbtnfemale.Size = new Size(63, 19);
            rbtnfemale.TabIndex = 9;
            rbtnfemale.TabStop = true;
            rbtnfemale.Text = "Female";
            rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(239, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Submit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(rbtnfemale);
            Controls.Add(rbtnmale);
            Controls.Add(txtBlood);
            Controls.Add(txtSemester);
            Controls.Add(txtId);
            Controls.Add(txtRoll);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Student Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox5;
        private RadioButton radioButton2;
        private Button btnSave;
        public TextBox txtName;
        public TextBox txtRoll;
        public TextBox txtId;
        public TextBox txtSemester;
        public TextBox txtBlood;
        public RadioButton rbtnmale;
        public RadioButton rbtnfemale;
    }
}
