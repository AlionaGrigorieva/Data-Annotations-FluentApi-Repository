
namespace HW4
{
    partial class SBForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SageCANCELButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SageNameTextBox = new System.Windows.Forms.TextBox();
            this.SageOKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(345, 164);
            this.dataGridView1.TabIndex = 13;
            // 
            // SageCANCELButton
            // 
            this.SageCANCELButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SageCANCELButton.Location = new System.Drawing.Point(374, 127);
            this.SageCANCELButton.Name = "SageCANCELButton";
            this.SageCANCELButton.Size = new System.Drawing.Size(58, 24);
            this.SageCANCELButton.TabIndex = 12;
            this.SageCANCELButton.Text = "CANCEL";
            this.SageCANCELButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // SageNameTextBox
            // 
            this.SageNameTextBox.Location = new System.Drawing.Point(354, 71);
            this.SageNameTextBox.Name = "SageNameTextBox";
            this.SageNameTextBox.Size = new System.Drawing.Size(95, 20);
            this.SageNameTextBox.TabIndex = 10;
            // 
            // SageOKButton
            // 
            this.SageOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SageOKButton.Location = new System.Drawing.Point(374, 97);
            this.SageOKButton.Name = "SageOKButton";
            this.SageOKButton.Size = new System.Drawing.Size(58, 24);
            this.SageOKButton.TabIndex = 9;
            this.SageOKButton.Text = "OK";
            this.SageOKButton.UseVisualStyleBackColor = true;
            // 
            // SageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 178);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SageCANCELButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SageNameTextBox);
            this.Controls.Add(this.SageOKButton);
            this.Name = "SageForm";
            this.Text = "Sage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SageCANCELButton;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox SageNameTextBox;
        private System.Windows.Forms.Button SageOKButton;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
    }
}