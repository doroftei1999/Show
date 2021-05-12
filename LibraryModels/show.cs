using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryModels
{
    public class show
    {
        public enum Genre
        {
            Comedie = 1,
            Drama = 2,
            Horror = 3,
            Thriller = 4,
            Aventura = 5,
            SF = 6
        };

        char FILE_SEPARATOR = ';';
        public string name
        { get; set; }

        public Genre genre
        { get; set; }

        public int numberOfSeasons
        { get; set; }

        public int numberOfEpisodes
        { get; set; }

        public double review
        { get; set; }

        public bool onGoing
        { get; set; }
        public show() { }

        public show(string info)
        {
            string[] splittedInfo = info.Split(FILE_SEPARATOR);
            name = splittedInfo[0];

            genre = (Genre)int.Parse(splittedInfo[1]);

            numberOfSeasons = int.Parse(splittedInfo[2]);
            numberOfEpisodes = int.Parse(splittedInfo[3]);
            review = double.Parse(splittedInfo[4]) / 10;
            review = (review < 1) ? review * 10 : review;
            onGoing = bool.Parse(splittedInfo[5]);
        }
        public static show operator <(show a, show b)
        {
            if (a.review <= b.review)
                return a;
            else
                return b;
        }
        public static show operator >(show a, show b)
        {
            if (a.review >= b.review)
                return a;
            else
                return b;
        }

        public string convertToString()
        {
            string onGoingString = (onGoing) ? "Inca apar episoade.\n" : "Serialul s-a incheiat.\n";
            return "Nume: " + name + "\nGenul: " + genre +
                "\nNumar de sezoane: " + numberOfSeasons.ToString() + "\nNumar de episoade: " +
                numberOfEpisodes.ToString() + "\nRecenzie: " + review.ToString() + "\n" + onGoingString;
        }
        public string convertToFileFormat()
        {
            return name + FILE_SEPARATOR + (int)genre + FILE_SEPARATOR + numberOfSeasons.ToString() + FILE_SEPARATOR + numberOfEpisodes.ToString() + FILE_SEPARATOR + review.ToString() + FILE_SEPARATOR + onGoing.ToString();
        }
    }
}
