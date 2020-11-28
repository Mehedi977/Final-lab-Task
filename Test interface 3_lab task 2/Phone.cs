using Final_Lab_task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task2
{
    class Program
    {
        public static Phone New { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Phone ");

            Console.WriteLine("Let's switch on  ");

            Phone f2 = New Phone();
            f2.Switch(true);

            Console.WriteLine("Let's check is switch off or not  ");
            Phone f3 = new Phone();
            f3.Switch(false);

            Phone f4 = new Phone();
            f4.play(true);

            Phone f5 = new Phone();
            f5.setVolume(100);

            Phone f6 = new Phone();
            f6.playNext();

            Phone f7 = new Phone();
            f7.playPrevious();

            Phone f8 = new Phone();

            f8.retune(100.02);
            Phone f9 = new Phone();
            f9.changeChannel();


            Phone Music = New Phone();
            Console.WriteLine("Let's see the music file details");
            Music.MusicFile("Abar Hasimukh", "Shironamhin", 2004, 250);
            Console.WriteLine("Next music file details");
            Music.MusicFile("AAmay Dekona", "Lucky Akhand", 1999, 300);
            Console.WriteLine("Changing the Music.....");
            MusicFile Muisic1 = new MusicFile();
            Muisic1.changeTitle("Ghuri tumi kar Akashe Uro");











            Console.ReadKey();
        }

        private static void Phone()
        {
            throw new NotImplementedException();
        }
    }
}