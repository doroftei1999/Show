
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
            this.genreLbl = new System.Windows.Forms.Label();
            this.Genuri = new System.Windows.Forms.GroupBox();
            this.SF = new System.Windows.Forms.CheckBox();
            this.Thriller = new System.Windows.Forms.CheckBox();
            this.Aventura = new System.Windows.Forms.CheckBox();
            this.Horror = new System.Windows.Forms.CheckBox();
            this.Drama = new System.Windows.Forms.CheckBox();
            this.Comedie = new System.Windows.Forms.CheckBox();
            this.AddShowBtn = new System.Windows.Forms.Button();
            this.ongoingLbl = new System.Windows.Forms.Label();
            this.OnGoing = new System.Windows.Forms.GroupBox();
            this.ongoingFalse = new System.Windows.Forms.RadioButton();
            this.ongoingTrue = new System.Windows.Forms.RadioButton();
            this.ShowsTxt = new System.Windows.Forms.RichTextBox();
            this.DisplayShowsBtn = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridViewSeriale = new System.Windows.Forms.DataGridView();
            this.lstBoxSeriale = new System.Windows.Forms.ListBox();
            this.Genuri.SuspendLayout();
            this.OnGoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriale)).BeginInit();
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
            // Genuri
            // 
            this.Genuri.Controls.Add(this.SF);
            this.Genuri.Controls.Add(this.Thriller);
            this.Genuri.Controls.Add(this.Aventura);
            this.Genuri.Controls.Add(this.Horror);
            this.Genuri.Controls.Add(this.Drama);
            this.Genuri.Controls.Add(this.Comedie);
            this.Genuri.Location = new System.Drawing.Point(277, 301);
            this.Genuri.Name = "Genuri";
            this.Genuri.Size = new System.Drawing.Size(138, 247);
            this.Genuri.TabIndex = 15;
            this.Genuri.TabStop = false;
            this.Genuri.Text = "Genuri";
            // 
            // SF
            // 
            this.SF.AutoSize = true;
            this.SF.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SF.Location = new System.Drawing.Point(0, 209);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(59, 32);
            this.SF.TabIndex = 26;
            this.SF.Text = "SF";
            this.SF.UseVisualStyleBackColor = true;
            // 
            // Thriller
            // 
            this.Thriller.AutoSize = true;
            this.Thriller.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Thriller.Location = new System.Drawing.Point(0, 138);
            this.Thriller.Name = "Thriller";
            this.Thriller.Size = new System.Drawing.Size(111, 32);
            this.Thriller.TabIndex = 24;
            this.Thriller.Text = "Thriller";
            this.Thriller.UseVisualStyleBackColor = true;
            // 
            // Aventura
            // 
            this.Aventura.AutoSize = true;
            this.Aventura.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aventura.Location = new System.Drawing.Point(0, 176);
            this.Aventura.Name = "Aventura";
            this.Aventura.Size = new System.Drawing.Size(132, 32);
            this.Aventura.TabIndex = 25;
            this.Aventura.Text = "Aventura";
            this.Aventura.UseVisualStyleBackColor = true;
            // 
            // Horror
            // 
            this.Horror.AutoSize = true;
            this.Horror.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Horror.Location = new System.Drawing.Point(0, 100);
            this.Horror.Name = "Horror";
            this.Horror.Size = new System.Drawing.Size(106, 32);
            this.Horror.TabIndex = 23;
            this.Horror.Text = "Horror";
            this.Horror.UseVisualStyleBackColor = true;
            // 
            // Drama
            // 
            this.Drama.AutoSize = true;
            this.Drama.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Drama.Location = new System.Drawing.Point(0, 62);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(105, 32);
            this.Drama.TabIndex = 22;
            this.Drama.Text = "Drama";
            this.Drama.UseVisualStyleBackColor = true;
            // 
            // Comedie
            // 
            this.Comedie.AutoSize = true;
            this.Comedie.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Comedie.Location = new System.Drawing.Point(0, 24);
            this.Comedie.Name = "Comedie";
            this.Comedie.Size = new System.Drawing.Size(126, 32);
            this.Comedie.TabIndex = 21;
            this.Comedie.Text = "Comedie";
            this.Comedie.UseVisualStyleBackColor = true;
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
            // OnGoing
            // 
            this.OnGoing.Controls.Add(this.ongoingFalse);
            this.OnGoing.Controls.Add(this.ongoingTrue);
            this.OnGoing.Location = new System.Drawing.Point(277, 234);
            this.OnGoing.Name = "OnGoing";
            this.OnGoing.Size = new System.Drawing.Size(125, 50);
            this.OnGoing.TabIndex = 18;
            this.OnGoing.TabStop = false;
            this.OnGoing.Text = "On-going";
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
            this.ShowsTxt.Size = new System.Drawing.Size(466, 583);
            this.ShowsTxt.TabIndex = 19;
            this.ShowsTxt.Text = "";
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
            // Modify
            // 
            this.Modify.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Modify.Location = new System.Drawing.Point(435, 234);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(177, 66);
            this.Modify.TabIndex = 21;
            this.Modify.Text = "Modificare serial";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(435, 325);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(177, 66);
            this.Search.TabIndex = 22;
            this.Search.Text = "Cautare serial";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridViewSeriale
            // 
            this.dataGridViewSeriale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeriale.Location = new System.Drawing.Point(1218, 56);
            this.dataGridViewSeriale.Name = "dataGridViewSeriale";
            this.dataGridViewSeriale.RowHeadersWidth = 51;
            this.dataGridViewSeriale.RowTemplate.Height = 27;
            this.dataGridViewSeriale.Size = new System.Drawing.Size(551, 244);
            this.dataGridViewSeriale.TabIndex = 23;
            this.dataGridViewSeriale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeriale_CellContentClick);
            // 
            // lstBoxSeriale
            // 
            this.lstBoxSeriale.FormattingEnabled = true;
            this.lstBoxSeriale.ItemHeight = 17;
            this.lstBoxSeriale.Location = new System.Drawing.Point(1218, 327);
            this.lstBoxSeriale.Name = "lstBoxSeriale";
            this.lstBoxSeriale.Size = new System.Drawing.Size(551, 310);
            this.lstBoxSeriale.TabIndex = 24;
            this.lstBoxSeriale.SelectedIndexChanged += new System.EventHandler(this.lstBoxSeriale_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 864);
            this.Controls.Add(this.lstBoxSeriale);
            this.Controls.Add(this.dataGridViewSeriale);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.DisplayShowsBtn);
            this.Controls.Add(this.ShowsTxt);
            this.Controls.Add(this.OnGoing);
            this.Controls.Add(this.ongoingLbl);
            this.Controls.Add(this.AddShowBtn);
            this.Controls.Add(this.Genuri);
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
            this.Text = "Seriale";
            this.Genuri.ResumeLayout(false);
            this.Genuri.PerformLayout();
            this.OnGoing.ResumeLayout(false);
            this.OnGoing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriale)).EndInit();
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
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.GroupBox Genuri;
        private System.Windows.Forms.Button AddShowBtn;
        private System.Windows.Forms.Label ongoingLbl;
        private System.Windows.Forms.GroupBox OnGoing;
        private System.Windows.Forms.RadioButton ongoingFalse;
        private System.Windows.Forms.RadioButton ongoingTrue;
        private System.Windows.Forms.RichTextBox ShowsTxt;
        private System.Windows.Forms.Button DisplayShowsBtn;
        private System.Windows.Forms.CheckBox SF;
        private System.Windows.Forms.CheckBox Thriller;
        private System.Windows.Forms.CheckBox Aventura;
        private System.Windows.Forms.CheckBox Horror;
        private System.Windows.Forms.CheckBox Drama;
        private System.Windows.Forms.CheckBox Comedie;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridViewSeriale;
        private System.Windows.Forms.ListBox lstBoxSeriale;
    }
}

