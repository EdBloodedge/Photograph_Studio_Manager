namespace Poyecto_estudio
{
    partial class FormReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReviews));
            this.labelRateUs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxReview = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelStars = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5Stars = new System.Windows.Forms.PictureBox();
            this.pictureBox4Stars = new System.Windows.Forms.PictureBox();
            this.pictureBox3Stars = new System.Windows.Forms.PictureBox();
            this.pictureBox2Stars = new System.Windows.Forms.PictureBox();
            this.pictureBox1Star = new System.Windows.Forms.PictureBox();
            this.pictureBoxTurnedOffStar = new System.Windows.Forms.PictureBox();
            this.pictureBoxLightedStar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5Stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Stars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnedOffStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightedStar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRateUs
            // 
            this.labelRateUs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRateUs.AutoSize = true;
            this.labelRateUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelRateUs.Location = new System.Drawing.Point(172, 38);
            this.labelRateUs.Name = "labelRateUs";
            this.labelRateUs.Size = new System.Drawing.Size(810, 29);
            this.labelRateUs.TabIndex = 0;
            this.labelRateUs.Text = "¿Tuviste una sesión de fotos con nosotros?  ¡Déjanos saber tu opinión!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.pictureBoxTurnedOffStar);
            this.panel1.Controls.Add(this.pictureBoxLightedStar);
            this.panel1.Controls.Add(this.labelRateUs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBoxReview
            // 
            this.textBoxReview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReview.Location = new System.Drawing.Point(169, 89);
            this.textBoxReview.MaxLength = 200;
            this.textBoxReview.Multiline = true;
            this.textBoxReview.Name = "textBoxReview";
            this.textBoxReview.Size = new System.Drawing.Size(805, 131);
            this.textBoxReview.TabIndex = 2;
            // 
            // tableLayoutPanelStars
            // 
            this.tableLayoutPanelStars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanelStars.ColumnCount = 5;
            this.tableLayoutPanelStars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStars.Controls.Add(this.pictureBox5Stars, 4, 0);
            this.tableLayoutPanelStars.Controls.Add(this.pictureBox4Stars, 3, 0);
            this.tableLayoutPanelStars.Controls.Add(this.pictureBox3Stars, 2, 0);
            this.tableLayoutPanelStars.Controls.Add(this.pictureBox2Stars, 1, 0);
            this.tableLayoutPanelStars.Controls.Add(this.pictureBox1Star, 0, 0);
            this.tableLayoutPanelStars.Location = new System.Drawing.Point(549, 40);
            this.tableLayoutPanelStars.Name = "tableLayoutPanelStars";
            this.tableLayoutPanelStars.RowCount = 1;
            this.tableLayoutPanelStars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStars.Size = new System.Drawing.Size(317, 46);
            this.tableLayoutPanelStars.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(872, 40);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(102, 43);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(172, 58);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(108, 25);
            this.labelNumber.TabIndex = 7;
            this.labelNumber.Text = "No. Orden:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estamos ansiosos por conocer tu opinión";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(286, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRate,
            this.columnHeaderDate,
            this.columnHeaderReview});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(185, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(797, 244);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRate
            // 
            this.columnHeaderRate.Text = "Calificación";
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Fecha";
            // 
            // columnHeaderReview
            // 
            this.columnHeaderReview.Text = "Reseña ";
            this.columnHeaderReview.Width = 612;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxReview);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.tableLayoutPanelStars);
            this.panel2.Controls.Add(this.buttonSend);
            this.panel2.Controls.Add(this.labelNumber);
            this.panel2.Location = new System.Drawing.Point(12, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 226);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox5Stars
            // 
            this.pictureBox5Stars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5Stars.BackgroundImage")));
            this.pictureBox5Stars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5Stars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5Stars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5Stars.Location = new System.Drawing.Point(255, 3);
            this.pictureBox5Stars.Name = "pictureBox5Stars";
            this.pictureBox5Stars.Size = new System.Drawing.Size(59, 40);
            this.pictureBox5Stars.TabIndex = 7;
            this.pictureBox5Stars.TabStop = false;
            this.pictureBox5Stars.Click += new System.EventHandler(this.pictureBox5Stars_Click);
            // 
            // pictureBox4Stars
            // 
            this.pictureBox4Stars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4Stars.BackgroundImage")));
            this.pictureBox4Stars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4Stars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4Stars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4Stars.Location = new System.Drawing.Point(192, 3);
            this.pictureBox4Stars.Name = "pictureBox4Stars";
            this.pictureBox4Stars.Size = new System.Drawing.Size(57, 40);
            this.pictureBox4Stars.TabIndex = 6;
            this.pictureBox4Stars.TabStop = false;
            this.pictureBox4Stars.Click += new System.EventHandler(this.pictureBox4Stars_Click);
            // 
            // pictureBox3Stars
            // 
            this.pictureBox3Stars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3Stars.BackgroundImage")));
            this.pictureBox3Stars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3Stars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3Stars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3Stars.Location = new System.Drawing.Point(129, 3);
            this.pictureBox3Stars.Name = "pictureBox3Stars";
            this.pictureBox3Stars.Size = new System.Drawing.Size(57, 40);
            this.pictureBox3Stars.TabIndex = 5;
            this.pictureBox3Stars.TabStop = false;
            this.pictureBox3Stars.Click += new System.EventHandler(this.pictureBox3Stars_Click);
            // 
            // pictureBox2Stars
            // 
            this.pictureBox2Stars.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2Stars.BackgroundImage")));
            this.pictureBox2Stars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2Stars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2Stars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2Stars.Location = new System.Drawing.Point(66, 3);
            this.pictureBox2Stars.Name = "pictureBox2Stars";
            this.pictureBox2Stars.Size = new System.Drawing.Size(57, 40);
            this.pictureBox2Stars.TabIndex = 4;
            this.pictureBox2Stars.TabStop = false;
            this.pictureBox2Stars.Click += new System.EventHandler(this.pictureBox2Stars_Click);
            // 
            // pictureBox1Star
            // 
            this.pictureBox1Star.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1Star.BackgroundImage")));
            this.pictureBox1Star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1Star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1Star.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1Star.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1Star.Name = "pictureBox1Star";
            this.pictureBox1Star.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1Star.TabIndex = 3;
            this.pictureBox1Star.TabStop = false;
            this.pictureBox1Star.Click += new System.EventHandler(this.pictureBox1Star_Click);
            // 
            // pictureBoxTurnedOffStar
            // 
            this.pictureBoxTurnedOffStar.BackgroundImage = global::Poyecto_estudio.Properties.Resources.icons8_estrella_50;
            this.pictureBoxTurnedOffStar.Location = new System.Drawing.Point(1117, 38);
            this.pictureBoxTurnedOffStar.Name = "pictureBoxTurnedOffStar";
            this.pictureBoxTurnedOffStar.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxTurnedOffStar.TabIndex = 6;
            this.pictureBoxTurnedOffStar.TabStop = false;
            this.pictureBoxTurnedOffStar.Visible = false;
            // 
            // pictureBoxLightedStar
            // 
            this.pictureBoxLightedStar.BackgroundImage = global::Poyecto_estudio.Properties.Resources.icons8_estrella_48;
            this.pictureBoxLightedStar.Location = new System.Drawing.Point(1058, 38);
            this.pictureBoxLightedStar.Name = "pictureBoxLightedStar";
            this.pictureBoxLightedStar.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxLightedStar.TabIndex = 5;
            this.pictureBoxLightedStar.TabStop = false;
            this.pictureBoxLightedStar.Visible = false;
            // 
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormReviews";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5Stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Stars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTurnedOffStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLightedStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRateUs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxReview;
        private System.Windows.Forms.PictureBox pictureBox1Star;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStars;
        private System.Windows.Forms.PictureBox pictureBox5Stars;
        private System.Windows.Forms.PictureBox pictureBox4Stars;
        private System.Windows.Forms.PictureBox pictureBox3Stars;
        private System.Windows.Forms.PictureBox pictureBox2Stars;
        private System.Windows.Forms.PictureBox pictureBoxLightedStar;
        private System.Windows.Forms.PictureBox pictureBoxTurnedOffStar;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderRate;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderReview;
        private System.Windows.Forms.Panel panel2;
    }
}