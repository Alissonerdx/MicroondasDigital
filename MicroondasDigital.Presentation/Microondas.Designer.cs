namespace MicroondasDigital.Presentation
{
    partial class Microondas
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
            this.PbDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // PbDisplay
            // 
            this.PbDisplay.Image = global::MicroondasDigital.Presentation.Properties.Resources._2908;
            this.PbDisplay.Location = new System.Drawing.Point(438, 12);
            this.PbDisplay.Name = "PbDisplay";
            this.PbDisplay.Size = new System.Drawing.Size(157, 342);
            this.PbDisplay.TabIndex = 0;
            this.PbDisplay.TabStop = false;
            // 
            // Microondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 384);
            this.Controls.Add(this.PbDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Microondas";
            this.Text = "Micro-ondas";
            ((System.ComponentModel.ISupportInitialize)(this.PbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbDisplay;
    }
}

