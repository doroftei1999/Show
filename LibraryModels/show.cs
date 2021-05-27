using System.Collections.Generic;

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

        private char FILE_SEPARATOR = ';';

        public string name
        { get; set; }

        public List<Genre> genres = new List<Genre>();

        public int numberOfSeasons
        { get; set; }

        public int numberOfEpisodes
        { get; set; }

        public double review
        { get; set; }

        public bool onGoing
        { get; set; }

        public show()
        {
        }

        public show(string info)
        {
            int x;
            string[] splittedInfo = info.Split(FILE_SEPARATOR);
            name = splittedInfo[0];
            foreach (char c in splittedInfo[1])
            {
                if (int.TryParse(c.ToString(), out x) == true)
                    genres.Add((Genre)x);
            }
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
            string Genres = string.Empty;
            foreach (Genre g in genres)
            {
                Genres += g.ToString();
                Genres += ',';
            }
            Genres = Genres.Remove(Genres.Length - 1);
            string onGoingString = (onGoing) ? "Inca apar episoade.\n" : "Serialul s-a incheiat.\n";
            return "Nume: " + name + " \nGenul: " + Genres +
                " \nNumar de sezoane: " + numberOfSeasons.ToString() + " \nNumar de episoade: " +
                numberOfEpisodes.ToString() + " \nRecenzie: " + review.ToString() + " \n" + onGoingString;
        }

        public string convertToFileFormat()
        {
            string Genres = string.Empty;
            foreach (Genre g in genres)
            {
                Genres += ((int)g).ToString();
                Genres += ',';
            }
            Genres = Genres.Remove(Genres.Length - 1);
            return name + FILE_SEPARATOR + Genres + FILE_SEPARATOR + numberOfSeasons.ToString() + FILE_SEPARATOR + numberOfEpisodes.ToString() + FILE_SEPARATOR + review.ToString() + FILE_SEPARATOR + onGoing.ToString();
        }
    }
}