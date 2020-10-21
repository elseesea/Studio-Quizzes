using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    class Quiz
    {
        List<Question> Questions { get; set; }// = new List<Question> { };

        public Quiz()
        {
            Questions = new List<Question> { };
        }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void ShowAllQuestionsAndAnswers()
        {
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine("Questions & Correct Answers");
                Console.Write("*************************\nQuestion " + (i + 1) + " - ");
                Question q = Questions[i];
                q.DisplayQuestion();
                Console.WriteLine();
                if (q is MultipleChoiceQuestion)
                {
                    q.DisplayAnswerChoices();
                    Console.WriteLine();
                    q.DisplayCorrectAnswers();
                }
                if (q is CheckBoxQuestion)
                {
                    q.DisplayCorrectAnswers();
                    Console.WriteLine();
                }
                if (q is TrueFalseQuestion)
                {
                    q.DisplayAnswerChoices();
                    Console.WriteLine();
                    q.DisplayCorrectAnswers();
                }
                Console.WriteLine();
            }
        }
    }
}
