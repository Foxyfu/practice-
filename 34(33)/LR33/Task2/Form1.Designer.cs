namespace Task2
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
            tabControl1 = new TabControl();
            TouristsPage = new TabPage();
            TouristsView = new DataGridView();
            ToursPage = new TabPage();
            ToursView = new DataGridView();
            SeasonsPage = new TabPage();
            SeasonsView = new DataGridView();
            TravelsPage = new TabPage();
            TravelsView = new DataGridView();
            PaymentsPage = new TabPage();
            PaymentsView = new DataGridView();
            tabControl1.SuspendLayout();
            TouristsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TouristsView).BeginInit();
            ToursPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToursView).BeginInit();
            SeasonsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SeasonsView).BeginInit();
            TravelsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TravelsView).BeginInit();
            PaymentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentsView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TouristsPage);
            tabControl1.Controls.Add(ToursPage);
            tabControl1.Controls.Add(SeasonsPage);
            tabControl1.Controls.Add(TravelsPage);
            tabControl1.Controls.Add(PaymentsPage);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 445);
            tabControl1.TabIndex = 0;
            // 
            // TouristsPage
            // 
            TouristsPage.Controls.Add(TouristsView);
            TouristsPage.Location = new Point(4, 24);
            TouristsPage.Name = "TouristsPage";
            TouristsPage.Size = new Size(791, 417);
            TouristsPage.TabIndex = 0;
            TouristsPage.Text = "Туристы";
            TouristsPage.UseVisualStyleBackColor = true;
            // 
            // TouristsView
            // 
            TouristsView.AllowUserToAddRows = false;
            TouristsView.AllowUserToDeleteRows = false;
            TouristsView.AllowUserToOrderColumns = true;
            TouristsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TouristsView.Dock = DockStyle.Fill;
            TouristsView.Location = new Point(0, 0);
            TouristsView.Name = "TouristsView";
            TouristsView.ReadOnly = true;
            TouristsView.RowTemplate.Height = 25;
            TouristsView.Size = new Size(791, 417);
            TouristsView.TabIndex = 0;
            // 
            // ToursPage
            // 
            ToursPage.Controls.Add(ToursView);
            ToursPage.Location = new Point(4, 24);
            ToursPage.Name = "ToursPage";
            ToursPage.Size = new Size(791, 417);
            ToursPage.TabIndex = 2;
            ToursPage.Text = "Туры";
            ToursPage.UseVisualStyleBackColor = true;
            // 
            // ToursView
            // 
            ToursView.AllowUserToAddRows = false;
            ToursView.AllowUserToDeleteRows = false;
            ToursView.AllowUserToOrderColumns = true;
            ToursView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToursView.Dock = DockStyle.Fill;
            ToursView.Location = new Point(0, 0);
            ToursView.Name = "ToursView";
            ToursView.ReadOnly = true;
            ToursView.RowTemplate.Height = 25;
            ToursView.Size = new Size(791, 417);
            ToursView.TabIndex = 0;
            // 
            // SeasonsPage
            // 
            SeasonsPage.Controls.Add(SeasonsView);
            SeasonsPage.Location = new Point(4, 24);
            SeasonsPage.Name = "SeasonsPage";
            SeasonsPage.Size = new Size(791, 417);
            SeasonsPage.TabIndex = 3;
            SeasonsPage.Text = "Сезоны";
            SeasonsPage.UseVisualStyleBackColor = true;
            // 
            // SeasonsView
            // 
            SeasonsView.AllowUserToAddRows = false;
            SeasonsView.AllowUserToDeleteRows = false;
            SeasonsView.AllowUserToOrderColumns = true;
            SeasonsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SeasonsView.Dock = DockStyle.Fill;
            SeasonsView.Location = new Point(0, 0);
            SeasonsView.Name = "SeasonsView";
            SeasonsView.ReadOnly = true;
            SeasonsView.RowTemplate.Height = 25;
            SeasonsView.Size = new Size(791, 417);
            SeasonsView.TabIndex = 0;
            // 
            // TravelsPage
            // 
            TravelsPage.Controls.Add(TravelsView);
            TravelsPage.Location = new Point(4, 24);
            TravelsPage.Name = "TravelsPage";
            TravelsPage.Size = new Size(791, 417);
            TravelsPage.TabIndex = 4;
            TravelsPage.Text = "Путёвки";
            TravelsPage.UseVisualStyleBackColor = true;
            // 
            // TravelsView
            // 
            TravelsView.AllowUserToAddRows = false;
            TravelsView.AllowUserToDeleteRows = false;
            TravelsView.AllowUserToOrderColumns = true;
            TravelsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TravelsView.Dock = DockStyle.Fill;
            TravelsView.Location = new Point(0, 0);
            TravelsView.Name = "TravelsView";
            TravelsView.ReadOnly = true;
            TravelsView.RowTemplate.Height = 25;
            TravelsView.Size = new Size(791, 417);
            TravelsView.TabIndex = 0;
            // 
            // PaymentsPage
            // 
            PaymentsPage.Controls.Add(PaymentsView);
            PaymentsPage.Location = new Point(4, 24);
            PaymentsPage.Name = "PaymentsPage";
            PaymentsPage.Size = new Size(791, 417);
            PaymentsPage.TabIndex = 5;
            PaymentsPage.Text = "Оплаты";
            PaymentsPage.UseVisualStyleBackColor = true;
            // 
            // PaymentsView
            // 
            PaymentsView.AllowUserToAddRows = false;
            PaymentsView.AllowUserToDeleteRows = false;
            PaymentsView.AllowUserToOrderColumns = true;
            PaymentsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentsView.Dock = DockStyle.Fill;
            PaymentsView.Location = new Point(0, 0);
            PaymentsView.Name = "PaymentsView";
            PaymentsView.ReadOnly = true;
            PaymentsView.RowTemplate.Height = 25;
            PaymentsView.Size = new Size(791, 417);
            PaymentsView.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            TouristsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TouristsView).EndInit();
            ToursPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ToursView).EndInit();
            SeasonsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SeasonsView).EndInit();
            TravelsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TravelsView).EndInit();
            PaymentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PaymentsView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TouristsPage;
        private TabPage TouristsInfoPage;
        private DataGridView dataGridView2;
        private TabPage ToursPage;
        private DataGridView ToursView;
        private TabPage SeasonsPage;
        private DataGridView SeasonsView;
        private TabPage TravelsPage;
        private DataGridView TravelsView;
        private TabPage PaymentsPage;
        private DataGridView PaymentsView;
        public DataGridView TouristsView;
    }
}