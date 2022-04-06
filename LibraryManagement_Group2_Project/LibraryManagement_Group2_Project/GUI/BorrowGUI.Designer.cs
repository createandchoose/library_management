﻿namespace LibraryManagement_Group2_Project.GUI
{
    partial class BorrowGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.dtpBorrowed = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCopyNumber = new System.Windows.Forms.TextBox();
            this.btnCheckCondition = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numBorrowedBooks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(79, 36);
            this.txtMemberCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(116, 20);
            this.txtMemberCode.TabIndex = 2;
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.White;
            this.btnCheckMember.Location = new System.Drawing.Point(7, 117);
            this.btnCheckMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(188, 24);
            this.btnCheckMember.TabIndex = 3;
            this.btnCheckMember.Text = "Проверить";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Enabled = false;
            this.txtMemberName.Location = new System.Drawing.Point(79, 59);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(116, 20);
            this.txtMemberName.TabIndex = 4;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(200, 36);
            this.dgvBorrowedBooks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersWidth = 51;
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(434, 233);
            this.dgvBorrowedBooks.TabIndex = 5;
            // 
            // dtpBorrowed
            // 
            this.dtpBorrowed.Location = new System.Drawing.Point(136, 59);
            this.dtpBorrowed.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBorrowed.Name = "dtpBorrowed";
            this.dtpBorrowed.Size = new System.Drawing.Size(119, 20);
            this.dtpBorrowed.TabIndex = 6;
            // 
            // dtpDue
            // 
            this.dtpDue.Location = new System.Drawing.Point(350, 59);
            this.dtpDue.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(115, 20);
            this.dtpDue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер копии:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Заимствованная дата:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок погашения:";
            // 
            // txtCopyNumber
            // 
            this.txtCopyNumber.Enabled = false;
            this.txtCopyNumber.Location = new System.Drawing.Point(92, 25);
            this.txtCopyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopyNumber.Name = "txtCopyNumber";
            this.txtCopyNumber.Size = new System.Drawing.Size(149, 20);
            this.txtCopyNumber.TabIndex = 11;
            // 
            // btnCheckCondition
            // 
            this.btnCheckCondition.BackColor = System.Drawing.Color.White;
            this.btnCheckCondition.Enabled = false;
            this.btnCheckCondition.Location = new System.Drawing.Point(260, 23);
            this.btnCheckCondition.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckCondition.Name = "btnCheckCondition";
            this.btnCheckCondition.Size = new System.Drawing.Size(202, 24);
            this.btnCheckCondition.TabIndex = 12;
            this.btnCheckCondition.Text = "Проверьте наличие";
            this.btnCheckCondition.UseVisualStyleBackColor = false;
            this.btnCheckCondition.Click += new System.EventHandler(this.btnCheckCondition_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.White;
            this.btnBorrow.Enabled = false;
            this.btnBorrow.Location = new System.Drawing.Point(478, 55);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(155, 28);
            this.btnBorrow.TabIndex = 13;
            this.btnBorrow.Text = "Одолжить";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество заимствованных книг:";
            // 
            // numBorrowedBooks
            // 
            this.numBorrowedBooks.AutoSize = true;
            this.numBorrowedBooks.Location = new System.Drawing.Point(385, 15);
            this.numBorrowedBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numBorrowedBooks.Name = "numBorrowedBooks";
            this.numBorrowedBooks.Size = new System.Drawing.Size(13, 13);
            this.numBorrowedBooks.TabIndex = 15;
            this.numBorrowedBooks.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dgvBorrowedBooks);
            this.groupBox1.Controls.Add(this.numBorrowedBooks);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMemberCode);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.btnCheckMember);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(641, 273);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проверить пользователя";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(79, 86);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Эл.Почта:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCheckCondition);
            this.groupBox2.Controls.Add(this.btnBorrow);
            this.groupBox2.Controls.Add(this.txtCopyNumber);
            this.groupBox2.Controls.Add(this.dtpDue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpBorrowed);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(641, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Одолжить";
            // 
            // BorrowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowGUI";
            this.Text = "Одолжить Книгу";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.DateTimePicker dtpBorrowed;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCopyNumber;
        private System.Windows.Forms.Button btnCheckCondition;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numBorrowedBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}