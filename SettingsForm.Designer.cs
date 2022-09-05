
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectLegthUpDown)).BeginInit();
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
            this.groupBox2.Controls.Add(this.btnColorDefault);
            this.groupBox2.Location = new System.Drawing.Point(363, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schemes";
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
            23,
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 287);
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
    }
}