namespace MatrixPOS.Forms
{
    partial class FormOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.BtnNewBill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.TextBox();
            this.DiscTxt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalUnits = new System.Windows.Forms.TextBox();
            this.SizeX = new System.Windows.Forms.TextBox();
            this.RateTxt = new System.Windows.Forms.NumericUpDown();
            this.UnitTxt = new System.Windows.Forms.ComboBox();
            this.DescriptionTxtOpt = new System.Windows.Forms.TextBox();
            this.QtyNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.RatePerLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeY = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteRowBtn.BackColor = System.Drawing.Color.White;
            this.DeleteRowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRowBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteRowBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteRowBtn.Location = new System.Drawing.Point(1157, 560);
            this.DeleteRowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(35, 32);
            this.DeleteRowBtn.TabIndex = 8;
            this.DeleteRowBtn.UseVisualStyleBackColor = false;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.Location = new System.Drawing.Point(13, 190);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 25;
            this.dataGridViewMain.Size = new System.Drawing.Size(1179, 345);
            this.dataGridViewMain.TabIndex = 10;
            // 
            // BtnNewBill
            // 
            this.BtnNewBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNewBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(110)))), ((int)(((byte)(251)))));
            this.BtnNewBill.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.BtnNewBill.ForeColor = System.Drawing.Color.White;
            this.BtnNewBill.Location = new System.Drawing.Point(13, 9);
            this.BtnNewBill.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewBill.Name = "BtnNewBill";
            this.BtnNewBill.Size = new System.Drawing.Size(223, 65);
            this.BtnNewBill.TabIndex = 9;
            this.BtnNewBill.Text = "نیا بل";
            this.BtnNewBill.UseVisualStyleBackColor = false;
            this.BtnNewBill.Click += new System.EventHandler(this.BtnNewBill_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label8.Location = new System.Drawing.Point(780, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 41);
            this.label8.TabIndex = 31;
            this.label8.Text = "لمبائی";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.label2.Location = new System.Drawing.Point(743, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "x";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(219)))), ((int)(((byte)(92)))));
            this.AddBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(13, 118);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(192, 65);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "اندراج";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.ClearBtn.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(969, 9);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(223, 65);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "مٹائیں";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label4.Location = new System.Drawing.Point(261, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 41);
            this.label4.TabIndex = 17;
            this.label4.Text = "ٹوٹل";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalTxt.Enabled = false;
            this.TotalTxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalTxt.Location = new System.Drawing.Point(213, 127);
            this.TotalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(144, 46);
            this.TotalTxt.TabIndex = 27;
            // 
            // DiscTxt
            // 
            this.DiscTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DiscTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.DiscTxt.Location = new System.Drawing.Point(365, 127);
            this.DiscTxt.Margin = new System.Windows.Forms.Padding(4);
            this.DiscTxt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DiscTxt.Name = "DiscTxt";
            this.DiscTxt.Size = new System.Drawing.Size(79, 46);
            this.DiscTxt.TabIndex = 6;
            this.DiscTxt.ValueChanged += new System.EventHandler(this.DiscTxt_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label3.Location = new System.Drawing.Point(375, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 41);
            this.label3.TabIndex = 19;
            this.label3.Text = "ڈسکاؤنٹ";
            // 
            // TotalUnits
            // 
            this.TotalUnits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalUnits.Enabled = false;
            this.TotalUnits.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.TotalUnits.Location = new System.Drawing.Point(565, 127);
            this.TotalUnits.Margin = new System.Windows.Forms.Padding(4);
            this.TotalUnits.Name = "TotalUnits";
            this.TotalUnits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalUnits.Size = new System.Drawing.Size(101, 46);
            this.TotalUnits.TabIndex = 29;
            // 
            // SizeX
            // 
            this.SizeX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SizeX.Enabled = false;
            this.SizeX.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.SizeX.Location = new System.Drawing.Point(674, 127);
            this.SizeX.Margin = new System.Windows.Forms.Padding(4);
            this.SizeX.Name = "SizeX";
            this.SizeX.Size = new System.Drawing.Size(64, 46);
            this.SizeX.TabIndex = 26;
            // 
            // RateTxt
            // 
            this.RateTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RateTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.RateTxt.Location = new System.Drawing.Point(450, 127);
            this.RateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.RateTxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.RateTxt.Name = "RateTxt";
            this.RateTxt.Size = new System.Drawing.Size(108, 46);
            this.RateTxt.TabIndex = 5;
            this.RateTxt.ValueChanged += new System.EventHandler(this.RateTxt_ValueChanged);
            // 
            // UnitTxt
            // 
            this.UnitTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitTxt.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14F, System.Drawing.FontStyle.Bold);
            this.UnitTxt.FormattingEnabled = true;
            this.UnitTxt.ItemHeight = 39;
            this.UnitTxt.Items.AddRange(new object[] {
            "میٹر",
            "گز"});
            this.UnitTxt.Location = new System.Drawing.Point(1026, 127);
            this.UnitTxt.Margin = new System.Windows.Forms.Padding(4);
            this.UnitTxt.Name = "UnitTxt";
            this.UnitTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UnitTxt.Size = new System.Drawing.Size(79, 47);
            this.UnitTxt.TabIndex = 2;
            this.UnitTxt.SelectedIndexChanged += new System.EventHandler(this.UnitTxt_SelectedIndexChanged);
            this.UnitTxt.VisibleChanged += new System.EventHandler(this.SizeY_ValueChanged);
            // 
            // DescriptionTxtOpt
            // 
            this.DescriptionTxtOpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionTxtOpt.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.DescriptionTxtOpt.Location = new System.Drawing.Point(849, 127);
            this.DescriptionTxtOpt.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTxtOpt.Multiline = true;
            this.DescriptionTxtOpt.Name = "DescriptionTxtOpt";
            this.DescriptionTxtOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DescriptionTxtOpt.Size = new System.Drawing.Size(167, 46);
            this.DescriptionTxtOpt.TabIndex = 3;
            // 
            // QtyNum
            // 
            this.QtyNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QtyNum.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.QtyNum.Location = new System.Drawing.Point(1113, 127);
            this.QtyNum.Margin = new System.Windows.Forms.Padding(4);
            this.QtyNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QtyNum.Name = "QtyNum";
            this.QtyNum.Size = new System.Drawing.Size(79, 46);
            this.QtyNum.TabIndex = 1;
            this.QtyNum.ValueChanged += new System.EventHandler(this.QtyNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label1.Location = new System.Drawing.Point(1135, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "تعداد";
            // 
            // RatePerLbl
            // 
            this.RatePerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RatePerLbl.AutoSize = true;
            this.RatePerLbl.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.RatePerLbl.Location = new System.Drawing.Point(475, 79);
            this.RatePerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatePerLbl.Name = "RatePerLbl";
            this.RatePerLbl.Size = new System.Drawing.Size(87, 41);
            this.RatePerLbl.TabIndex = 16;
            this.RatePerLbl.Text = "ریٹ فی میٹر";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label7.Location = new System.Drawing.Point(1045, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 41);
            this.label7.TabIndex = 15;
            this.label7.Text = "یونٹ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label5.Location = new System.Drawing.Point(594, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 41);
            this.label5.TabIndex = 20;
            this.label5.Text = "صافی";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 14.25F);
            this.label6.Location = new System.Drawing.Point(913, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 41);
            this.label6.TabIndex = 14;
            this.label6.Text = "تفصیل";
            // 
            // SizeY
            // 
            this.SizeY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SizeY.Font = new System.Drawing.Font("Arial Narrow", 20.25F);
            this.SizeY.Location = new System.Drawing.Point(762, 128);
            this.SizeY.Margin = new System.Windows.Forms.Padding(4);
            this.SizeY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeY.Name = "SizeY";
            this.SizeY.Size = new System.Drawing.Size(79, 46);
            this.SizeY.TabIndex = 4;
            this.SizeY.ValueChanged += new System.EventHandler(this.SizeY_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(156)))));
            this.btnSave.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(13, 539);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 63);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "محفوظ کریں";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 610);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.SizeY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.DiscTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalUnits);
            this.Controls.Add(this.SizeX);
            this.Controls.Add(this.RateTxt);
            this.Controls.Add(this.UnitTxt);
            this.Controls.Add(this.DescriptionTxtOpt);
            this.Controls.Add(this.QtyNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RatePerLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.BtnNewBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrders";
            this.Text = "آرڈر";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button BtnNewBill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalTxt;
        private System.Windows.Forms.NumericUpDown DiscTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalUnits;
        private System.Windows.Forms.TextBox SizeX;
        private System.Windows.Forms.NumericUpDown RateTxt;
        private System.Windows.Forms.ComboBox UnitTxt;
        private System.Windows.Forms.TextBox DescriptionTxtOpt;
        private System.Windows.Forms.NumericUpDown QtyNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RatePerLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SizeY;
        private System.Windows.Forms.Button btnSave;
    }
}