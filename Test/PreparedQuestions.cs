using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class PreparedQuestions
    {
        public List<QuestionData> getPreparedQuestions()
        {
            List<QuestionData> questionsData = new List<QuestionData>();
            questionsData.Add(new QuestionData("2 + 2", "3", "4", "2", 2));
            questionsData.Add(new QuestionData("3 * 4", "12", "14", "10", 1));
            questionsData.Add(new QuestionData("7 - 4", "1", "5", "3", 3));
            questionsData.Add(new QuestionData("11 * 5", "54", "58", "55", 3));
            questionsData.Add(new QuestionData("1 + 4", "5", "6", "8", 1));
            questionsData.Add(new QuestionData("8 / 2", "2", "4", "6", 2));
            questionsData.Add(new QuestionData("12 + 2", "14", "15", "10", 1));
            questionsData.Add(new QuestionData("45 - 12", "33", "34", "32", 1));
            questionsData.Add(new QuestionData("25 + 25", "35", "44", "50", 3));
            questionsData.Add(new QuestionData("13 + 23", "36", "34", "38", 1));

            return questionsData;
        }
    }
}
