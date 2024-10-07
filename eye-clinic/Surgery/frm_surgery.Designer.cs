namespace eye_clinic.Surgery
{
    partial class frm_surgery
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
            this.lbl_surgery = new System.Windows.Forms.Label();
            this.btn_addsurgery = new System.Windows.Forms.Button();
            this.tbl_surgery = new System.Windows.Forms.DataGridView();
            this.btn_backsurgery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_surgery)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_surgery
            // 
            this.lbl_surgery.AutoSize = true;
            this.lbl_surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surgery.Location = new System.Drawing.Point(48, 37);
            this.lbl_surgery.Name = "lbl_surgery";
            this.lbl_surgery.Size = new System.Drawing.Size(239, 69);
            this.lbl_surgery.TabIndex = 2;
            this.lbl_surgery.Text = "Surgery";
            // 
            // btn_addsurgery
            // 
            this.btn_addsurgery.BackColor = System.Drawing.Color.Blue;
            this.btn_addsurgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addsurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsurgery.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_addsurgery.Location = new System.Drawing.Point(60, 136);
            this.btn_addsurgery.Name = "btn_addsurgery";
            this.btn_addsurgery.Size = new System.Drawing.Size(335, 70);
            this.btn_addsurgery.TabIndex = 3;
            this.btn_addsurgery.Text = "Add New Surgery";
            this.btn_addsurgery.UseVisualStyleBackColor = false;
            // 
            // tbl_surgery
            // 
            this.tbl_surgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_surgery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_surgery.Location = new System.Drawing.Point(60, 275);
            this.tbl_surgery.Name = "tbl_surgery";
            this.tbl_surgery.RowHeadersWidth = 51;
            this.tbl_surgery.RowTemplate.Height = 24;
            this.tbl_surgery.Size = new System.Drawing.Size(1923, 769);
            this.tbl_surgery.TabIndex = 5;
            // 
            // btn_backsurgery
            // 
            this.btn_backsurgery.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backsurgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backsurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backsurgery.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backsurgery.Location = new System.Drawing.Point(1836, 136);
            this.btn_backsurgery.Name = "btn_backsurgery";
            this.btn_backsurgery.Size = new System.Drawing.Size(147, 70);
            this.btn_backsurgery.TabIndex = 4;
            this.btn_backsurgery.Text = "Back";
            this.btn_backsurgery.UseVisualStyleBackColor = false;
            // 
            // frm_surgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 970);
            this.Controls.Add(this.tbl_surgery);
            this.Controls.Add(this.btn_backsurgery);
            this.Controls.Add(this.btn_addsurgery);
            this.Controls.Add(this.lbl_surgery);
            this.Name = "frm_surgery";
            this.Text = "frm_surgery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_surgery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_surgery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_surgery;
        private System.Windows.Forms.Button btn_addsurgery;
        private System.Windows.Forms.DataGridView tbl_surgery;
        private System.Windows.Forms.Button btn_backsurgery;
    }
}