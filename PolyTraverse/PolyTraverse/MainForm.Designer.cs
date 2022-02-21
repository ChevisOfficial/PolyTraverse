namespace PolyTraverse
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
            this.Coordinates = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.OptionMenu = new System.Windows.Forms.MenuStrip();
            this.Data = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenData = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.Calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTraverse = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Curvature = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveReport = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Splitter = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.Coordinates)).BeginInit();
            this.OptionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coordinates
            // 
            this.Coordinates.AllowUserToOrderColumns = true;
            this.Coordinates.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Coordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Coordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.Coordinates.Dock = System.Windows.Forms.DockStyle.Top;
            this.Coordinates.Location = new System.Drawing.Point(0, 24);
            this.Coordinates.Name = "Coordinates";
            this.Coordinates.Size = new System.Drawing.Size(818, 231);
            this.Coordinates.TabIndex = 0;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Output
            // 
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.Location = new System.Drawing.Point(0, 258);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(818, 209);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // OptionMenu
            // 
            this.OptionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Data,
            this.Calculate,
            this.RefreshTraverse,
            this.Tool,
            this.Curvature,
            this.Report,
            this.About});
            this.OptionMenu.Location = new System.Drawing.Point(0, 0);
            this.OptionMenu.Name = "OptionMenu";
            this.OptionMenu.Size = new System.Drawing.Size(818, 24);
            this.OptionMenu.TabIndex = 2;
            this.OptionMenu.Text = "menuStrip1";
            // 
            // Data
            // 
            this.Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenData,
            this.SaveData});
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(62, 20);
            this.Data.Text = "Данные";
            // 
            // OpenData
            // 
            this.OpenData.Name = "OpenData";
            this.OpenData.Size = new System.Drawing.Size(133, 22);
            this.OpenData.Text = "Открыть";
            this.OpenData.Click += new System.EventHandler(this.OpenData_Click);
            // 
            // SaveData
            // 
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(133, 22);
            this.SaveData.Text = "Сохранить";
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // Calculate
            // 
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(80, 20);
            this.Calculate.Text = "Рассчитать";
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // RefreshTraverse
            // 
            this.RefreshTraverse.Name = "RefreshTraverse";
            this.RefreshTraverse.Size = new System.Drawing.Size(73, 20);
            this.RefreshTraverse.Text = "Обновить";
            this.RefreshTraverse.Click += new System.EventHandler(this.RefreshTraverse_Click);
            // 
            // Tool
            // 
            this.Tool.Name = "Tool";
            this.Tool.Size = new System.Drawing.Size(86, 20);
            this.Tool.Text = "Инструмент";
            this.Tool.Click += new System.EventHandler(this.Tool_Click);
            // 
            // Curvature
            // 
            this.Curvature.Name = "Curvature";
            this.Curvature.Size = new System.Drawing.Size(88, 20);
            this.Curvature.Text = "Вытянутость";
            this.Curvature.Click += new System.EventHandler(this.Curvature_Click);
            // 
            // Report
            // 
            this.Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveReport});
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(51, 20);
            this.Report.Text = "Отчёт";
            // 
            // SaveReport
            // 
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(180, 22);
            this.SaveReport.Text = "Сохранить";
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(102, 20);
            this.About.Text = "О приложении";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Splitter
            // 
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter.Location = new System.Drawing.Point(0, 255);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(818, 3);
            this.Splitter.TabIndex = 3;
            this.Splitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 467);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.Coordinates);
            this.Controls.Add(this.OptionMenu);
            this.MainMenuStrip = this.OptionMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт полигонометрического хода";
            ((System.ComponentModel.ISupportInitialize)(this.Coordinates)).EndInit();
            this.OptionMenu.ResumeLayout(false);
            this.OptionMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.MenuStrip OptionMenu;
        private System.Windows.Forms.ToolStripMenuItem Calculate;
        private System.Windows.Forms.ToolStripMenuItem Tool;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.ToolStripMenuItem Curvature;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Report;
        private System.Windows.Forms.ToolStripMenuItem SaveReport;
        private System.Windows.Forms.ToolStripMenuItem Data;
        private System.Windows.Forms.ToolStripMenuItem OpenData;
        private System.Windows.Forms.ToolStripMenuItem SaveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        public System.Windows.Forms.DataGridView Coordinates;
        private System.Windows.Forms.ToolStripMenuItem RefreshTraverse;
    }
}

