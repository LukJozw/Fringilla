
namespace Fringilla
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.btnColorDefault = new System.Windows.Forms.Button();
            this.blueUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenUpDown = new System.Windows.Forms.NumericUpDown();
            this.redUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHighFilt = new System.Windows.Forms.Button();
            this.btnMedFilter = new System.Windows.Forms.Button();
            this.btnSmallFilter = new System.Windows.Forms.Button();
            this.loopsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.vectLegthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnWlenRed = new System.Windows.Forms.Button();
            this.monoUpDown = new System.Windows.Forms.NumericUpDown();
            this.polyUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBitmap = new System.Windows.Forms.TextBox();
            this.textBoxReports = new System.Windows.Forms.TextBox();
            this.btnBitmap = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectLegthUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyUpDown)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.blueUpDown);
            this.groupBox1.Controls.Add(this.greenUpDown);
            this.groupBox1.Controls.Add(this.redUpDown);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Conversion Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColorRed);
            this.groupBox2.Controls.Add(this.btnColorDefault);
            this.groupBox2.Location = new System.Drawing.Point(363, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schemes";
            // 
            // btnColorRed
            // 
            this.btnColorRed.Location = new System.Drawing.Point(6, 63);
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.Size = new System.Drawing.Size(75, 23);
            this.btnColorRed.TabIndex = 1;
            this.btnColorRed.Text = "Red";
            this.btnColorRed.UseVisualStyleBackColor = true;
            this.btnColorRed.Click += new System.EventHandler(this.btnColorRed_Click);
            // 
            // btnColorDefault
            // 
            this.btnColorDefault.Location = new System.Drawing.Point(6, 34);
            this.btnColorDefault.Name = "btnColorDefault";
            this.btnColorDefault.Size = new System.Drawing.Size(75, 23);
            this.btnColorDefault.TabIndex = 0;
            this.btnColorDefault.Text = "Default";
            this.btnColorDefault.UseVisualStyleBackColor = true;
            this.btnColorDefault.Click += new System.EventHandler(this.btnColorDefault_Click);
            // 
            // blueUpDown
            // 
            this.blueUpDown.DecimalPlaces = 2;
            this.blueUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.blueUpDown.Location = new System.Drawing.Point(78, 110);
            this.blueUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueUpDown.Name = "blueUpDown";
            this.blueUpDown.Size = new System.Drawing.Size(63, 23);
            this.blueUpDown.TabIndex = 6;
            this.blueUpDown.ValueChanged += new System.EventHandler(this.blueUpDown_ValueChanged);
            // 
            // greenUpDown
            // 
            this.greenUpDown.DecimalPlaces = 2;
            this.greenUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.greenUpDown.Location = new System.Drawing.Point(78, 77);
            this.greenUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenUpDown.Name = "greenUpDown";
            this.greenUpDown.Size = new System.Drawing.Size(63, 23);
            this.greenUpDown.TabIndex = 5;
            this.greenUpDown.ValueChanged += new System.EventHandler(this.greenUpDown_ValueChanged);
            // 
            // redUpDown
            // 
            this.redUpDown.DecimalPlaces = 2;
            this.redUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.redUpDown.Location = new System.Drawing.Point(78, 46);
            this.redUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redUpDown.Name = "redUpDown";
            this.redUpDown.Size = new System.Drawing.Size(63, 23);
            this.redUpDown.TabIndex = 4;
            this.redUpDown.ValueChanged += new System.EventHandler(this.redUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fringilla.Properties.Resources.triColor_128;
            this.pictureBox1.Location = new System.Drawing.Point(218, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHighFilt);
            this.groupBox3.Controls.Add(this.btnMedFilter);
            this.groupBox3.Controls.Add(this.btnSmallFilter);
            this.groupBox3.Controls.Add(this.loopsUpDown);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.vectLegthUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Parameters";
            // 
            // btnHighFilt
            // 
            this.btnHighFilt.Location = new System.Drawing.Point(507, 59);
            this.btnHighFilt.Name = "btnHighFilt";
            this.btnHighFilt.Size = new System.Drawing.Size(75, 23);
            this.btnHighFilt.TabIndex = 12;
            this.btnHighFilt.Text = "(11x11)";
            this.btnHighFilt.UseVisualStyleBackColor = true;
            this.btnHighFilt.Click += new System.EventHandler(this.btnHighFilt_Click);
            // 
            // btnMedFilter
            // 
            this.btnMedFilter.Location = new System.Drawing.Point(414, 59);
            this.btnMedFilter.Name = "btnMedFilter";
            this.btnMedFilter.Size = new System.Drawing.Size(75, 23);
            this.btnMedFilter.TabIndex = 11;
            this.btnMedFilter.Text = "(9x9)";
            this.btnMedFilter.UseVisualStyleBackColor = true;
            this.btnMedFilter.Click += new System.EventHandler(this.btnMedFilter_Click);
            // 
            // btnSmallFilter
            // 
            this.btnSmallFilter.Location = new System.Drawing.Point(321, 59);
            this.btnSmallFilter.Name = "btnSmallFilter";
            this.btnSmallFilter.Size = new System.Drawing.Size(75, 23);
            this.btnSmallFilter.TabIndex = 10;
            this.btnSmallFilter.Text = "(3x3)";
            this.btnSmallFilter.UseVisualStyleBackColor = true;
            this.btnSmallFilter.Click += new System.EventHandler(this.btnSmallFilter_Click);
            // 
            // loopsUpDown
            // 
            this.loopsUpDown.Location = new System.Drawing.Point(225, 58);
            this.loopsUpDown.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.loopsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loopsUpDown.Name = "loopsUpDown";
            this.loopsUpDown.Size = new System.Drawing.Size(69, 23);
            this.loopsUpDown.TabIndex = 9;
            this.loopsUpDown.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.loopsUpDown.ValueChanged += new System.EventHandler(this.loopsUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(164, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loops :";
            // 
            // vectLegthUpDown
            // 
            this.vectLegthUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.vectLegthUpDown.Location = new System.Drawing.Point(72, 58);
            this.vectLegthUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.vectLegthUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vectLegthUpDown.Name = "vectLegthUpDown";
            this.vectLegthUpDown.Size = new System.Drawing.Size(69, 23);
            this.vectLegthUpDown.TabIndex = 5;
            this.vectLegthUpDown.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.vectLegthUpDown.ValueChanged += new System.EventHandler(this.vectLegthUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Length :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description: Procedure using Savitzky-Golay filter metod at given vector length a" +
    "nd number of iterations to smooth.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.btnWlenRed);
            this.groupBox4.Controls.Add(this.monoUpDown);
            this.groupBox4.Controls.Add(this.polyUpDown);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(607, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wavelength";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(483, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Na (594 nm)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(482, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Poly (540 nm)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(358, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Green (535 nm)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWlenRed
            // 
            this.btnWlenRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWlenRed.Location = new System.Drawing.Point(358, 22);
            this.btnWlenRed.Name = "btnWlenRed";
            this.btnWlenRed.Size = new System.Drawing.Size(118, 23);
            this.btnWlenRed.TabIndex = 11;
            this.btnWlenRed.Text = "Red (650 nm)";
            this.btnWlenRed.UseVisualStyleBackColor = true;
            this.btnWlenRed.Click += new System.EventHandler(this.btnWlenRed_Click);
            // 
            // monoUpDown
            // 
            this.monoUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.monoUpDown.Location = new System.Drawing.Point(289, 27);
            this.monoUpDown.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.monoUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.monoUpDown.Name = "monoUpDown";
            this.monoUpDown.Size = new System.Drawing.Size(48, 23);
            this.monoUpDown.TabIndex = 7;
            this.monoUpDown.Value = new decimal(new int[] {
            535,
            0,
            0,
            0});
            this.monoUpDown.ValueChanged += new System.EventHandler(this.monoUpDown_ValueChanged);
            // 
            // polyUpDown
            // 
            this.polyUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.polyUpDown.Location = new System.Drawing.Point(111, 27);
            this.polyUpDown.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.polyUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.polyUpDown.Name = "polyUpDown";
            this.polyUpDown.Size = new System.Drawing.Size(48, 23);
            this.polyUpDown.TabIndex = 6;
            this.polyUpDown.Value = new decimal(new int[] {
            540,
            0,
            0,
            0});
            this.polyUpDown.ValueChanged += new System.EventHandler(this.polyUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(175, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Monochromatic:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Polychromatic:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReports);
            this.groupBox5.Controls.Add(this.btnBitmap);
            this.groupBox5.Controls.Add(this.textBoxReports);
            this.groupBox5.Controls.Add(this.textBoxBitmap);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(12, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(607, 84);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Program Directories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Reports patch:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bitmap Patch:";
            // 
            // textBoxBitmap
            // 
            this.textBoxBitmap.Location = new System.Drawing.Point(113, 26);
            this.textBoxBitmap.Name = "textBoxBitmap";
            this.textBoxBitmap.Size = new System.Drawing.Size(396, 23);
            this.textBoxBitmap.TabIndex = 2;
            // 
            // textBoxReports
            // 
            this.textBoxReports.Location = new System.Drawing.Point(113, 55);
            this.textBoxReports.Name = "textBoxReports";
            this.textBoxReports.Size = new System.Drawing.Size(396, 23);
            this.textBoxReports.TabIndex = 3;
            // 
            // btnBitmap
            // 
            this.btnBitmap.Location = new System.Drawing.Point(515, 26);
            this.btnBitmap.Name = "btnBitmap";
            this.btnBitmap.Size = new System.Drawing.Size(67, 23);
            this.btnBitmap.TabIndex = 4;
            this.btnBitmap.Text = "...";
            this.btnBitmap.UseVisualStyleBackColor = true;
            this.btnBitmap.Click += new System.EventHandler(this.btnBitmap_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(515, 55);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(67, 23);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "...";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 464);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectLegthUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyUpDown)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown blueUpDown;
        private System.Windows.Forms.NumericUpDown greenUpDown;
        private System.Windows.Forms.NumericUpDown redUpDown;
        private System.Windows.Forms.Button btnColorDefault;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown loopsUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown vectLegthUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHighFilt;
        private System.Windows.Forms.Button btnMedFilter;
        private System.Windows.Forms.Button btnSmallFilter;
        private System.Windows.Forms.Button btnColorRed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnWlenRed;
        private System.Windows.Forms.NumericUpDown monoUpDown;
        private System.Windows.Forms.NumericUpDown polyUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBitmap;
        private System.Windows.Forms.TextBox textBoxReports;
        private System.Windows.Forms.TextBox textBoxBitmap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}