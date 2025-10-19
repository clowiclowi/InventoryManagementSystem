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
            this.lblReportType = new Label();
            this.cmbReportType = new ComboBox();
            this.lblStartDate = new Label();
            this.dtpStartDate = new DateTimePicker();
            this.lblEndDate = new Label();
            this.dtpEndDate = new DateTimePicker();
            this.btnGenerateReport = new Button();
            this.btnToday = new Button();
            this.btnClose = new Button();
            this.dgvResults = new DataGridView();
            this.lblSummary = new Label();
            this.panelControls = new Panel();
            this.panelResults = new Panel();
            this.panelControls.SuspendLayout();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // ReportsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Text = "Reports & Analytics";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Panel Controls
            this.panelControls.Dock = DockStyle.Top;
            this.panelControls.Height = 120;
            this.panelControls.BackColor = System.Drawing.Color.LightBlue;
            this.panelControls.Padding = new Padding(20);

            // Report type
            this.lblReportType.Text = "Report Type:";
            this.lblReportType.Location = new System.Drawing.Point(20, 20);
            this.lblReportType.Size = new System.Drawing.Size(100, 25);

            this.cmbReportType.Location = new System.Drawing.Point(130, 20);
            this.cmbReportType.Size = new System.Drawing.Size(200, 25);
            this.cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbReportType.SelectedIndexChanged += new EventHandler(this.cmbReportType_SelectedIndexChanged);

            // Date range
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.Location = new System.Drawing.Point(20, 60);
            this.lblStartDate.Size = new System.Drawing.Size(100, 25);

            this.dtpStartDate.Location = new System.Drawing.Point(130, 60);
            this.dtpStartDate.Size = new System.Drawing.Size(150, 25);
            this.dtpStartDate.Value = DateTime.Today;

            this.lblEndDate.Text = "End Date:";
            this.lblEndDate.Location = new System.Drawing.Point(300, 60);
            this.lblEndDate.Size = new System.Drawing.Size(100, 25);

            this.dtpEndDate.Location = new System.Drawing.Point(410, 60);
            this.dtpEndDate.Size = new System.Drawing.Size(150, 25);
            this.dtpEndDate.Value = DateTime.Today;

            // Buttons
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Location = new System.Drawing.Point(580, 20);
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 40);
            this.btnGenerateReport.Click += new EventHandler(this.btnGenerateReport_Click);

            this.btnToday.Text = "Today";
            this.btnToday.Location = new System.Drawing.Point(720, 20);
            this.btnToday.Size = new System.Drawing.Size(80, 40);
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.FlatStyle = FlatStyle.Flat;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.Click += new EventHandler(this.btnToday_Click);

            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(820, 20);
            this.btnClose.Size = new System.Drawing.Size(80, 40);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Panel Results
            this.panelResults.Dock = DockStyle.Fill;
            this.panelResults.BackColor = System.Drawing.Color.LightGray;
            this.panelResults.Padding = new Padding(20);

            // Summary label
            this.lblSummary.Text = "Select a report type and click 'Generate Report'";
            this.lblSummary.Location = new System.Drawing.Point(20, 20);
            this.lblSummary.Size = new System.Drawing.Size(800, 60);
            this.lblSummary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummary.BackColor = System.Drawing.Color.White;
            this.lblSummary.BorderStyle = BorderStyle.FixedSingle;

            // Results grid
            this.dgvResults.Location = new System.Drawing.Point(20, 100);
            this.dgvResults.Size = new System.Drawing.Size(800, 400);
            this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ReadOnly = true;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add controls to panels
            this.panelControls.Controls.Add(this.lblReportType);
            this.panelControls.Controls.Add(this.cmbReportType);
            this.panelControls.Controls.Add(this.lblStartDate);
            this.panelControls.Controls.Add(this.dtpStartDate);
            this.panelControls.Controls.Add(this.lblEndDate);
            this.panelControls.Controls.Add(this.dtpEndDate);
            this.panelControls.Controls.Add(this.btnGenerateReport);
            this.panelControls.Controls.Add(this.btnToday);
            this.panelControls.Controls.Add(this.btnClose);

            this.panelResults.Controls.Add(this.lblSummary);
            this.panelResults.Controls.Add(this.dgvResults);

            // Add panels to form
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelControls);

            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
