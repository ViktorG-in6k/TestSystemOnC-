using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{    
    public class Program
    {        
        public void Main(string[] args)
        {
            PreparedQuestions preparedQuestions = new PreparedQuestions();
            List<QuestionData> questionsData = preparedQuestions.getPreparedQuestions();

            Parser parser = new Parser();

            int parsedValue;
            int result = 0;

            foreach(QuestionData questionData in questionsData)
            {
                Console.WriteLine(questionData.ToString());
                Console.WriteLine("Enter 1 from 3 variant");

                parsedValue = parser.tryToParseValueFrom1To3(Console.ReadLine());
               
                while(parsedValue == 0)
                {
                    Console.WriteLine("Incorrect input value. Try again");
                    parsedValue = parser.tryToParseValueFrom1To3(Console.ReadLine());
                }

                Console.Clear();
                result += addPoint(parsedValue, questionData);                 
            }

            showResult(result);
        }       

        public int addPoint(int parsedValue, QuestionData questionData)
        {
            if (parsedValue == questionData.getReze())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void showResult(int result)
        {
            Console.WriteLine("Your result: " + result + "/10");
            Console.WriteLine("Press any button for exit");
            Console.ReadKey();
        }
    }
}
