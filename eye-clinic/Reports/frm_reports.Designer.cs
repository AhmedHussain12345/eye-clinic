namespace eye_clinic.Reports
{
    partial class frm_reports
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
            this.lbl_reports = new System.Windows.Forms.Label();
            this.btn_addreports = new System.Windows.Forms.Button();
            this.btn_backreports = new System.Windows.Forms.Button();
            this.tbl_reports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_reports
            // 
            this.lbl_reports.AutoSize = true;
            this.lbl_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reports.Location = new System.Drawing.Point(45, 40);
            this.lbl_reports.Name = "lbl_reports";
            this.lbl_reports.Size = new System.Drawing.Size(239, 69);
            this.lbl_reports.TabIndex = 3;
            this.lbl_reports.Text = "Reports";
            // 
            // btn_addreports
            // 
            this.btn_addreports.BackColor = System.Drawing.Color.Red;
            this.btn_addreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addreports.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_addreports.Location = new System.Drawing.Point(57, 140);
            this.btn_addreports.Name = "btn_addreports";
            this.btn_addreports.Size = new System.Drawing.Size(335, 70);
            this.btn_addreports.TabIndex = 4;
            this.btn_addreports.Text = "Add New Reports";
            this.btn_addreports.UseVisualStyleBackColor = false;
            this.btn_addreports.Click += new System.EventHandler(this.btn_addreports_Click);
            // 
            // btn_backreports
            // 
            this.btn_backreports.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backreports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backreports.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backreports.Location = new System.Drawing.Point(1846, 140);
            this.btn_backreports.Name = "btn_backreports";
            this.btn_backreports.Size = new System.Drawing.Size(147, 70);
            this.btn_backreports.TabIndex = 5;
            this.btn_backreports.Text = "Back";
            this.btn_backreports.UseVisualStyleBackColor = false;
            // 
            // tbl_reports
            // 
            this.tbl_reports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_reports.Location = new System.Drawing.Point(57, 272);
            this.tbl_reports.Name = "tbl_reports";
            this.tbl_reports.RowHeadersWidth = 51;
            this.tbl_reports.RowTemplate.Height = 24;
            this.tbl_reports.Size = new System.Drawing.Size(1936, 769);
            this.tbl_reports.TabIndex = 6;
            // 
            // frm_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 970);
            this.Controls.Add(this.tbl_reports);
            this.Controls.Add(this.btn_backreports);
            this.Controls.Add(this.btn_addreports);
            this.Controls.Add(this.lbl_reports);
            this.Name = "frm_reports";
            this.Text = "frm_reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_reports;
        private System.Windows.Forms.Button btn_addreports;
        private System.Windows.Forms.Button btn_backreports;
        private System.Windows.Forms.DataGridView tbl_reports;
    }
}