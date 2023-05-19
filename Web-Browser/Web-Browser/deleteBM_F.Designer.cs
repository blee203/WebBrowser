namespace Web_Browser
{
    partial class deleteBM_F
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
            this.label1 = new System.Windows.Forms.Label();
            this.BMName_TBx = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteAllBMButton = new System.Windows.Forms.Button();
            this.clearBMToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.findBM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BMURL_TBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.URLList = new System.Windows.Forms.RichTextBox();
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
            this.BMName_TBx.Size = new System.Drawing.Size(626, 22);
            this.BMName_TBx.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 400);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 38);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(357, 400);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 38);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteAllBMButton
            // 
            this.deleteAllBMButton.Location = new System.Drawing.Point(487, 400);
            this.deleteAllBMButton.Name = "deleteAllBMButton";
            this.deleteAllBMButton.Size = new System.Drawing.Size(151, 38);
            this.deleteAllBMButton.TabIndex = 4;
            this.deleteAllBMButton.Text = "Clear bookmarks";
            this.clearBMToolTip.SetToolTip(this.deleteAllBMButton, "Delete all bookmarks");
            this.deleteAllBMButton.UseVisualStyleBackColor = true;
            this.deleteAllBMButton.Click += new System.EventHandler(this.deleteAllBMButton_Click);
            // 
            // findBM
            // 
            this.findBM.Location = new System.Drawing.Point(12, 400);
            this.findBM.Name = "findBM";
            this.findBM.Size = new System.Drawing.Size(215, 38);
            this.findBM.TabIndex = 5;
            this.findBM.Text = "Find bookmarks with this name";
            this.findBM.UseVisualStyleBackColor = true;
            this.findBM.Click += new System.EventHandler(this.findBM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL of the bookmark that need to delete";
            this.label2.Visible = false;
            // 
            // BMURL_TBx
            // 
            this.BMURL_TBx.Location = new System.Drawing.Point(12, 72);
            this.BMURL_TBx.Name = "BMURL_TBx";
            this.BMURL_TBx.Size = new System.Drawing.Size(626, 22);
            this.BMURL_TBx.TabIndex = 7;
            this.BMURL_TBx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "URLs of bookmarks have the name";
            this.label3.Visible = false;
            // 
            // URLList
            // 
            this.URLList.AutoWordSelection = true;
            this.URLList.DetectUrls = false;
            this.URLList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.URLList.Location = new System.Drawing.Point(14, 123);
            this.URLList.Name = "URLList";
            this.URLList.ReadOnly = true;
            this.URLList.Size = new System.Drawing.Size(624, 271);
            this.URLList.TabIndex = 9;
            this.URLList.Text = "";
            this.URLList.Visible = false;
            // 
            // deleteBM_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.URLList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BMURL_TBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findBM);
            this.Controls.Add(this.deleteAllBMButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.BMName_TBx);
            this.Controls.Add(this.label1);
            this.Name = "deleteBM_F";
            this.Text = "Delete bookmark";
            this.Load += new System.EventHandler(this.deleteBM_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BMName_TBx;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteAllBMButton;
        private System.Windows.Forms.ToolTip clearBMToolTip;
        private System.Windows.Forms.Button findBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BMURL_TBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox URLList;
    }
}