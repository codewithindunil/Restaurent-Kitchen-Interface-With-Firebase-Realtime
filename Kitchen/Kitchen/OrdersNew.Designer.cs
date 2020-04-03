namespace Kitchen
{
    partial class OrdersNew
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersNew));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblQty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnStatusMark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 41);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Item";
            // 
            // lblSize
            // 
            this.lblSize.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(233, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(88, 41);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // lblQty
            // 
            this.lblQty.AllowDrop = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(360, 25);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(85, 41);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Qty";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // btnStatusMark
            // 
            this.btnStatusMark.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStatusMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStatusMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStatusMark.BorderRadius = 0;
            this.btnStatusMark.ButtonText = "PENDING";
            this.btnStatusMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatusMark.DisabledColor = System.Drawing.Color.Gray;
            this.btnStatusMark.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStatusMark.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStatusMark.Iconimage")));
            this.btnStatusMark.Iconimage_right = null;
            this.btnStatusMark.Iconimage_right_Selected = null;
            this.btnStatusMark.Iconimage_Selected = null;
            this.btnStatusMark.IconMarginLeft = 0;
            this.btnStatusMark.IconMarginRight = 0;
            this.btnStatusMark.IconRightVisible = true;
            this.btnStatusMark.IconRightZoom = 0D;
            this.btnStatusMark.IconVisible = true;
            this.btnStatusMark.IconZoom = 90D;
            this.btnStatusMark.IsTab = false;
            this.btnStatusMark.Location = new System.Drawing.Point(533, 18);
            this.btnStatusMark.Name = "btnStatusMark";
            this.btnStatusMark.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStatusMark.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStatusMark.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStatusMark.selected = false;
            this.btnStatusMark.Size = new System.Drawing.Size(217, 48);
            this.btnStatusMark.TabIndex = 3;
            this.btnStatusMark.Text = "PENDING";
            this.btnStatusMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusMark.Textcolor = System.Drawing.Color.White;
            this.btnStatusMark.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // OrdersNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnStatusMark);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Name = "OrdersNew";
            this.Size = new System.Drawing.Size(786, 91);
            this.Load += new System.EventHandler(this.OrdersNew_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblQty;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSize;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuFlatButton btnStatusMark;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
