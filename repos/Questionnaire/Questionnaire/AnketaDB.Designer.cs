namespace Questionnaire
{
    partial class AnketaDB
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anketaDataSet = new Questionnaire.AnketaDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Questionnaire.AnketaDataSetTableAdapters.StaffTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.опытРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объёмЗарплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водительскоеУдостоверениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияПравDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предпочитаемыйГрафикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.резюмеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.опытРаботыDataGridViewTextBoxColumn,
            this.объёмЗарплатыDataGridViewTextBoxColumn,
            this.наличиеАвтоDataGridViewTextBoxColumn,
            this.водительскоеУдостоверениеDataGridViewTextBoxColumn,
            this.категорияПравDataGridViewTextBoxColumn,
            this.предпочитаемыйГрафикDataGridViewTextBoxColumn,
            this.резюмеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // anketaDataSet
            // 
            this.anketaDataSet.DataSetName = "AnketaDataSet";
            this.anketaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.anketaDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            // 
            // опытРаботыDataGridViewTextBoxColumn
            // 
            this.опытРаботыDataGridViewTextBoxColumn.DataPropertyName = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.Name = "опытРаботыDataGridViewTextBoxColumn";
            // 
            // объёмЗарплатыDataGridViewTextBoxColumn
            // 
            this.объёмЗарплатыDataGridViewTextBoxColumn.DataPropertyName = "Объём зарплаты";
            this.объёмЗарплатыDataGridViewTextBoxColumn.HeaderText = "Объём зарплаты";
            this.объёмЗарплатыDataGridViewTextBoxColumn.Name = "объёмЗарплатыDataGridViewTextBoxColumn";
            // 
            // наличиеАвтоDataGridViewTextBoxColumn
            // 
            this.наличиеАвтоDataGridViewTextBoxColumn.DataPropertyName = "Наличие авто";
            this.наличиеАвтоDataGridViewTextBoxColumn.HeaderText = "Наличие авто";
            this.наличиеАвтоDataGridViewTextBoxColumn.Name = "наличиеАвтоDataGridViewTextBoxColumn";
            // 
            // водительскоеУдостоверениеDataGridViewTextBoxColumn
            // 
            this.водительскоеУдостоверениеDataGridViewTextBoxColumn.DataPropertyName = "Водительское удостоверение";
            this.водительскоеУдостоверениеDataGridViewTextBoxColumn.HeaderText = "Водительское удостоверение";
            this.водительскоеУдостоверениеDataGridViewTextBoxColumn.Name = "водительскоеУдостоверениеDataGridViewTextBoxColumn";
            // 
            // категорияПравDataGridViewTextBoxColumn
            // 
            this.категорияПравDataGridViewTextBoxColumn.DataPropertyName = "Категория прав";
            this.категорияПравDataGridViewTextBoxColumn.HeaderText = "Категория прав";
            this.категорияПравDataGridViewTextBoxColumn.Name = "категорияПравDataGridViewTextBoxColumn";
            // 
            // предпочитаемыйГрафикDataGridViewTextBoxColumn
            // 
            this.предпочитаемыйГрафикDataGridViewTextBoxColumn.DataPropertyName = "Предпочитаемый график";
            this.предпочитаемыйГрафикDataGridViewTextBoxColumn.HeaderText = "Предпочитаемый график";
            this.предпочитаемыйГрафикDataGridViewTextBoxColumn.Name = "предпочитаемыйГрафикDataGridViewTextBoxColumn";
            // 
            // резюмеDataGridViewTextBoxColumn
            // 
            this.резюмеDataGridViewTextBoxColumn.DataPropertyName = "Резюме";
            this.резюмеDataGridViewTextBoxColumn.HeaderText = "Резюме";
            this.резюмеDataGridViewTextBoxColumn.Name = "резюмеDataGridViewTextBoxColumn";
            // 
            // AnketaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 392);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnketaDB";
            this.Text = "AnketaDB";
            this.Load += new System.EventHandler(this.AnketaDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public AnketaDataSet anketaDataSet;
        public System.Windows.Forms.BindingSource staffBindingSource;
        public AnketaDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn опытРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объёмЗарплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn водительскоеУдостоверениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияПравDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предпочитаемыйГрафикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn резюмеDataGridViewTextBoxColumn;
    }
}