namespace BankCard
{
    partial class Cards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.buttonCheck = new System.Windows.Forms.Button();
            this.NumberCard = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.PanelValid = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelValid.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(163)))), ((int)(((byte)(120)))));
            this.buttonCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.buttonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(221)))), ((int)(((byte)(177)))));
            this.buttonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new System.Drawing.Point(112, 116);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(157, 42);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Проверка";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // NumberCard
            // 
            this.NumberCard.Location = new System.Drawing.Point(76, 75);
            this.NumberCard.Multiline = true;
            this.NumberCard.Name = "NumberCard";
            this.NumberCard.Size = new System.Drawing.Size(240, 25);
            this.NumberCard.TabIndex = 1;
            this.NumberCard.Enter += new System.EventHandler(this.NumberCard_Enter);
            this.NumberCard.Leave += new System.EventHandler(this.NumberCard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAdd.Location = new System.Drawing.Point(130, 174);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(122, 13);
            this.labelAdd.TabIndex = 4;
            this.labelAdd.Text = "Добавить новую карту";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // PanelValid
            // 
            this.PanelValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.PanelValid.Controls.Add(this.CloseLabel);
            this.PanelValid.Controls.Add(this.label1);
            this.PanelValid.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelValid.Location = new System.Drawing.Point(0, 0);
            this.PanelValid.Name = "PanelValid";
            this.PanelValid.Size = new System.Drawing.Size(333, 54);
            this.PanelValid.TabIndex = 6;
            this.PanelValid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelValid_MouseDown);
            this.PanelValid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelValid_MouseMove);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseLabel.Location = new System.Drawing.Point(314, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(16, 18);
            this.CloseLabel.TabIndex = 7;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проверка карты";
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(333, 196);
            this.Controls.Add(this.PanelValid);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NumberCard);
            this.Controls.Add(this.buttonCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelValid.ResumeLayout(false);
            this.PanelValid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox NumberCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Panel PanelValid;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label label1;
    }
}

