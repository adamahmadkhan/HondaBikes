namespace Modern_Login
{
    partial class TotalCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.UpdateCart = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(385, 28);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(42, 41);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // UpdateCart
            // 
            this.UpdateCart.BackColor = System.Drawing.Color.Red;
            this.UpdateCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateCart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.UpdateCart.FlatAppearance.BorderSize = 0;
            this.UpdateCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UpdateCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCart.Location = new System.Drawing.Point(423, 28);
            this.UpdateCart.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCart.Name = "UpdateCart";
            this.UpdateCart.Size = new System.Drawing.Size(114, 41);
            this.UpdateCart.TabIndex = 7;
            this.UpdateCart.Text = "UpdateCart";
            this.UpdateCart.UseVisualStyleBackColor = false;
            this.UpdateCart.Click += new System.EventHandler(this.UpdateCart_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(851, 481);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // TotalCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.UpdateCart);
            this.Name = "TotalCart";
            this.Size = new System.Drawing.Size(888, 594);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button UpdateCart;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
