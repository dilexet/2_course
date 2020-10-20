namespace Video_Rental_Store
{
    partial class DVD
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
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDmovieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesDataSet = new Video_Rental_Store.MoviesDataSet();
            this.dVDmovieTableAdapter = new Video_Rental_Store.MoviesDataSetTableAdapters.DVDmovieTableAdapter();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDgamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesDataSet = new Video_Rental_Store.GamesDataSet();
            this.dVDgamesTableAdapter = new Video_Rental_Store.GamesDataSetTableAdapters.DVDgamesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SearchMovieButton = new System.Windows.Forms.Button();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.SearchGameButton = new System.Windows.Forms.Button();
            this.AddGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDmovieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDgamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AutoGenerateColumns = false;
            this.dataGridViewMovies.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridViewMovies.DataSource = this.dVDmovieBindingSource;
            this.dataGridViewMovies.Location = new System.Drawing.Point(-1, 38);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(445, 241);
            this.dataGridViewMovies.TabIndex = 9;
            this.dataGridViewMovies.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // dVDmovieBindingSource
            // 
            this.dVDmovieBindingSource.DataMember = "DVDmovie";
            this.dVDmovieBindingSource.DataSource = this.moviesDataSet;
            // 
            // moviesDataSet
            // 
            this.moviesDataSet.DataSetName = "MoviesDataSet";
            this.moviesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVDmovieTableAdapter
            // 
            this.dVDmovieTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.AutoGenerateColumns = false;
            this.dataGridViewGames.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn1,
            this.costDataGridViewTextBoxColumn1});
            this.dataGridViewGames.DataSource = this.dVDgamesBindingSource;
            this.dataGridViewGames.Location = new System.Drawing.Point(450, 38);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.Size = new System.Drawing.Size(447, 241);
            this.dataGridViewGames.TabIndex = 10;
            this.dataGridViewGames.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // numberDataGridViewTextBoxColumn1
            // 
            this.numberDataGridViewTextBoxColumn1.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn1.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn1.Name = "numberDataGridViewTextBoxColumn1";
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            // 
            // dVDgamesBindingSource
            // 
            this.dVDgamesBindingSource.DataMember = "DVDgames";
            this.dVDgamesBindingSource.DataSource = this.gamesDataSet;
            // 
            // gamesDataSet
            // 
            this.gamesDataSet.DataSetName = "GamesDataSet";
            this.gamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVDgamesTableAdapter
            // 
            this.dVDgamesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 32);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(598, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movies";
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseLabel.Location = new System.Drawing.Point(880, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(17, 16);
            this.CloseLabel.TabIndex = 9;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(413, 306);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchMovieButton
            // 
            this.SearchMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchMovieButton.Location = new System.Drawing.Point(226, 301);
            this.SearchMovieButton.Name = "SearchMovieButton";
            this.SearchMovieButton.Size = new System.Drawing.Size(75, 23);
            this.SearchMovieButton.TabIndex = 14;
            this.SearchMovieButton.Text = "Search";
            this.SearchMovieButton.UseVisualStyleBackColor = true;
            this.SearchMovieButton.Click += new System.EventHandler(this.SearchMovieButton_Click);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMovieButton.Location = new System.Drawing.Point(75, 301);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(75, 23);
            this.AddMovieButton.TabIndex = 13;
            this.AddMovieButton.Text = "Add";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // SearchGameButton
            // 
            this.SearchGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchGameButton.Location = new System.Drawing.Point(744, 301);
            this.SearchGameButton.Name = "SearchGameButton";
            this.SearchGameButton.Size = new System.Drawing.Size(75, 23);
            this.SearchGameButton.TabIndex = 16;
            this.SearchGameButton.Text = "Search";
            this.SearchGameButton.UseVisualStyleBackColor = true;
            this.SearchGameButton.Click += new System.EventHandler(this.SearchGameButton_Click);
            // 
            // AddGameButton
            // 
            this.AddGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGameButton.Location = new System.Drawing.Point(589, 301);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(75, 23);
            this.AddGameButton.TabIndex = 15;
            this.AddGameButton.Text = "Add";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // DVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(897, 341);
            this.Controls.Add(this.SearchGameButton);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.SearchMovieButton);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewGames);
            this.Controls.Add(this.dataGridViewMovies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD";
            this.Load += new System.EventHandler(this.DVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDmovieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDgamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridViewMovies;
        public MoviesDataSet moviesDataSet;
        private System.Windows.Forms.BindingSource dVDmovieBindingSource;
        public MoviesDataSetTableAdapters.DVDmovieTableAdapter dVDmovieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewGames;
        public GamesDataSet gamesDataSet;
        private System.Windows.Forms.BindingSource dVDgamesBindingSource;
        public GamesDataSetTableAdapters.DVDgamesTableAdapter dVDgamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SearchMovieButton;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchGameButton;
        private System.Windows.Forms.Button AddGameButton;
    }
}