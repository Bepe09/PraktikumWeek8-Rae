
namespace PraktikumWeek8
{
    partial class FormHasilPertandingan
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
            this.comboBoxTim1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTim2 = new System.Windows.Forms.ComboBox();
            this.labelManager1 = new System.Windows.Forms.Label();
            this.labelManager2 = new System.Windows.Forms.Label();
            this.labelCaptain2 = new System.Windows.Forms.Label();
            this.labelCaptain1 = new System.Windows.Forms.Label();
            this.labelVS = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTim1
            // 
            this.comboBoxTim1.FormattingEnabled = true;
            this.comboBoxTim1.Location = new System.Drawing.Point(97, 76);
            this.comboBoxTim1.Name = "comboBoxTim1";
            this.comboBoxTim1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTim1.TabIndex = 0;
            this.comboBoxTim1.SelectedIndexChanged += new System.EventHandler(this.comboBoxTim1_SelectedIndexChanged);
            // 
            // comboBoxTim2
            // 
            this.comboBoxTim2.FormattingEnabled = true;
            this.comboBoxTim2.Location = new System.Drawing.Point(427, 76);
            this.comboBoxTim2.Name = "comboBoxTim2";
            this.comboBoxTim2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTim2.TabIndex = 1;
            // 
            // labelManager1
            // 
            this.labelManager1.AutoSize = true;
            this.labelManager1.Location = new System.Drawing.Point(94, 144);
            this.labelManager1.Name = "labelManager1";
            this.labelManager1.Size = new System.Drawing.Size(72, 17);
            this.labelManager1.TabIndex = 2;
            this.labelManager1.Text = "Manager :";
            // 
            // labelManager2
            // 
            this.labelManager2.AutoSize = true;
            this.labelManager2.Location = new System.Drawing.Point(424, 144);
            this.labelManager2.Name = "labelManager2";
            this.labelManager2.Size = new System.Drawing.Size(72, 17);
            this.labelManager2.TabIndex = 3;
            this.labelManager2.Text = "Manager :";
            // 
            // labelCaptain2
            // 
            this.labelCaptain2.AutoSize = true;
            this.labelCaptain2.Location = new System.Drawing.Point(424, 182);
            this.labelCaptain2.Name = "labelCaptain2";
            this.labelCaptain2.Size = new System.Drawing.Size(64, 17);
            this.labelCaptain2.TabIndex = 4;
            this.labelCaptain2.Text = "Captain :";
            // 
            // labelCaptain1
            // 
            this.labelCaptain1.AutoSize = true;
            this.labelCaptain1.Location = new System.Drawing.Point(94, 182);
            this.labelCaptain1.Name = "labelCaptain1";
            this.labelCaptain1.Size = new System.Drawing.Size(64, 17);
            this.labelCaptain1.TabIndex = 5;
            this.labelCaptain1.Text = "Captain :";
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(311, 79);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(26, 17);
            this.labelVS.TabIndex = 6;
            this.labelVS.Text = "VS";
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(250, 262);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(67, 17);
            this.labelStadium.TabIndex = 7;
            this.labelStadium.Text = "Stadium :";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(247, 295);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(70, 17);
            this.labelCapacity.TabIndex = 8;
            this.labelCapacity.Text = "Capacity :";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.labelCaptain1);
            this.Controls.Add(this.labelCaptain2);
            this.Controls.Add(this.labelManager2);
            this.Controls.Add(this.labelManager1);
            this.Controls.Add(this.comboBoxTim2);
            this.Controls.Add(this.comboBoxTim1);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTim1;
        private System.Windows.Forms.ComboBox comboBoxTim2;
        private System.Windows.Forms.Label labelManager1;
        private System.Windows.Forms.Label labelManager2;
        private System.Windows.Forms.Label labelCaptain2;
        private System.Windows.Forms.Label labelCaptain1;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelCapacity;
    }
}

