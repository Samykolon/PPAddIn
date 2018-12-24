namespace SimpleWorshipSlides
{
    partial class NewSongUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSongText = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.TBTexter = new System.Windows.Forms.TextBox();
            this.TBMusic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Songtitle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Music by:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Songtext:";
            // 
            // TBSongText
            // 
            this.TBSongText.AcceptsReturn = true;
            this.TBSongText.AcceptsTab = true;
            this.TBSongText.Location = new System.Drawing.Point(16, 121);
            this.TBSongText.Multiline = true;
            this.TBSongText.Name = "TBSongText";
            this.TBSongText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBSongText.Size = new System.Drawing.Size(499, 474);
            this.TBSongText.TabIndex = 4;
            // 
            // BAdd
            // 
            this.BAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAdd.Location = new System.Drawing.Point(12, 601);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(247, 23);
            this.BAdd.TabIndex = 5;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            // 
            // BCancel
            // 
            this.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancel.Location = new System.Drawing.Point(269, 601);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(245, 23);
            this.BCancel.TabIndex = 6;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            // 
            // TBTitle
            // 
            this.TBTitle.Location = new System.Drawing.Point(87, 13);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(428, 20);
            this.TBTitle.TabIndex = 7;
            // 
            // TBTexter
            // 
            this.TBTexter.Location = new System.Drawing.Point(87, 40);
            this.TBTexter.Name = "TBTexter";
            this.TBTexter.Size = new System.Drawing.Size(428, 20);
            this.TBTexter.TabIndex = 8;
            // 
            // TBMusic
            // 
            this.TBMusic.Location = new System.Drawing.Point(87, 67);
            this.TBMusic.Name = "TBMusic";
            this.TBMusic.Size = new System.Drawing.Size(428, 20);
            this.TBMusic.TabIndex = 9;
            // 
            // NewSongUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 636);
            this.Controls.Add(this.TBMusic);
            this.Controls.Add(this.TBTexter);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBSongText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewSongUI";
            this.ShowIcon = false;
            this.Text = "Add New Song";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSongUI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSongText;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.TextBox TBTitle;
        private System.Windows.Forms.TextBox TBTexter;
        private System.Windows.Forms.TextBox TBMusic;
    }
}