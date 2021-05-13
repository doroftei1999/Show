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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowAdd_Click(object sender, EventArgs e)
        {
            string info;
            info = nameTxt.Text + ';';
            if (Comedie.Checked)
                info += "1";
            else if (Drama.Checked)
                info += "2";
            else if (Horror.Checked)
                info += "3";
            else if (Thriller.Checked)
                info += "4";
            else if (Aventura.Checked)
                info += "5";
            else if (SF.Checked)
                info += "6";
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
        }

        private void DisplayShows_Click(object sender, EventArgs e)
        {
            ShowsTxt.Clear();
            ArrayList Shows = file.GetShows();
            foreach (show s in Shows)
                ShowsTxt.AppendText(s.convertToString());
        }

        private void ShowsTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
