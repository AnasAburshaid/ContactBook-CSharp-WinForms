namespace Forms_PresintationLayer
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblIDPrefix = new System.Windows.Forms.Label();
            this.lblContactID = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.ppContactImage = new System.Windows.Forms.PictureBox();
            this.LinkSet = new System.Windows.Forms.LinkLabel();
            this.LinkDelete = new System.Windows.Forms.LinkLabel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelHeader.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppContactImage)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.lblMode);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblIDPrefix);
            this.panelHeader.Controls.Add(this.lblContactID);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1040, 90);
            this.panelHeader.TabIndex = 2;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(28, 14);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(311, 41);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Add New Contact";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(32, 54);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(290, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Fill in the details below and click Save";
            // 
            // lblIDPrefix
            // 
            this.lblIDPrefix.AutoSize = true;
            this.lblIDPrefix.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblIDPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.lblIDPrefix.Location = new System.Drawing.Point(870, 34);
            this.lblIDPrefix.Name = "lblIDPrefix";
            this.lblIDPrefix.Size = new System.Drawing.Size(90, 21);
            this.lblIDPrefix.TabIndex = 2;
            this.lblIDPrefix.Text = "Contact ID";
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblContactID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(119)))), ((int)(((byte)(221)))));
            this.lblContactID.Location = new System.Drawing.Point(870, 54);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(39, 33);
            this.lblContactID.TabIndex = 3;
            this.lblContactID.Text = "--";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.panelLeft.Controls.Add(this.ppContactImage);
            this.panelLeft.Controls.Add(this.LinkSet);
            this.panelLeft.Controls.Add(this.LinkDelete);
            this.panelLeft.Location = new System.Drawing.Point(0, 90);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(310, 680);
            this.panelLeft.TabIndex = 1;
            // 
            // ppContactImage
            // 
            this.ppContactImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.ppContactImage.Location = new System.Drawing.Point(55, 60);
            this.ppContactImage.Name = "ppContactImage";
            this.ppContactImage.Size = new System.Drawing.Size(200, 200);
            this.ppContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppContactImage.TabIndex = 0;
            this.ppContactImage.TabStop = false;
            // 
            // LinkSet
            // 
            this.LinkSet.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.LinkSet.AutoSize = true;
            this.LinkSet.Font = new System.Drawing.Font("Tahoma", 11F);
            this.LinkSet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(119)))), ((int)(((byte)(221)))));
            this.LinkSet.Location = new System.Drawing.Point(90, 278);
            this.LinkSet.Name = "LinkSet";
            this.LinkSet.Size = new System.Drawing.Size(90, 23);
            this.LinkSet.TabIndex = 1;
            this.LinkSet.TabStop = true;
            this.LinkSet.Text = "Set Photo";
            this.LinkSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSet_LinkClicked);
            // 
            // LinkDelete
            // 
            this.LinkDelete.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LinkDelete.AutoSize = true;
            this.LinkDelete.Font = new System.Drawing.Font("Tahoma", 11F);
            this.LinkDelete.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LinkDelete.Location = new System.Drawing.Point(175, 278);
            this.LinkDelete.Name = "LinkDelete";
            this.LinkDelete.Size = new System.Drawing.Size(77, 23);
            this.LinkDelete.TabIndex = 2;
            this.LinkDelete.TabStop = true;
            this.LinkDelete.Text = "Remove";
            this.LinkDelete.Visible = false;
            this.LinkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDelete_LinkClicked);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.txtFirstname);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.txtLastname);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.txtPhone);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.Controls.Add(this.dateTimePicker1);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.cmbCountry);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.txtAddress);
            this.panelRight.Location = new System.Drawing.Point(310, 90);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(730, 680);
            this.panelRight.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(30, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "FIRST NAME";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtFirstname.Location = new System.Drawing.Point(30, 54);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(310, 32);
            this.txtFirstname.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(370, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "LAST NAME";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtLastname.Location = new System.Drawing.Point(370, 54);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(310, 32);
            this.txtLastname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(30, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "EMAIL ADDRESS";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtEmail.Location = new System.Drawing.Point(30, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(650, 32);
            this.txtEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(30, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "PHONE NUMBER";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtPhone.Location = new System.Drawing.Point(30, 234);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 32);
            this.txtPhone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label9.Location = new System.Drawing.Point(370, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "DATE OF BIRTH";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 32);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(30, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "COUNTRY";
            // 
            // cmbCountry
            // 
            this.cmbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCountry.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(30, 324);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(310, 32);
            this.cmbCountry.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(30, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADDRESS";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtAddress.Location = new System.Drawing.Point(30, 414);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(650, 32);
            this.txtAddress.TabIndex = 6;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 770);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1040, 70);
            this.panelFooter.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(119)))), ((int)(((byte)(221)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(450, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Contact";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(670, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 840);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppContactImage)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblIDPrefix;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox ppContactImage;
        private System.Windows.Forms.LinkLabel LinkSet;
        private System.Windows.Forms.LinkLabel LinkDelete;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}