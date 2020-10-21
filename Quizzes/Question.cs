using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    abstract class Question
    {
        public string QuestionText { get; set; }

        public Question (string questionText)
        {
            QuestionText = questionText;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
        }

        public abstract void DisplayAnswerChoices();

        public abstract void DisplayCorrectAnswers();

        public abstract void DisplayPromptForAnswer();

        public abstract void CheckAnswers(string userAnswer);
    }
}
