namespace MM_Restauration
{
    partial class CustomizedErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizedErrorMessage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.caption = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorMsg = new System.Windows.Forms.Label();
            this.wrongBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.caption);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 31);
            this.panel1.TabIndex = 0;
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caption.ForeColor = System.Drawing.Color.White;
            this.caption.Location = new System.Drawing.Point(3, 5);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(85, 22);
            this.caption.TabIndex = 1;
            this.caption.Text = "Captoin";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.DimGray;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.DimGray;
            this.cancelBtn.Location = new System.Drawing.Point(363, -1);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(35, 34);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.White;
            this.errorMsg.Location = new System.Drawing.Point(12, 60);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(86, 21);
            this.errorMsg.TabIndex = 1;
            this.errorMsg.Text = "Message";
            this.errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongBtn
            // 
            this.wrongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrongBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongBtn.ForeColor = System.Drawing.Color.DimGray;
            this.wrongBtn.Location = new System.Drawing.Point(290, 163);
            this.wrongBtn.Name = "wrongBtn";
            this.wrongBtn.Size = new System.Drawing.Size(99, 36);
            this.wrongBtn.TabIndex = 2;
            this.wrongBtn.Text = "Ok";
            this.wrongBtn.UseVisualStyleBackColor = true;
            this.wrongBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 175);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(396, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 175);
            this.panel4.TabIndex = 4;
            // 
            // CustomizedErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(401, 211);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wrongBtn);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomizedErrorMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomizedErrorMessage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button wrongBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}