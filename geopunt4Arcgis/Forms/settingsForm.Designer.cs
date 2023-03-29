namespace geopunt4Arcgis
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.timeoutLbl = new System.Windows.Forms.Label();
            this.timeOutnum = new System.Windows.Forms.NumericUpDown();
            this.maxRowsLbl = new System.Windows.Forms.Label();
            this.maxRowCsvNum = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRowCsvNum)).BeginInit();
            this.SuspendLayout();
            // 
            // timeoutLbl
            // 
            this.timeoutLbl.AutoSize = true;
            this.timeoutLbl.Location = new System.Drawing.Point(9, 7);
            this.timeoutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeoutLbl.Name = "timeoutLbl";
            this.timeoutLbl.Size = new System.Drawing.Size(218, 13);
            this.timeoutLbl.TabIndex = 0;
            this.timeoutLbl.Text = "Timeout voor internetconnecties (seconden):";
            // 
            // timeOutnum
            // 
            this.timeOutnum.Location = new System.Drawing.Point(128, 27);
            this.timeOutnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeOutnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeOutnum.Name = "timeOutnum";
            this.timeOutnum.Size = new System.Drawing.Size(97, 20);
            this.timeOutnum.TabIndex = 1;
            this.timeOutnum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // maxRowsLbl
            // 
            this.maxRowsLbl.AutoSize = true;
            this.maxRowsLbl.Location = new System.Drawing.Point(9, 61);
            this.maxRowsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxRowsLbl.Name = "maxRowsLbl";
            this.maxRowsLbl.Size = new System.Drawing.Size(214, 13);
            this.maxRowsLbl.TabIndex = 2;
            this.maxRowsLbl.Text = "Maximaal aantal rijen voor csv geocodering:";
            // 
            // maxRowCsvNum
            // 
            this.maxRowCsvNum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.maxRowCsvNum.Location = new System.Drawing.Point(128, 85);
            this.maxRowCsvNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxRowCsvNum.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.maxRowCsvNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxRowCsvNum.Name = "maxRowCsvNum";
            this.maxRowCsvNum.Size = new System.Drawing.Size(97, 20);
            this.maxRowCsvNum.TabIndex = 3;
            this.maxRowCsvNum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(144, 119);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(74, 28);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Opslaan";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(55, 119);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 28);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Annuleer";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // settingsForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(228, 163);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.maxRowCsvNum);
            this.Controls.Add(this.maxRowsLbl);
            this.Controls.Add(this.timeOutnum);
            this.Controls.Add(this.timeoutLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 202);
            this.MinimumSize = new System.Drawing.Size(244, 202);
            this.Name = "settingsForm";
            this.Text = "Instellingen";
            ((System.ComponentModel.ISupportInitialize)(this.timeOutnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRowCsvNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeoutLbl;
        private System.Windows.Forms.NumericUpDown timeOutnum;
        private System.Windows.Forms.Label maxRowsLbl;
        private System.Windows.Forms.NumericUpDown maxRowCsvNum;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}