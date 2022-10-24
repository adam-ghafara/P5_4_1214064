namespace P5_4_1214064
{
    partial class MessageBox
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
            this.btClose = new System.Windows.Forms.Button();
            this.rcbHasil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(168, 170);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "OK";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // rcbHasil
            // 
            this.rcbHasil.Location = new System.Drawing.Point(15, 12);
            this.rcbHasil.Name = "rcbHasil";
            this.rcbHasil.Size = new System.Drawing.Size(381, 149);
            this.rcbHasil.TabIndex = 1;
            this.rcbHasil.Text = "";
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 205);
            this.Controls.Add(this.rcbHasil);
            this.Controls.Add(this.btClose);
            this.Name = "MessageBox";
            this.Text = "Peringatan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.RichTextBox rcbHasil;
    }
}