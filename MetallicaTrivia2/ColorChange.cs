using System;
using System.Collections.Generic;
using System.Text;

namespace MetallicaTrivia2
{
    public class ColorChange
    {
        //HEADER COLOR METHODS
        public void BlackCyanStar()
        {
            BBlack();
            FCyan();
            Console.Write("*");
        }

        public void BlackDarkCyanStar()
        {
            BBlack();
            FDarkCyan();
            Console.Write("*");
        }
        public void CyanDarkCyanStars()
        {
            Console.Write("  "); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar();
            BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar();
            BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar();
            BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar();
            BlackCyanStar(); BlackDarkCyanStar();
        }
        public void DarkCyanCyanStars()
        {
            BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar();
            BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar();
            BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar();
            BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar(); BlackDarkCyanStar(); BlackCyanStar();
            BlackDarkCyanStar();
        }
        public void BlackWhiteMetallicaStar()
        {
            CyanDarkCyanStars();
            FWhite();
            Console.Write("Welcome to ");
            BlackCyanStar();
            BlackDarkCyanStar();
            FWhite();
            Console.Write(" Metallica ");
            BlackDarkCyanStar();
            BlackCyanStar();
            FWhite();
            Console.Write(" Trivia!");
            DarkCyanCyanStars();
            Console.WriteLine();

        }
        public void DarkBlueCyanHead()
        {
            BBlack();
            FCyan();
            Console.WriteLine("  *****************************************************************************");
        }
        public void DarkBlueDarkCyanHead()
        {
            BBlack();
            FDarkCyan();
            Console.WriteLine("  *****************************************************************************");
        }

        public void BlackWhiteMetallica()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"********************** Welcome  to  Metallica  Trivia! *********************");

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
            Console.Write("  Ready to play?");
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
            Console.WriteLine($"  Opps! Wrong Answer! The answer we were looking for is: {correctAnswer} ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public void CyanRightAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Great Job!");

        }

        // READY FOR NEXT QUESTION METHOD
        public void DarkGrayReadyNext()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.Write("  Ready for the next one?");
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
            Console.WriteLine("  Thanks for Playing!");

        }
        public void SeeYaLaterWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  See ya later!");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public void HowToSeeForegroundBackground()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;
            Console.WriteLine("All the foreground colors except {0}, the background color:",
                       currentBackground);
            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   The foreground color is {0}.", color);
            }
            Console.WriteLine();

            Console.WriteLine("All the background colors except {0}, the foreground color:",
                       currentForeground);
            foreach (var color in colors)
            {
                if (color == currentForeground) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   The background color is {0}.", color);
            }

        }
        //Foreground colors
        public void FBlack()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void FDarkBlue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public void FDarkGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void FDarkCyan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public void FDarkRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public void FDarkMagenta()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public void FDarkYellow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public void FDarkGray()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public void FGray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void FBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public void FGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void FCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public void FRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void FMagenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public void FYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void FWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Background colors
        public void BBlack()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void BDarkBlue()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        public void BDarkGreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }
        public void BDarkCyan()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
        }
        public void BDarkRed()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
        }
        public void BDarkMagenta()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
        }
        public void BDarkYellow()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
        }
        public void BDarkGray()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public void BGray()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        public void BBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public void BGreen()
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        public void BCyan()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
        }
        public void BRed()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        public void BMagenta()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
        }
        public void BYellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        public void BWhite()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }

    }
}

