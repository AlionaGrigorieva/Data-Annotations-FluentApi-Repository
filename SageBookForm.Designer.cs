
namespace HW4
{
    partial class SageBookForm
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
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SageListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SageBookCANCELButton = new System.Windows.Forms.Button();
            this.SageBookOKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Book:";
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.Location = new System.Drawing.Point(260, 33);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(218, 43);
            this.BooksListBox.TabIndex = 19;
            // 
            // SageListBox
            // 
            this.SageListBox.FormattingEnabled = true;
            this.SageListBox.Location = new System.Drawing.Point(12, 33);
            this.SageListBox.Name = "SageListBox";
            this.SageListBox.Size = new System.Drawing.Size(218, 43);
            this.SageListBox.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(466, 159);
            this.dataGridView1.TabIndex = 21;
            // 
            // SageBookCANCELButton
            // 
            this.SageBookCANCELButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SageBookCANCELButton.Location = new System.Drawing.Point(420, 275);
            this.SageBookCANCELButton.Name = "SageBookCANCELButton";
            this.SageBookCANCELButton.Size = new System.Drawing.Size(58, 24);
            this.SageBookCANCELButton.TabIndex = 23;
            this.SageBookCANCELButton.Text = "CANCEL";
            this.SageBookCANCELButton.UseVisualStyleBackColor = true;
            // 
            // SageBookOKButton
            // 
            this.SageBookOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SageBookOKButton.Location = new System.Drawing.Point(16, 275);
            this.SageBookOKButton.Name = "SageBookOKButton";
            this.SageBookOKButton.Size = new System.Drawing.Size(58, 24);
            this.SageBookOKButton.TabIndex = 22;
            this.SageBookOKButton.Text = "OK";
            this.SageBookOKButton.UseVisualStyleBackColor = true;
            // 
            // SageBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.SageBookCANCELButton);
            this.Controls.Add(this.SageBookOKButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SageListBox);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SageBookForm";
            this.Text = "SageBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.ListBox BooksListBox;
        protected internal System.Windows.Forms.ListBox SageListBox;
        private System.Windows.Forms.Button SageBookCANCELButton;
        private System.Windows.Forms.Button SageBookOKButton;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
    }
}