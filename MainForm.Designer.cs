
namespace Fringilla
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.angleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.chartBckg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackLineY = new System.Windows.Forms.TrackBar();
            this.trackLineX = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lineLenUpDown = new System.Windows.Forms.NumericUpDown();
            this.chartFilm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelBckg = new System.Windows.Forms.Panel();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelProcessing = new System.Windows.Forms.Panel();
            this.rbDist = new System.Windows.Forms.RadioButton();
            this.rbZero = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.mapPointPanel = new Fringilla.TransparentPanel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBckg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLineY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLineX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilm)).BeginInit();
            this.panelBckg.SuspendLayout();
            this.panelFilm.SuspendLayout();
            this.panelProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openToolStripMenuItem.Text = "Open Bitmap";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutAuthorToolStripMenuItem.Text = "About Author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = ":)";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabel.Text = ":)";
            // 
            // toolStripStatusLabelFile
            // 
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            this.toolStripStatusLabelFile.Size = new System.Drawing.Size(0, 17);
            // 
            // angleUpDown
            // 
            this.angleUpDown.Location = new System.Drawing.Point(77, 429);
            this.angleUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angleUpDown.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.angleUpDown.Name = "angleUpDown";
            this.angleUpDown.Size = new System.Drawing.Size(34, 20);
            this.angleUpDown.TabIndex = 3;
            this.angleUpDown.ValueChanged += new System.EventHandler(this.angleUpDown_ValueChanged);
            this.angleUpDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.angleUpDown_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Angle :";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPictureBox.Image = global::Fringilla.Properties.Resources.mainPictureBox_bckImage_256;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 27);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(350, 350);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            // 
            // chartBckg
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBckg.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBckg.Legends.Add(legend1);
            this.chartBckg.Location = new System.Drawing.Point(4, 4);
            this.chartBckg.Name = "chartBckg";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBckg.Series.Add(series1);
            this.chartBckg.Size = new System.Drawing.Size(440, 183);
            this.chartBckg.TabIndex = 0;
            this.chartBckg.Text = "Background";
            this.chartBckg.Click += new System.EventHandler(this.chartBckg_Click);
            // 
            // trackLineY
            // 
            this.trackLineY.Location = new System.Drawing.Point(368, 27);
            this.trackLineY.Name = "trackLineY";
            this.trackLineY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackLineY.RightToLeftLayout = true;
            this.trackLineY.Size = new System.Drawing.Size(45, 350);
            this.trackLineY.TabIndex = 8;
            this.trackLineY.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLineY.Scroll += new System.EventHandler(this.trackLineY_Scroll);
            this.trackLineY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackLineY_MouseUp);
            // 
            // trackLineX
            // 
            this.trackLineX.Location = new System.Drawing.Point(12, 383);
            this.trackLineX.Maximum = 350;
            this.trackLineX.Name = "trackLineX";
            this.trackLineX.Size = new System.Drawing.Size(350, 45);
            this.trackLineX.TabIndex = 9;
            this.trackLineX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackLineX.Value = 60;
            this.trackLineX.Scroll += new System.EventHandler(this.trackLineX_Scroll);
            this.trackLineX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackLineX_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Line Length :";
            // 
            // lineLenUpDown
            // 
            this.lineLenUpDown.Location = new System.Drawing.Point(220, 429);
            this.lineLenUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lineLenUpDown.Name = "lineLenUpDown";
            this.lineLenUpDown.Size = new System.Drawing.Size(47, 20);
            this.lineLenUpDown.TabIndex = 11;
            this.lineLenUpDown.ValueChanged += new System.EventHandler(this.lineLenUpDown_ValueChanged);
            this.lineLenUpDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lineLenUpDown_MouseUp);
            // 
            // chartFilm
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFilm.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFilm.Legends.Add(legend2);
            this.chartFilm.Location = new System.Drawing.Point(3, 3);
            this.chartFilm.Name = "chartFilm";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFilm.Series.Add(series2);
            this.chartFilm.Size = new System.Drawing.Size(441, 182);
            this.chartFilm.TabIndex = 0;
            this.chartFilm.Text = "Film";
            this.chartFilm.Click += new System.EventHandler(this.chartFilm_Click);
            // 
            // panelBckg
            // 
            this.panelBckg.Controls.Add(this.chartBckg);
            this.panelBckg.Location = new System.Drawing.Point(419, 43);
            this.panelBckg.Name = "panelBckg";
            this.panelBckg.Size = new System.Drawing.Size(447, 190);
            this.panelBckg.TabIndex = 18;
            // 
            // panelFilm
            // 
            this.panelFilm.Controls.Add(this.chartFilm);
            this.panelFilm.Location = new System.Drawing.Point(419, 259);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(447, 190);
            this.panelFilm.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(420, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Background";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(420, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Film";
            // 
            // panelProcessing
            // 
            this.panelProcessing.Controls.Add(this.rbDist);
            this.panelProcessing.Controls.Add(this.rbZero);
            this.panelProcessing.Controls.Add(this.rbLine);
            this.panelProcessing.Enabled = false;
            this.panelProcessing.Location = new System.Drawing.Point(886, 43);
            this.panelProcessing.Name = "panelProcessing";
            this.panelProcessing.Size = new System.Drawing.Size(284, 25);
            this.panelProcessing.TabIndex = 22;
            // 
            // rbDist
            // 
            this.rbDist.AutoSize = true;
            this.rbDist.Location = new System.Drawing.Point(214, 4);
            this.rbDist.Name = "rbDist";
            this.rbDist.Size = new System.Drawing.Size(67, 17);
            this.rbDist.TabIndex = 24;
            this.rbDist.TabStop = true;
            this.rbDist.Text = "Distance";
            this.rbDist.UseVisualStyleBackColor = true;
            // 
            // rbZero
            // 
            this.rbZero.AutoSize = true;
            this.rbZero.Location = new System.Drawing.Point(102, 4);
            this.rbZero.Name = "rbZero";
            this.rbZero.Size = new System.Drawing.Size(58, 17);
            this.rbZero.TabIndex = 24;
            this.rbZero.TabStop = true;
            this.rbZero.Text = "0-order";
            this.rbZero.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(3, 3);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 23;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(886, 74);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(284, 341);
            this.richTextBox.TabIndex = 24;
            this.richTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(886, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 26;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1095, 426);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "Export to .txt";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // mapPointPanel
            // 
            this.mapPointPanel.Location = new System.Drawing.Point(12, 27);
            this.mapPointPanel.Name = "mapPointPanel";
            this.mapPointPanel.Size = new System.Drawing.Size(350, 350);
            this.mapPointPanel.TabIndex = 6;
            this.mapPointPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mapPointPanel_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 484);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panelProcessing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelFilm);
            this.Controls.Add(this.panelBckg);
            this.Controls.Add(this.lineLenUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackLineX);
            this.Controls.Add(this.trackLineY);
            this.Controls.Add(this.mapPointPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angleUpDown);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fringilla";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBckg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLineY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLineX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilm)).EndInit();
            this.panelBckg.ResumeLayout(false);
            this.panelFilm.ResumeLayout(false);
            this.panelProcessing.ResumeLayout(false);
            this.panelProcessing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.NumericUpDown angleUpDown;
        private System.Windows.Forms.Label label1;
        private TransparentPanel mapPointPanel;
        public System.Windows.Forms.TrackBar trackLineY;
        private System.Windows.Forms.TrackBar trackLineX;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown lineLenUpDown;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartBckg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile;
        private System.Windows.Forms.Panel panelBckg;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelProcessing;
        private System.Windows.Forms.RadioButton rbDist;
        private System.Windows.Forms.RadioButton rbZero;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
    }
}

