using System;
using System.Collections.Generic;
using System.Text;

namespace MetallicaTrivia2
{
    public class ColorChange
    {

        /* public void ColorsToChange()
         {
             Console.BackgroundColor = ConsoleColor.DarkBlue;
             Console.ForegroundColor = ConsoleColor.Cyan;
             Console.ForegroundColor = ConsoleColor.DarkCyan;
             Console.ForegroundColor = ConsoleColor.White;
             Console.BackgroundColor = ConsoleColor.Black;
             Console.ForegroundColor = ConsoleColor.DarkGray;
             Console.ForegroundColor = ConsoleColor.Red;
         }
        */
        //HEADER COLOR METHODS
        public void DarkBlueCyanHead()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************************");
        }
        public void DarkBlueDarkCyanHead()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("****************************************");
        }
        public void BlackWhiteMetallica()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("      Welcome to Metallica Trivia!      ");

        }

        //DEFAULT COLOR METHOD
        public void BlackDarkGray()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        //READY TO PLAY METHOD 
        public void ReadyToPlayDarkGrayWhite()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ready to play?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t1 for Yes");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2 for No");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //ANSWER COLOR METHODS
        public void RedWrongAnswer(string correctAnswer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opps! Wrong Answer! The answer we were looking for is: {correctAnswer} ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public void CyanRightAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Great Job!");

        }

        // READY FOR NEXT QUESTION METHOD
        public void DarkGrayReadyNext()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.Write("Ready for the next one?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t1 for Yes");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" or ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("2 for No");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

        }

        //QUIT PLAYING METHODS
        public void ThanksForPlaying()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thanks for Playing!");

        }
        public void SeeYaLaterWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("See ya later!");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
