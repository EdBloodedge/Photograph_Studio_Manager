namespace Poyecto_estudio
{
    partial class FormAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs));
            this.labelAboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAboutUs
            // 
            this.labelAboutUs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAboutUs.AutoSize = true;
            this.labelAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(168)))), ((int)(((byte)(219)))));
            this.labelAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAboutUs.Location = new System.Drawing.Point(12, 66);
            this.labelAboutUs.Name = "labelAboutUs";
            this.labelAboutUs.Size = new System.Drawing.Size(985, 435);
            this.labelAboutUs.TabIndex = 0;
            this.labelAboutUs.Text = resources.GetString("labelAboutUs.Text");
            this.labelAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(219)))));
            this.BackgroundImage = global::Poyecto_estudio.Properties.Resources.WhatsApp_Image_2023_12_03_at_8_11_08_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1010, 559);
            this.Controls.Add(this.labelAboutUs);
            this.Name = "FormAboutUs";
            this.Text = "FormAboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAboutUs;
    }
}