using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzes
{
    class CheckBoxQuestion : Question
    {
        List<KeyValuePair<bool, string>> Answers { get; set; } = new List<KeyValuePair<bool, string>> { };

        public CheckBoxQuestion(string questionText) : base(questionText)
        {

        }

        public CheckBoxQuestion(string questionText, List<KeyValuePair<bool, string>> answers) : base(questionText)
        {
            Answers = answers;
        }

        public void AddChoice(bool check, string answerText)
        {
            KeyValuePair<bool, string> answer = new KeyValuePair<bool, string> (check, answerText);
            Answers.Add(answer);
        }

        public void AddChoice(KeyValuePair<bool, string> answer)
        {
            Answers.Add(answer);
        }

        public override void DisplayAnswerChoices()
        {
            
        }

        public override void DisplayCorrectAnswers()
        {
            foreach (KeyValuePair<bool, string> answer in Answers)
            {
                if (answer.Key)
                {
                    Console.Write("checked ");
                }
                else
                {
                    Console.Write("        ");
                }
                Console.WriteLine(answer.Value);
            }
        }
    }
}
