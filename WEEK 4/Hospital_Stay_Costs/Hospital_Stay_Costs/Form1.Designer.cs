namespace Hospital_Stay_Costs
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRehab = new System.Windows.Forms.TextBox();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.txtSurgical = new System.Windows.Forms.TextBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.txtNumberofdays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreapproved = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(161, 193);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtRehab
            // 
            this.txtRehab.Location = new System.Drawing.Point(161, 167);
            this.txtRehab.Name = "txtRehab";
            this.txtRehab.Size = new System.Drawing.Size(100, 20);
            this.txtRehab.TabIndex = 2;
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(161, 141);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(100, 20);
            this.txtLab.TabIndex = 3;
            // 
            // txtSurgical
            // 
            this.txtSurgical.Location = new System.Drawing.Point(161, 115);
            this.txtSurgical.Name = "txtSurgical";
            this.txtSurgical.Size = new System.Drawing.Size(100, 20);
            this.txtSurgical.TabIndex = 4;
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(161, 89);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(100, 20);
            this.txtMedication.TabIndex = 5;
            // 
            // txtNumberofdays
            // 
            this.txtNumberofdays.Location = new System.Drawing.Point(161, 63);
            this.txtNumberofdays.Name = "txtNumberofdays";
            this.txtNumberofdays.Size = new System.Drawing.Size(100, 20);
            this.txtNumberofdays.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "No. of days in hospital:";
            // 
            // txtPreapproved
            // 
            this.txtPreapproved.Location = new System.Drawing.Point(161, 37);
            this.txtPreapproved.Name = "txtPreapproved";
            this.txtPreapproved.Size = new System.Drawing.Size(100, 20);
            this.txtPreapproved.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Preapproved:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medication Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Surgical Charges:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lab Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Physical Rehab Charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 299);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreapproved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberofdays);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtSurgical);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.txtRehab);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRehab;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.TextBox txtSurgical;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.TextBox txtNumberofdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreapproved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

