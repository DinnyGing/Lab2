namespace Lab2
{
    partial class EditAppointment
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
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxClient = new System.Windows.Forms.DomainUpDown();
            this.textBoxProcedure = new System.Windows.Forms.DomainUpDown();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 30);
            this.label9.TabIndex = 40;
            this.label9.Text = "Client";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 43);
            this.label1.TabIndex = 35;
            this.label1.Text = "Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "Procedure";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "Confirm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(168, 77);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(360, 22);
            this.datePicker.TabIndex = 45;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClient.Location = new System.Drawing.Point(168, 157);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(360, 34);
            this.textBoxClient.TabIndex = 46;
            // 
            // textBoxProcedure
            // 
            this.textBoxProcedure.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcedure.Location = new System.Drawing.Point(168, 203);
            this.textBoxProcedure.Name = "textBoxProcedure";
            this.textBoxProcedure.Size = new System.Drawing.Size(360, 34);
            this.textBoxProcedure.TabIndex = 47;
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Location = new System.Drawing.Point(168, 122);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(360, 22);
            this.timePicker.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 305);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProcedure);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DomainUpDown textBoxClient;
        private System.Windows.Forms.DomainUpDown textBoxProcedure;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label3;
    }
}