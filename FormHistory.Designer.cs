namespace Poyecto_estudio
{
    partial class FormHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.buttonLookUp = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.radioButtonOrderNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderNumber.Location = new System.Drawing.Point(400, 43);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(360, 19);
            this.textBoxOrderNumber.TabIndex = 0;
            // 
            // buttonLookUp
            // 
            this.buttonLookUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLookUp.FlatAppearance.BorderSize = 0;
            this.buttonLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookUp.Location = new System.Drawing.Point(792, 26);
            this.buttonLookUp.Name = "buttonLookUp";
            this.buttonLookUp.Size = new System.Drawing.Size(103, 49);
            this.buttonLookUp.TabIndex = 2;
            this.buttonLookUp.Text = "Buscar";
            this.buttonLookUp.UseVisualStyleBackColor = false;
            this.buttonLookUp.Click += new System.EventHandler(this.buttonLookUp_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrder.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(883, 459);
            this.dataGridViewOrder.TabIndex = 3;
            // 
            // radioButtonOrderNumber
            // 
            this.radioButtonOrderNumber.AutoSize = true;
            this.radioButtonOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOrderNumber.Location = new System.Drawing.Point(12, 38);
            this.radioButtonOrderNumber.Name = "radioButtonOrderNumber";
            this.radioButtonOrderNumber.Size = new System.Drawing.Size(159, 24);
            this.radioButtonOrderNumber.TabIndex = 4;
            this.radioButtonOrderNumber.TabStop = true;
            this.radioButtonOrderNumber.Text = "Número de orden";
            this.radioButtonOrderNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerName
            // 
            this.radioButtonCustomerName.AutoSize = true;
            this.radioButtonCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomerName.Location = new System.Drawing.Point(195, 38);
            this.radioButtonCustomerName.Name = "radioButtonCustomerName";
            this.radioButtonCustomerName.Size = new System.Drawing.Size(166, 24);
            this.radioButtonCustomerName.TabIndex = 5;
            this.radioButtonCustomerName.TabStop = true;
            this.radioButtonCustomerName.Text = "Nombre de cliente";
            this.radioButtonCustomerName.UseVisualStyleBackColor = true;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(907, 565);
            this.Controls.Add(this.radioButtonCustomerName);
            this.Controls.Add(this.radioButtonOrderNumber);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.buttonLookUp);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Name = "FormHistory";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button buttonLookUp;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.RadioButton radioButtonOrderNumber;
        private System.Windows.Forms.RadioButton radioButtonCustomerName;
    }
}