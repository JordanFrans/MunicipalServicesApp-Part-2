namespace MunicipalServicesApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRecommend = new System.Windows.Forms.Panel();
            this.lblRecommendedHeader = new System.Windows.Forms.Label();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.pnlRecommend.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(25, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 30);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(295, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Items.AddRange(new object[] {
            "All Categories",
            "Community",
            "Utilities",
            "Festivals"});
            this.cmbCategoryFilter.Location = new System.Drawing.Point(440, 45);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(200, 31);
            this.cmbCategoryFilter.TabIndex = 2;
            this.cmbCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryFilter_SelectedIndexChanged);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colCategory,
            this.colDate,
            this.colDesc});
            this.dgvEvents.Location = new System.Drawing.Point(25, 100);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 51;
            this.dgvEvents.RowTemplate.Height = 24;
            this.dgvEvents.Size = new System.Drawing.Size(615, 300);
            this.dgvEvents.TabIndex = 3;
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Event Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 140;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 100;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date Scheduled";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 110;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Description Details";
            this.colDesc.MinimumWidth = 6;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            this.colDesc.Width = 210;
            // 
            // pnlRecommend
            // 
            this.pnlRecommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlRecommend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecommend.Controls.Add(this.lblRecommendedHeader);
            this.pnlRecommend.Controls.Add(this.lstRecommendations);
            this.pnlRecommend.Location = new System.Drawing.Point(25, 420);
            this.pnlRecommend.Name = "pnlRecommend";
            this.pnlRecommend.Size = new System.Drawing.Size(615, 115);
            this.pnlRecommend.TabIndex = 4;
            // 
            // lblRecommendedHeader
            // 
            this.lblRecommendedHeader.AutoSize = true;
            this.lblRecommendedHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecommendedHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRecommendedHeader.Location = new System.Drawing.Point(12, 10);
            this.lblRecommendedHeader.Name = "lblRecommendedHeader";
            this.lblRecommendedHeader.Size = new System.Drawing.Size(262, 23);
            this.lblRecommendedHeader.TabIndex = 0;
            this.lblRecommendedHeader.Text = "Recommended for You (None):";
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 21;
            this.lstRecommendations.Location = new System.Drawing.Point(15, 40);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(580, 46);
            this.lstRecommendations.TabIndex = 1;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(22, 20);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(161, 17);
            this.lblSearchTitle.TabIndex = 5;
            this.lblSearchTitle.Text = "Search Keywords/Titles:";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Location = new System.Drawing.Point(437, 20);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(129, 17);
            this.lblFilterTitle.TabIndex = 6;
            this.lblFilterTitle.Text = "Filter by Category:";
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 560);
            this.Controls.Add(this.lblFilterTitle);
            this.Controls.Add(this.lblSearchTitle);
            this.Controls.Add(this.pnlRecommend);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Events & Announcements";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.pnlRecommend.ResumeLayout(false);
            this.pnlRecommend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.Panel pnlRecommend;
        private System.Windows.Forms.Label lblRecommendedHeader;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.Label lblFilterTitle;
    }
}
