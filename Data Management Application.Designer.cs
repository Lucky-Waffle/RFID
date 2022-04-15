
namespace RFID
{
    partial class Data_Management_Application
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
            this.dvgViewData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectHouseToView = new System.Windows.Forms.ComboBox();
            this.btnViewPersonInDataGridView = new System.Windows.Forms.Button();
            this.btnViewHousesInDataGridView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddPerson = new System.Windows.Forms.TextBox();
            this.btnNewPerson = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewAdresse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeAdresse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboSelectPerson = new System.Windows.Forms.ComboBox();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnViewPersonInHouse = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNewAdressePostNr = new System.Windows.Forms.TextBox();
            this.txtScanRFIDtag = new System.Windows.Forms.TextBox();
            this.bntScanRFIDtag = new System.Windows.Forms.Button();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSelectedRFIDtag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPoststed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgViewData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgViewData
            // 
            this.dvgViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgViewData.Location = new System.Drawing.Point(1007, 164);
            this.dvgViewData.Name = "dvgViewData";
            this.dvgViewData.RowHeadersWidth = 82;
            this.dvgViewData.RowTemplate.Height = 33;
            this.dvgViewData.Size = new System.Drawing.Size(955, 565);
            this.dvgViewData.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1433, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 42);
            this.label3.TabIndex = 106;
            this.label3.Text = "DataGridView for viewing data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 109;
            this.label1.Text = "Select Adresse:";
            // 
            // cboSelectHouseToView
            // 
            this.cboSelectHouseToView.FormattingEnabled = true;
            this.cboSelectHouseToView.Location = new System.Drawing.Point(53, 104);
            this.cboSelectHouseToView.Margin = new System.Windows.Forms.Padding(6);
            this.cboSelectHouseToView.Name = "cboSelectHouseToView";
            this.cboSelectHouseToView.Size = new System.Drawing.Size(318, 33);
            this.cboSelectHouseToView.TabIndex = 110;
            this.cboSelectHouseToView.SelectedIndexChanged += new System.EventHandler(this.cboSelectHouseToView_SelectedIndexChanged);
            // 
            // btnViewPersonInDataGridView
            // 
            this.btnViewPersonInDataGridView.Location = new System.Drawing.Point(1007, 68);
            this.btnViewPersonInDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPersonInDataGridView.Name = "btnViewPersonInDataGridView";
            this.btnViewPersonInDataGridView.Size = new System.Drawing.Size(194, 69);
            this.btnViewPersonInDataGridView.TabIndex = 134;
            this.btnViewPersonInDataGridView.Text = "View all Person";
            this.btnViewPersonInDataGridView.UseVisualStyleBackColor = true;
            this.btnViewPersonInDataGridView.Click += new System.EventHandler(this.btnViewPersonInDataGridView_Click);
            // 
            // btnViewHousesInDataGridView
            // 
            this.btnViewHousesInDataGridView.Location = new System.Drawing.Point(1209, 68);
            this.btnViewHousesInDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewHousesInDataGridView.Name = "btnViewHousesInDataGridView";
            this.btnViewHousesInDataGridView.Size = new System.Drawing.Size(194, 69);
            this.btnViewHousesInDataGridView.TabIndex = 135;
            this.btnViewHousesInDataGridView.Text = "View all Houses";
            this.btnViewHousesInDataGridView.UseVisualStyleBackColor = true;
            this.btnViewHousesInDataGridView.Click += new System.EventHandler(this.btnViewHousesInDataGridView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 136;
            this.label2.Text = "Add User:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 137;
            this.label9.Text = "Name:";
            // 
            // txtAddPerson
            // 
            this.txtAddPerson.Location = new System.Drawing.Point(53, 353);
            this.txtAddPerson.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddPerson.Name = "txtAddPerson";
            this.txtAddPerson.Size = new System.Drawing.Size(234, 31);
            this.txtAddPerson.TabIndex = 143;
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Location = new System.Drawing.Point(53, 674);
            this.btnNewPerson.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(234, 44);
            this.btnNewPerson.TabIndex = 144;
            this.btnNewPerson.Text = "Add New Person";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1991, 48);
            this.menuStrip1.TabIndex = 146;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(207, 44);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataLoggingToolStripMenuItem,
            this.monitoringToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dataLoggingToolStripMenuItem
            // 
            this.dataLoggingToolStripMenuItem.Name = "dataLoggingToolStripMenuItem";
            this.dataLoggingToolStripMenuItem.Size = new System.Drawing.Size(269, 44);
            this.dataLoggingToolStripMenuItem.Text = "Logging";
            this.dataLoggingToolStripMenuItem.Click += new System.EventHandler(this.dataLoggingToolStripMenuItem_Click);
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(269, 44);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            this.monitoringToolStripMenuItem.Click += new System.EventHandler(this.monitoringToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(339, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 480);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 37);
            this.label7.TabIndex = 152;
            this.label7.Text = "Change Adresse:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 153;
            this.label8.Text = "Selected Adresse:";
            // 
            // txtNewAdresse
            // 
            this.txtNewAdresse.Location = new System.Drawing.Point(382, 437);
            this.txtNewAdresse.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewAdresse.Name = "txtNewAdresse";
            this.txtNewAdresse.Size = new System.Drawing.Size(234, 31);
            this.txtNewAdresse.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 25);
            this.label10.TabIndex = 156;
            this.label10.Text = "New Adresse:";
            // 
            // btnChangeAdresse
            // 
            this.btnChangeAdresse.Location = new System.Drawing.Point(382, 674);
            this.btnChangeAdresse.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangeAdresse.Name = "btnChangeAdresse";
            this.btnChangeAdresse.Size = new System.Drawing.Size(234, 44);
            this.btnChangeAdresse.TabIndex = 157;
            this.btnChangeAdresse.Text = "Change Adresse";
            this.btnChangeAdresse.UseVisualStyleBackColor = true;
            this.btnChangeAdresse.Click += new System.EventHandler(this.btnChangeAdresse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(668, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 480);
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(718, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 37);
            this.label11.TabIndex = 159;
            this.label11.Text = "Delete User:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(720, 322);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 25);
            this.label12.TabIndex = 160;
            this.label12.Text = "Select Person:";
            // 
            // cboSelectPerson
            // 
            this.cboSelectPerson.FormattingEnabled = true;
            this.cboSelectPerson.Location = new System.Drawing.Point(710, 353);
            this.cboSelectPerson.Margin = new System.Windows.Forms.Padding(6);
            this.cboSelectPerson.Name = "cboSelectPerson";
            this.cboSelectPerson.Size = new System.Drawing.Size(234, 33);
            this.cboSelectPerson.TabIndex = 161;
            this.cboSelectPerson.SelectedIndexChanged += new System.EventHandler(this.cboSelectPerson_SelectedIndexChanged);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(710, 674);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(234, 44);
            this.btnDeletePerson.TabIndex = 162;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnViewPersonInHouse
            // 
            this.btnViewPersonInHouse.Location = new System.Drawing.Point(382, 73);
            this.btnViewPersonInHouse.Margin = new System.Windows.Forms.Padding(6);
            this.btnViewPersonInHouse.Name = "btnViewPersonInHouse";
            this.btnViewPersonInHouse.Size = new System.Drawing.Size(260, 77);
            this.btnViewPersonInHouse.TabIndex = 163;
            this.btnViewPersonInHouse.Text = "View Person in Selected Adresse";
            this.btnViewPersonInHouse.UseVisualStyleBackColor = true;
            this.btnViewPersonInHouse.Click += new System.EventHandler(this.btnViewPersonInHouse_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 490);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 25);
            this.label13.TabIndex = 164;
            this.label13.Text = "New Post Number:";
            // 
            // txtNewAdressePostNr
            // 
            this.txtNewAdressePostNr.Location = new System.Drawing.Point(382, 523);
            this.txtNewAdressePostNr.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewAdressePostNr.Name = "txtNewAdressePostNr";
            this.txtNewAdressePostNr.Size = new System.Drawing.Size(234, 31);
            this.txtNewAdressePostNr.TabIndex = 165;
            // 
            // txtScanRFIDtag
            // 
            this.txtScanRFIDtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanRFIDtag.Location = new System.Drawing.Point(53, 500);
            this.txtScanRFIDtag.Name = "txtScanRFIDtag";
            this.txtScanRFIDtag.ReadOnly = true;
            this.txtScanRFIDtag.Size = new System.Drawing.Size(234, 38);
            this.txtScanRFIDtag.TabIndex = 166;
            // 
            // bntScanRFIDtag
            // 
            this.bntScanRFIDtag.Location = new System.Drawing.Point(79, 437);
            this.bntScanRFIDtag.Margin = new System.Windows.Forms.Padding(6);
            this.bntScanRFIDtag.Name = "bntScanRFIDtag";
            this.bntScanRFIDtag.Size = new System.Drawing.Size(179, 44);
            this.bntScanRFIDtag.TabIndex = 167;
            this.bntScanRFIDtag.Text = "Scan RFID Tag";
            this.bntScanRFIDtag.UseVisualStyleBackColor = true;
            this.bntScanRFIDtag.Click += new System.EventHandler(this.bntScanRFIDtag_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(382, 353);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.ReadOnly = true;
            this.txtAdresse.Size = new System.Drawing.Size(234, 38);
            this.txtAdresse.TabIndex = 169;
            // 
            // txtSelectedRFIDtag
            // 
            this.txtSelectedRFIDtag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedRFIDtag.Location = new System.Drawing.Point(710, 443);
            this.txtSelectedRFIDtag.Name = "txtSelectedRFIDtag";
            this.txtSelectedRFIDtag.ReadOnly = true;
            this.txtSelectedRFIDtag.Size = new System.Drawing.Size(234, 38);
            this.txtSelectedRFIDtag.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 170;
            this.label4.Text = "Selected RFID tag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 572);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 172;
            this.label5.Text = "New Poststed";
            // 
            // txtNewPoststed
            // 
            this.txtNewPoststed.Location = new System.Drawing.Point(382, 605);
            this.txtNewPoststed.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewPoststed.Name = "txtNewPoststed";
            this.txtNewPoststed.Size = new System.Drawing.Size(234, 31);
            this.txtNewPoststed.TabIndex = 173;
            // 
            // Data_Management_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 758);
            this.Controls.Add(this.txtNewPoststed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSelectedRFIDtag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.bntScanRFIDtag);
            this.Controls.Add(this.txtScanRFIDtag);
            this.Controls.Add(this.txtNewAdressePostNr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnViewPersonInHouse);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.cboSelectPerson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChangeAdresse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNewAdresse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewPerson);
            this.Controls.Add(this.txtAddPerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewHousesInDataGridView);
            this.Controls.Add(this.btnViewPersonInDataGridView);
            this.Controls.Add(this.cboSelectHouseToView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvgViewData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Data_Management_Application";
            this.Text = "Data_Management_Application";
            ((System.ComponentModel.ISupportInitialize)(this.dvgViewData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgViewData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectHouseToView;
        private System.Windows.Forms.Button btnViewPersonInDataGridView;
        private System.Windows.Forms.Button btnViewHousesInDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddPerson;
        private System.Windows.Forms.Button btnNewPerson;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewAdresse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChangeAdresse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboSelectPerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnViewPersonInHouse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNewAdressePostNr;
        private System.Windows.Forms.TextBox txtScanRFIDtag;
        private System.Windows.Forms.Button bntScanRFIDtag;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtSelectedRFIDtag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPoststed;
    }
}