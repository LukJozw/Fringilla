
namespace Fringilla
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRGate = new Fringilla.CircularButton();
            this.btnMailTo = new Fringilla.CircularButton();
            this.btnLinkedIn = new Fringilla.CircularButton();
            this.circularPictureBox1 = new Fringilla.CircularPictureBox();
            this.btnClose = new Fringilla.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(43, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 1);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(102, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Researcher in the field of Material Science, simulation and computing.\r\nOver 5 ye" +
    "ars of Matlab simulation practice and C/C++ programming of uC\'s.\r\nNow beginning " +
    "C# .NET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(296, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "About Me";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(267, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lukasz Jozwiak";
            // 
            // btnRGate
            // 
            this.btnRGate.FlatAppearance.BorderSize = 0;
            this.btnRGate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRGate.Image = global::Fringilla.Properties.Resources.rgProfile_64;
            this.btnRGate.Location = new System.Drawing.Point(536, 367);
            this.btnRGate.Name = "btnRGate";
            this.btnRGate.Size = new System.Drawing.Size(86, 86);
            this.btnRGate.TabIndex = 4;
            this.btnRGate.UseVisualStyleBackColor = true;
            this.btnRGate.Click += new System.EventHandler(this.btnRGate_Click);
            // 
            // btnMailTo
            // 
            this.btnMailTo.FlatAppearance.BorderSize = 0;
            this.btnMailTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailTo.Image = global::Fringilla.Properties.Resources.mailTo_64;
            this.btnMailTo.Location = new System.Drawing.Point(329, 367);
            this.btnMailTo.Name = "btnMailTo";
            this.btnMailTo.Size = new System.Drawing.Size(86, 86);
            this.btnMailTo.TabIndex = 3;
            this.btnMailTo.UseVisualStyleBackColor = true;
            this.btnMailTo.Click += new System.EventHandler(this.btnMailTo_Click);
            // 
            // btnLinkedIn
            // 
            this.btnLinkedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLinkedIn.FlatAppearance.BorderSize = 0;
            this.btnLinkedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkedIn.Image = global::Fringilla.Properties.Resources.linkedInProfile_64;
            this.btnLinkedIn.Location = new System.Drawing.Point(122, 367);
            this.btnLinkedIn.Name = "btnLinkedIn";
            this.btnLinkedIn.Size = new System.Drawing.Size(86, 86);
            this.btnLinkedIn.TabIndex = 2;
            this.btnLinkedIn.UseVisualStyleBackColor = true;
            this.btnLinkedIn.Click += new System.EventHandler(this.btnLinkedIn_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularPictureBox1.Image = global::Fringilla.Properties.Resources.myphoto;
            this.circularPictureBox1.Location = new System.Drawing.Point(288, 40);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(138, 138);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Fringilla.Properties.Resources.exitButton_24;
            this.btnClose.Location = new System.Drawing.Point(661, 40);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRGate);
            this.Controls.Add(this.btnMailTo);
            this.Controls.Add(this.btnLinkedIn);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Author";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAbout_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAbout_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton btnClose;
        private CircularPictureBox circularPictureBox1;
        private CircularButton btnLinkedIn;
        private CircularButton btnMailTo;
        private CircularButton btnRGate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}