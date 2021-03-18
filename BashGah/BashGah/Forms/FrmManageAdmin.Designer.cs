namespace BashGah.Forms
{
    partial class FrmManageAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.cbReStore = new System.Windows.Forms.CheckBox();
            this.cbBackUp = new System.Windows.Forms.CheckBox();
            this.cbManageAccess = new System.Windows.Forms.CheckBox();
            this.cbCaseHistory = new System.Windows.Forms.CheckBox();
            this.cbAddGoods = new System.Windows.Forms.CheckBox();
            this.cbManageMember = new System.Windows.Forms.CheckBox();
            this.cbSaleGoods = new System.Windows.Forms.CheckBox();
            this.cbManageWardrobe = new System.Windows.Forms.CheckBox();
            this.cbManageGoods = new System.Windows.Forms.CheckBox();
            this.cbAddMember = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLabel = new FontAwesome.Sharp.IconButton();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 755);
            this.panel1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Add);
            this.panel7.Controls.Add(this.cbReStore);
            this.panel7.Controls.Add(this.cbBackUp);
            this.panel7.Controls.Add(this.cbManageAccess);
            this.panel7.Controls.Add(this.cbCaseHistory);
            this.panel7.Controls.Add(this.cbAddGoods);
            this.panel7.Controls.Add(this.cbManageMember);
            this.panel7.Controls.Add(this.cbSaleGoods);
            this.panel7.Controls.Add(this.cbManageWardrobe);
            this.panel7.Controls.Add(this.cbManageGoods);
            this.panel7.Controls.Add(this.cbAddMember);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(827, 685);
            this.panel7.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Add.IconColor = System.Drawing.Color.White;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.IconSize = 27;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(342, 627);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(160, 46);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "ثبت";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbReStore
            // 
            this.cbReStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbReStore.AutoSize = true;
            this.cbReStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReStore.Location = new System.Drawing.Point(537, 578);
            this.cbReStore.Name = "cbReStore";
            this.cbReStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbReStore.Size = new System.Drawing.Size(146, 28);
            this.cbReStore.TabIndex = 34;
            this.cbReStore.Text = "بازیابی پشتیبانی";
            this.cbReStore.UseVisualStyleBackColor = true;
            // 
            // cbBackUp
            // 
            this.cbBackUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBackUp.AutoSize = true;
            this.cbBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBackUp.Location = new System.Drawing.Point(222, 457);
            this.cbBackUp.Name = "cbBackUp";
            this.cbBackUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbBackUp.Size = new System.Drawing.Size(117, 28);
            this.cbBackUp.TabIndex = 33;
            this.cbBackUp.Text = "تهیه پشتیبان";
            this.cbBackUp.UseVisualStyleBackColor = true;
            // 
            // cbManageAccess
            // 
            this.cbManageAccess.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbManageAccess.AutoSize = true;
            this.cbManageAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageAccess.Location = new System.Drawing.Point(192, 400);
            this.cbManageAccess.Name = "cbManageAccess";
            this.cbManageAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbManageAccess.Size = new System.Drawing.Size(147, 28);
            this.cbManageAccess.TabIndex = 32;
            this.cbManageAccess.Text = "مدیریت دسترسی";
            this.cbManageAccess.UseVisualStyleBackColor = true;
            // 
            // cbCaseHistory
            // 
            this.cbCaseHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCaseHistory.AutoSize = true;
            this.cbCaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaseHistory.Location = new System.Drawing.Point(537, 523);
            this.cbCaseHistory.Name = "cbCaseHistory";
            this.cbCaseHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCaseHistory.Size = new System.Drawing.Size(130, 28);
            this.cbCaseHistory.TabIndex = 31;
            this.cbCaseHistory.Text = "بررسی سوابق";
            this.cbCaseHistory.UseVisualStyleBackColor = true;
            // 
            // cbAddGoods
            // 
            this.cbAddGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAddGoods.AutoSize = true;
            this.cbAddGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddGoods.Location = new System.Drawing.Point(393, 400);
            this.cbAddGoods.Name = "cbAddGoods";
            this.cbAddGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAddGoods.Size = new System.Drawing.Size(95, 28);
            this.cbAddGoods.TabIndex = 30;
            this.cbAddGoods.Text = "ثبت کالا ";
            this.cbAddGoods.UseVisualStyleBackColor = true;
            // 
            // cbManageMember
            // 
            this.cbManageMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbManageMember.AutoSize = true;
            this.cbManageMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageMember.Location = new System.Drawing.Point(539, 457);
            this.cbManageMember.Name = "cbManageMember";
            this.cbManageMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbManageMember.Size = new System.Drawing.Size(128, 28);
            this.cbManageMember.TabIndex = 29;
            this.cbManageMember.Text = "مدیریت اعضا";
            this.cbManageMember.UseVisualStyleBackColor = true;
            // 
            // cbSaleGoods
            // 
            this.cbSaleGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSaleGoods.AutoSize = true;
            this.cbSaleGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaleGoods.Location = new System.Drawing.Point(384, 523);
            this.cbSaleGoods.Name = "cbSaleGoods";
            this.cbSaleGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSaleGoods.Size = new System.Drawing.Size(104, 28);
            this.cbSaleGoods.TabIndex = 28;
            this.cbSaleGoods.Text = "فروش کالا";
            this.cbSaleGoods.UseVisualStyleBackColor = true;
            // 
            // cbManageWardrobe
            // 
            this.cbManageWardrobe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbManageWardrobe.AutoSize = true;
            this.cbManageWardrobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageWardrobe.Location = new System.Drawing.Point(205, 523);
            this.cbManageWardrobe.Name = "cbManageWardrobe";
            this.cbManageWardrobe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbManageWardrobe.Size = new System.Drawing.Size(134, 28);
            this.cbManageWardrobe.TabIndex = 27;
            this.cbManageWardrobe.Text = "مدیریت کمد ها";
            this.cbManageWardrobe.UseVisualStyleBackColor = true;
            // 
            // cbManageGoods
            // 
            this.cbManageGoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbManageGoods.AutoSize = true;
            this.cbManageGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManageGoods.Location = new System.Drawing.Point(374, 457);
            this.cbManageGoods.Name = "cbManageGoods";
            this.cbManageGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbManageGoods.Size = new System.Drawing.Size(114, 28);
            this.cbManageGoods.TabIndex = 26;
            this.cbManageGoods.Text = "مدیریت کالا";
            this.cbManageGoods.UseVisualStyleBackColor = true;
            // 
            // cbAddMember
            // 
            this.cbAddMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbAddMember.AutoSize = true;
            this.cbAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddMember.Location = new System.Drawing.Point(578, 400);
            this.cbAddMember.Name = "cbAddMember";
            this.cbAddMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAddMember.Size = new System.Drawing.Size(89, 28);
            this.cbAddMember.TabIndex = 25;
            this.cbAddMember.Text = "ثبت نام ";
            this.cbAddMember.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPass2);
            this.panel6.Controls.Add(this.txtPass);
            this.panel6.Controls.Add(this.txtName);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(827, 380);
            this.panel6.TabIndex = 6;
            // 
            // txtPass2
            // 
            this.txtPass2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(203, 308);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(299, 27);
            this.txtPass2.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(203, 266);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(299, 27);
            this.txtPass.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(203, 224);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(299, 27);
            this.txtName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(511, 311);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "تکرار رمز : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 269);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "رمز : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 227);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کاربری : ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtGrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(827, 187);
            this.panel8.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Fuchsia;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 745);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 10);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(837, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 695);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Fuchsia;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 695);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnLabel
            // 
            this.btnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLabel.BackColor = System.Drawing.Color.White;
            this.btnLabel.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnLabel.FlatAppearance.BorderSize = 5;
            this.btnLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnLabel.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnLabel.IconColor = System.Drawing.Color.Fuchsia;
            this.btnLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabel.Location = new System.Drawing.Point(217, -5);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(412, 65);
            this.btnLabel.TabIndex = 0;
            this.btnLabel.Text = "سطح دسترسی";
            this.btnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLabel.UseVisualStyleBackColor = false;
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.AllowUserToResizeColumns = false;
            this.dtGrid.AllowUserToResizeRows = false;
            this.dtGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FullName});
            this.dtGrid.Location = new System.Drawing.Point(205, 6);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtGrid.RowHeadersWidth = 51;
            this.dtGrid.RowTemplate.Height = 24;
            this.dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid.Size = new System.Drawing.Size(414, 166);
            this.dtGrid.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "AdminAccess_ID";
            this.Column1.HeaderText = "شناسه";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "AdminAccess_UserName";
            this.FullName.HeaderText = "نام مدیر";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // FrmManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 755);
            this.Controls.Add(this.panel1);
            this.Name = "FrmManageAdmin";
            this.Text = "FrmManageAdmin";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.CheckBox cbReStore;
        private System.Windows.Forms.CheckBox cbBackUp;
        private System.Windows.Forms.CheckBox cbManageAccess;
        private System.Windows.Forms.CheckBox cbCaseHistory;
        private System.Windows.Forms.CheckBox cbAddGoods;
        private System.Windows.Forms.CheckBox cbManageMember;
        private System.Windows.Forms.CheckBox cbSaleGoods;
        private System.Windows.Forms.CheckBox cbManageWardrobe;
        private System.Windows.Forms.CheckBox cbManageGoods;
        private System.Windows.Forms.CheckBox cbAddMember;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
    }
}