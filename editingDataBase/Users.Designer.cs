namespace editingDataBase
    {
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ДобавлениеЗаписи = new System.Windows.Forms.ToolStripButton();
            this.РедактированиеЗаписи = new System.Windows.Forms.ToolStripButton();
            this.УдалениеЗаписи = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(992, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ДобавлениеЗаписи,
            this.РедактированиеЗаписи,
            this.УдалениеЗаписи});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ДобавлениеЗаписи
            // 
            this.ДобавлениеЗаписи.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ДобавлениеЗаписи.Image = ((System.Drawing.Image)(resources.GetObject("ДобавлениеЗаписи.Image")));
            this.ДобавлениеЗаписи.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ДобавлениеЗаписи.Name = "ДобавлениеЗаписи";
            this.ДобавлениеЗаписи.Size = new System.Drawing.Size(23, 22);
            this.ДобавлениеЗаписи.Text = "Add";
            this.ДобавлениеЗаписи.Click += new System.EventHandler(this.ДобавлениеЗаписи_Click);
            // 
            // РедактированиеЗаписи
            // 
            this.РедактированиеЗаписи.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.РедактированиеЗаписи.Image = ((System.Drawing.Image)(resources.GetObject("РедактированиеЗаписи.Image")));
            this.РедактированиеЗаписи.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.РедактированиеЗаписи.Name = "РедактированиеЗаписи";
            this.РедактированиеЗаписи.Size = new System.Drawing.Size(23, 22);
            this.РедактированиеЗаписи.Text = "Edit";
            this.РедактированиеЗаписи.Click += new System.EventHandler(this.РедактированиеЗаписи_Click);
            // 
            // УдалениеЗаписи
            // 
            this.УдалениеЗаписи.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.УдалениеЗаписи.Image = ((System.Drawing.Image)(resources.GetObject("УдалениеЗаписи.Image")));
            this.УдалениеЗаписи.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.УдалениеЗаписи.Name = "УдалениеЗаписи";
            this.УдалениеЗаписи.Size = new System.Drawing.Size(23, 22);
            this.УдалениеЗаписи.Text = "Remove";
            this.УдалениеЗаписи.Click += new System.EventHandler(this.УдалениеЗаписи_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ДобавлениеЗаписи;
        private System.Windows.Forms.ToolStripButton РедактированиеЗаписи;
        private System.Windows.Forms.ToolStripButton УдалениеЗаписи;
        }
    }