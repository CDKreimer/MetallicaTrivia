using System;
using System.Collections.Generic;
using System.Text;

namespace MetallicaTrivia2
{
    class QADictionary
    {
        private int CountCorrect;
        private int CountWrong;
        ColorChange line = new ColorChange();
        public Dictionary<string, string> MetallicaTriviaDict = new Dictionary<string, string>()
        {
            { "What year did Metallica form?" , "1981" },
            { "What is the name of their whiskey created in 2018?" , "blackened" },
            { "What is the name of their pilsner beer created in 2019?" , "enter night" },
            { "What symphony/orchestra did Metallica partner with for S&M and S&M2?" , "san francisco symphony orchestra" },
            { "Metallica started with which original band member placing an ad in the paper looking to start a band?" , "lars ulrich" },
            { "Who is the lead singer of Metallica?" , "james hetfield" },
            { "Who is the drummer of Metallica?" , "lars ulrich" },
            { "Who is the original bass player of Metallica?" , "ron mcgovney" },
            { "Who is the current bass player?" , "robert trujillo" },
            { "Who was the bass player from 1982 - 1986?" , "cliff burton" },
            { "Who was the bass player from 1986 - 2001?" , "jason newsted" },
            { "Who was the original lead guitarist in 1982?" , "dave mustaine" },
            { "Who is the current lead guitar from 1983-present?" , "kirk hammett" },
            { "What's the first album Metallica released in 1983?" , "kill 'em all" },
            { "What's the name of Metallica's cover album released in 1998?" , "garage inc" },
            { "What are Metallica fans called?" , "fifth members" },
            { "In 2001, Metallica won the Grammy Award for Best Rock Instrumental Performance along with Michel Kamen and the San Francisco Symphony Orchestra. With which song did they win this award?" , "the call of ktulu" },
            { "What is the longest studio album?" , "load" },
            { "What is James Hetfield's nickname?" , "papa het" },
            { "What is Kirk Hammet's nickname?" , "the ripper" },
            { "What is Lars Ulrich's nickname?" , "flathead" },
            { "What is Robert Trujillo's nickname?" , "the whiskey warlord" },
        };


        public void metallicaLoopQuestions()
        {
            foreach (KeyValuePair<string, string> loopQuestions in MetallicaTriviaDict)
            {
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
                questionAsk(loopAnswers.Key, loopAnswers.Value);
            }
            return answer;
        }
        public bool questionAsk(string question, string answer)
        {
            Console.WriteLine($"{question}");
            string playerAnswer = Console.ReadLine();

            if (playerAnswer.ToLower() == answer)
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
    }

}

