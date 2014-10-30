using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HalloweenQuiz
{

    class LoaderController
    {
        string question;
        string correctAnswer;
        string[] guesses;

        private List<AQuestion> questions; 
        public string[] Load(string file)
       
        {
            using (StreamReader reader = new StreamReader(file))
            {
                
                QuestionModel currentQuestionModel = new QuestionModel(question, correctAnswer, guesses);
            }


        }
    }
}
