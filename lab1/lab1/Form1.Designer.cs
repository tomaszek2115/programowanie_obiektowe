﻿namespace lab1
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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 130);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += digitClick;
            // 
            // button2
            // 
            button2.Location = new Point(99, 130);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += digitClick;
            // 
            // button3
            // 
            button3.Location = new Point(195, 130);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += digitClick;
            // 
            // button4
            // 
            button4.Location = new Point(291, 130);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += operatorClick;
            // 
            // button5
            // 
            button5.Location = new Point(3, 226);
            button5.Name = "button5";
            button5.Size = new Size(90, 90);
            button5.TabIndex = 4;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += digitClick;
            // 
            // button6
            // 
            button6.Location = new Point(99, 226);
            button6.Name = "button6";
            button6.Size = new Size(90, 90);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += digitClick;
            // 
            // button7
            // 
            button7.Location = new Point(195, 226);
            button7.Name = "button7";
            button7.Size = new Size(90, 90);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += digitClick;
            // 
            // button8
            // 
            button8.Location = new Point(291, 226);
            button8.Name = "button8";
            button8.Size = new Size(90, 90);
            button8.TabIndex = 7;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += operatorClick;
            // 
            // button9
            // 
            button9.Location = new Point(3, 322);
            button9.Name = "button9";
            button9.Size = new Size(90, 90);
            button9.TabIndex = 8;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += digitClick;
            // 
            // button10
            // 
            button10.Location = new Point(99, 322);
            button10.Name = "button10";
            button10.Size = new Size(90, 90);
            button10.TabIndex = 9;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += digitClick;
            // 
            // button11
            // 
            button11.Location = new Point(195, 322);
            button11.Name = "button11";
            button11.Size = new Size(90, 90);
            button11.TabIndex = 10;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = true;
            button11.Click += digitClick;
            // 
            // button12
            // 
            button12.Location = new Point(291, 322);
            button12.Name = "button12";
            button12.Size = new Size(90, 90);
            button12.TabIndex = 11;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += operatorClick;
            // 
            // button13
            // 
            button13.Location = new Point(3, 418);
            button13.Name = "button13";
            button13.Size = new Size(90, 90);
            button13.TabIndex = 12;
            button13.Text = "DEL";
            button13.UseVisualStyleBackColor = true;
            button13.Click += delClick;
            // 
            // button14
            // 
            button14.Location = new Point(99, 418);
            button14.Name = "button14";
            button14.Size = new Size(90, 90);
            button14.TabIndex = 13;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            button14.Click += digitClick;
            // 
            // button15
            // 
            button15.Location = new Point(195, 418);
            button15.Name = "button15";
            button15.Size = new Size(90, 90);
            button15.TabIndex = 14;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += equalSignClick;
            // 
            // button16
            // 
            button16.Location = new Point(291, 418);
            button16.Name = "button16";
            button16.Size = new Size(90, 90);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += operatorClick;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.Location = new Point(38, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(300, 57);
            textBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(textBox);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
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
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox textBox;
    }
}
