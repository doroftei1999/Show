
namespace Show_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nrSeasonsLbl = new System.Windows.Forms.Label();
            this.nrEpisodesLbl = new System.Windows.Forms.Label();
            this.reviewLbl = new System.Windows.Forms.Label();
            this.nrSeasonsTxt = new System.Windows.Forms.TextBox();
            this.nrEpisodesTxt = new System.Windows.Forms.TextBox();
            this.reviewTxt = new System.Windows.Forms.TextBox();
            this.Comedie = new System.Windows.Forms.RadioButton();
            this.genreLbl = new System.Windows.Forms.Label();
            this.Drama = new System.Windows.Forms.RadioButton();
            this.Horror = new System.Windows.Forms.RadioButton();
            this.Thriller = new System.Windows.Forms.RadioButton();
            this.Aventura = new System.Windows.Forms.RadioButton();
            this.SF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddShowBtn = new System.Windows.Forms.Button();
            this.ongoingLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ongoingFalse = new System.Windows.Forms.RadioButton();
            this.ongoingTrue = new System.Windows.Forms.RadioButton();
            this.ShowsTxt = new System.Windows.Forms.RichTextBox();
            this.DisplayShowsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(277, 56);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(125, 25);
            this.nameTxt.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLbl.Location = new System.Drawing.Point(27, 56);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(76, 28);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Nume";
            this.nameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // nrSeasonsLbl
            // 
            this.nrSeasonsLbl.AutoSize = true;
            this.nrSeasonsLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrSeasonsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nrSeasonsLbl.Location = new System.Drawing.Point(27, 102);
            this.nrSeasonsLbl.Name = "nrSeasonsLbl";
            this.nrSeasonsLbl.Size = new System.Drawing.Size(226, 28);
            this.nrSeasonsLbl.TabIndex = 2;
            this.nrSeasonsLbl.Text = "Numarul de sezoane";
            // 
            // nrEpisodesLbl
            // 
            this.nrEpisodesLbl.AutoSize = true;
            this.nrEpisodesLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrEpisodesLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nrEpisodesLbl.Location = new System.Drawing.Point(27, 151);
            this.nrEpisodesLbl.Name = "nrEpisodesLbl";
            this.nrEpisodesLbl.Size = new System.Drawing.Size(236, 28);
            this.nrEpisodesLbl.TabIndex = 3;
            this.nrEpisodesLbl.Text = "Numarul de episoade";
            // 
            // reviewLbl
            // 
            this.reviewLbl.AutoSize = true;
            this.reviewLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reviewLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reviewLbl.Location = new System.Drawing.Point(27, 193);
            this.reviewLbl.Name = "reviewLbl";
            this.reviewLbl.Size = new System.Drawing.Size(140, 28);
            this.reviewLbl.TabIndex = 4;
            this.reviewLbl.Text = "Nota review";
            // 
            // nrSeasonsTxt
            // 
            this.nrSeasonsTxt.Location = new System.Drawing.Point(277, 107);
            this.nrSeasonsTxt.Name = "nrSeasonsTxt";
            this.nrSeasonsTxt.Size = new System.Drawing.Size(125, 25);
            this.nrSeasonsTxt.TabIndex = 5;
            // 
            // nrEpisodesTxt
            // 
            this.nrEpisodesTxt.Location = new System.Drawing.Point(277, 154);
            this.nrEpisodesTxt.Name = "nrEpisodesTxt";
            this.nrEpisodesTxt.Size = new System.Drawing.Size(125, 25);
            this.nrEpisodesTxt.TabIndex = 6;
            // 
            // reviewTxt
            // 
            this.reviewTxt.Location = new System.Drawing.Point(277, 198);
            this.reviewTxt.Name = "reviewTxt";
            this.reviewTxt.Size = new System.Drawing.Size(125, 25);
            this.reviewTxt.TabIndex = 7;
            // 
            // Comedie
            // 
            this.Comedie.AutoSize = true;
            this.Comedie.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comedie.Location = new System.Drawing.Point(6, 24);
            this.Comedie.Name = "Comedie";
            this.Comedie.Size = new System.Drawing.Size(125, 32);
            this.Comedie.TabIndex = 8;
            this.Comedie.TabStop = true;
            this.Comedie.Text = "Comedie";
            this.Comedie.UseVisualStyleBackColor = true;
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.genreLbl.Location = new System.Drawing.Point(27, 301);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(169, 28);
            this.genreLbl.TabIndex = 9;
            this.genreLbl.Text = "Alegeti un gen:";
            // 
            // Drama
            // 
            this.Drama.AutoSize = true;
            this.Drama.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Drama.Location = new System.Drawing.Point(6, 62);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(104, 32);
            this.Drama.TabIndex = 10;
            this.Drama.TabStop = true;
            this.Drama.Text = "Drama";
            this.Drama.UseVisualStyleBackColor = true;
            // 
            // Horror
            // 
            this.Horror.AutoSize = true;
            this.Horror.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Horror.Location = new System.Drawing.Point(6, 100);
            this.Horror.Name = "Horror";
            this.Horror.Size = new System.Drawing.Size(105, 32);
            this.Horror.TabIndex = 11;
            this.Horror.TabStop = true;
            this.Horror.Text = "Horror";
            this.Horror.UseVisualStyleBackColor = true;
            // 
            // Thriller
            // 
            this.Thriller.AutoSize = true;
            this.Thriller.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thriller.Location = new System.Drawing.Point(6, 138);
            this.Thriller.Name = "Thriller";
            this.Thriller.Size = new System.Drawing.Size(110, 32);
            this.Thriller.TabIndex = 12;
            this.Thriller.TabStop = true;
            this.Thriller.Text = "Thriller";
            this.Thriller.UseVisualStyleBackColor = true;
            // 
            // Aventura
            // 
            this.Aventura.AutoSize = true;
            this.Aventura.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aventura.Location = new System.Drawing.Point(6, 171);
            this.Aventura.Name = "Aventura";
            this.Aventura.Size = new System.Drawing.Size(131, 32);
            this.Aventura.TabIndex = 13;
            this.Aventura.TabStop = true;
            this.Aventura.Text = "Aventura";
            this.Aventura.UseVisualStyleBackColor = true;
            // 
            // SF
            // 
            this.SF.AutoSize = true;
            this.SF.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SF.Location = new System.Drawing.Point(6, 209);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(58, 32);
            this.SF.TabIndex = 14;
            this.SF.TabStop = true;
            this.SF.Text = "SF";
            this.SF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Comedie);
            this.groupBox1.Controls.Add(this.SF);
            this.groupBox1.Controls.Add(this.Drama);
            this.groupBox1.Controls.Add(this.Aventura);
            this.groupBox1.Controls.Add(this.Horror);
            this.groupBox1.Controls.Add(this.Thriller);
            this.groupBox1.Location = new System.Drawing.Point(277, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 247);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genuri";
            // 
            // AddShowBtn
            // 
            this.AddShowBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddShowBtn.Location = new System.Drawing.Point(435, 56);
            this.AddShowBtn.Name = "AddShowBtn";
            this.AddShowBtn.Size = new System.Drawing.Size(167, 59);
            this.AddShowBtn.TabIndex = 16;
            this.AddShowBtn.Text = "Adauga serial";
            this.AddShowBtn.UseVisualStyleBackColor = true;
            this.AddShowBtn.Click += new System.EventHandler(this.ShowAdd_Click);
            // 
            // ongoingLbl
            // 
            this.ongoingLbl.AutoSize = true;
            this.ongoingLbl.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ongoingLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ongoingLbl.Location = new System.Drawing.Point(27, 234);
            this.ongoingLbl.Name = "ongoingLbl";
            this.ongoingLbl.Size = new System.Drawing.Size(110, 28);
            this.ongoingLbl.TabIndex = 17;
            this.ongoingLbl.Text = "On-going";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ongoingFalse);
            this.groupBox2.Controls.Add(this.ongoingTrue);
            this.groupBox2.Location = new System.Drawing.Point(277, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 50);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "On-going";
            // 
            // ongoingFalse
            // 
            this.ongoingFalse.AutoSize = true;
            this.ongoingFalse.Location = new System.Drawing.Point(60, 24);
            this.ongoingFalse.Name = "ongoingFalse";
            this.ongoingFalse.Size = new System.Drawing.Size(47, 21);
            this.ongoingFalse.TabIndex = 19;
            this.ongoingFalse.TabStop = true;
            this.ongoingFalse.Text = "Nu";
            this.ongoingFalse.UseVisualStyleBackColor = true;
            // 
            // ongoingTrue
            // 
            this.ongoingTrue.AutoSize = true;
            this.ongoingTrue.Location = new System.Drawing.Point(6, 23);
            this.ongoingTrue.Name = "ongoingTrue";
            this.ongoingTrue.Size = new System.Drawing.Size(48, 21);
            this.ongoingTrue.TabIndex = 19;
            this.ongoingTrue.TabStop = true;
            this.ongoingTrue.Text = "Da";
            this.ongoingTrue.UseVisualStyleBackColor = true;
            // 
            // ShowsTxt
            // 
            this.ShowsTxt.Location = new System.Drawing.Point(728, 56);
            this.ShowsTxt.Name = "ShowsTxt";
            this.ShowsTxt.Size = new System.Drawing.Size(627, 448);
            this.ShowsTxt.TabIndex = 19;
            this.ShowsTxt.Text = "";
            this.ShowsTxt.TextChanged += new System.EventHandler(this.ShowsTxt_TextChanged);
            // 
            // DisplayShowsBtn
            // 
            this.DisplayShowsBtn.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayShowsBtn.Location = new System.Drawing.Point(435, 151);
            this.DisplayShowsBtn.Name = "DisplayShowsBtn";
            this.DisplayShowsBtn.Size = new System.Drawing.Size(177, 59);
            this.DisplayShowsBtn.TabIndex = 20;
            this.DisplayShowsBtn.Text = "Afisare seriale";
            this.DisplayShowsBtn.UseVisualStyleBackColor = true;
            this.DisplayShowsBtn.Click += new System.EventHandler(this.DisplayShows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 888);
            this.Controls.Add(this.DisplayShowsBtn);
            this.Controls.Add(this.ShowsTxt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ongoingLbl);
            this.Controls.Add(this.AddShowBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.reviewTxt);
            this.Controls.Add(this.nrEpisodesTxt);
            this.Controls.Add(this.nrSeasonsTxt);
            this.Controls.Add(this.reviewLbl);
            this.Controls.Add(this.nrEpisodesLbl);
            this.Controls.Add(this.nrSeasonsLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.Name = "Form1";
            this.Text = "Gen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label nrSeasonsLbl;
        private System.Windows.Forms.Label nrEpisodesLbl;
        private System.Windows.Forms.Label reviewLbl;
        private System.Windows.Forms.TextBox nrSeasonsTxt;
        private System.Windows.Forms.TextBox nrEpisodesTxt;
        private System.Windows.Forms.TextBox reviewTxt;
        private System.Windows.Forms.RadioButton Comedie;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.RadioButton Drama;
        private System.Windows.Forms.RadioButton Horror;
        private System.Windows.Forms.RadioButton Thriller;
        private System.Windows.Forms.RadioButton Aventura;
        private System.Windows.Forms.RadioButton SF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddShowBtn;
        private System.Windows.Forms.Label ongoingLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ongoingFalse;
        private System.Windows.Forms.RadioButton ongoingTrue;
        private System.Windows.Forms.RichTextBox ShowsTxt;
        private System.Windows.Forms.Button DisplayShowsBtn;
    }
}

