using System;

namespace AssignQues6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string bulls_string = Console.ReadLine();
            Console.WriteLine("Enter the character");
            string c = Console.ReadLine();
            char ch = char.Parse(c);//parsing the string to character
            var count = 0;//initilizing count so as to find the index
            for (int i = 0; i < bulls_string.Length; i++)
            {
                count = count + 1;
                if (bulls_string[i] == ch)
                {
                    break;// if the first insance of the character is found, loop breaks
                }
            
            }
            if (!(count >= bulls_string.Length))// count exceeds the dtring length only when character is not present
            {
                var dum = "";
                for (int i = count - 1; i >= 0; i--)
                {
                    dum = dum + bulls_string[i];
                }
                for (int i = count; i < bulls_string.Length; i++)
                {
                    dum = dum + bulls_string[i];
                }
                Console.WriteLine(dum);
            }
            else// when the character is not present
            {
                Console.WriteLine(bulls_string);
            }
            
            
            
            
        }
    }
}
