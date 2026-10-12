namespace BigONotationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tlpRoot = new TableLayoutPanel();
            pnlMain = new Panel();
            lstOutput = new ListBox();
            tlpTop = new TableLayoutPanel();
            lblTopic = new Label();
            lblExercise = new Label();
            cmbTopic = new ComboBox();
            cmbExercise = new ComboBox();
            lblInput = new Label();
            txtInput = new TextBox();
            btnRun = new Button();
            pnlInfo = new Panel();
            lblComplexity = new Label();
            tlpRoot.SuspendLayout();
            pnlMain.SuspendLayout();
            tlpTop.SuspendLayout();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpRoot
            // 
            tlpRoot.BackColor = Color.Transparent;
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpRoot.Controls.Add(pnlMain, 0, 0);
            tlpRoot.Controls.Add(pnlInfo, 1, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 2;
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 23.320158F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 76.67984F));
            tlpRoot.Size = new Size(1200, 506);
            tlpRoot.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(32, 32, 36);
            pnlMain.Controls.Add(lstOutput);
            pnlMain.Controls.Add(tlpTop);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(20, 20);
            pnlMain.Margin = new Padding(20, 20, 10, 20);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(15);
            tlpRoot.SetRowSpan(pnlMain, 2);
            pnlMain.Size = new Size(630, 466);
            pnlMain.TabIndex = 0;
            // 
            // lstOutput
            // 
            lstOutput.BackColor = Color.FromArgb(20, 20, 24);
            lstOutput.BorderStyle = BorderStyle.None;
            lstOutput.Dock = DockStyle.Fill;
            lstOutput.Font = new Font("Consolas", 11F);
            lstOutput.ForeColor = Color.Gainsboro;
            lstOutput.FormattingEnabled = true;
            lstOutput.HorizontalScrollbar = true;
            lstOutput.IntegralHeight = false;
            lstOutput.Location = new Point(15, 157);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(600, 294);
            lstOutput.TabIndex = 4;
            // 
            // tlpTop
            // 
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.Controls.Add(lblTopic, 0, 0);
            tlpTop.Controls.Add(lblExercise, 1, 0);
            tlpTop.Controls.Add(cmbTopic, 0, 1);
            tlpTop.Controls.Add(cmbExercise, 1, 1);
            tlpTop.Controls.Add(lblInput, 0, 2);
            tlpTop.Controls.Add(txtInput, 0, 3);
            tlpTop.Controls.Add(btnRun, 1, 3);
            tlpTop.Dock = DockStyle.Top;
            tlpTop.Location = new Point(15, 15);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 4;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tlpTop.Size = new Size(600, 142);
            tlpTop.TabIndex = 0;
            // 
            // lblTopic
            // 
            lblTopic.Dock = DockStyle.Fill;
            lblTopic.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTopic.ForeColor = Color.White;
            lblTopic.Location = new Point(3, 0);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(294, 28);
            lblTopic.TabIndex = 0;
            lblTopic.Text = "Select Big-O Topic:";
            lblTopic.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblExercise
            // 
            lblExercise.Dock = DockStyle.Fill;
            lblExercise.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblExercise.ForeColor = Color.White;
            lblExercise.Location = new Point(303, 0);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(294, 28);
            lblExercise.TabIndex = 1;
            lblExercise.Text = "Select Exercise:";
            lblExercise.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cmbTopic
            // 
            cmbTopic.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbTopic.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTopic.Font = new Font("Segoe UI", 11F);
            cmbTopic.FormattingEnabled = true;
            cmbTopic.Items.AddRange(new object[] { "O(1) - Constant Time", "O(n) - Linear Time", "O(log n) - Logarithmic Time", "O(n²) - Quadratic Time", "O(2^n) - Exponential Time" });
            cmbTopic.Location = new Point(3, 33);
            cmbTopic.Margin = new Padding(3, 3, 12, 3);
            cmbTopic.Name = "cmbTopic";
            cmbTopic.Size = new Size(285, 28);
            cmbTopic.TabIndex = 0;
            cmbTopic.SelectedIndexChanged += CmbTopic_SelectedIndexChanged;
            // 
            // cmbExercise
            // 
            cmbExercise.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExercise.Font = new Font("Segoe UI", 11F);
            cmbExercise.FormattingEnabled = true;
            cmbExercise.Location = new Point(303, 33);
            cmbExercise.Margin = new Padding(3, 3, 12, 3);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(285, 28);
            cmbExercise.TabIndex = 1;
            cmbExercise.SelectedIndexChanged += CmbExercise_SelectedIndexChanged;
            // 
            // lblInput
            // 
            lblInput.Dock = DockStyle.Fill;
            lblInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInput.ForeColor = Color.White;
            lblInput.Location = new Point(3, 66);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(294, 28);
            lblInput.TabIndex = 4;
            lblInput.Text = "Input N / Target Value:";
            lblInput.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Font = new Font("Segoe UI", 11F);
            txtInput.Location = new Point(3, 104);
            txtInput.Margin = new Padding(3, 3, 12, 3);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(285, 27);
            txtInput.TabIndex = 2;
            txtInput.Text = "5";
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRun.BackColor = Color.FromArgb(60, 60, 70);
            btnRun.FlatAppearance.BorderColor = Color.Gray;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRun.ForeColor = Color.White;
            btnRun.Location = new Point(303, 101);
            btnRun.Margin = new Padding(3, 3, 12, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(285, 34);
            btnRun.TabIndex = 3;
            btnRun.Text = "▶ RUN EXERCISE";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += BtnRun_Click;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(32, 32, 36);
            pnlInfo.Controls.Add(lblComplexity);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(670, 20);
            pnlInfo.Margin = new Padding(10, 20, 20, 10);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Padding = new Padding(15);
            pnlInfo.Size = new Size(510, 88);
            pnlInfo.TabIndex = 1;
            // 
            // lblComplexity
            // 
            lblComplexity.Dock = DockStyle.Fill;
            lblComplexity.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblComplexity.ForeColor = Color.White;
            lblComplexity.Location = new Point(15, 15);
            lblComplexity.Name = "lblComplexity";
            lblComplexity.Size = new Size(480, 58);
            lblComplexity.TabIndex = 0;
            lblComplexity.Text = "Complexity Info: O(1) - Constant Time (Executes instantly in 1 step)";
            lblComplexity.TextAlign = ContentAlignment.MiddleLeft;
            lblComplexity.Click += lblComplexity_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 506);
            Controls.Add(tlpRoot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Big-O Notation Visualizer - Data Structures & Algorithms";
            Load += Form1_Load;
            tlpRoot.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            tlpTop.ResumeLayout(false);
            tlpTop.PerformLayout();
            pnlInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpRoot;
        private Panel pnlMain;
        private TableLayoutPanel tlpTop;
        private Label lblTopic;
        private Label lblExercise;
        private ComboBox cmbTopic;
        private ComboBox cmbExercise;
        private Label lblInput;
        private TextBox txtInput;
        private Button btnRun;
        private ListBox lstOutput;
        private Panel pnlInfo;
        private Label lblComplexity;
    }
}