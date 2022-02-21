namespace PolyTraverse
{
    partial class AccuracyToolForm
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
            this.SetAccuracy = new System.Windows.Forms.Button();
            this.AccuracyAngleLabel = new System.Windows.Forms.Label();
            this.AccuracyAngle = new System.Windows.Forms.TextBox();
            this.AccuracyLengthFirst = new System.Windows.Forms.TextBox();
            this.AccuracyLengthLabel = new System.Windows.Forms.Label();
            this.AccuracyLengthSecond = new System.Windows.Forms.TextBox();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetAccuracy
            // 
            this.SetAccuracy.Location = new System.Drawing.Point(161, 63);
            this.SetAccuracy.Name = "SetAccuracy";
            this.SetAccuracy.Size = new System.Drawing.Size(125, 22);
            this.SetAccuracy.TabIndex = 0;
            this.SetAccuracy.Text = "Задать";
            this.SetAccuracy.UseVisualStyleBackColor = true;
            this.SetAccuracy.Click += new System.EventHandler(this.SetAccuracy_Click);
            // 
            // AccuracyAngleLabel
            // 
            this.AccuracyAngleLabel.AutoSize = true;
            this.AccuracyAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuracyAngleLabel.Location = new System.Drawing.Point(12, 9);
            this.AccuracyAngleLabel.Name = "AccuracyAngleLabel";
            this.AccuracyAngleLabel.Size = new System.Drawing.Size(35, 20);
            this.AccuracyAngleLabel.TabIndex = 1;
            this.AccuracyAngleLabel.Text = "mβ:";
            // 
            // AccuracyAngle
            // 
            this.AccuracyAngle.Location = new System.Drawing.Point(53, 11);
            this.AccuracyAngle.Name = "AccuracyAngle";
            this.AccuracyAngle.Size = new System.Drawing.Size(233, 20);
            this.AccuracyAngle.TabIndex = 2;
            this.AccuracyAngle.Text = "5";
            // 
            // AccuracyLengthFirst
            // 
            this.AccuracyLengthFirst.Location = new System.Drawing.Point(53, 37);
            this.AccuracyLengthFirst.Name = "AccuracyLengthFirst";
            this.AccuracyLengthFirst.Size = new System.Drawing.Size(92, 20);
            this.AccuracyLengthFirst.TabIndex = 4;
            this.AccuracyLengthFirst.Text = "1";
            // 
            // AccuracyLengthLabel
            // 
            this.AccuracyLengthLabel.AutoSize = true;
            this.AccuracyLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccuracyLengthLabel.Location = new System.Drawing.Point(12, 35);
            this.AccuracyLengthLabel.Name = "AccuracyLengthLabel";
            this.AccuracyLengthLabel.Size = new System.Drawing.Size(34, 20);
            this.AccuracyLengthLabel.TabIndex = 3;
            this.AccuracyLengthLabel.Text = "ms:";
            // 
            // AccuracyLengthSecond
            // 
            this.AccuracyLengthSecond.Location = new System.Drawing.Point(194, 37);
            this.AccuracyLengthSecond.Name = "AccuracyLengthSecond";
            this.AccuracyLengthSecond.Size = new System.Drawing.Size(92, 20);
            this.AccuracyLengthSecond.TabIndex = 5;
            this.AccuracyLengthSecond.Text = "1";
            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusLabel.Location = new System.Drawing.Point(160, 37);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(18, 20);
            this.PlusLabel.TabIndex = 6;
            this.PlusLabel.Text = "+";
            // 
            // AccuracyToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 94);
            this.Controls.Add(this.PlusLabel);
            this.Controls.Add(this.AccuracyLengthSecond);
            this.Controls.Add(this.AccuracyLengthFirst);
            this.Controls.Add(this.AccuracyLengthLabel);
            this.Controls.Add(this.AccuracyAngle);
            this.Controls.Add(this.AccuracyAngleLabel);
            this.Controls.Add(this.SetAccuracy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccuracyToolForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Точность инструмента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetAccuracy;
        private System.Windows.Forms.Label AccuracyAngleLabel;
        private System.Windows.Forms.Label AccuracyLengthLabel;
        private System.Windows.Forms.Label PlusLabel;
        public System.Windows.Forms.TextBox AccuracyAngle;
        public System.Windows.Forms.TextBox AccuracyLengthFirst;
        public System.Windows.Forms.TextBox AccuracyLengthSecond;
    }
}