using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    class TrueFalseQuestion : Question
    {
        public bool Answer { get; set; }

        public TrueFalseQuestion(string questionText, bool answer) : base(questionText)
        {
            Answer = answer;
        }

        public override void DisplayAnswerChoices()
        {
            Console.WriteLine();
            Console.WriteLine("(T)rue or (F)alse: ");
        }

        public override void DisplayCorrectAnswers()
        {
            Console.WriteLine("Answer: " + Answer);
        }

        public override void DisplayPromptForAnswer()
        {
            Console.WriteLine("Your answer:");
        }

        public override void CheckAnswers(string userAnswer)
        {
            userAnswer = userAnswer.Trim().ToLower();
            string allcapsAnswer = Answer.ToString().ToUpper();

            Console.WriteLine();
            if (userAnswer.Equals("t") && Answer || userAnswer.Equals("f") && !Answer)
            {
                Console.Write("You are correct! It is ");
            }
            else
            {
                Console.Write("Sorry, you are incorrect. The correct answer is ");
            }
            Console.WriteLine(allcapsAnswer + ".");
        }
    }
}
