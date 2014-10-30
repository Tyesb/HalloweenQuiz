using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenQuiz
{
    public class QuestionModel
    {
        public string CorrectAnswer;
        public string Question;
        public Dictionary<int, string> answerList;
 
        public QuestionModel(string correctanswer, string question, string[]guesses)
        {
            CorrectAnswer = correctanswer;
            Question = question;
            answerList.AddRange(guesses);
        }


    }
}
