using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class QuestionData
    {
        private string title;
        private List<string> variants = new List<string>();
        private int res;

        public QuestionData(string title, string var1, string var2, string var3, int res)
        {
            this.title = title;

            this.variants.Add(var1);
            this.variants.Add(var2);
            this.variants.Add(var3);

            if(res < 1 || res > 3)
            {
                this.res = 1;

            }
            else
            {
                this.res = res;
            }
        }

        public override string ToString()
        {
            return title + "\n"
                + "1) " + variants[0] + "\n"
                + "2) " + variants[1] + "\n"
                + "3) " + variants[2] + "\n";
        }

        public string getTitle()
        {
            return title;
        }
        public List<string> getVariants()
        {
            return variants;
        }
        public int getReze()
        {
            return res;
        }
    }
}
