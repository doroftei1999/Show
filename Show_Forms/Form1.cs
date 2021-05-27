using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using LibraryModels;
using DataAccess;

namespace Show_Forms
{
    public partial class Form1 : Form
    {
        DataInterface file = StorageFactory.GetStorageAdministrator();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void ShowAdd_Click(object sender, EventArgs e)
        {
            if (checkControls() == false)
                return;
            else
                reset_colors();
            int counter = 0;
            string info;
            info = nameTxt.Text + ';';
            string [] genres = show.Genre.GetNames(typeof(show.Genre));
            foreach (Control c in Genuri.Controls)
                if(c.GetType() == typeof(CheckBox) && ((CheckBox)c).Checked == true)
                {
                    counter = 0;
                    foreach (string genre in genres)
                    {
                        counter++;
                        if(c.Text == genre)
                        {
                            info += counter.ToString();
                            info += ',';
                        }
                    }
                }
            info = info.Remove(info.Length - 1);
            info += ';';
            info += nrSeasonsTxt.Text;
            info += ';';
            info += nrEpisodesTxt.Text;
            info += ';';
            info += reviewTxt.Text;
            info += ';';
            if (ongoingTrue.Checked)
                info += "true";
            else
                info += "false";
            show s = new show(info);
            file.AddShow(s);
            Clear();
        }

        private void DisplayShows_Click(object sender, EventArgs e)
        {
            ShowsTxt.Clear();
            ArrayList Shows = file.GetShows();
            foreach (show s in Shows)
            {
                ShowsTxt.AppendText(s.convertToString());
                lstBoxSeriale.Items.Add(s.convertToString());
            }
        }

        private void Clear()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = null;
                else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }
            foreach (Control c in Genuri.Controls)
                ((CheckBox)c).Checked = false;
            foreach (Control c in OnGoing.Controls)
                ((RadioButton)c).Checked = false;

        }
        private bool checkControls()
        {
            int counter = 0;
            if (nameTxt.Text == string.Empty)
            {
                nameLbl.ForeColor = Color.Red;
                return false;
            }
            bool result = int.TryParse(nrSeasonsTxt.Text, out counter);
            if (nrSeasonsTxt.Text == string.Empty || result == false)
            {
                nrSeasonsLbl.ForeColor = Color.Red;
                return false;
            }
            result = int.TryParse(nrEpisodesTxt.Text, out counter);
            if (nrEpisodesTxt.Text == string.Empty || result == false)
            {
                nrEpisodesLbl.ForeColor = Color.Red;
                return false;
            }
            result = int.TryParse(reviewTxt.Text, out counter);
            if (reviewTxt.Text == string.Empty || result == false)
            {
                reviewLbl.ForeColor = Color.Red;
                return false;
            }
            if (ongoingFalse.Checked == false && ongoingTrue.Checked == false)
            {
                ongoingLbl.ForeColor = Color.Red;
                return false;
            }
            foreach (Control c in Genuri.Controls)
                if (((CheckBox)c).Checked == true)
                    counter++;
            if(counter == 0)
            {
                genreLbl.ForeColor = Color.Red;
                return false;
            }
            return true;
        }
        private void reset_colors()
        {
            nameLbl.ForeColor = Color. Black;
            nrSeasonsLbl.ForeColor = Color.Black;
            nrEpisodesLbl.ForeColor = Color.Black;
            reviewLbl.ForeColor = Color.Black;
            ongoingLbl.ForeColor = Color.Black;
            genreLbl.ForeColor = Color.Black;
        }
        private void Modify_Click(object sender, EventArgs e)
        {
            if (checkControls() == false)
                return;
            else
                reset_colors();
            ArrayList Shows = file.GetShows();
            int counter;
            foreach(show s in Shows)
            {
                if(nameTxt.Text == s.name)
                {
                    s.genres.Clear();
                    counter = 6;
                    foreach (Control c in Genuri.Controls)
                    {
                        if (c.GetType() == typeof(CheckBox) && ((CheckBox)c).Checked == true)
                            s.genres.Add((show.Genre)counter);
                        counter--;
                    }
                    if (ongoingTrue.Checked)
                        s.onGoing = true;
                    else
                        s.onGoing = false;
                    s.numberOfEpisodes = int.Parse(nrEpisodesTxt.Text);
                    s.numberOfSeasons = int.Parse(nrSeasonsTxt.Text);
                    s.review = float.Parse(reviewTxt.Text);
                    file.modifyShow(Shows);
                    return;
                }
            }
            ShowsTxt.AppendText("Nu exista serialul cu acest nume");
        }
        private void updateControls()
        {

        }
        private void Search_Click(object sender, EventArgs e)
        {
            ArrayList Shows = file.GetShows();
            string name = nameTxt.Text;
            ShowsTxt.Clear();
            foreach (show s in Shows)
            {
                if(s.name == name)
                {
                    ShowsTxt.AppendText(s.convertToString());
                    return;
                }
            }
            ShowsTxt.AppendText("Nu exista serialul cu acest nume");
        }

        private void dataGridViewSeriale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstBoxSeriale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
