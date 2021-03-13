namespace BashGah.Forms
{
    partial class FrmManageMember
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDetails = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.txtValidDay = new System.Windows.Forms.MaskedTextBox();
            this.txtJoinDay = new System.Windows.Forms.MaskedTextBox();
            this.txtBirthDay = new System.Windows.Forms.MaskedTextBox();
            this.btnOpenPicture = new FontAwesome.Sharp.IconButton();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubDelete = new FontAwesome.Sharp.IconButton();
            this.btnSubPayFee = new FontAwesome.Sharp.IconButton();
            this.btnSubEdite = new FontAwesome.Sharp.IconButton();
            this.btnSubDetail = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLabel = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.pnlSubMenu.SuspendLayout();
            this.pnlSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pnlSubMenu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 776);
            this.panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDetails);
            this.panel7.Controls.Add(this.txtSearch);
            this.panel7.Controls.Add(this.dtGrid);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(260, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(652, 706);
            this.panel7.TabIndex = 9;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnDetails.IconColor = System.Drawing.Color.White;
            this.btnDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetails.IconSize = 30;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(441, 615);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(160, 46);
            this.btnDetails.TabIndex = 22;
            this.btnDetails.Text = "جزیات";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(378, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(224, 34);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.AllowUserToResizeColumns = false;
            this.dtGrid.AllowUserToResizeRows = false;
            this.dtGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FullName,
            this.PhoneNumber,
            this.JoinDate});
            this.dtGrid.Location = new System.Drawing.Point(62, 61);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtGrid.RowHeadersWidth = 51;
            this.dtGrid.RowTemplate.Height = 24;
            this.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid.Size = new System.Drawing.Size(540, 527);
            this.dtGrid.TabIndex = 5;
            this.dtGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Athlete_ID";
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Athlete_FullName";
            this.FullName.HeaderText = "نام و نام خانوادگی";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "Athlete_PhoneNumber";
            this.PhoneNumber.HeaderText = "شماره ی تلفن";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 140;
            // 
            // JoinDate
            // 
            this.JoinDate.DataPropertyName = "Athlete_BirthDay";
            this.JoinDate.HeaderText = "تاریخ عضویت";
            this.JoinDate.MinimumWidth = 6;
            this.JoinDate.Name = "JoinDate";
            this.JoinDate.ReadOnly = true;
            this.JoinDate.Width = 135;
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlSubMenu.Controls.Add(this.pnlSub);
            this.pnlSubMenu.Controls.Add(this.btnSubDelete);
            this.pnlSubMenu.Controls.Add(this.btnSubPayFee);
            this.pnlSubMenu.Controls.Add(this.btnSubEdite);
            this.pnlSubMenu.Controls.Add(this.btnSubDetail);
            this.pnlSubMenu.Controls.Add(this.panel8);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(10, 60);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(250, 706);
            this.pnlSubMenu.TabIndex = 8;
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlSub.Controls.Add(this.btnEdit);
            this.pnlSub.Controls.Add(this.txtValidDay);
            this.pnlSub.Controls.Add(this.txtJoinDay);
            this.pnlSub.Controls.Add(this.txtBirthDay);
            this.pnlSub.Controls.Add(this.btnOpenPicture);
            this.pnlSub.Controls.Add(this.pctImage);
            this.pnlSub.Controls.Add(this.label7);
            this.pnlSub.Controls.Add(this.txtAddress);
            this.pnlSub.Controls.Add(this.txtPhoneNumber);
            this.pnlSub.Controls.Add(this.txtName);
            this.pnlSub.Controls.Add(this.label6);
            this.pnlSub.Controls.Add(this.label5);
            this.pnlSub.Controls.Add(this.label4);
            this.pnlSub.Controls.Add(this.label3);
            this.pnlSub.Controls.Add(this.label2);
            this.pnlSub.Controls.Add(this.label1);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSub.Location = new System.Drawing.Point(0, 187);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(250, 519);
            this.pnlSub.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 35;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(54, 425);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 49);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtValidDay
            // 
            this.txtValidDay.Enabled = false;
            this.txtValidDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidDay.Location = new System.Drawing.Point(10, 168);
            this.txtValidDay.Mask = "0000/00/00";
            this.txtValidDay.Name = "txtValidDay";
            this.txtValidDay.Size = new System.Drawing.Size(120, 27);
            this.txtValidDay.TabIndex = 69;
            this.txtValidDay.ValidatingType = typeof(System.DateTime);
            // 
            // txtJoinDay
            // 
            this.txtJoinDay.Enabled = false;
            this.txtJoinDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinDay.Location = new System.Drawing.Point(10, 126);
            this.txtJoinDay.Mask = "0000/00/00";
            this.txtJoinDay.Name = "txtJoinDay";
            this.txtJoinDay.Size = new System.Drawing.Size(120, 27);
            this.txtJoinDay.TabIndex = 68;
            this.txtJoinDay.ValidatingType = typeof(System.DateTime);
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Enabled = false;
            this.txtBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDay.Location = new System.Drawing.Point(10, 88);
            this.txtBirthDay.Mask = "0000/00/00";
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(120, 27);
            this.txtBirthDay.TabIndex = 24;
            this.txtBirthDay.ValidatingType = typeof(System.DateTime);
            // 
            // btnOpenPicture
            // 
            this.btnOpenPicture.Enabled = false;
            this.btnOpenPicture.FlatAppearance.BorderSize = 0;
            this.btnOpenPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPicture.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnOpenPicture.IconColor = System.Drawing.Color.Cyan;
            this.btnOpenPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenPicture.IconSize = 25;
            this.btnOpenPicture.Location = new System.Drawing.Point(11, 321);
            this.btnOpenPicture.Name = "btnOpenPicture";
            this.btnOpenPicture.Size = new System.Drawing.Size(25, 25);
            this.btnOpenPicture.TabIndex = 67;
            this.btnOpenPicture.UseVisualStyleBackColor = true;
            this.btnOpenPicture.Click += new System.EventHandler(this.btnOpenPicture_Click);
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(10, 320);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(75, 75);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImage.TabIndex = 66;
            this.pctImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 326);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "عکس : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(7, 213);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(177, 95);
            this.txtAddress.TabIndex = 64;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(7, 53);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(190, 27);
            this.txtPhoneNumber.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(7, 21);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(190, 27);
            this.txtName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 57);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "تلفن : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 207);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "آدرس : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 168);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "ت اعتبار : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 133);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "ت عضویت : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 95);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "ت تولد : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "نام : ";
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubDelete.FlatAppearance.BorderSize = 0;
            this.btnSubDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDelete.ForeColor = System.Drawing.Color.White;
            this.btnSubDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSubDelete.IconColor = System.Drawing.Color.White;
            this.btnSubDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubDelete.IconSize = 22;
            this.btnSubDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDelete.Location = new System.Drawing.Point(0, 149);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.Size = new System.Drawing.Size(250, 38);
            this.btnSubDelete.TabIndex = 4;
            this.btnSubDelete.Text = "حذف کاربر";
            this.btnSubDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubDelete.UseVisualStyleBackColor = true;
            this.btnSubDelete.Click += new System.EventHandler(this.btnSubDelete_Click);
            // 
            // btnSubPayFee
            // 
            this.btnSubPayFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPayFee.FlatAppearance.BorderSize = 0;
            this.btnSubPayFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPayFee.ForeColor = System.Drawing.Color.White;
            this.btnSubPayFee.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnSubPayFee.IconColor = System.Drawing.Color.White;
            this.btnSubPayFee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubPayFee.IconSize = 22;
            this.btnSubPayFee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPayFee.Location = new System.Drawing.Point(0, 111);
            this.btnSubPayFee.Name = "btnSubPayFee";
            this.btnSubPayFee.Size = new System.Drawing.Size(250, 38);
            this.btnSubPayFee.TabIndex = 3;
            this.btnSubPayFee.Text = "پرداخت شهریه";
            this.btnSubPayFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubPayFee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubPayFee.UseVisualStyleBackColor = true;
            this.btnSubPayFee.Click += new System.EventHandler(this.btnSubPayFee_Click);
            // 
            // btnSubEdite
            // 
            this.btnSubEdite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEdite.FlatAppearance.BorderSize = 0;
            this.btnSubEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEdite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubEdite.ForeColor = System.Drawing.Color.White;
            this.btnSubEdite.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSubEdite.IconColor = System.Drawing.Color.White;
            this.btnSubEdite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubEdite.IconSize = 22;
            this.btnSubEdite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEdite.Location = new System.Drawing.Point(0, 73);
            this.btnSubEdite.Name = "btnSubEdite";
            this.btnSubEdite.Size = new System.Drawing.Size(250, 38);
            this.btnSubEdite.TabIndex = 2;
            this.btnSubEdite.Text = "ویرایش کاربر";
            this.btnSubEdite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubEdite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubEdite.UseVisualStyleBackColor = true;
            this.btnSubEdite.Click += new System.EventHandler(this.btnSubEdite_Click);
            // 
            // btnSubDetail
            // 
            this.btnSubDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubDetail.FlatAppearance.BorderSize = 0;
            this.btnSubDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDetail.ForeColor = System.Drawing.Color.White;
            this.btnSubDetail.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnSubDetail.IconColor = System.Drawing.Color.White;
            this.btnSubDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubDetail.IconSize = 22;
            this.btnSubDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDetail.Location = new System.Drawing.Point(0, 35);
            this.btnSubDetail.Name = "btnSubDetail";
            this.btnSubDetail.Size = new System.Drawing.Size(250, 38);
            this.btnSubDetail.TabIndex = 1;
            this.btnSubDetail.Text = "جزیات";
            this.btnSubDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSubDetail.UseVisualStyleBackColor = true;
            this.btnSubDetail.Click += new System.EventHandler(this.btnSubDetail_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnReturn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 35);
            this.panel8.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnReturn.IconColor = System.Drawing.Color.White;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 40;
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(36, 35);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Aqua;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 766);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(902, 10);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(912, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 716);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 716);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnLabel
            // 
            this.btnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLabel.BackColor = System.Drawing.Color.White;
            this.btnLabel.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnLabel.FlatAppearance.BorderSize = 5;
            this.btnLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabel.ForeColor = System.Drawing.Color.Cyan;
            this.btnLabel.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnLabel.IconColor = System.Drawing.Color.Cyan;
            this.btnLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabel.Location = new System.Drawing.Point(217, -5);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(487, 65);
            this.btnLabel.TabIndex = 0;
            this.btnLabel.Text = "مدیریت اعضا";
            this.btnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLabel.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 776);
            this.Controls.Add(this.panel1);
            this.Name = "FrmManageMember";
            this.Text = "FrmManageMember";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.pnlSubMenu.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton btnDetails;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDate;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSubDelete;
        private FontAwesome.Sharp.IconButton btnSubPayFee;
        private FontAwesome.Sharp.IconButton btnSubEdite;
        private FontAwesome.Sharp.IconButton btnSubDetail;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLabel;
        private System.Windows.Forms.MaskedTextBox txtBirthDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnOpenPicture;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.MaskedTextBox txtValidDay;
        private System.Windows.Forms.MaskedTextBox txtJoinDay;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}