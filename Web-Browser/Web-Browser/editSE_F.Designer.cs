namespace Web_Browser
{
    partial class editSE_F
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
            this.SEName_TBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SEURL_TBx = new System.Windows.Forms.TextBox();
            this.editThisSEButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter search engine you want to edit";
            // 
            // SEName_TBx
            // 
            this.SEName_TBx.Location = new System.Drawing.Point(12, 28);
            this.SEName_TBx.Name = "SEName_TBx";
            this.SEName_TBx.Size = new System.Drawing.Size(658, 22);
            this.SEName_TBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            this.label2.Visible = false;
            // 
            // SEURL_TBx
            // 
            this.SEURL_TBx.Location = new System.Drawing.Point(15, 72);
            this.SEURL_TBx.Name = "SEURL_TBx";
            this.SEURL_TBx.Size = new System.Drawing.Size(655, 22);
            this.SEURL_TBx.TabIndex = 3;
            this.SEURL_TBx.Visible = false;
            // 
            // editThisSEButton
            // 
            this.editThisSEButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editThisSEButton.Location = new System.Drawing.Point(12, 100);
            this.editThisSEButton.Name = "editThisSEButton";
            this.editThisSEButton.Size = new System.Drawing.Size(195, 38);
            this.editThisSEButton.TabIndex = 4;
            this.editThisSEButton.Text = "Edit this search engine";
            this.editThisSEButton.UseVisualStyleBackColor = true;
            this.editThisSEButton.Click += new System.EventHandler(this.editThisSEButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(367, 100);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 38);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditButton.Location = new System.Drawing.Point(515, 100);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(155, 38);
            this.saveEditButton.TabIndex = 6;
            this.saveEditButton.Text = "Save";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Visible = false;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // editSE_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editThisSEButton);
            this.Controls.Add(this.SEURL_TBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SEName_TBx);
            this.Controls.Add(this.label1);
            this.Name = "editSE_F";
            this.Text = "Edit search engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SEName_TBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SEURL_TBx;
        private System.Windows.Forms.Button editThisSEButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveEditButton;
    }
}