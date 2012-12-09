namespace QueensUni
{
    partial class StudentDetails
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdStDetails = new System.Windows.Forms.DataGridView();
            this.St_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.St_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(328, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "AddNew";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(409, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdStDetails
            // 
            this.grdStDetails.AllowUserToAddRows = false;
            this.grdStDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.St_Id,
            this.St_Name,
            this.Dob,
            this.Gpa,
            this.Active});
            this.grdStDetails.Location = new System.Drawing.Point(12, 87);
            this.grdStDetails.Name = "grdStDetails";
            this.grdStDetails.Size = new System.Drawing.Size(743, 300);
            this.grdStDetails.TabIndex = 2;
            // 
            // St_Id
            // 
            this.St_Id.HeaderText = "Student ID";
            this.St_Id.Name = "St_Id";
            this.St_Id.ReadOnly = true;
            // 
            // St_Name
            // 
            this.St_Name.HeaderText = "Student Name";
            this.St_Name.Name = "St_Name";
            this.St_Name.ReadOnly = true;
            this.St_Name.Width = 300;
            // 
            // Dob
            // 
            this.Dob.HeaderText = "Date of Birth";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            // 
            // Gpa
            // 
            this.Gpa.HeaderText = "GPA";
            this.Gpa.Name = "Gpa";
            this.Gpa.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 399);
            this.Controls.Add(this.grdStDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdStDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn St_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}