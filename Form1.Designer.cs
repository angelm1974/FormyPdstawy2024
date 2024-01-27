namespace FormyPdstawy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnTop = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            wpisoweDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            wiekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nazwiskoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rankingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kolarzBindingSource = new BindingSource(components);
            btnDodaj = new Button();
            imageList1 = new ImageList(components);
            btnEdytuj = new Button();
            btnUsun = new Button();
            btnZamknij = new Button();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kolarzBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnTop.BackColor = Color.RoyalBlue;
            pnTop.Controls.Add(pictureBox1);
            pnTop.Controls.Add(label1);
            pnTop.Location = new Point(12, 12);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1260, 100);
            pnTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 34);
            label1.Name = "label1";
            label1.Size = new Size(495, 32);
            label1.TabIndex = 0;
            label1.Text = "Aplikacja do zarządzania Tour De Pologne";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, wpisoweDataGridViewCheckBoxColumn, wiekDataGridViewTextBoxColumn, teamDataGridViewTextBoxColumn, imieDataGridViewTextBoxColumn, nazwiskoDataGridViewTextBoxColumn, rankingDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kolarzBindingSource;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1260, 398);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // wpisoweDataGridViewCheckBoxColumn
            // 
            wpisoweDataGridViewCheckBoxColumn.DataPropertyName = "Wpisowe";
            wpisoweDataGridViewCheckBoxColumn.Frozen = true;
            wpisoweDataGridViewCheckBoxColumn.HeaderText = "Wpisowe";
            wpisoweDataGridViewCheckBoxColumn.Name = "wpisoweDataGridViewCheckBoxColumn";
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            teamDataGridViewTextBoxColumn.HeaderText = "Team";
            teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            imieDataGridViewTextBoxColumn.HeaderText = "Imię";
            imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            imieDataGridViewTextBoxColumn.Width = 80;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            nazwiskoDataGridViewTextBoxColumn.Width = 80;
            // 
            // rankingDataGridViewTextBoxColumn
            // 
            rankingDataGridViewTextBoxColumn.DataPropertyName = "Ranking";
            rankingDataGridViewTextBoxColumn.HeaderText = "Ranking";
            rankingDataGridViewTextBoxColumn.Name = "rankingDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 50;
            // 
            // kolarzBindingSource
            // 
            kolarzBindingSource.AllowNew = false;
            kolarzBindingSource.DataSource = typeof(Kolarz);
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDodaj.BackColor = Color.Transparent;
            btnDodaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnDodaj.ImageKey = "add.png";
            btnDodaj.ImageList = imageList1;
            btnDodaj.Location = new Point(12, 552);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Padding = new Padding(5, 0, 0, 0);
            btnDodaj.Size = new Size(157, 48);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj kolarza";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add.png");
            imageList1.Images.SetKeyName(1, "close.png");
            imageList1.Images.SetKeyName(2, "delete.png");
            imageList1.Images.SetKeyName(3, "edit.png");
            // 
            // btnEdytuj
            // 
            btnEdytuj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdytuj.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdytuj.ImageKey = "edit.png";
            btnEdytuj.ImageList = imageList1;
            btnEdytuj.Location = new Point(175, 552);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Padding = new Padding(5, 0, 0, 0);
            btnEdytuj.Size = new Size(157, 48);
            btnEdytuj.TabIndex = 3;
            btnEdytuj.Text = "Edytuj kolarza";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUsun.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsun.ImageKey = "delete.png";
            btnUsun.ImageList = imageList1;
            btnUsun.Location = new Point(338, 552);
            btnUsun.Name = "btnUsun";
            btnUsun.Padding = new Padding(5, 0, 0, 0);
            btnUsun.Size = new Size(157, 48);
            btnUsun.TabIndex = 4;
            btnUsun.Text = "Usuń kolarza";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnZamknij
            // 
            btnZamknij.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnZamknij.ImageAlign = ContentAlignment.MiddleLeft;
            btnZamknij.ImageKey = "close.png";
            btnZamknij.ImageList = imageList1;
            btnZamknij.Location = new Point(1115, 552);
            btnZamknij.Name = "btnZamknij";
            btnZamknij.Padding = new Padding(5, 0, 0, 0);
            btnZamknij.Size = new Size(157, 48);
            btnZamknij.TabIndex = 5;
            btnZamknij.Text = "Zamknij";
            btnZamknij.UseVisualStyleBackColor = true;
            btnZamknij.Click += btnZamknij_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1284, 612);
            Controls.Add(btnZamknij);
            Controls.Add(btnUsun);
            Controls.Add(btnEdytuj);
            Controls.Add(btnDodaj);
            Controls.Add(dataGridView1);
            Controls.Add(pnTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Aplikacja do zarządzania Tour De Pologne";
            Activated += Form1_Activated;
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kolarzBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDodaj;
        private Button btnEdytuj;
        private Button btnUsun;
        private Button btnZamknij;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private BindingSource kolarzBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn wpisoweDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rankingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}