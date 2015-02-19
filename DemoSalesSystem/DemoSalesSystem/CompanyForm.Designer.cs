namespace DemoSalesSystem
{
    partial class CompanyForm
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
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.lblCompanyFax = new System.Windows.Forms.Label();
            this.lblCompanyProvince = new System.Windows.Forms.Label();
            this.lblCompanyAltPhone = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.txtCompanyFax = new System.Windows.Forms.TextBox();
            this.txtCompanyNotes = new System.Windows.Forms.TextBox();
            this.txtCompanyAltPhone = new System.Windows.Forms.TextBox();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.btnCompanySave = new System.Windows.Forms.Button();
            this.gbxContacts = new System.Windows.Forms.GroupBox();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.btnDummyCont = new System.Windows.Forms.Button();
            this.txtContactBranch = new System.Windows.Forms.TextBox();
            this.txtContactSignature = new System.Windows.Forms.TextBox();
            this.txtContactExtension = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboSalutation = new System.Windows.Forms.ComboBox();
            this.lblSalutation = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContactPostal = new System.Windows.Forms.TextBox();
            this.btnContactUpdate = new System.Windows.Forms.Button();
            this.cboContactProvince = new System.Windows.Forms.ComboBox();
            this.btnContactSave = new System.Windows.Forms.Button();
            this.btnContactDelete = new System.Windows.Forms.Button();
            this.txtContactCreation = new System.Windows.Forms.TextBox();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.txtContactCity = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblContactCreation = new System.Windows.Forms.Label();
            this.txtContactAddress = new System.Windows.Forms.TextBox();
            this.lblContactPostal = new System.Windows.Forms.Label();
            this.lblContactAltPhone = new System.Windows.Forms.Label();
            this.lblContactAddress = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtContactAltPhone = new System.Windows.Forms.TextBox();
            this.lblContactProvince = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lblContactFax = new System.Windows.Forms.Label();
            this.lblContactCity = new System.Windows.Forms.Label();
            this.txtContactFax = new System.Windows.Forms.TextBox();
            this.gbxCompany = new System.Windows.Forms.GroupBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.btnDummyComp = new System.Windows.Forms.Button();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.txtCompanyPostal = new System.Windows.Forms.TextBox();
            this.cboCompanyProvince = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCompanyCreationDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblCompanyCreation = new System.Windows.Forms.Label();
            this.lblCompanyPostal = new System.Windows.Forms.Label();
            this.gbxContacts.SuspendLayout();
            this.gbxCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCompanies
            // 
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.Location = new System.Drawing.Point(30, 19);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(180, 290);
            this.lstCompanies.TabIndex = 0;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(235, 19);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(41, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Name: ";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(221, 153);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(99, 13);
            this.lblMission.TabIndex = 2;
            this.lblMission.Text = "Mission Statement: ";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(274, 236);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(46, 13);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "Slogan: ";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(226, 48);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCompanyAddress.TabIndex = 4;
            this.lblCompanyAddress.Text = "Address";
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Location = new System.Drawing.Point(434, 22);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(84, 13);
            this.lblCompanyPhone.TabIndex = 5;
            this.lblCompanyPhone.Text = "Phone Number: ";
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Location = new System.Drawing.Point(241, 77);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(30, 13);
            this.lblCompanyCity.TabIndex = 6;
            this.lblCompanyCity.Text = "City: ";
            // 
            // lblCompanyFax
            // 
            this.lblCompanyFax.AutoSize = true;
            this.lblCompanyFax.Location = new System.Drawing.Point(713, 48);
            this.lblCompanyFax.Name = "lblCompanyFax";
            this.lblCompanyFax.Size = new System.Drawing.Size(30, 13);
            this.lblCompanyFax.TabIndex = 7;
            this.lblCompanyFax.Text = "Fax: ";
            // 
            // lblCompanyProvince
            // 
            this.lblCompanyProvince.AutoSize = true;
            this.lblCompanyProvince.Location = new System.Drawing.Point(221, 103);
            this.lblCompanyProvince.Name = "lblCompanyProvince";
            this.lblCompanyProvince.Size = new System.Drawing.Size(55, 13);
            this.lblCompanyProvince.TabIndex = 8;
            this.lblCompanyProvince.Text = "Province: ";
            // 
            // lblCompanyAltPhone
            // 
            this.lblCompanyAltPhone.AutoSize = true;
            this.lblCompanyAltPhone.Location = new System.Drawing.Point(658, 22);
            this.lblCompanyAltPhone.Name = "lblCompanyAltPhone";
            this.lblCompanyAltPhone.Size = new System.Drawing.Size(89, 13);
            this.lblCompanyAltPhone.TabIndex = 9;
            this.lblCompanyAltPhone.Text = "Alternate Phone: ";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(277, 19);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(151, 20);
            this.txtCompanyName.TabIndex = 10;
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(326, 150);
            this.txtMission.Multiline = true;
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(562, 77);
            this.txtMission.TabIndex = 11;
            // 
            // txtSlogan
            // 
            this.txtSlogan.Location = new System.Drawing.Point(326, 233);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(280, 20);
            this.txtSlogan.TabIndex = 12;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(277, 48);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(151, 20);
            this.txtCompanyAddress.TabIndex = 13;
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(524, 19);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(116, 20);
            this.txtCompanyPhone.TabIndex = 14;
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Location = new System.Drawing.Point(277, 74);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(187, 20);
            this.txtCompanyCity.TabIndex = 15;
            // 
            // txtCompanyFax
            // 
            this.txtCompanyFax.Location = new System.Drawing.Point(753, 45);
            this.txtCompanyFax.Name = "txtCompanyFax";
            this.txtCompanyFax.Size = new System.Drawing.Size(122, 20);
            this.txtCompanyFax.TabIndex = 16;
            // 
            // txtCompanyNotes
            // 
            this.txtCompanyNotes.Location = new System.Drawing.Point(326, 265);
            this.txtCompanyNotes.Multiline = true;
            this.txtCompanyNotes.Name = "txtCompanyNotes";
            this.txtCompanyNotes.Size = new System.Drawing.Size(417, 54);
            this.txtCompanyNotes.TabIndex = 17;
            // 
            // txtCompanyAltPhone
            // 
            this.txtCompanyAltPhone.Location = new System.Drawing.Point(753, 19);
            this.txtCompanyAltPhone.Name = "txtCompanyAltPhone";
            this.txtCompanyAltPhone.Size = new System.Drawing.Size(122, 20);
            this.txtCompanyAltPhone.TabIndex = 18;
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Enabled = false;
            this.btnCompanyDelete.Location = new System.Drawing.Point(849, 296);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCompanyDelete.TabIndex = 20;
            this.btnCompanyDelete.Text = "Delete";
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.btnCompanyDelete_Click);
            // 
            // btnCompanySave
            // 
            this.btnCompanySave.Location = new System.Drawing.Point(768, 296);
            this.btnCompanySave.Name = "btnCompanySave";
            this.btnCompanySave.Size = new System.Drawing.Size(75, 23);
            this.btnCompanySave.TabIndex = 22;
            this.btnCompanySave.Text = "Save";
            this.btnCompanySave.UseVisualStyleBackColor = true;
            this.btnCompanySave.Click += new System.EventHandler(this.btnCompanySave_Click);
            // 
            // gbxContacts
            // 
            this.gbxContacts.Controls.Add(this.txtContactEmail);
            this.gbxContacts.Controls.Add(this.lblContactEmail);
            this.gbxContacts.Controls.Add(this.txtContactID);
            this.gbxContacts.Controls.Add(this.lblContactID);
            this.gbxContacts.Controls.Add(this.btnDummyCont);
            this.gbxContacts.Controls.Add(this.txtContactBranch);
            this.gbxContacts.Controls.Add(this.txtContactSignature);
            this.gbxContacts.Controls.Add(this.txtContactExtension);
            this.gbxContacts.Controls.Add(this.txtContactTitle);
            this.gbxContacts.Controls.Add(this.lblBranch);
            this.gbxContacts.Controls.Add(this.lblSignature);
            this.gbxContacts.Controls.Add(this.lblExtension);
            this.gbxContacts.Controls.Add(this.lblTitle);
            this.gbxContacts.Controls.Add(this.cboSalutation);
            this.gbxContacts.Controls.Add(this.lblSalutation);
            this.gbxContacts.Controls.Add(this.lblLastName);
            this.gbxContacts.Controls.Add(this.txtLastName);
            this.gbxContacts.Controls.Add(this.txtContactPostal);
            this.gbxContacts.Controls.Add(this.btnContactUpdate);
            this.gbxContacts.Controls.Add(this.cboContactProvince);
            this.gbxContacts.Controls.Add(this.btnContactSave);
            this.gbxContacts.Controls.Add(this.btnContactDelete);
            this.gbxContacts.Controls.Add(this.txtContactCreation);
            this.gbxContacts.Controls.Add(this.lstContacts);
            this.gbxContacts.Controls.Add(this.txtContactCity);
            this.gbxContacts.Controls.Add(this.lblFirstName);
            this.gbxContacts.Controls.Add(this.txtFirstName);
            this.gbxContacts.Controls.Add(this.lblContactCreation);
            this.gbxContacts.Controls.Add(this.txtContactAddress);
            this.gbxContacts.Controls.Add(this.lblContactPostal);
            this.gbxContacts.Controls.Add(this.lblContactAltPhone);
            this.gbxContacts.Controls.Add(this.lblContactAddress);
            this.gbxContacts.Controls.Add(this.txtContactPhone);
            this.gbxContacts.Controls.Add(this.txtContactAltPhone);
            this.gbxContacts.Controls.Add(this.lblContactProvince);
            this.gbxContacts.Controls.Add(this.lblContactPhone);
            this.gbxContacts.Controls.Add(this.lblContactFax);
            this.gbxContacts.Controls.Add(this.lblContactCity);
            this.gbxContacts.Controls.Add(this.txtContactFax);
            this.gbxContacts.Enabled = false;
            this.gbxContacts.Location = new System.Drawing.Point(20, 352);
            this.gbxContacts.Name = "gbxContacts";
            this.gbxContacts.Size = new System.Drawing.Size(930, 238);
            this.gbxContacts.TabIndex = 23;
            this.gbxContacts.TabStop = false;
            this.gbxContacts.Text = "Contacts";
            this.gbxContacts.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(470, 157);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(136, 20);
            this.txtContactEmail.TabIndex = 67;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(422, 159);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(35, 13);
            this.lblContactEmail.TabIndex = 66;
            this.lblContactEmail.Text = "Email:";
            // 
            // txtContactID
            // 
            this.txtContactID.Enabled = false;
            this.txtContactID.Location = new System.Drawing.Point(716, 130);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(31, 20);
            this.txtContactID.TabIndex = 65;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Location = new System.Drawing.Point(673, 133);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(21, 13);
            this.lblContactID.TabIndex = 64;
            this.lblContactID.Text = "ID:";
            // 
            // btnDummyCont
            // 
            this.btnDummyCont.Location = new System.Drawing.Point(849, 179);
            this.btnDummyCont.Name = "btnDummyCont";
            this.btnDummyCont.Size = new System.Drawing.Size(75, 23);
            this.btnDummyCont.TabIndex = 33;
            this.btnDummyCont.Text = "Dummy Info";
            this.btnDummyCont.UseVisualStyleBackColor = true;
            this.btnDummyCont.Click += new System.EventHandler(this.btnDummyCont_Click);
            // 
            // txtContactBranch
            // 
            this.txtContactBranch.Location = new System.Drawing.Point(471, 130);
            this.txtContactBranch.Name = "txtContactBranch";
            this.txtContactBranch.Size = new System.Drawing.Size(78, 20);
            this.txtContactBranch.TabIndex = 63;
            // 
            // txtContactSignature
            // 
            this.txtContactSignature.Location = new System.Drawing.Point(471, 101);
            this.txtContactSignature.Name = "txtContactSignature";
            this.txtContactSignature.Size = new System.Drawing.Size(116, 20);
            this.txtContactSignature.TabIndex = 62;
            // 
            // txtContactExtension
            // 
            this.txtContactExtension.Location = new System.Drawing.Point(471, 49);
            this.txtContactExtension.Name = "txtContactExtension";
            this.txtContactExtension.Size = new System.Drawing.Size(116, 20);
            this.txtContactExtension.TabIndex = 61;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(471, 76);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(116, 20);
            this.txtContactTitle.TabIndex = 60;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(407, 133);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(61, 13);
            this.lblBranch.TabIndex = 59;
            this.lblBranch.Text = "Branch ID: ";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Location = new System.Drawing.Point(407, 108);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(58, 13);
            this.lblSignature.TabIndex = 58;
            this.lblSignature.Text = "Signature: ";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(415, 49);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(59, 13);
            this.lblExtension.TabIndex = 57;
            this.lblExtension.Text = "Extension: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(431, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Title: ";
            // 
            // cboSalutation
            // 
            this.cboSalutation.FormattingEnabled = true;
            this.cboSalutation.Location = new System.Drawing.Point(224, 83);
            this.cboSalutation.Name = "cboSalutation";
            this.cboSalutation.Size = new System.Drawing.Size(121, 21);
            this.cboSalutation.TabIndex = 55;
            // 
            // lblSalutation
            // 
            this.lblSalutation.AutoSize = true;
            this.lblSalutation.Location = new System.Drawing.Point(168, 83);
            this.lblSalutation.Name = "lblSalutation";
            this.lblSalutation.Size = new System.Drawing.Size(60, 13);
            this.lblSalutation.TabIndex = 54;
            this.lblSalutation.Text = "Salutation: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(156, 59);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 52;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(224, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(151, 20);
            this.txtLastName.TabIndex = 53;
            // 
            // txtContactPostal
            // 
            this.txtContactPostal.Location = new System.Drawing.Point(224, 186);
            this.txtContactPostal.Name = "txtContactPostal";
            this.txtContactPostal.Size = new System.Drawing.Size(151, 20);
            this.txtContactPostal.TabIndex = 51;
            // 
            // btnContactUpdate
            // 
            this.btnContactUpdate.Enabled = false;
            this.btnContactUpdate.Location = new System.Drawing.Point(753, 179);
            this.btnContactUpdate.Name = "btnContactUpdate";
            this.btnContactUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContactUpdate.TabIndex = 17;
            this.btnContactUpdate.Text = "Update";
            this.btnContactUpdate.UseVisualStyleBackColor = true;
            this.btnContactUpdate.Click += new System.EventHandler(this.btnContactUpdate_Click);
            // 
            // cboContactProvince
            // 
            this.cboContactProvince.FormattingEnabled = true;
            this.cboContactProvince.Location = new System.Drawing.Point(224, 159);
            this.cboContactProvince.Name = "cboContactProvince";
            this.cboContactProvince.Size = new System.Drawing.Size(70, 21);
            this.cboContactProvince.TabIndex = 50;
            // 
            // btnContactSave
            // 
            this.btnContactSave.Location = new System.Drawing.Point(753, 209);
            this.btnContactSave.Name = "btnContactSave";
            this.btnContactSave.Size = new System.Drawing.Size(75, 23);
            this.btnContactSave.TabIndex = 16;
            this.btnContactSave.Text = "Save";
            this.btnContactSave.UseVisualStyleBackColor = true;
            this.btnContactSave.Click += new System.EventHandler(this.btnContactSave_Click);
            // 
            // btnContactDelete
            // 
            this.btnContactDelete.Enabled = false;
            this.btnContactDelete.Location = new System.Drawing.Point(849, 209);
            this.btnContactDelete.Name = "btnContactDelete";
            this.btnContactDelete.Size = new System.Drawing.Size(75, 23);
            this.btnContactDelete.TabIndex = 15;
            this.btnContactDelete.Text = "Delete";
            this.btnContactDelete.UseVisualStyleBackColor = true;
            this.btnContactDelete.Click += new System.EventHandler(this.btnContactDelete_Click);
            // 
            // txtContactCreation
            // 
            this.txtContactCreation.Enabled = false;
            this.txtContactCreation.Location = new System.Drawing.Point(716, 101);
            this.txtContactCreation.Name = "txtContactCreation";
            this.txtContactCreation.Size = new System.Drawing.Size(100, 20);
            this.txtContactCreation.TabIndex = 48;
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(7, 19);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(143, 199);
            this.lstContacts.TabIndex = 0;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // txtContactCity
            // 
            this.txtContactCity.Location = new System.Drawing.Point(224, 134);
            this.txtContactCity.Name = "txtContactCity";
            this.txtContactCity.Size = new System.Drawing.Size(172, 20);
            this.txtContactCity.TabIndex = 42;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(156, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(224, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(151, 20);
            this.txtFirstName.TabIndex = 39;
            // 
            // lblContactCreation
            // 
            this.lblContactCreation.AutoSize = true;
            this.lblContactCreation.Location = new System.Drawing.Point(628, 107);
            this.lblContactCreation.Name = "lblContactCreation";
            this.lblContactCreation.Size = new System.Drawing.Size(78, 13);
            this.lblContactCreation.TabIndex = 46;
            this.lblContactCreation.Text = "Creation Date: ";
            // 
            // txtContactAddress
            // 
            this.txtContactAddress.Location = new System.Drawing.Point(224, 108);
            this.txtContactAddress.Name = "txtContactAddress";
            this.txtContactAddress.Size = new System.Drawing.Size(151, 20);
            this.txtContactAddress.TabIndex = 40;
            // 
            // lblContactPostal
            // 
            this.lblContactPostal.AutoSize = true;
            this.lblContactPostal.Location = new System.Drawing.Point(150, 189);
            this.lblContactPostal.Name = "lblContactPostal";
            this.lblContactPostal.Size = new System.Drawing.Size(70, 13);
            this.lblContactPostal.TabIndex = 45;
            this.lblContactPostal.Text = "Postal Code: ";
            // 
            // lblContactAltPhone
            // 
            this.lblContactAltPhone.AutoSize = true;
            this.lblContactAltPhone.Location = new System.Drawing.Point(605, 26);
            this.lblContactAltPhone.Name = "lblContactAltPhone";
            this.lblContactAltPhone.Size = new System.Drawing.Size(89, 13);
            this.lblContactAltPhone.TabIndex = 38;
            this.lblContactAltPhone.Text = "Alternate Phone: ";
            // 
            // lblContactAddress
            // 
            this.lblContactAddress.AutoSize = true;
            this.lblContactAddress.Location = new System.Drawing.Point(173, 108);
            this.lblContactAddress.Name = "lblContactAddress";
            this.lblContactAddress.Size = new System.Drawing.Size(45, 13);
            this.lblContactAddress.TabIndex = 33;
            this.lblContactAddress.Text = "Address";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(471, 23);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(116, 20);
            this.txtContactPhone.TabIndex = 41;
            // 
            // txtContactAltPhone
            // 
            this.txtContactAltPhone.Location = new System.Drawing.Point(700, 23);
            this.txtContactAltPhone.Name = "txtContactAltPhone";
            this.txtContactAltPhone.Size = new System.Drawing.Size(122, 20);
            this.txtContactAltPhone.TabIndex = 44;
            // 
            // lblContactProvince
            // 
            this.lblContactProvince.AutoSize = true;
            this.lblContactProvince.Location = new System.Drawing.Point(168, 163);
            this.lblContactProvince.Name = "lblContactProvince";
            this.lblContactProvince.Size = new System.Drawing.Size(55, 13);
            this.lblContactProvince.TabIndex = 37;
            this.lblContactProvince.Text = "Province: ";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Location = new System.Drawing.Point(381, 26);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(84, 13);
            this.lblContactPhone.TabIndex = 34;
            this.lblContactPhone.Text = "Phone Number: ";
            // 
            // lblContactFax
            // 
            this.lblContactFax.AutoSize = true;
            this.lblContactFax.Location = new System.Drawing.Point(660, 52);
            this.lblContactFax.Name = "lblContactFax";
            this.lblContactFax.Size = new System.Drawing.Size(30, 13);
            this.lblContactFax.TabIndex = 36;
            this.lblContactFax.Text = "Fax: ";
            // 
            // lblContactCity
            // 
            this.lblContactCity.AutoSize = true;
            this.lblContactCity.Location = new System.Drawing.Point(188, 137);
            this.lblContactCity.Name = "lblContactCity";
            this.lblContactCity.Size = new System.Drawing.Size(30, 13);
            this.lblContactCity.TabIndex = 35;
            this.lblContactCity.Text = "City: ";
            // 
            // txtContactFax
            // 
            this.txtContactFax.Location = new System.Drawing.Point(700, 49);
            this.txtContactFax.Name = "txtContactFax";
            this.txtContactFax.Size = new System.Drawing.Size(122, 20);
            this.txtContactFax.TabIndex = 43;
            // 
            // gbxCompany
            // 
            this.gbxCompany.Controls.Add(this.txtCompanyID);
            this.gbxCompany.Controls.Add(this.lblCompanyID);
            this.gbxCompany.Controls.Add(this.btnDummyComp);
            this.gbxCompany.Controls.Add(this.btnCompanyUpdate);
            this.gbxCompany.Controls.Add(this.txtCompanyPostal);
            this.gbxCompany.Controls.Add(this.cboCompanyProvince);
            this.gbxCompany.Controls.Add(this.btnCompanyDelete);
            this.gbxCompany.Controls.Add(this.cboStatus);
            this.gbxCompany.Controls.Add(this.txtCompanyCreationDate);
            this.gbxCompany.Controls.Add(this.lblStatus);
            this.gbxCompany.Controls.Add(this.lstCompanies);
            this.gbxCompany.Controls.Add(this.lblNotes);
            this.gbxCompany.Controls.Add(this.txtCompanyNotes);
            this.gbxCompany.Controls.Add(this.lblCompanyName);
            this.gbxCompany.Controls.Add(this.lblCompanyCreation);
            this.gbxCompany.Controls.Add(this.btnCompanySave);
            this.gbxCompany.Controls.Add(this.lblMission);
            this.gbxCompany.Controls.Add(this.lblCompanyPostal);
            this.gbxCompany.Controls.Add(this.lblSlogan);
            this.gbxCompany.Controls.Add(this.lblCompanyAddress);
            this.gbxCompany.Controls.Add(this.txtCompanyAltPhone);
            this.gbxCompany.Controls.Add(this.lblCompanyPhone);
            this.gbxCompany.Controls.Add(this.lblCompanyCity);
            this.gbxCompany.Controls.Add(this.txtCompanyFax);
            this.gbxCompany.Controls.Add(this.lblCompanyFax);
            this.gbxCompany.Controls.Add(this.txtCompanyCity);
            this.gbxCompany.Controls.Add(this.lblCompanyProvince);
            this.gbxCompany.Controls.Add(this.txtCompanyPhone);
            this.gbxCompany.Controls.Add(this.lblCompanyAltPhone);
            this.gbxCompany.Controls.Add(this.txtCompanyAddress);
            this.gbxCompany.Controls.Add(this.txtCompanyName);
            this.gbxCompany.Controls.Add(this.txtSlogan);
            this.gbxCompany.Controls.Add(this.txtMission);
            this.gbxCompany.Location = new System.Drawing.Point(20, 12);
            this.gbxCompany.Name = "gbxCompany";
            this.gbxCompany.Size = new System.Drawing.Size(930, 334);
            this.gbxCompany.TabIndex = 24;
            this.gbxCompany.TabStop = false;
            this.gbxCompany.Text = "Companies";
            this.gbxCompany.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Enabled = false;
            this.txtCompanyID.Location = new System.Drawing.Point(524, 46);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(42, 20);
            this.txtCompanyID.TabIndex = 35;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Location = new System.Drawing.Point(497, 48);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(21, 13);
            this.lblCompanyID.TabIndex = 33;
            this.lblCompanyID.Text = "ID:";
            // 
            // btnDummyComp
            // 
            this.btnDummyComp.Location = new System.Drawing.Point(849, 268);
            this.btnDummyComp.Name = "btnDummyComp";
            this.btnDummyComp.Size = new System.Drawing.Size(75, 23);
            this.btnDummyComp.TabIndex = 32;
            this.btnDummyComp.Text = "Dummy Info";
            this.btnDummyComp.UseVisualStyleBackColor = true;
            this.btnDummyComp.Click += new System.EventHandler(this.btnDummyComp_Click);
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.Enabled = false;
            this.btnCompanyUpdate.Location = new System.Drawing.Point(768, 267);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCompanyUpdate.TabIndex = 31;
            this.btnCompanyUpdate.Text = "Update";
            this.btnCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // txtCompanyPostal
            // 
            this.txtCompanyPostal.Location = new System.Drawing.Point(277, 123);
            this.txtCompanyPostal.Name = "txtCompanyPostal";
            this.txtCompanyPostal.Size = new System.Drawing.Size(113, 20);
            this.txtCompanyPostal.TabIndex = 30;
            // 
            // cboCompanyProvince
            // 
            this.cboCompanyProvince.FormattingEnabled = true;
            this.cboCompanyProvince.Location = new System.Drawing.Point(277, 99);
            this.cboCompanyProvince.Name = "cboCompanyProvince";
            this.cboCompanyProvince.Size = new System.Drawing.Size(70, 21);
            this.cboCompanyProvince.TabIndex = 29;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(753, 100);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 28;
            // 
            // txtCompanyCreationDate
            // 
            this.txtCompanyCreationDate.Enabled = false;
            this.txtCompanyCreationDate.Location = new System.Drawing.Point(753, 71);
            this.txtCompanyCreationDate.Name = "txtCompanyCreationDate";
            this.txtCompanyCreationDate.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyCreationDate.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(700, 108);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status: ";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(274, 268);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 13);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "Notes: ";
            // 
            // lblCompanyCreation
            // 
            this.lblCompanyCreation.AutoSize = true;
            this.lblCompanyCreation.Location = new System.Drawing.Point(665, 77);
            this.lblCompanyCreation.Name = "lblCompanyCreation";
            this.lblCompanyCreation.Size = new System.Drawing.Size(78, 13);
            this.lblCompanyCreation.TabIndex = 25;
            this.lblCompanyCreation.Text = "Creation Date: ";
            // 
            // lblCompanyPostal
            // 
            this.lblCompanyPostal.AutoSize = true;
            this.lblCompanyPostal.Location = new System.Drawing.Point(201, 126);
            this.lblCompanyPostal.Name = "lblCompanyPostal";
            this.lblCompanyPostal.Size = new System.Drawing.Size(70, 13);
            this.lblCompanyPostal.TabIndex = 24;
            this.lblCompanyPostal.Text = "Postal Code: ";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 610);
            this.Controls.Add(this.gbxCompany);
            this.Controls.Add(this.gbxContacts);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.gbxContacts.ResumeLayout(false);
            this.gbxContacts.PerformLayout();
            this.gbxCompany.ResumeLayout(false);
            this.gbxCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.Label lblCompanyFax;
        private System.Windows.Forms.Label lblCompanyProvince;
        private System.Windows.Forms.Label lblCompanyAltPhone;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyCity;
        private System.Windows.Forms.TextBox txtCompanyFax;
        private System.Windows.Forms.TextBox txtCompanyNotes;
        private System.Windows.Forms.TextBox txtCompanyAltPhone;
        private System.Windows.Forms.Button btnCompanyDelete;
        private System.Windows.Forms.Button btnCompanySave;
        private System.Windows.Forms.GroupBox gbxContacts;
        private System.Windows.Forms.Button btnContactUpdate;
        private System.Windows.Forms.Button btnContactSave;
        private System.Windows.Forms.Button btnContactDelete;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.GroupBox gbxCompany;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCompanyCreation;
        private System.Windows.Forms.Label lblCompanyPostal;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtCompanyPostal;
        private System.Windows.Forms.ComboBox cboCompanyProvince;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCompanyCreationDate;
        private System.Windows.Forms.Button btnCompanyUpdate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContactPostal;
        private System.Windows.Forms.ComboBox cboContactProvince;
        private System.Windows.Forms.TextBox txtContactCreation;
        private System.Windows.Forms.TextBox txtContactCity;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblContactCreation;
        private System.Windows.Forms.TextBox txtContactAddress;
        private System.Windows.Forms.Label lblContactPostal;
        private System.Windows.Forms.Label lblContactAltPhone;
        private System.Windows.Forms.Label lblContactAddress;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtContactAltPhone;
        private System.Windows.Forms.Label lblContactProvince;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.Label lblContactFax;
        private System.Windows.Forms.Label lblContactCity;
        private System.Windows.Forms.TextBox txtContactFax;
        private System.Windows.Forms.TextBox txtContactBranch;
        private System.Windows.Forms.TextBox txtContactSignature;
        private System.Windows.Forms.TextBox txtContactExtension;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboSalutation;
        private System.Windows.Forms.Label lblSalutation;
        private System.Windows.Forms.Button btnDummyCont;
        private System.Windows.Forms.Button btnDummyComp;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Label lblContactID;
    }
}