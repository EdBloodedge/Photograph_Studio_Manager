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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.buttonLookUp = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.radioButtonOrderNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerName = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.AcceptsReturn = true;
            this.textBoxOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrderNumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderNumber.Location = new System.Drawing.Point(367, 39);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(535, 26);
            this.textBoxOrderNumber.TabIndex = 0;
            // 
            // buttonLookUp
            // 
            this.buttonLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLookUp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLookUp.FlatAppearance.BorderSize = 0;
            this.buttonLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLookUp.Location = new System.Drawing.Point(367, 94);
            this.buttonLookUp.Name = "buttonLookUp";
            this.buttonLookUp.Size = new System.Drawing.Size(535, 47);
            this.buttonLookUp.TabIndex = 2;
            this.buttonLookUp.Text = "Buscar";
            this.buttonLookUp.UseVisualStyleBackColor = false;
            this.buttonLookUp.Click += new System.EventHandler(this.buttonLookUp_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(227)))));
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrder.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridViewOrder.Location = new System.Drawing.Point(12, 173);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(890, 488);
            this.dataGridViewOrder.TabIndex = 3;
            // 
            // radioButtonOrderNumber
            // 
            this.radioButtonOrderNumber.AutoSize = true;
            this.radioButtonOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOrderNumber.Location = new System.Drawing.Point(6, 27);
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
            this.radioButtonCustomerName.Location = new System.Drawing.Point(6, 57);
            this.radioButtonCustomerName.Name = "radioButtonCustomerName";
            this.radioButtonCustomerName.Size = new System.Drawing.Size(166, 24);
            this.radioButtonCustomerName.TabIndex = 5;
            this.radioButtonCustomerName.TabStop = true;
            this.radioButtonCustomerName.Text = "Nombre de cliente";
            this.radioButtonCustomerName.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Número de teléfono";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.radioButtonAll);
            this.groupBoxSearch.Controls.Add(this.radioButtonOrderNumber);
            this.groupBoxSearch.Controls.Add(this.radioButton1);
            this.groupBoxSearch.Controls.Add(this.radioButtonCustomerName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(320, 155);
            this.groupBoxSearch.TabIndex = 8;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Buscar con";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.Location = new System.Drawing.Point(6, 117);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(67, 24);
            this.radioButtonAll.TabIndex = 8;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Todo";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.Visible = false;
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(914, 673);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.buttonLookUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Button buttonLookUp;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.RadioButton radioButtonOrderNumber;
        private System.Windows.Forms.RadioButton radioButtonCustomerName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonAll;
    }
}