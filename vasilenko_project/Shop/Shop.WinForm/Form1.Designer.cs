namespace Shop.WinForm
{
    partial class Form1
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
            this.gBoxCategory = new System.Windows.Forms.GroupBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.gBoxListGood = new System.Windows.Forms.GroupBox();
            this.lbGood = new System.Windows.Forms.ListBox();
            this.gBoxGood = new System.Windows.Forms.GroupBox();
            this.lblMaunufacturer = new System.Windows.Forms.Label();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameGood = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.gBoxCategory.SuspendLayout();
            this.gBoxListGood.SuspendLayout();
            this.gBoxGood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxCategory
            // 
            this.gBoxCategory.Controls.Add(this.lbCategory);
            this.gBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.gBoxCategory.Name = "gBoxCategory";
            this.gBoxCategory.Size = new System.Drawing.Size(163, 228);
            this.gBoxCategory.TabIndex = 0;
            this.gBoxCategory.TabStop = false;
            this.gBoxCategory.Text = "Категории";
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Location = new System.Drawing.Point(7, 20);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(150, 199);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // gBoxListGood
            // 
            this.gBoxListGood.Controls.Add(this.lbGood);
            this.gBoxListGood.Location = new System.Drawing.Point(181, 12);
            this.gBoxListGood.Name = "gBoxListGood";
            this.gBoxListGood.Size = new System.Drawing.Size(307, 228);
            this.gBoxListGood.TabIndex = 1;
            this.gBoxListGood.TabStop = false;
            this.gBoxListGood.Text = "Товары";
            // 
            // lbGood
            // 
            this.lbGood.FormattingEnabled = true;
            this.lbGood.Location = new System.Drawing.Point(6, 19);
            this.lbGood.Name = "lbGood";
            this.lbGood.Size = new System.Drawing.Size(295, 199);
            this.lbGood.TabIndex = 1;
            this.lbGood.SelectedIndexChanged += new System.EventHandler(this.lbGood_SelectedIndexChanged);
            // 
            // gBoxGood
            // 
            this.gBoxGood.Controls.Add(this.lblMaunufacturer);
            this.gBoxGood.Controls.Add(this.pictureGood);
            this.gBoxGood.Controls.Add(this.lblCount);
            this.gBoxGood.Controls.Add(this.lblPrice);
            this.gBoxGood.Controls.Add(this.lblNameGood);
            this.gBoxGood.Location = new System.Drawing.Point(12, 246);
            this.gBoxGood.Name = "gBoxGood";
            this.gBoxGood.Size = new System.Drawing.Size(476, 144);
            this.gBoxGood.TabIndex = 2;
            this.gBoxGood.TabStop = false;
            this.gBoxGood.Text = "Информация о товаре";
            // 
            // lblMaunufacturer
            // 
            this.lblMaunufacturer.AutoSize = true;
            this.lblMaunufacturer.Location = new System.Drawing.Point(7, 64);
            this.lblMaunufacturer.Name = "lblMaunufacturer";
            this.lblMaunufacturer.Size = new System.Drawing.Size(76, 13);
            this.lblMaunufacturer.TabIndex = 4;
            this.lblMaunufacturer.Text = "Maunufacturer";
            // 
            // pictureGood
            // 
            this.pictureGood.Location = new System.Drawing.Point(274, 19);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(196, 119);
            this.pictureGood.TabIndex = 3;
            this.pictureGood.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 111);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblNameGood
            // 
            this.lblNameGood.AutoSize = true;
            this.lblNameGood.Location = new System.Drawing.Point(7, 29);
            this.lblNameGood.Name = "lblNameGood";
            this.lblNameGood.Size = new System.Drawing.Size(35, 13);
            this.lblNameGood.TabIndex = 0;
            this.lblNameGood.Text = "Name";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(358, 405);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(130, 23);
            this.btnAddCart.TabIndex = 3;
            this.btnAddCart.Text = "Добавить в корзину";
            this.btnAddCart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 439);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.gBoxGood);
            this.Controls.Add(this.gBoxListGood);
            this.Controls.Add(this.gBoxCategory);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxCategory.ResumeLayout(false);
            this.gBoxListGood.ResumeLayout(false);
            this.gBoxGood.ResumeLayout(false);
            this.gBoxGood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxCategory;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.GroupBox gBoxListGood;
        private System.Windows.Forms.ListBox lbGood;
        private System.Windows.Forms.GroupBox gBoxGood;
        private System.Windows.Forms.Label lblMaunufacturer;
        private System.Windows.Forms.PictureBox pictureGood;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameGood;
        private System.Windows.Forms.Button btnAddCart;
    }
}

