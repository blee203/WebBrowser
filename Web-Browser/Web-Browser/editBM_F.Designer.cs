namespace Web_Browser
{
    partial class editBM_F
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
            this.BMName_TBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BMURL_TBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.URLList = new System.Windows.Forms.RichTextBox();
            this.findBMButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editThisBMButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookmark\'s name";
            // 
            // BMName_TBx
            // 
            this.BMName_TBx.Location = new System.Drawing.Point(12, 28);
            this.BMName_TBx.Name = "BMName_TBx";
            this.BMName_TBx.Size = new System.Drawing.Size(653, 22);
            this.BMName_TBx.TabIndex = 1;
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
            // BMURL_TBx
            // 
            this.BMURL_TBx.Location = new System.Drawing.Point(12, 72);
            this.BMURL_TBx.Name = "BMURL_TBx";
            this.BMURL_TBx.Size = new System.Drawing.Size(653, 22);
            this.BMURL_TBx.TabIndex = 4;
            this.BMURL_TBx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "URLs of bookmarks with the name";
            this.label3.Visible = false;
            // 
            // URLList
            // 
            this.URLList.Location = new System.Drawing.Point(12, 116);
            this.URLList.Name = "URLList";
            this.URLList.ReadOnly = true;
            this.URLList.Size = new System.Drawing.Size(653, 275);
            this.URLList.TabIndex = 6;
            this.URLList.Text = "";
            this.URLList.Visible = false;
            // 
            // findBMButton
            // 
            this.findBMButton.Location = new System.Drawing.Point(15, 397);
            this.findBMButton.Name = "findBMButton";
            this.findBMButton.Size = new System.Drawing.Size(220, 41);
            this.findBMButton.TabIndex = 7;
            this.findBMButton.Text = "Find bookmarks with this name";
            this.findBMButton.UseVisualStyleBackColor = true;
            this.findBMButton.Click += new System.EventHandler(this.findBMButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(448, 397);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 41);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // editThisBMButton
            // 
            this.editThisBMButton.AutoSize = true;
            this.editThisBMButton.Location = new System.Drawing.Point(241, 397);
            this.editThisBMButton.Name = "editThisBMButton";
            this.editThisBMButton.Size = new System.Drawing.Size(143, 41);
            this.editThisBMButton.TabIndex = 9;
            this.editThisBMButton.Text = "Edit this bookmark";
            this.editThisBMButton.UseVisualStyleBackColor = true;
            this.editThisBMButton.Visible = false;
            this.editThisBMButton.Click += new System.EventHandler(this.editThisBMButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(560, 397);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 41);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editBM_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editThisBMButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findBMButton);
            this.Controls.Add(this.URLList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BMURL_TBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BMName_TBx);
            this.Controls.Add(this.label1);
            this.Name = "editBM_F";
            this.Text = "Edit Bookmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BMName_TBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BMURL_TBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox URLList;
        private System.Windows.Forms.Button findBMButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editThisBMButton;
        private System.Windows.Forms.Button saveButton;
    }
}