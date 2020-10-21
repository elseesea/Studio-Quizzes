using System;
using System.Collections.Generic;

namespace Quizzes
{
    class Program
    {
        private static void CreateAndAddQuestions(Quiz quiz)
        {
            // Create a multiple-choice question object
            Question q1 = new MultipleChoiceQuestion("Which language is not a strongly typed language?",
                new Dictionary<int, string>() {
                    {1, "Java" },
                    {2, "Javascript" },
                    {3, "C#" },
                    {4, "None of the above" }
                },
                2);

            // Create a checkbox question object
            Question q2 = new CheckBoxQuestion("Select the planets:",
                new Dictionary<int, KeyValuePair<bool, string>>() {
                    {1, new KeyValuePair<bool, string>(true, "Earth") },
                    {2, new KeyValuePair<bool, string>(false, "Helios") },
                    {3, new KeyValuePair<bool, string>(false, "Titan") },
                    {4, new KeyValuePair<bool, string>(false, "Zeus") },
                    {5, new KeyValuePair<bool, string>(true, "Mars") },
                    {6, new KeyValuePair<bool, string>(true, "Jupiter") }
                }
            );

            // Create a truefalse question object
            Question q3 = new TrueFalseQuestion("LaunchCode is awesome", true);

            // Add the question objects to the quiz
            quiz.AddQuestion(q1);
            quiz.AddQuestion(q2);
            quiz.AddQuestion(q3);
        }

        static void Main(string[] args)
        {
            // Create a new quiz
            Quiz quiz = new Quiz();

            CreateAndAddQuestions(quiz);
            
            // Display all questions, answer choices, & correct answers
            //quiz.ShowAllQuestionsAndCorrectAnswers();

            Console.WriteLine("\nA Quiz For You");
            for (int i = 0; i < quiz.Questions.Count; i++)
            {
                Console.Write("\nQuestion " + (i + 1) + " - ");
                Question q = quiz.Questions[i];
                q.DisplayQuestion();
                Console.WriteLine();
                q.DisplayAnswerChoices();
                Console.WriteLine();
                q.DisplayPromptForAnswer();
                string userInput = Console.ReadLine();
                q.CheckAnswers(userInput);
                Console.WriteLine();
            }

        }
    }
}
