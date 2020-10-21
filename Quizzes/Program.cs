using System;
using System.Collections.Generic;

namespace Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            Question q1 = new MultipleChoiceQuestion("Which language is not a strongly typed language?");
            (q1 as MultipleChoiceQuestion).AddChoice(1, "Java");
            (q1 as MultipleChoiceQuestion).AddChoice(2, "JavaScript");
            (q1 as MultipleChoiceQuestion).AddChoice(3, "C#");
            (q1 as MultipleChoiceQuestion).AddChoice(4, "None of the above");
            (q1 as MultipleChoiceQuestion).CorrectAnswer = 2;

            Question q2 = new CheckBoxQuestion("Select the planets:");
            (q2 as CheckBoxQuestion).AddChoice(true, "Earth");
            (q2 as CheckBoxQuestion).AddChoice(false, "Helios");
            (q2 as CheckBoxQuestion).AddChoice(false, "Titan");
            (q2 as CheckBoxQuestion).AddChoice(false, "Zeus");
            (q2 as CheckBoxQuestion).AddChoice(true, "Mars");
            (q2 as CheckBoxQuestion).AddChoice(true, "Jupiter");

            Question q3 = new TrueFalseQuestion("LaunchCode is awesome", true);

            quiz.AddQuestion(q1);
            quiz.AddQuestion(q2);
            quiz.AddQuestion(q3);

            //quiz.ShowAllQuestionsAndAnswers();

            Console.WriteLine("\nA Quiz For You");
            for (int i = 0; i < quiz.Questions.Count; i++)
            {
                Console.Write("\nQuestion " + (i + 1) + " - ");
                Question q = quiz.Questions[i];
                q.DisplayQuestion();
                Console.WriteLine();
                if (q is MultipleChoiceQuestion)
                {
                    q.DisplayAnswerChoices();
                    Console.WriteLine();
                    //q.DisplayCorrectAnswers();
                }
                if (q is CheckBoxQuestion)
                {
                    q.DisplayAnswerChoices();
                    //q.DisplayCorrectAnswers();
                    Console.WriteLine();
                }
                if (q is TrueFalseQuestion)
                {
                    q.DisplayAnswerChoices();
                    Console.WriteLine();
                    //q.DisplayCorrectAnswers();
                }
                Console.Write("Your answer: ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
            }

        }
    }
}
