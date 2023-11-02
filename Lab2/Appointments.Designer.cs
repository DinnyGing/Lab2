namespace Lab2
{
    partial class Appointments
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.futureBox = new System.Windows.Forms.CheckBox();
            this.lastBox = new System.Windows.Forms.CheckBox();
            this.earlyBox = new System.Windows.Forms.CheckBox();
            this.lastestBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add New Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 292);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 34);
            this.button2.TabIndex = 37;
            this.button2.Text = "Use Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "Filter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // futureBox
            // 
            this.futureBox.AutoSize = true;
            this.futureBox.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureBox.Location = new System.Drawing.Point(169, 70);
            this.futureBox.Name = "futureBox";
            this.futureBox.Size = new System.Drawing.Size(93, 28);
            this.futureBox.TabIndex = 42;
            this.futureBox.Text = "Future";
            this.futureBox.UseVisualStyleBackColor = true;
            // 
            // lastBox
            // 
            this.lastBox.AutoSize = true;
            this.lastBox.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBox.Location = new System.Drawing.Point(92, 70);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(71, 28);
            this.lastBox.TabIndex = 43;
            this.lastBox.Text = "Last";
            this.lastBox.UseVisualStyleBackColor = true;
            // 
            // earlyBox
            // 
            this.earlyBox.AutoSize = true;
            this.earlyBox.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earlyBox.Location = new System.Drawing.Point(679, 70);
            this.earlyBox.Name = "earlyBox";
            this.earlyBox.Size = new System.Drawing.Size(82, 28);
            this.earlyBox.TabIndex = 47;
            this.earlyBox.Text = "Early";
            this.earlyBox.UseVisualStyleBackColor = true;
            // 
            // lastestBox
            // 
            this.lastestBox.AutoSize = true;
            this.lastestBox.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastestBox.Location = new System.Drawing.Point(767, 71);
            this.lastestBox.Name = "lastestBox";
            this.lastestBox.Size = new System.Drawing.Size(96, 28);
            this.lastestBox.TabIndex = 46;
            this.lastestBox.Text = "Lastest";
            this.lastestBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(874, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 34);
            this.button3.TabIndex = 45;
            this.button3.Text = "Use Sorted";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 30);
            this.label3.TabIndex = 44;
            this.label3.Text = "Sort First Data Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(874, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 34);
            this.button4.TabIndex = 48;
            this.button4.Text = "Next Page";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 34);
            this.button5.TabIndex = 49;
            this.button5.Text = "Previous Page";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 30);
            this.label4.TabIndex = 50;
            this.label4.Text = "Currennt Page:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPage
            // 
            this.textBoxPage.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPage.Location = new System.Drawing.Point(375, 408);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.ReadOnly = true;
            this.textBoxPage.Size = new System.Drawing.Size(47, 34);
            this.textBoxPage.TabIndex = 51;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.textBoxPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.earlyBox);
            this.Controls.Add(this.lastestBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.futureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Appointments";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox futureBox;
        private System.Windows.Forms.CheckBox lastBox;
        private System.Windows.Forms.CheckBox earlyBox;
        private System.Windows.Forms.CheckBox lastestBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPage;
    }
}