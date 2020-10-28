namespace BankCard
{
    partial class AddCards
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TypeCard = new System.Windows.Forms.TextBox();
            this.DigitCount = new System.Windows.Forms.TextBox();
            this.Digits = new System.Windows.Forms.TextBox();
            this.CardType = new System.Windows.Forms.Label();
            this.digitsCount = new System.Windows.Forms.Label();
            this.two_digit = new System.Windows.Forms.Label();
            this.labelInv = new System.Windows.Forms.Label();
            this.PanelRegistr = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRegistr.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(169)))));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(60)))), ((int)(((byte)(169)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(169)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(161, 174);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 31);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TypeCard
            // 
            this.TypeCard.Location = new System.Drawing.Point(161, 48);
            this.TypeCard.Name = "TypeCard";
            this.TypeCard.Size = new System.Drawing.Size(192, 20);
            this.TypeCard.TabIndex = 1;
            this.TypeCard.Enter += new System.EventHandler(this.TypeCard_Enter);
            this.TypeCard.Leave += new System.EventHandler(this.TypeCard_Leave);
            // 
            // DigitCount
            // 
            this.DigitCount.Location = new System.Drawing.Point(161, 92);
            this.DigitCount.Name = "DigitCount";
            this.DigitCount.Size = new System.Drawing.Size(192, 20);
            this.DigitCount.TabIndex = 2;
            this.DigitCount.Enter += new System.EventHandler(this.DigitCount_Enter);
            this.DigitCount.Leave += new System.EventHandler(this.DigitCount_Leave);
            // 
            // Digits
            // 
            this.Digits.Location = new System.Drawing.Point(161, 138);
            this.Digits.Name = "Digits";
            this.Digits.Size = new System.Drawing.Size(192, 20);
            this.Digits.TabIndex = 3;
            this.Digits.Enter += new System.EventHandler(this.Digits_Enter);
            this.Digits.Leave += new System.EventHandler(this.Digits_Leave);
            // 
            // CardType
            // 
            this.CardType.AutoSize = true;
            this.CardType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardType.ForeColor = System.Drawing.SystemColors.Control;
            this.CardType.Location = new System.Drawing.Point(12, 49);
            this.CardType.Name = "CardType";
            this.CardType.Size = new System.Drawing.Size(101, 19);
            this.CardType.TabIndex = 4;
            this.CardType.Text = "Тип карточки";
            // 
            // digitsCount
            // 
            this.digitsCount.AutoSize = true;
            this.digitsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digitsCount.ForeColor = System.Drawing.SystemColors.Control;
            this.digitsCount.Location = new System.Drawing.Point(12, 93);
            this.digitsCount.Name = "digitsCount";
            this.digitsCount.Size = new System.Drawing.Size(128, 19);
            this.digitsCount.TabIndex = 5;
            this.digitsCount.Text = "Количество цифр";
            // 
            // two_digit
            // 
            this.two_digit.AutoSize = true;
            this.two_digit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two_digit.ForeColor = System.Drawing.SystemColors.Control;
            this.two_digit.Location = new System.Drawing.Point(12, 139);
            this.two_digit.Name = "two_digit";
            this.two_digit.Size = new System.Drawing.Size(138, 19);
            this.two_digit.TabIndex = 6;
            this.two_digit.Text = "Первые две цифры";
            // 
            // labelInv
            // 
            this.labelInv.AutoSize = true;
            this.labelInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInv.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInv.Location = new System.Drawing.Point(198, 216);
            this.labelInv.Name = "labelInv";
            this.labelInv.Size = new System.Drawing.Size(91, 13);
            this.labelInv.TabIndex = 7;
            this.labelInv.Text = "Проверка карты";
            this.labelInv.Click += new System.EventHandler(this.labelInv_Click);
            // 
            // PanelRegistr
            // 
            this.PanelRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(17)))), ((int)(((byte)(80)))));
            this.PanelRegistr.Controls.Add(this.CloseLabel);
            this.PanelRegistr.Controls.Add(this.label1);
            this.PanelRegistr.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelRegistr.Location = new System.Drawing.Point(0, 0);
            this.PanelRegistr.Name = "PanelRegistr";
            this.PanelRegistr.Size = new System.Drawing.Size(412, 42);
            this.PanelRegistr.TabIndex = 8;
            this.PanelRegistr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelRegistr_MouseDown);
            this.PanelRegistr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelRegistr_MouseMove);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseLabel.Location = new System.Drawing.Point(393, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(16, 18);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "x";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление карты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(31)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(412, 238);
            this.Controls.Add(this.PanelRegistr);
            this.Controls.Add(this.labelInv);
            this.Controls.Add(this.two_digit);
            this.Controls.Add(this.digitsCount);
            this.Controls.Add(this.CardType);
            this.Controls.Add(this.Digits);
            this.Controls.Add(this.DigitCount);
            this.Controls.Add(this.TypeCard);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCards";
            this.PanelRegistr.ResumeLayout(false);
            this.PanelRegistr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox TypeCard;
        private System.Windows.Forms.TextBox DigitCount;
        private System.Windows.Forms.TextBox Digits;
        private System.Windows.Forms.Label CardType;
        private System.Windows.Forms.Label digitsCount;
        private System.Windows.Forms.Label two_digit;
        private System.Windows.Forms.Label labelInv;
        private System.Windows.Forms.Panel PanelRegistr;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label label1;
    }
}