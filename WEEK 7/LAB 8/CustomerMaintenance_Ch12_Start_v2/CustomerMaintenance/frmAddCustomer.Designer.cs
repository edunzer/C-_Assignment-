namespace CustomerMaintenance
{
    partial class frmAddVehicle
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
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.lbPurchasePrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbVin = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNumberOfDoors = new System.Windows.Forms.Label();
            this.lbBedSize = new System.Windows.Forms.Label();
            this.txtNumberOfDoors = new System.Windows.Forms.TextBox();
            this.txtBedSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCar = new System.Windows.Forms.CheckBox();
            this.chkTruck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(103, 133);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(176, 20);
            this.txtPurchasePrice.TabIndex = 15;
            this.txtPurchasePrice.Tag = "Purchase Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(103, 101);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(176, 20);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Tag = "Description";
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(103, 69);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(176, 20);
            this.txtVin.TabIndex = 13;
            this.txtVin.Tag = "Vin";
            // 
            // lbPurchasePrice
            // 
            this.lbPurchasePrice.Location = new System.Drawing.Point(12, 130);
            this.lbPurchasePrice.Name = "lbPurchasePrice";
            this.lbPurchasePrice.Size = new System.Drawing.Size(95, 23);
            this.lbPurchasePrice.TabIndex = 20;
            this.lbPurchasePrice.Text = "Purchase Price:";
            this.lbPurchasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(11, 101);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(72, 23);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Description:";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVin
            // 
            this.lbVin.Location = new System.Drawing.Point(11, 69);
            this.lbVin.Name = "lbVin";
            this.lbVin.Size = new System.Drawing.Size(72, 23);
            this.lbVin.TabIndex = 18;
            this.lbVin.Text = "Vin:";
            this.lbVin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(170, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNumberOfDoors
            // 
            this.lbNumberOfDoors.AutoSize = true;
            this.lbNumberOfDoors.Location = new System.Drawing.Point(13, 166);
            this.lbNumberOfDoors.Name = "lbNumberOfDoors";
            this.lbNumberOfDoors.Size = new System.Drawing.Size(60, 13);
            this.lbNumberOfDoors.TabIndex = 21;
            this.lbNumberOfDoors.Text = "# of Doors:";
            this.lbNumberOfDoors.Visible = false;
            // 
            // lbBedSize
            // 
            this.lbBedSize.AutoSize = true;
            this.lbBedSize.Location = new System.Drawing.Point(13, 165);
            this.lbBedSize.Name = "lbBedSize";
            this.lbBedSize.Size = new System.Drawing.Size(52, 13);
            this.lbBedSize.TabIndex = 22;
            this.lbBedSize.Text = "Bed Size:";
            this.lbBedSize.Visible = false;
            // 
            // txtNumberOfDoors
            // 
            this.txtNumberOfDoors.Location = new System.Drawing.Point(103, 163);
            this.txtNumberOfDoors.Name = "txtNumberOfDoors";
            this.txtNumberOfDoors.Size = new System.Drawing.Size(176, 20);
            this.txtNumberOfDoors.TabIndex = 16;
            this.txtNumberOfDoors.Tag = "Number of Doors";
            this.txtNumberOfDoors.Visible = false;
            // 
            // txtBedSize
            // 
            this.txtBedSize.Location = new System.Drawing.Point(103, 163);
            this.txtBedSize.Name = "txtBedSize";
            this.txtBedSize.Size = new System.Drawing.Size(176, 20);
            this.txtBedSize.TabIndex = 17;
            this.txtBedSize.Tag = "Bed Size";
            this.txtBedSize.Visible = false;
            this.txtBedSize.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Select vehicle type:";
            // 
            // chkCar
            // 
            this.chkCar.AutoSize = true;
            this.chkCar.Location = new System.Drawing.Point(127, 24);
            this.chkCar.Name = "chkCar";
            this.chkCar.Size = new System.Drawing.Size(42, 17);
            this.chkCar.TabIndex = 24;
            this.chkCar.Text = "Car";
            this.chkCar.UseVisualStyleBackColor = true;
            this.chkCar.CheckedChanged += new System.EventHandler(this.chkCar_CheckedChanged);
            // 
            // chkTruck
            // 
            this.chkTruck.AutoSize = true;
            this.chkTruck.Location = new System.Drawing.Point(189, 24);
            this.chkTruck.Name = "chkTruck";
            this.chkTruck.Size = new System.Drawing.Size(54, 17);
            this.chkTruck.TabIndex = 25;
            this.chkTruck.Text = "Truck";
            this.chkTruck.UseVisualStyleBackColor = true;
            this.chkTruck.CheckedChanged += new System.EventHandler(this.chkTruck_CheckedChanged);
            // 
            // frmAddVehicle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(303, 293);
            this.ControlBox = false;
            this.Controls.Add(this.chkTruck);
            this.Controls.Add(this.chkCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbBedSize);
            this.Controls.Add(this.lbNumberOfDoors);
            this.Controls.Add(this.txtNumberOfDoors);
            this.Controls.Add(this.txtBedSize);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.lbPurchasePrice);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbVin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lbPurchasePrice;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbVin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNumberOfDoors;
        private System.Windows.Forms.Label lbBedSize;
        private System.Windows.Forms.TextBox txtNumberOfDoors;
        private System.Windows.Forms.TextBox txtBedSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCar;
        private System.Windows.Forms.CheckBox chkTruck;
    }
}