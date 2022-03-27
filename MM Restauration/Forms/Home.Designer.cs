namespace MM_Restauration
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.maxiBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.ComBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maxiBtn
            // 
            this.maxiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxiBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.maxiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxiBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxiBtn.Image")));
            this.maxiBtn.Location = new System.Drawing.Point(1008, 3);
            this.maxiBtn.Name = "maxiBtn";
            this.maxiBtn.Size = new System.Drawing.Size(35, 35);
            this.maxiBtn.TabIndex = 0;
            this.maxiBtn.UseVisualStyleBackColor = true;
            this.maxiBtn.Click += new System.EventHandler(this.maxiBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1050, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Tag = "";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.Location = new System.Drawing.Point(966, 3);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(35, 35);
            this.minBtn.TabIndex = 0;
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maxiBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 7);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1083, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 498);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 498);
            this.panel4.TabIndex = 4;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuBtn.AutoSize = true;
            this.MenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.Location = new System.Drawing.Point(87, 223);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(220, 220);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // ComBtn
            // 
            this.ComBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBtn.AutoSize = true;
            this.ComBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ComBtn.Image = ((System.Drawing.Image)(resources.GetObject("ComBtn.Image")));
            this.ComBtn.Location = new System.Drawing.Point(440, 223);
            this.ComBtn.Name = "ComBtn";
            this.ComBtn.Size = new System.Drawing.Size(220, 220);
            this.ComBtn.TabIndex = 0;
            this.ComBtn.Text = "  Commandes";
            this.ComBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ComBtn.UseVisualStyleBackColor = true;
            this.ComBtn.Click += new System.EventHandler(this.comBtn_Click);
            // 
            // CustBtn
            // 
            this.CustBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustBtn.AutoSize = true;
            this.CustBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.CustBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustBtn.Image")));
            this.CustBtn.Location = new System.Drawing.Point(793, 223);
            this.CustBtn.Name = "CustBtn";
            this.CustBtn.Size = new System.Drawing.Size(220, 220);
            this.CustBtn.TabIndex = 0;
            this.CustBtn.Text = "Clients";
            this.CustBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CustBtn.UseVisualStyleBackColor = true;
            this.CustBtn.Click += new System.EventHandler(this.cusBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(382, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 89);
            this.panel5.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1090, 550);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.CustBtn);
            this.Controls.Add(this.ComBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MM Restauration";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maxiBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button ComBtn;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.Panel panel5;
    }
}

