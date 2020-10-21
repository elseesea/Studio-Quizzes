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
            Console.WriteLine("(T)rue or (F)alse: ");
        }

        public override void DisplayCorrectAnswers()
        {
            Console.WriteLine("Answer: " + Answer);
        }
    }
}
