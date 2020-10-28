namespace Video_Rental_Store
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new Video_Rental_Store.ClientDataSet();
            this.customerTableAdapter = new Video_Rental_Store.ClientDataSetTableAdapters.customerTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 58);
            this.panel1.TabIndex = 1;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLabel.Location = new System.Drawing.Point(854, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(17, 16);
            this.CloseLabel.TabIndex = 2;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(56, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(171, 226);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(292, 226);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.apartamentDataGridViewTextBoxColumn,
            this.uniqueCustomerIDDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.customerBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(847, 150);
            this.dataGridViewClient.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "house";
            this.houseDataGridViewTextBoxColumn.HeaderText = "house";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            // 
            // apartamentDataGridViewTextBoxColumn
            // 
            this.apartamentDataGridViewTextBoxColumn.DataPropertyName = "apartament";
            this.apartamentDataGridViewTextBoxColumn.HeaderText = "apartament";
            this.apartamentDataGridViewTextBoxColumn.Name = "apartamentDataGridViewTextBoxColumn";
            // 
            // uniqueCustomerIDDataGridViewTextBoxColumn
            // 
            this.uniqueCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "unique customer ID";
            this.uniqueCustomerIDDataGridViewTextBoxColumn.HeaderText = "unique customer ID";
            this.uniqueCustomerIDDataGridViewTextBoxColumn.Name = "uniqueCustomerIDDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.clientDataSet;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(871, 261);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.DataGridView dataGridViewClient;
        public ClientDataSet clientDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        public ClientDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueCustomerIDDataGridViewTextBoxColumn;
    }
}

