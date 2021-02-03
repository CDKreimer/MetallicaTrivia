using System;

namespace MetallicaTrivia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QADictionary triviaDict = new QADictionary();

            WelcomeHeader header = new WelcomeHeader();
            header.Header();
            ColorChange line = new ColorChange();
            line.ReadyToPlayDarkGrayWhite(); // Ready to play

            while (true)
            {
                string playerChoice = Console.ReadLine();
                if (playerChoice != "1")
                {
                    line.SeeYaLaterWhite();
                    break;
                }
                if (playerChoice == "1")
                {
                    triviaDict.metallicaLoopQuestions(); //calls the dictionary method


                }

            }

        }
    }
}
