namespace eye_clinic.Doctors
{
    partial class frm_doctors
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
            this.components = new System.ComponentModel.Container();
            this.lbl_doctors = new System.Windows.Forms.Label();
            this.btn_adddoctor = new System.Windows.Forms.Button();
            this.btn_backdoctor = new System.Windows.Forms.Button();
            this.tbl_surgery = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_surgery)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_doctors
            // 
            this.lbl_doctors.AutoSize = true;
            this.lbl_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctors.Location = new System.Drawing.Point(48, 48);
            this.lbl_doctors.Name = "lbl_doctors";
            this.lbl_doctors.Size = new System.Drawing.Size(236, 69);
            this.lbl_doctors.TabIndex = 0;
            this.lbl_doctors.Text = "Doctors";
            // 
            // btn_adddoctor
            // 
            this.btn_adddoctor.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_adddoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adddoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_adddoctor.Location = new System.Drawing.Point(60, 143);
            this.btn_adddoctor.Name = "btn_adddoctor";
            this.btn_adddoctor.Size = new System.Drawing.Size(335, 70);
            this.btn_adddoctor.TabIndex = 1;
            this.btn_adddoctor.Text = "Add New Doctor";
            this.btn_adddoctor.UseVisualStyleBackColor = false;
            this.btn_adddoctor.Click += new System.EventHandler(this.btn_adddoctor_Click);
            // 
            // btn_backdoctor
            // 
            this.btn_backdoctor.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backdoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backdoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backdoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backdoctor.Location = new System.Drawing.Point(1836, 143);
            this.btn_backdoctor.Name = "btn_backdoctor";
            this.btn_backdoctor.Size = new System.Drawing.Size(147, 70);
            this.btn_backdoctor.TabIndex = 2;
            this.btn_backdoctor.Text = "Back";
            this.btn_backdoctor.UseVisualStyleBackColor = false;
            // 
            // tbl_surgery
            // 
            this.tbl_surgery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_surgery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_surgery.ContextMenuStrip = this.contextMenuStrip1;
            this.tbl_surgery.Location = new System.Drawing.Point(60, 282);
            this.tbl_surgery.Name = "tbl_surgery";
            this.tbl_surgery.RowHeadersWidth = 51;
            this.tbl_surgery.RowTemplate.Height = 24;
            this.tbl_surgery.Size = new System.Drawing.Size(1923, 769);
            this.tbl_surgery.TabIndex = 6;
            this.tbl_surgery.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_surgery_CellEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frm_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 988);
            this.Controls.Add(this.tbl_surgery);
            this.Controls.Add(this.btn_backdoctor);
            this.Controls.Add(this.btn_adddoctor);
            this.Controls.Add(this.lbl_doctors);
            this.Name = "frm_doctors";
            this.Text = "frm_doctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_doctors_Load);
            this.SizeChanged += new System.EventHandler(this.frm_doctors_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_surgery)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_doctors;
        private System.Windows.Forms.Button btn_adddoctor;
        private System.Windows.Forms.Button btn_backdoctor;
        private System.Windows.Forms.DataGridView tbl_surgery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}