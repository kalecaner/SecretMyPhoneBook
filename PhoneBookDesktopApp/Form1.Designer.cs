
namespace SecretMyPhoneBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpAddEditDelete = new System.Windows.Forms.GroupBox();
            this.chkFavorite = new System.Windows.Forms.CheckBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnZtoA = new System.Windows.Forms.Button();
            this.btnAtoZ = new System.Windows.Forms.Button();
            this.grpAddEditDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.Location = new System.Drawing.Point(41, 30);
            this.lblListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(72, 25);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "People";
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.ItemHeight = 21;
            this.lstPeople.Location = new System.Drawing.Point(41, 71);
            this.lstPeople.Margin = new System.Windows.Forms.Padding(4);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(471, 340);
            this.lstPeople.TabIndex = 1;
            this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::SecretMyPhoneBook.Properties.Resources._728898_page_folder_add_plus_file_icon__1_;
            this.btnAddNew.Location = new System.Drawing.Point(819, 13);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 46);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttInfo.SetToolTip(this.btnAddNew, "Create a new user for phone book.");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(302, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "write a text..";
            this.txtSearch.Size = new System.Drawing.Size(209, 29);
            this.txtSearch.TabIndex = 11;
            this.ttInfo.SetToolTip(this.txtSearch, "Finds a person.");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpAddEditDelete
            // 
            this.grpAddEditDelete.Controls.Add(this.chkFavorite);
            this.grpAddEditDelete.Controls.Add(this.rdbMale);
            this.grpAddEditDelete.Controls.Add(this.btnDel);
            this.grpAddEditDelete.Controls.Add(this.btnSave);
            this.grpAddEditDelete.Controls.Add(this.btnAdd);
            this.grpAddEditDelete.Controls.Add(this.rdbFemale);
            this.grpAddEditDelete.Controls.Add(this.cmbCategory);
            this.grpAddEditDelete.Controls.Add(this.txtPhone);
            this.grpAddEditDelete.Controls.Add(this.lblGender);
            this.grpAddEditDelete.Controls.Add(this.txtSurname);
            this.grpAddEditDelete.Controls.Add(this.txtName);
            this.grpAddEditDelete.Controls.Add(this.lblCategory);
            this.grpAddEditDelete.Controls.Add(this.lblPhone);
            this.grpAddEditDelete.Controls.Add(this.lblSurname);
            this.grpAddEditDelete.Controls.Add(this.lblName);
            this.grpAddEditDelete.Location = new System.Drawing.Point(553, 67);
            this.grpAddEditDelete.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddEditDelete.Name = "grpAddEditDelete";
            this.grpAddEditDelete.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddEditDelete.Size = new System.Drawing.Size(356, 344);
            this.grpAddEditDelete.TabIndex = 4;
            this.grpAddEditDelete.TabStop = false;
            this.grpAddEditDelete.Text = "Person Add / Edit / Delete";
            // 
            // chkFavorite
            // 
            this.chkFavorite.AutoSize = true;
            this.chkFavorite.Location = new System.Drawing.Point(134, 230);
            this.chkFavorite.Name = "chkFavorite";
            this.chkFavorite.Size = new System.Drawing.Size(84, 25);
            this.chkFavorite.TabIndex = 7;
            this.chkFavorite.Text = "Favorite";
            this.chkFavorite.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(286, 199);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(62, 25);
            this.rdbMale.TabIndex = 6;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Image = global::SecretMyPhoneBook.Properties.Resources._728918_cancel_error_exit_fault_alert_icon__1_;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.Location = new System.Drawing.Point(44, 295);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 32);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Del";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.btnDel, "Deletes a person from phone book.");
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SecretMyPhoneBook.Properties.Resources._728991_diskette_save_data_disk_drive_icon__1_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(148, 295);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.btnSave, "Saves person details.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::SecretMyPhoneBook.Properties.Resources._728991_diskette_save_data_disk_drive_icon__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(252, 295);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.btnAdd, "Adds a new person to phone book.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Checked = true;
            this.rdbFemale.Location = new System.Drawing.Point(134, 199);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(78, 25);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Family",
            "Friend"});
            this.cmbCategory.Location = new System.Drawing.Point(134, 164);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(214, 29);
            this.cmbCategory.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 128);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(214, 29);
            this.txtPhone.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(26, 201);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 21);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(134, 91);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PlaceholderText = "Doe";
            this.txtSurname.Size = new System.Drawing.Size(214, 29);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 54);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "John";
            this.txtName.Size = new System.Drawing.Size(214, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(26, 167);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 21);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(26, 131);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 21);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(26, 94);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(73, 21);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecretMyPhoneBook.Properties.Resources._2220662_logo_media_social_phone_share_icon;
            this.pictureBox1.Location = new System.Drawing.Point(553, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Bilgilendirme";
            // 
            // btnZtoA
            // 
            this.btnZtoA.Image = global::SecretMyPhoneBook.Properties.Resources._1608406_alpha_desc_sort_icon;
            this.btnZtoA.Location = new System.Drawing.Point(254, 30);
            this.btnZtoA.Name = "btnZtoA";
            this.btnZtoA.Size = new System.Drawing.Size(41, 29);
            this.btnZtoA.TabIndex = 12;
            this.btnZtoA.UseVisualStyleBackColor = true;
            this.btnZtoA.Click += new System.EventHandler(this.btnZtoA_Click);
            // 
            // btnAtoZ
            // 
            this.btnAtoZ.Image = global::SecretMyPhoneBook.Properties.Resources._1608407_alpha_asc_sort_icon;
            this.btnAtoZ.Location = new System.Drawing.Point(207, 30);
            this.btnAtoZ.Name = "btnAtoZ";
            this.btnAtoZ.Size = new System.Drawing.Size(41, 29);
            this.btnAtoZ.TabIndex = 13;
            this.btnAtoZ.UseVisualStyleBackColor = true;
            this.btnAtoZ.Click += new System.EventHandler(this.btnAtoZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 433);
            this.Controls.Add(this.btnAtoZ);
            this.Controls.Add(this.btnZtoA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpAddEditDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lstPeople);
            this.Controls.Add(this.lblListTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddEditDelete.ResumeLayout(false);
            this.grpAddEditDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpAddEditDelete;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button btnZtoA;
        private System.Windows.Forms.Button btnAtoZ;
    }
}

