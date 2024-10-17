using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GurzanVM.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            
            
                value = value.Replace("a b c", "");
                value = value.Replace("A B C", "");
                value = value.Replace("А Б В", "");


         
                return true;
        }
         


    }
}
