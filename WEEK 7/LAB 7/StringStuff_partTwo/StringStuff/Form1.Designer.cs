namespace StringStuff
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
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.txtCaseSwitch = new System.Windows.Forms.TextBox();
            this.txtReverse = new System.Windows.Forms.TextBox();
            this.txtPigLatin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDollarSigns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(107, 25);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(200, 20);
            this.txtEnter.TabIndex = 1;
            // 
            // txtCaseSwitch
            // 
            this.txtCaseSwitch.Location = new System.Drawing.Point(107, 73);
            this.txtCaseSwitch.Name = "txtCaseSwitch";
            this.txtCaseSwitch.ReadOnly = true;
            this.txtCaseSwitch.Size = new System.Drawing.Size(200, 20);
            this.txtCaseSwitch.TabIndex = 2;
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(107, 100);
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.ReadOnly = true;
            this.txtReverse.Size = new System.Drawing.Size(200, 20);
            this.txtReverse.TabIndex = 3;
            // 
            // txtPigLatin
            // 
            this.txtPigLatin.Location = new System.Drawing.Point(107, 129);
            this.txtPigLatin.Name = "txtPigLatin";
            this.txtPigLatin.ReadOnly = true;
            this.txtPigLatin.Size = new System.Drawing.Size(200, 20);
            this.txtPigLatin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Switch Case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reverse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pig Latin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dollar Signs";
            // 
            // txtDollarSigns
            // 
            this.txtDollarSigns.Location = new System.Drawing.Point(107, 159);
            this.txtDollarSigns.Name = "txtDollarSigns";
            this.txtDollarSigns.ReadOnly = true;
            this.txtDollarSigns.Size = new System.Drawing.Size(200, 20);
            this.txtDollarSigns.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 204);
            this.Controls.Add(this.txtDollarSigns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPigLatin);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.txtCaseSwitch);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.TextBox txtCaseSwitch;
        private System.Windows.Forms.TextBox txtReverse;
        private System.Windows.Forms.TextBox txtPigLatin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDollarSigns;
    }
}

