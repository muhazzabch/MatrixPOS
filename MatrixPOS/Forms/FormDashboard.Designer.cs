namespace MatrixPOS.Forms
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTodaysOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelTop3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl7DaysSale = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panelTop4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTodaysSale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.panelTop1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl7DaysOrders = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelTop2.SuspendLayout();
            this.panelTop3.SuspendLayout();
            this.panelTop4.SuspendLayout();
            this.panelTop1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.LabelStyle.Format = "PKR(0)";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 137);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerSize = 8;
            series1.Name = "سیلز";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1171, 457);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // panelTop2
            // 
            this.panelTop2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(156)))));
            this.panelTop2.Controls.Add(this.label9);
            this.panelTop2.Controls.Add(this.lblTodaysOrders);
            this.panelTop2.Controls.Add(this.label6);
            this.panelTop2.Controls.Add(this.iconButton2);
            this.panelTop2.Location = new System.Drawing.Point(327, 16);
            this.panelTop2.Name = "panelTop2";
            this.panelTop2.Size = new System.Drawing.Size(270, 100);
            this.panelTop2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "آج";
            // 
            // lblTodaysOrders
            // 
            this.lblTodaysOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodaysOrders.AutoSize = true;
            this.lblTodaysOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysOrders.ForeColor = System.Drawing.Color.White;
            this.lblTodaysOrders.Location = new System.Drawing.Point(145, 53);
            this.lblTodaysOrders.Name = "lblTodaysOrders";
            this.lblTodaysOrders.Size = new System.Drawing.Size(132, 20);
            this.lblTodaysOrders.TabIndex = 17;
            this.lblTodaysOrders.Text = "Today\'sOrders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "آرڈر موصول";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(30, 43);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 40);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panelTop3
            // 
            this.panelTop3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.panelTop3.Controls.Add(this.label7);
            this.panelTop3.Controls.Add(this.lbl7DaysSale);
            this.panelTop3.Controls.Add(this.label8);
            this.panelTop3.Controls.Add(this.iconButton5);
            this.panelTop3.Location = new System.Drawing.Point(617, 16);
            this.panelTop3.Name = "panelTop3";
            this.panelTop3.Size = new System.Drawing.Size(270, 100);
            this.panelTop3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "گزشتہ 7 دن";
            // 
            // lbl7DaysSale
            // 
            this.lbl7DaysSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl7DaysSale.AutoSize = true;
            this.lbl7DaysSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7DaysSale.ForeColor = System.Drawing.Color.White;
            this.lbl7DaysSale.Location = new System.Drawing.Point(140, 53);
            this.lbl7DaysSale.Name = "lbl7DaysSale";
            this.lbl7DaysSale.Size = new System.Drawing.Size(99, 20);
            this.lbl7DaysSale.TabIndex = 16;
            this.lbl7DaysSale.Text = "7DaysSale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(234, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 46);
            this.label8.TabIndex = 14;
            this.label8.Text = "سیلز";
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(30, 43);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(44, 40);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // panelTop4
            // 
            this.panelTop4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(131)))));
            this.panelTop4.Controls.Add(this.label5);
            this.panelTop4.Controls.Add(this.lblTodaysSale);
            this.panelTop4.Controls.Add(this.label4);
            this.panelTop4.Controls.Add(this.iconButton7);
            this.panelTop4.Location = new System.Drawing.Point(907, 16);
            this.panelTop4.Name = "panelTop4";
            this.panelTop4.Size = new System.Drawing.Size(270, 100);
            this.panelTop4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "آج";
            // 
            // lblTodaysSale
            // 
            this.lblTodaysSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTodaysSale.AutoSize = true;
            this.lblTodaysSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysSale.ForeColor = System.Drawing.Color.White;
            this.lblTodaysSale.Location = new System.Drawing.Point(140, 53);
            this.lblTodaysSale.Name = "lblTodaysSale";
            this.lblTodaysSale.Size = new System.Drawing.Size(111, 20);
            this.lblTodaysSale.TabIndex = 16;
            this.lblTodaysSale.Text = "Today\'sSale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(234, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "سیلز";
            // 
            // iconButton7
            // 
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(30, 43);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(44, 40);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // panelTop1
            // 
            this.panelTop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(110)))), ((int)(((byte)(251)))));
            this.panelTop1.Controls.Add(this.label10);
            this.panelTop1.Controls.Add(this.lbl7DaysOrders);
            this.panelTop1.Controls.Add(this.iconButton1);
            this.panelTop1.Controls.Add(this.label2);
            this.panelTop1.Controls.Add(this.label1);
            this.panelTop1.Location = new System.Drawing.Point(37, 16);
            this.panelTop1.Name = "panelTop1";
            this.panelTop1.Size = new System.Drawing.Size(270, 100);
            this.panelTop1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-1, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 34);
            this.label10.TabIndex = 18;
            this.label10.Text = "گزشتہ 7 دن";
            // 
            // lbl7DaysOrders
            // 
            this.lbl7DaysOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl7DaysOrders.AutoSize = true;
            this.lbl7DaysOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7DaysOrders.ForeColor = System.Drawing.Color.White;
            this.lbl7DaysOrders.Location = new System.Drawing.Point(145, 53);
            this.lbl7DaysOrders.Name = "lbl7DaysOrders";
            this.lbl7DaysOrders.Size = new System.Drawing.Size(120, 20);
            this.lbl7DaysOrders.TabIndex = 17;
            this.lbl7DaysOrders.Text = "7DaysOrders";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(30, 43);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 40);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "آرڈر موصول";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "گزشتہ 7 دنوں کی آمدنی";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelTop2);
            this.Controls.Add(this.panelTop3);
            this.Controls.Add(this.panelTop4);
            this.Controls.Add(this.panelTop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "ڈیش بورڈ";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.Resize += new System.EventHandler(this.FormDashboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelTop2.ResumeLayout(false);
            this.panelTop2.PerformLayout();
            this.panelTop3.ResumeLayout(false);
            this.panelTop3.PerformLayout();
            this.panelTop4.ResumeLayout(false);
            this.panelTop4.PerformLayout();
            this.panelTop1.ResumeLayout(false);
            this.panelTop1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelTop2;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Panel panelTop4;
        private System.Windows.Forms.Panel panelTop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl7DaysSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTodaysSale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTodaysOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl7DaysOrders;
    }
}