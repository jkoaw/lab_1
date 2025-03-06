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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            textBox1 = new TextBox();
            button_dodo = new Button();
            button_ode = new Button();
            button_mno = new Button();
            button_dzi = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(328, 266);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(121, 209);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(225, 209);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(328, 209);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(121, 154);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(225, 154);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(328, 152);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(225, 316);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 10;
            // 
            // button_dodo
            // 
            button_dodo.Location = new Point(460, 149);
            button_dodo.Name = "button_dodo";
            button_dodo.Size = new Size(65, 28);
            button_dodo.TabIndex = 11;
            button_dodo.Text = "dodaj";
            button_dodo.UseVisualStyleBackColor = true;
            button_dodo.Click += button_dodo_Click;
            // 
            // button_ode
            // 
            button_ode.Location = new Point(460, 207);
            button_ode.Name = "button_ode";
            button_ode.Size = new Size(75, 23);
            button_ode.TabIndex = 12;
            button_ode.Text = "odejmij";
            button_ode.UseVisualStyleBackColor = true;
            button_ode.Click += button_ode_Click;
            // 
            // button_mno
            // 
            button_mno.Location = new Point(460, 250);
            button_mno.Name = "button_mno";
            button_mno.Size = new Size(75, 23);
            button_mno.TabIndex = 13;
            button_mno.Text = "pomnoz";
            button_mno.UseVisualStyleBackColor = true;
            button_mno.Click += button_mno_Click;
            // 
            // button_dzi
            // 
            button_dzi.Location = new Point(460, 288);
            button_dzi.Name = "button_dzi";
            button_dzi.Size = new Size(75, 23);
            button_dzi.TabIndex = 14;
            button_dzi.Text = "dziel";
            button_dzi.UseVisualStyleBackColor = true;
            button_dzi.Click += button_dzi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 444);
            Controls.Add(button_dzi);
            Controls.Add(button_mno);
            Controls.Add(button_ode);
            Controls.Add(button_dodo);
            Controls.Add(textBox1);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private TextBox textBox1;
        private Button button_dodo;
        private Button button_ode;
        private Button button_mno;
        private Button button_dzi;
    }
}
