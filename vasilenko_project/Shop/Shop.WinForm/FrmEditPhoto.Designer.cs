namespace Shop.WinForm
{
    partial class FrmEditPhoto
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
            this.dgvGood = new System.Windows.Forms.DataGridView();
            this.flowPanelPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGood
            // 
            this.dgvGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGood.Location = new System.Drawing.Point(12, 25);
            this.dgvGood.MultiSelect = false;
            this.dgvGood.Name = "dgvGood";
            this.dgvGood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGood.Size = new System.Drawing.Size(500, 243);
            this.dgvGood.TabIndex = 0;
            this.dgvGood.SelectionChanged += new System.EventHandler(this.dgvGood_SelectionChanged);
            // 
            // flowPanelPhoto
            // 
            this.flowPanelPhoto.AutoScroll = true;
            this.flowPanelPhoto.Location = new System.Drawing.Point(533, 25);
            this.flowPanelPhoto.Name = "flowPanelPhoto";
            this.flowPanelPhoto.Size = new System.Drawing.Size(143, 243);
            this.flowPanelPhoto.TabIndex = 1;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(408, 275);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(104, 23);
            this.btnAddPhoto.TabIndex = 2;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save to DB";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEditPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 309);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.flowPanelPhoto);
            this.Controls.Add(this.dgvGood);
            this.Name = "FrmEditPhoto";
            this.Text = "FrmEditPhoto";
            this.Load += new System.EventHandler(this.FrmEditPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGood;
        private System.Windows.Forms.FlowLayoutPanel flowPanelPhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnSave;
    }
}