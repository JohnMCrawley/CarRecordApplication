namespace CarRecordApplication
{
    partial class CarRecordsApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRecordsApplication));
            this.groupboxAddRecord = new System.Windows.Forms.GroupBox();
            this.txtboxOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtboxEngineSize = new System.Windows.Forms.TextBox();
            this.txtboxCarCol = new System.Windows.Forms.TextBox();
            this.txtboxCarMod = new System.Windows.Forms.TextBox();
            this.txtboxCarMan = new System.Windows.Forms.TextBox();
            this.checkboxPetrol = new System.Windows.Forms.CheckBox();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblPetrol = new System.Windows.Forms.Label();
            this.lblCarCol = new System.Windows.Forms.Label();
            this.lblCarMod = new System.Windows.Forms.Label();
            this.lblCarMan = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.groupboxDisplayRecords = new System.Windows.Forms.GroupBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.listboxDisplayRecords = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxAddRecord.SuspendLayout();
            this.groupboxDisplayRecords.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxAddRecord
            // 
            this.groupboxAddRecord.Controls.Add(this.txtboxOrderNumber);
            this.groupboxAddRecord.Controls.Add(this.lblOrderNumber);
            this.groupboxAddRecord.Controls.Add(this.btnSave);
            this.groupboxAddRecord.Controls.Add(this.txtboxEngineSize);
            this.groupboxAddRecord.Controls.Add(this.txtboxCarCol);
            this.groupboxAddRecord.Controls.Add(this.txtboxCarMod);
            this.groupboxAddRecord.Controls.Add(this.txtboxCarMan);
            this.groupboxAddRecord.Controls.Add(this.checkboxPetrol);
            this.groupboxAddRecord.Controls.Add(this.lblEngineSize);
            this.groupboxAddRecord.Controls.Add(this.lblPetrol);
            this.groupboxAddRecord.Controls.Add(this.lblCarCol);
            this.groupboxAddRecord.Controls.Add(this.lblCarMod);
            this.groupboxAddRecord.Controls.Add(this.lblCarMan);
            this.groupboxAddRecord.Controls.Add(this.btnResetForm);
            this.groupboxAddRecord.Controls.Add(this.btnAddRecord);
            this.groupboxAddRecord.Location = new System.Drawing.Point(12, 27);
            this.groupboxAddRecord.Name = "groupboxAddRecord";
            this.groupboxAddRecord.Size = new System.Drawing.Size(255, 278);
            this.groupboxAddRecord.TabIndex = 0;
            this.groupboxAddRecord.TabStop = false;
            this.groupboxAddRecord.Text = " Add Record";
            // 
            // txtboxOrderNumber
            // 
            this.txtboxOrderNumber.Location = new System.Drawing.Point(124, 23);
            this.txtboxOrderNumber.Name = "txtboxOrderNumber";
            this.txtboxOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxOrderNumber.TabIndex = 0;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(22, 25);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNumber.TabIndex = 13;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxEngineSize
            // 
            this.txtboxEngineSize.Location = new System.Drawing.Point(124, 175);
            this.txtboxEngineSize.Name = "txtboxEngineSize";
            this.txtboxEngineSize.Size = new System.Drawing.Size(100, 20);
            this.txtboxEngineSize.TabIndex = 5;
            // 
            // txtboxCarCol
            // 
            this.txtboxCarCol.Location = new System.Drawing.Point(124, 120);
            this.txtboxCarCol.Name = "txtboxCarCol";
            this.txtboxCarCol.Size = new System.Drawing.Size(100, 20);
            this.txtboxCarCol.TabIndex = 3;
            // 
            // txtboxCarMod
            // 
            this.txtboxCarMod.Location = new System.Drawing.Point(124, 87);
            this.txtboxCarMod.Name = "txtboxCarMod";
            this.txtboxCarMod.Size = new System.Drawing.Size(100, 20);
            this.txtboxCarMod.TabIndex = 2;
            // 
            // txtboxCarMan
            // 
            this.txtboxCarMan.Location = new System.Drawing.Point(124, 54);
            this.txtboxCarMan.Name = "txtboxCarMan";
            this.txtboxCarMan.Size = new System.Drawing.Size(100, 20);
            this.txtboxCarMan.TabIndex = 1;
            // 
            // checkboxPetrol
            // 
            this.checkboxPetrol.AutoSize = true;
            this.checkboxPetrol.Location = new System.Drawing.Point(124, 152);
            this.checkboxPetrol.Name = "checkboxPetrol";
            this.checkboxPetrol.Size = new System.Drawing.Size(15, 14);
            this.checkboxPetrol.TabIndex = 4;
            this.checkboxPetrol.UseVisualStyleBackColor = true;
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(22, 178);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(63, 13);
            this.lblEngineSize.TabIndex = 6;
            this.lblEngineSize.Text = "Engine Size";
            // 
            // lblPetrol
            // 
            this.lblPetrol.AutoSize = true;
            this.lblPetrol.Location = new System.Drawing.Point(22, 153);
            this.lblPetrol.Name = "lblPetrol";
            this.lblPetrol.Size = new System.Drawing.Size(34, 13);
            this.lblPetrol.TabIndex = 5;
            this.lblPetrol.Text = "Petrol";
            // 
            // lblCarCol
            // 
            this.lblCarCol.AutoSize = true;
            this.lblCarCol.Location = new System.Drawing.Point(22, 123);
            this.lblCarCol.Name = "lblCarCol";
            this.lblCarCol.Size = new System.Drawing.Size(56, 13);
            this.lblCarCol.TabIndex = 4;
            this.lblCarCol.Text = "Car Colour";
            // 
            // lblCarMod
            // 
            this.lblCarMod.AutoSize = true;
            this.lblCarMod.Location = new System.Drawing.Point(22, 90);
            this.lblCarMod.Name = "lblCarMod";
            this.lblCarMod.Size = new System.Drawing.Size(55, 13);
            this.lblCarMod.TabIndex = 3;
            this.lblCarMod.Text = "Car Model";
            // 
            // lblCarMan
            // 
            this.lblCarMan.AutoSize = true;
            this.lblCarMan.Location = new System.Drawing.Point(22, 54);
            this.lblCarMan.Name = "lblCarMan";
            this.lblCarMan.Size = new System.Drawing.Size(89, 13);
            this.lblCarMan.TabIndex = 2;
            this.lblCarMan.Text = "Car Manufacturer";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(9, 224);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(90, 224);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecord.TabIndex = 6;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // groupboxDisplayRecords
            // 
            this.groupboxDisplayRecords.Controls.Add(this.btnDeleteRecord);
            this.groupboxDisplayRecords.Controls.Add(this.listboxDisplayRecords);
            this.groupboxDisplayRecords.Controls.Add(this.btnDisplay);
            this.groupboxDisplayRecords.Controls.Add(this.btnEdit);
            this.groupboxDisplayRecords.Location = new System.Drawing.Point(273, 27);
            this.groupboxDisplayRecords.Name = "groupboxDisplayRecords";
            this.groupboxDisplayRecords.Size = new System.Drawing.Size(382, 278);
            this.groupboxDisplayRecords.TabIndex = 1;
            this.groupboxDisplayRecords.TabStop = false;
            this.groupboxDisplayRecords.Text = "Display Records";
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(317, 76);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(55, 23);
            this.btnDeleteRecord.TabIndex = 3;
            this.btnDeleteRecord.Text = "Delete";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // listboxDisplayRecords
            // 
            this.listboxDisplayRecords.FormattingEnabled = true;
            this.listboxDisplayRecords.Location = new System.Drawing.Point(7, 20);
            this.listboxDisplayRecords.Name = "listboxDisplayRecords";
            this.listboxDisplayRecords.Size = new System.Drawing.Size(304, 225);
            this.listboxDisplayRecords.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(317, 18);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(55, 23);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(317, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(666, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // submenuClose
            // 
            this.submenuClose.Name = "submenuClose";
            this.submenuClose.Size = new System.Drawing.Size(103, 22);
            this.submenuClose.Text = "Close";
            this.submenuClose.Click += new System.EventHandler(this.submenuClose_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // CarRecordsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 315);
            this.Controls.Add(this.groupboxDisplayRecords);
            this.Controls.Add(this.groupboxAddRecord);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "CarRecordsApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Records";
            this.groupboxAddRecord.ResumeLayout(false);
            this.groupboxAddRecord.PerformLayout();
            this.groupboxDisplayRecords.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxAddRecord;
        private System.Windows.Forms.GroupBox groupboxDisplayRecords;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.TextBox txtboxEngineSize;
        private System.Windows.Forms.TextBox txtboxCarCol;
        private System.Windows.Forms.TextBox txtboxCarMod;
        private System.Windows.Forms.TextBox txtboxCarMan;
        private System.Windows.Forms.CheckBox checkboxPetrol;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblPetrol;
        private System.Windows.Forms.Label lblCarCol;
        private System.Windows.Forms.Label lblCarMod;
        private System.Windows.Forms.Label lblCarMan;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox listboxDisplayRecords;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem submenuClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtboxOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
    }
}

