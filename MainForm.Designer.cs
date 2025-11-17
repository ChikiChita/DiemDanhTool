namespace DiemDanhTool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnMarkProject;

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
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnMarkProject = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // comboName
            this.comboName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboName.Location = new System.Drawing.Point(12, 12);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(360, 25);

            // comboProject
            this.comboProject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboProject.Location = new System.Drawing.Point(12, 50);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(200, 25);

            // btnCheckIn
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCheckIn.Location = new System.Drawing.Point(12, 90);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(110, 36);
            this.btnCheckIn.Text = "Vào làm";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);

            // btnCheckOut
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCheckOut.Location = new System.Drawing.Point(130, 90);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(110, 36);
            this.btnCheckOut.Text = "Ra ca";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);

            // btnMarkProject
            this.btnMarkProject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMarkProject.Location = new System.Drawing.Point(250, 90);
            this.btnMarkProject.Name = "btnMarkProject";
            this.btnMarkProject.Size = new System.Drawing.Size(120, 36);
            this.btnMarkProject.Text = "Đánh dấu dự án";
            this.btnMarkProject.UseVisualStyleBackColor = true;
            this.btnMarkProject.Click += new System.EventHandler(this.btnMarkProject_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(384, 150);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnMarkProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool Chấm Công";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }
    }
}
