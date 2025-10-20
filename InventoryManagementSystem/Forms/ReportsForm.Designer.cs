namespace InventoryManagementSystem
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerateReport;
        private Button btnToday;
        private Button btnClose;
        private DataGridView dgvResults;
        private Label lblSummary;
        private Panel panelControls;
        private Panel panelResults;


        private void InitializeComponent()
        {
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            btnToday = new Button();
            btnClose = new Button();
            dgvResults = new DataGridView();
            lblSummary = new Label();
            panelControls = new Panel();
            panelResults = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panelControls.SuspendLayout();
            panelResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblReportType
            // 
            lblReportType.ForeColor = SystemColors.Window;
            lblReportType.Location = new Point(18, 15);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(88, 19);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type:";
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Location = new Point(114, 15);
            cmbReportType.Margin = new Padding(3, 2, 3, 2);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(176, 23);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.ForeColor = SystemColors.Window;
            lblStartDate.Location = new Point(18, 45);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(88, 19);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(114, 45);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(132, 23);
            dtpStartDate.TabIndex = 3;
            dtpStartDate.Value = new DateTime(2025, 10, 20, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            lblEndDate.ForeColor = SystemColors.Window;
            lblEndDate.Location = new Point(262, 45);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(88, 19);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(359, 45);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(132, 23);
            dtpEndDate.TabIndex = 5;
            dtpEndDate.Value = new DateTime(2025, 10, 20, 0, 0, 0, 0);
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.White;
            btnGenerateReport.Location = new Point(508, 15);
            btnGenerateReport.Margin = new Padding(3, 2, 3, 2);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(105, 30);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.FromArgb(59, 130, 246);
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.ForeColor = Color.White;
            btnToday.Location = new Point(630, 15);
            btnToday.Margin = new Padding(3, 2, 3, 2);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(70, 30);
            btnToday.TabIndex = 7;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Location = new Point(718, 15);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(70, 30);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.Location = new Point(18, 128);
            dgvResults.Margin = new Padding(3, 2, 3, 2);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(700, 247);
            dgvResults.TabIndex = 1;
            // 
            // lblSummary
            // 
            lblSummary.BackColor = Color.White;
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblSummary.Location = new Point(18, 15);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(700, 100);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Select a report type and click 'Generate Report'";
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(30, 41, 59);
            panelControls.Controls.Add(lblReportType);
            panelControls.Controls.Add(cmbReportType);
            panelControls.Controls.Add(lblStartDate);
            panelControls.Controls.Add(dtpStartDate);
            panelControls.Controls.Add(lblEndDate);
            panelControls.Controls.Add(dtpEndDate);
            panelControls.Controls.Add(btnGenerateReport);
            panelControls.Controls.Add(btnToday);
            panelControls.Controls.Add(btnClose);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(3, 2, 3, 2);
            panelControls.Name = "panelControls";
            panelControls.Padding = new Padding(18, 15, 18, 15);
            panelControls.Size = new Size(1050, 90);
            panelControls.TabIndex = 1;
            // 
            // panelResults
            // 
            panelResults.BackColor = Color.FromArgb(51, 65, 85);
            panelResults.Controls.Add(lblSummary);
            panelResults.Controls.Add(dgvResults);
            panelResults.Dock = DockStyle.Fill;
            panelResults.Location = new Point(0, 90);
            panelResults.Margin = new Padding(3, 2, 3, 2);
            panelResults.Name = "panelResults";
            panelResults.Padding = new Padding(18, 15, 18, 15);
            panelResults.Size = new Size(1050, 435);
            panelResults.TabIndex = 0;
            panelResults.Paint += panelResults_Paint;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 525);
            Controls.Add(panelResults);
            Controls.Add(panelControls);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports & Analytics";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panelControls.ResumeLayout(false);
            panelResults.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
