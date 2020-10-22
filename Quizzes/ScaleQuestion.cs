using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    class ScaleQuestion : Question
    {
        public int ScaleBegin { get; set; }
        public int ScaleEnd { get; set; }

        public ScaleQuestion (string questionText) : base (questionText)
        {

        }

        public ScaleQuestion (string questionText, int scaleBegin, int scaleEnd) : base (questionText)
        {
            ScaleBegin = scaleBegin;
            ScaleEnd = scaleEnd;
        }

        public override void DisplayPromptForAnswer()
        {
            throw new NotImplementedException();
        }

        public override void DisplayAnswerChoices()
        {
            throw new NotImplementedException();
        }

        public override void CheckAnswers(string userAnswer)
        {
            throw new NotImplementedException();
        }

        public override void DisplayCorrectAnswers()
        {
            throw new NotImplementedException();
        }

        public override void DisplayQuestion()
        {
            base.DisplayQuestion();
        }
    } // class
} // namespace
