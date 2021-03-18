namespace BashGah.Forms
{
    partial class FrmAddWardrobs
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
            this.lblWarn = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLabel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(490, 290);
            this.panel1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblWarn);
            this.panel7.Controls.Add(this.txt);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btn_Add);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(470, 239);
            this.panel7.TabIndex = 9;
            // 
            // lblWarn
            // 
            this.lblWarn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarn.AutoSize = true;
            this.lblWarn.Location = new System.Drawing.Point(182, 135);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWarn.Size = new System.Drawing.Size(20, 17);
            this.lblWarn.TabIndex = 26;
            this.lblWarn.Text = "...";
            // 
            // txt
            // 
            this.txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(123, 60);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(199, 27);
            this.txt.TabIndex = 25;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "شماره ی کمد : ";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Add.IconColor = System.Drawing.Color.White;
            this.btn_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Add.IconSize = 27;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(144, 174);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(160, 46);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "اضافه کردن";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SpringGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 10);
            this.panel5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(480, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 249);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SpringGreen;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 249);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 41);
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
            this.btnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnLabel.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnLabel.IconColor = System.Drawing.Color.SpringGreen;
            this.btnLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLabel.IconSize = 28;
            this.btnLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabel.Location = new System.Drawing.Point(162, 0);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(152, 41);
            this.btnLabel.TabIndex = 0;
            this.btnLabel.Text = "اضافه کردن کمد";
            this.btnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLabel.UseVisualStyleBackColor = false;
            // 
            // FrmAddWardrobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 290);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddWardrobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه کردن کمد";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Add;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnLabel;
    }
}