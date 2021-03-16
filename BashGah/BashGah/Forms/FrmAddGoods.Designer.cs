namespace BashGah.Forms
{
    partial class FrmAddGoods
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
            this.txtInventory = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLabel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtInventory);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCalcel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGoodsName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 634);
            this.panel1.TabIndex = 2;
            // 
            // txtInventory
            // 
            this.txtInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(198, 248);
            this.txtInventory.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(300, 30);
            this.txtInventory.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(198, 182);
            this.txtPrice.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(300, 30);
            this.txtPrice.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(576, 185);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "قیمت کالا";
            // 
            // btnCalcel
            // 
            this.btnCalcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCalcel.FlatAppearance.BorderSize = 0;
            this.btnCalcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcel.ForeColor = System.Drawing.Color.White;
            this.btnCalcel.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCalcel.IconColor = System.Drawing.Color.White;
            this.btnCalcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcel.Location = new System.Drawing.Point(200, 526);
            this.btnCalcel.Name = "btnCalcel";
            this.btnCalcel.Size = new System.Drawing.Size(196, 56);
            this.btnCalcel.TabIndex = 22;
            this.btnCalcel.Text = "لغو";
            this.btnCalcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcel.UseVisualStyleBackColor = false;
            this.btnCalcel.Click += new System.EventHandler(this.btnCalcel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(466, 526);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 56);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ثبت";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 249);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "تعداد موجودی : ";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGoodsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsName.Location = new System.Drawing.Point(200, 116);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGoodsName.Size = new System.Drawing.Size(300, 30);
            this.txtGoodsName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 117);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام کالا :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SpringGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 624);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 10);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(833, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 574);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SpringGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 574);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnLabel
            // 
            this.btnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLabel.BackColor = System.Drawing.Color.White;
            this.btnLabel.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnLabel.FlatAppearance.BorderSize = 5;
            this.btnLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnLabel.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnLabel.IconColor = System.Drawing.Color.SpringGreen;
            this.btnLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabel.Location = new System.Drawing.Point(217, -5);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(408, 65);
            this.btnLabel.TabIndex = 0;
            this.btnLabel.Text = "ثبت کالا";
            this.btnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLabel.UseVisualStyleBackColor = false;
            // 
            // FrmAddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 634);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddGoods";
            this.Text = "FrmAddGoods";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnCalcel;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLabel;
        private System.Windows.Forms.NumericUpDown txtInventory;
        private System.Windows.Forms.NumericUpDown txtPrice;
    }
}