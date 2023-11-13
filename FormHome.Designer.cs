namespace Poyecto_estudio
{
    partial class FormHome
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
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.Turquoise;
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.Location = new System.Drawing.Point(300, 216);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(400, 100);
            this.buttonHistory.TabIndex = 2;
            this.buttonHistory.Text = "Ver historial de ordenes";
            this.buttonHistory.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrder.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(300, 50);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(400, 100);
            this.buttonOrder.TabIndex = 3;
            this.buttonOrder.Text = "Hacer una orden";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonReviews
            // 
            this.buttonReviews.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReviews.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.buttonReviews.FlatAppearance.BorderSize = 0;
            this.buttonReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReviews.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReviews.Location = new System.Drawing.Point(300, 376);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(400, 100);
            this.buttonReviews.TabIndex = 4;
            this.buttonReviews.Text = "Reseñas";
            this.buttonReviews.UseVisualStyleBackColor = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.buttonReviews);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormHome";
            this.Text = "HOME";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonReviews;
    }
}

