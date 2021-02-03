using System;
using System.Collections.Generic;
using System.Text;

namespace MetallicaTrivia2
{
    //create method if answered correctly add 1 then get total count

    //create method that takes the string to display and color then you can call that method instead of duplicating it
    class QADictionary
    {
        private int CountCorrect;
        private int CountWrong; 
        ColorChange line = new ColorChange();
        public Dictionary<string, string> MetallicaTriviaDict = new Dictionary<string, string>()
        {
            { "What year did Metallica form?", "1981" },
            { "What is the name of their whiskey created in 2018?", "blackened" },
            { "What is the name of their pilsner beer created in 2019?", "enter night" },
            { "What symphony/orchestra did Metallica partner with for S&M and S&M2?", "san francisco symphony orchestra" },
            { "Metallica started with which original band member placing an ad in the paper looking to start a band?", "lars ulrich" },
        };


        public void metallicaLoopQuestions()
        {
            foreach (KeyValuePair<string, string> loopQuestions in MetallicaTriviaDict)
            {

                //   Console.WriteLine($"{looping.Key}"); //question
                // Console.WriteLine($"{looping.Value}");//answer 
                questionAsk(loopQuestions.Key, loopQuestions.Value);
                line.DarkGrayReadyNext();
                string playerChoice = Console.ReadLine();
                if (playerChoice != "1")
                {
                    line.ThanksForPlaying();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"You got {CountCorrect} questions right!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You got {CountWrong} questions wrong.");
                    break;
                }

            }
        }
        public bool metallicaLoopAnswer()
        {
            bool answer = false;
            foreach (KeyValuePair<string, string> loopAnswers in MetallicaTriviaDict)
            {

                //   Console.WriteLine($"{looping.Key}"); //question
                // Console.WriteLine($"{looping.Value}");//answer 
                //  questionAnswer(loopAnswers.Key, loopAnswers.Value);
                questionAsk(loopAnswers.Key, loopAnswers.Value);


            }
            return answer;
        }
        public bool questionAsk(string question, string answer)
        {
            Console.WriteLine($"{question}");
            string playerAnswer = Console.ReadLine();
           
            int countWrong = 0;
            if (playerAnswer == answer)
            {
                line.CyanRightAnswer();
                CountCorrect++;

                return true;
            }
            else
            {
                line.RedWrongAnswer(answer);
                CountWrong++;

                return false;
            }
         

        }
        public void questionAnswer(string question, string answer)
        {
            Console.WriteLine($"{answer}");
        }

      /* public void GameCounts(int correct, int wrong)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"You got {co} questions right!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You got XX questions wrong.");
        }
      */

    }









}

