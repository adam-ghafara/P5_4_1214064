namespace P5_4_1214064
{
    partial class MainForm
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
            this.Title = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.fillName = new System.Windows.Forms.TextBox();
            this.fillGender = new System.Windows.Forms.ComboBox();
            this.fillBirth = new System.Windows.Forms.DateTimePicker();
            this.gbclass = new System.Windows.Forms.GroupBox();
            this.cbKmp = new System.Windows.Forms.CheckBox();
            this.cbKdk = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbSax = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.gbSch = new System.Windows.Forms.GroupBox();
            this.Sch4 = new System.Windows.Forms.RadioButton();
            this.Sch3 = new System.Windows.Forms.RadioButton();
            this.Sch2 = new System.Windows.Forms.RadioButton();
            this.Sch1 = new System.Windows.Forms.RadioButton();
            this.btShow = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.gbclass.SuspendLayout();
            this.gbSch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(298, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Form Pendaftaran";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(243, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Nama";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(243, 90);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(100, 18);
            this.GenderLabel.TabIndex = 2;
            this.GenderLabel.Text = "Jenis Kelamin";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLabel.Location = new System.Drawing.Point(243, 118);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(96, 18);
            this.BirthLabel.TabIndex = 3;
            this.BirthLabel.Text = "Tanggal Lahir";
            // 
            // fillName
            // 
            this.fillName.Location = new System.Drawing.Point(378, 63);
            this.fillName.Name = "fillName";
            this.fillName.Size = new System.Drawing.Size(180, 20);
            this.fillName.TabIndex = 4;
            // 
            // fillGender
            // 
            this.fillGender.FormattingEnabled = true;
            this.fillGender.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.fillGender.Location = new System.Drawing.Point(378, 90);
            this.fillGender.Name = "fillGender";
            this.fillGender.Size = new System.Drawing.Size(180, 21);
            this.fillGender.TabIndex = 5;
            // 
            // fillBirth
            // 
            this.fillBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fillBirth.Location = new System.Drawing.Point(378, 118);
            this.fillBirth.Name = "fillBirth";
            this.fillBirth.Size = new System.Drawing.Size(180, 20);
            this.fillBirth.TabIndex = 6;
            this.fillBirth.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // gbclass
            // 
            this.gbclass.Controls.Add(this.cbKmp);
            this.gbclass.Controls.Add(this.cbKdk);
            this.gbclass.Controls.Add(this.cbVokal);
            this.gbclass.Controls.Add(this.cbDrum);
            this.gbclass.Controls.Add(this.cbPiano);
            this.gbclass.Controls.Add(this.cbSax);
            this.gbclass.Controls.Add(this.cbGitar);
            this.gbclass.Controls.Add(this.cbBiola);
            this.gbclass.Location = new System.Drawing.Point(48, 174);
            this.gbclass.Name = "gbclass";
            this.gbclass.Size = new System.Drawing.Size(330, 211);
            this.gbclass.TabIndex = 7;
            this.gbclass.TabStop = false;
            this.gbclass.Text = "Pilih Kelas";
            // 
            // cbKmp
            // 
            this.cbKmp.AutoSize = true;
            this.cbKmp.Location = new System.Drawing.Point(185, 168);
            this.cbKmp.Name = "cbKmp";
            this.cbKmp.Size = new System.Drawing.Size(73, 17);
            this.cbKmp.TabIndex = 10;
            this.cbKmp.Text = "Komposer";
            this.cbKmp.UseVisualStyleBackColor = true;
            // 
            // cbKdk
            // 
            this.cbKdk.AutoSize = true;
            this.cbKdk.Location = new System.Drawing.Point(48, 168);
            this.cbKdk.Name = "cbKdk";
            this.cbKdk.Size = new System.Drawing.Size(75, 17);
            this.cbKdk.TabIndex = 9;
            this.cbKdk.Text = "Konduktor";
            this.cbKdk.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(185, 128);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 5;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(185, 88);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(51, 17);
            this.cbDrum.TabIndex = 4;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(185, 48);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 3;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbSax
            // 
            this.cbSax.AutoSize = true;
            this.cbSax.Location = new System.Drawing.Point(48, 128);
            this.cbSax.Name = "cbSax";
            this.cbSax.Size = new System.Drawing.Size(80, 17);
            this.cbSax.TabIndex = 2;
            this.cbSax.Text = "Saxophone";
            this.cbSax.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(48, 88);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(48, 48);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // gbSch
            // 
            this.gbSch.Controls.Add(this.Sch4);
            this.gbSch.Controls.Add(this.Sch3);
            this.gbSch.Controls.Add(this.Sch2);
            this.gbSch.Controls.Add(this.Sch1);
            this.gbSch.Location = new System.Drawing.Point(422, 174);
            this.gbSch.Name = "gbSch";
            this.gbSch.Size = new System.Drawing.Size(330, 211);
            this.gbSch.TabIndex = 8;
            this.gbSch.TabStop = false;
            this.gbSch.Text = "Pilih Jadwal";
            // 
            // Sch4
            // 
            this.Sch4.AutoSize = true;
            this.Sch4.Location = new System.Drawing.Point(23, 167);
            this.Sch4.Name = "Sch4";
            this.Sch4.Size = new System.Drawing.Size(129, 17);
            this.Sch4.TabIndex = 3;
            this.Sch4.TabStop = true;
            this.Sch4.Text = "Minggu, 14.00 - 17.00";
            this.Sch4.UseVisualStyleBackColor = true;
            // 
            // Sch3
            // 
            this.Sch3.AutoSize = true;
            this.Sch3.Location = new System.Drawing.Point(23, 128);
            this.Sch3.Name = "Sch3";
            this.Sch3.Size = new System.Drawing.Size(169, 17);
            this.Sch3.TabIndex = 2;
            this.Sch3.TabStop = true;
            this.Sch3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.Sch3.UseVisualStyleBackColor = true;
            // 
            // Sch2
            // 
            this.Sch2.AutoSize = true;
            this.Sch2.Location = new System.Drawing.Point(23, 88);
            this.Sch2.Name = "Sch2";
            this.Sch2.Size = new System.Drawing.Size(169, 17);
            this.Sch2.TabIndex = 1;
            this.Sch2.TabStop = true;
            this.Sch2.Text = "Selasa && Kamis, 14.00 - 16.00 ";
            this.Sch2.UseVisualStyleBackColor = true;
            // 
            // Sch1
            // 
            this.Sch1.AutoSize = true;
            this.Sch1.Location = new System.Drawing.Point(23, 48);
            this.Sch1.Name = "Sch1";
            this.Sch1.Size = new System.Drawing.Size(162, 17);
            this.Sch1.TabIndex = 0;
            this.Sch1.TabStop = true;
            this.Sch1.Text = "Senin && Rabu, 14.00 - 16.00 ";
            this.Sch1.UseVisualStyleBackColor = true;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(303, 404);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(75, 23);
            this.btShow.TabIndex = 9;
            this.btShow.Text = "Tampilkan";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btDone
            // 
            this.btDone.Location = new System.Drawing.Point(422, 404);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(75, 23);
            this.btDone.TabIndex = 10;
            this.btDone.Text = "Selesai";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.gbSch);
            this.Controls.Add(this.gbclass);
            this.Controls.Add(this.fillBirth);
            this.Controls.Add(this.fillGender);
            this.Controls.Add(this.fillName);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Title);
            this.Name = "MainForm";
            this.Text = "Pendaftaran";
            this.gbclass.ResumeLayout(false);
            this.gbclass.PerformLayout();
            this.gbSch.ResumeLayout(false);
            this.gbSch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.TextBox fillName;
        private System.Windows.Forms.ComboBox fillGender;
        private System.Windows.Forms.DateTimePicker fillBirth;
        private System.Windows.Forms.GroupBox gbclass;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox gbSch;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbSax;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbKdk;
        private System.Windows.Forms.CheckBox cbKmp;
        private System.Windows.Forms.RadioButton Sch1;
        private System.Windows.Forms.RadioButton Sch4;
        private System.Windows.Forms.RadioButton Sch3;
        private System.Windows.Forms.RadioButton Sch2;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btDone;
    }
}

