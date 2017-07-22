namespace SimpleParser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelStartId = new System.Windows.Forms.Label();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.Abort = new System.Windows.Forms.Button();
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgressStatus = new System.Windows.Forms.Label();
            this.labelBaseUrl = new System.Windows.Forms.Label();
            this.textBaseUrl = new System.Windows.Forms.TextBox();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.labelEndId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelStartId
            // 
            this.LabelStartId.AutoSize = true;
            this.LabelStartId.Location = new System.Drawing.Point(8, 9);
            this.LabelStartId.Name = "LabelStartId";
            this.LabelStartId.Size = new System.Drawing.Size(71, 13);
            this.LabelStartId.TabIndex = 1;
            this.LabelStartId.Tag = " ";
            this.LabelStartId.Text = "Start Page ID";
            // 
            // NumericStart
            // 
            this.NumericStart.Location = new System.Drawing.Point(12, 25);
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(74, 20);
            this.NumericStart.TabIndex = 2;
            this.NumericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(11, 269);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // NumericEnd
            // 
            this.NumericEnd.Location = new System.Drawing.Point(12, 72);
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(75, 20);
            this.NumericEnd.TabIndex = 5;
            this.NumericEnd.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(11, 298);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(75, 23);
            this.Abort.TabIndex = 6;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // ListTitles
            // 
            this.ListTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(0, 0);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(540, 357);
            this.ListTitles.TabIndex = 7;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.labelEndId);
            this.panelSettings.Controls.Add(this.textPrefix);
            this.panelSettings.Controls.Add(this.labelPrefix);
            this.panelSettings.Controls.Add(this.textBaseUrl);
            this.panelSettings.Controls.Add(this.labelBaseUrl);
            this.panelSettings.Controls.Add(this.LabelStartId);
            this.panelSettings.Controls.Add(this.Abort);
            this.panelSettings.Controls.Add(this.NumericStart);
            this.panelSettings.Controls.Add(this.NumericEnd);
            this.panelSettings.Controls.Add(this.Start);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSettings.Location = new System.Drawing.Point(324, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(216, 327);
            this.panelSettings.TabIndex = 8;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelProgressStatus);
            this.panelStatus.Controls.Add(this.progressBar);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 327);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(540, 30);
            this.panelStatus.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(145, 23);
            this.progressBar.TabIndex = 0;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // labelProgressStatus
            // 
            this.labelProgressStatus.AutoSize = true;
            this.labelProgressStatus.Location = new System.Drawing.Point(145, 8);
            this.labelProgressStatus.Name = "labelProgressStatus";
            this.labelProgressStatus.Size = new System.Drawing.Size(0, 13);
            this.labelProgressStatus.TabIndex = 2;
            this.labelProgressStatus.Tag = " ";
            // 
            // labelBaseUrl
            // 
            this.labelBaseUrl.AutoSize = true;
            this.labelBaseUrl.Location = new System.Drawing.Point(9, 105);
            this.labelBaseUrl.Name = "labelBaseUrl";
            this.labelBaseUrl.Size = new System.Drawing.Size(56, 13);
            this.labelBaseUrl.TabIndex = 7;
            this.labelBaseUrl.Text = "Base URL";
            // 
            // textBaseUrl
            // 
            this.textBaseUrl.Location = new System.Drawing.Point(12, 121);
            this.textBaseUrl.Name = "textBaseUrl";
            this.textBaseUrl.Size = new System.Drawing.Size(123, 20);
            this.textBaseUrl.TabIndex = 8;
            this.textBaseUrl.Text = "http://habrahabr.ru";
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(9, 156);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(33, 13);
            this.labelPrefix.TabIndex = 9;
            this.labelPrefix.Text = "Prefix";
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(12, 172);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(123, 20);
            this.textPrefix.TabIndex = 10;
            this.textPrefix.Text = "page{CurrentId}";
            // 
            // labelEndId
            // 
            this.labelEndId.AutoSize = true;
            this.labelEndId.Location = new System.Drawing.Point(9, 56);
            this.labelEndId.Name = "labelEndId";
            this.labelEndId.Size = new System.Drawing.Size(68, 13);
            this.labelEndId.TabIndex = 11;
            this.labelEndId.Tag = " ";
            this.labelEndId.Text = "End Page ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.ListTitles);
            this.Name = "MainForm";
            this.Text = "Simple Parser";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelStartId;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelProgressStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox textBaseUrl;
        private System.Windows.Forms.Label labelBaseUrl;
        private System.Windows.Forms.Label labelEndId;
    }
}

