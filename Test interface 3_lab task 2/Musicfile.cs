using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task2
{
    public class musicFile
    {
        private string Title;

        private string Artist;

        private int yearOfRelease;

        private int DurationInSeconds;

        public string tname
        {
            get { return Title; }

            set { Title = value; }
        }
        public string aname
        {
            get { return Artist; }

            set { Artist = value; }
        }
        public musicFile()
        {

        }
        public musicFile(string title, string artist, int YearOfRelease, int durationInSeconds)
        {
            this.Title = title;
            this.Artist = artist;
            this.yearOfRelease = YearOfRelease;
            this.DurationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            string t1 = title;
            Console.WriteLine("Changing the music Title :" + t1);
        }
    }
}