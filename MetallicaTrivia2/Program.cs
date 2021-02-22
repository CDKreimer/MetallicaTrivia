using System;

namespace MetallicaTrivia2
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeHeader header = new WelcomeHeader();
            ColorChange line = new ColorChange();


            //Console.WriteLine("Hello World!");
            QADictionary triviaDict = new QADictionary();
            
            header.Header2();
            header.Header3();
            //header.Header();
            
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
