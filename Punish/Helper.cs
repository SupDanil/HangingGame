using System;
using System.Collections.Generic;
using System.Text;

namespace Punish
{
   public static class Helper
    {
       public static void Chek(this string [] words)
        {
            var rnd = new Random();
            string Word = words[rnd.Next(1, 5)];
            char[] Letters;
            Letters = Word.ToCharArray();
            Console.WriteLine("Вводите слово по буквам, с маленькой буквы");
            Console.WriteLine($"Первая Буква слова ({Letters[0]}), начните вводить слово с этой буквы");
            int LetTr = 0 ;
           
            for (int i = 0; i < Letters.Length; i++)
            {
                char Symbol = Convert.ToChar(Console.ReadLine());
                if (Letters[i] == Symbol)
                {
                    Console.WriteLine("Вы ввели парвильную букву");
                    LetTr += 1;
                }
                else
                {
                    Console.WriteLine("Вы ввели не парвильную букву");
                }
            }
            if (LetTr == Letters.Length)
            {
                Console.WriteLine($"Загаданное слово было {Word} , и угадали все слово");
            }
            else
            {
                Console.WriteLine($"Загаданное слово было {Word} , вы угадали {LetTr} букв");
            }
            
            
        }
    }
}
