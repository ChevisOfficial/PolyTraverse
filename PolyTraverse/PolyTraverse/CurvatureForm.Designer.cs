namespace PolyTraverse
{
    partial class CurvatureForm
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
            this.First = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SetCurvature = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.Third = new System.Windows.Forms.TextBox();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(123, 11);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(163, 20);
            this.First.TabIndex = 9;
            this.First.Text = "8";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstLabel.Location = new System.Drawing.Point(12, 9);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(85, 20);
            this.FirstLabel.TabIndex = 8;
            this.FirstLabel.Text = "I (n < L/t) t:";
            // 
            // SetCurvature
            // 
            this.SetCurvature.Location = new System.Drawing.Point(161, 89);
            this.SetCurvature.Name = "SetCurvature";
            this.SetCurvature.Size = new System.Drawing.Size(125, 22);
            this.SetCurvature.TabIndex = 7;
            this.SetCurvature.Text = "Задать";
            this.SetCurvature.UseVisualStyleBackColor = true;
            this.SetCurvature.Click += new System.EventHandler(this.SetCurvature_Click);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(123, 37);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(163, 20);
            this.Second.TabIndex = 11;
            this.Second.Text = "24";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLabel.Location = new System.Drawing.Point(12, 35);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(81, 20);
            this.SecondLabel.TabIndex = 10;
            this.SecondLabel.Text = "II (r < α) α:";
            // 
            // Third
            // 
            this.Third.Location = new System.Drawing.Point(123, 63);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(163, 20);
            this.Third.TabIndex = 13;
            this.Third.Text = "1,3";
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.AutoSize = true;
            this.ThirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdLabel.Location = new System.Drawing.Point(12, 61);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Size = new System.Drawing.Size(105, 20);
            this.ThirdLabel.TabIndex = 12;
            this.ThirdLabel.Text = "III ([S]/L < t) t:";
            // 
            // CurvatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 118);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.ThirdLabel);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.First);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.SetCurvature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurvatureForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Критерии вытянутости хода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Button SetCurvature;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label ThirdLabel;
        public System.Windows.Forms.TextBox First;
        public System.Windows.Forms.TextBox Second;
        public System.Windows.Forms.TextBox Third;
    }
}