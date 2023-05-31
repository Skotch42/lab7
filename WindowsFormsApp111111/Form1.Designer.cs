namespace WindowsFormsApp111111
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SanctionsPresent = new System.Windows.Forms.CheckBox();
            this.QualityValue = new System.Windows.Forms.TrackBar();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbFixPeople = new System.Windows.Forms.Label();
            this.lbProbPeople = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.DifficultyValue = new System.Windows.Forms.NumericUpDown();
            this.SanctionsValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PopularValue = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanctionsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularValue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PopularValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.SanctionsPresent);
            this.panel1.Controls.Add(this.QualityValue);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbFixPeople);
            this.panel1.Controls.Add(this.lbProbPeople);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.DifficultyValue);
            this.panel1.Controls.Add(this.SanctionsValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 251);
            this.panel1.TabIndex = 0;
            // 
            // SanctionsPresent
            // 
            this.SanctionsPresent.AutoSize = true;
            this.SanctionsPresent.Checked = true;
            this.SanctionsPresent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SanctionsPresent.Location = new System.Drawing.Point(258, 87);
            this.SanctionsPresent.Margin = new System.Windows.Forms.Padding(4);
            this.SanctionsPresent.Name = "SanctionsPresent";
            this.SanctionsPresent.Size = new System.Drawing.Size(85, 20);
            this.SanctionsPresent.TabIndex = 12;
            this.SanctionsPresent.Text = "Санкции";
            this.SanctionsPresent.UseVisualStyleBackColor = true;
            this.SanctionsPresent.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // QualityValue
            // 
            this.QualityValue.Location = new System.Drawing.Point(41, 170);
            this.QualityValue.Margin = new System.Windows.Forms.Padding(4);
            this.QualityValue.Name = "QualityValue";
            this.QualityValue.Size = new System.Drawing.Size(269, 56);
            this.QualityValue.TabIndex = 11;
            this.QualityValue.Value = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(1390, 71);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(16, 16);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "...";
            // 
            // lbFixPeople
            // 
            this.lbFixPeople.AutoSize = true;
            this.lbFixPeople.Location = new System.Drawing.Point(1138, 71);
            this.lbFixPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixPeople.Name = "lbFixPeople";
            this.lbFixPeople.Size = new System.Drawing.Size(16, 16);
            this.lbFixPeople.TabIndex = 9;
            this.lbFixPeople.Text = "...";
            // 
            // lbProbPeople
            // 
            this.lbProbPeople.AutoSize = true;
            this.lbProbPeople.Location = new System.Drawing.Point(839, 71);
            this.lbProbPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProbPeople.Name = "lbProbPeople";
            this.lbProbPeople.Size = new System.Drawing.Size(16, 16);
            this.lbProbPeople.TabIndex = 8;
            this.lbProbPeople.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1013, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Люди, починившие сломанную технику";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(1001, 150);
            this.btStart.Margin = new System.Windows.Forms.Padding(4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(273, 73);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // DifficultyValue
            // 
            this.DifficultyValue.DecimalPlaces = 1;
            this.DifficultyValue.Location = new System.Drawing.Point(439, 28);
            this.DifficultyValue.Margin = new System.Windows.Forms.Padding(4);
            this.DifficultyValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DifficultyValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DifficultyValue.Name = "DifficultyValue";
            this.DifficultyValue.Size = new System.Drawing.Size(160, 22);
            this.DifficultyValue.TabIndex = 2;
            this.DifficultyValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SanctionsValue
            // 
            this.SanctionsValue.Location = new System.Drawing.Point(440, 85);
            this.SanctionsValue.Margin = new System.Windows.Forms.Padding(4);
            this.SanctionsValue.Name = "SanctionsValue";
            this.SanctionsValue.Size = new System.Drawing.Size(160, 22);
            this.SanctionsValue.TabIndex = 3;
            this.SanctionsValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Люди со сломанной техникой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1350, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена ремонта, $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Качество техники";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сила санкций";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сложность поломки";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            legend2.Title = "Модель ремонта быт. техн.";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 253);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Label = "Туристы";
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 7;
            series4.Name = "Люди со слом. техн.";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Label = "Клиенты";
            series5.Legend = "Legend1";
            series5.MarkerBorderWidth = 7;
            series5.Name = "Люди с почин. техн.";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Label = "Цена";
            series6.Legend = "Legend1";
            series6.Name = "Цена, $";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1563, 521);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PopularValue
            // 
            this.PopularValue.Location = new System.Drawing.Point(363, 170);
            this.PopularValue.Margin = new System.Windows.Forms.Padding(4);
            this.PopularValue.Name = "PopularValue";
            this.PopularValue.Size = new System.Drawing.Size(269, 56);
            this.PopularValue.TabIndex = 14;
            this.PopularValue.Value = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Популярность компании";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 774);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanctionsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopularValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown DifficultyValue;
        private System.Windows.Forms.NumericUpDown SanctionsValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox SanctionsPresent;
        private System.Windows.Forms.TrackBar QualityValue;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbFixPeople;
        private System.Windows.Forms.Label lbProbPeople;
        private System.Windows.Forms.TrackBar PopularValue;
        private System.Windows.Forms.Label label7;
    }
}

