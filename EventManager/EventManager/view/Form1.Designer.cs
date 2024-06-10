namespace EventManager
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.title_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desc_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priority_box = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // title_box
            // 
            this.title_box.Location = new System.Drawing.Point(13, 30);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(200, 20);
            this.title_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // desc_box
            // 
            this.desc_box.Location = new System.Drawing.Point(13, 74);
            this.desc_box.Name = "desc_box";
            this.desc_box.Size = new System.Drawing.Size(200, 20);
            this.desc_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(13, 118);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(200, 20);
            this.date_picker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.type_box.Location = new System.Drawing.Point(13, 161);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(200, 21);
            this.type_box.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // priority_box
            // 
            this.priority_box.FormattingEnabled = true;
            this.priority_box.Items.AddRange(new object[] {
            "Work",
            "Family",
            "Entertainment",
            "Health",
            "Sport"});
            this.priority_box.Location = new System.Drawing.Point(13, 206);
            this.priority_box.Name = "priority_box";
            this.priority_box.Size = new System.Drawing.Size(200, 21);
            this.priority_box.TabIndex = 9;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 242);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(200, 23);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "button1";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(220, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 425);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.priority_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desc_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox priority_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

