using System;

namespace Punish
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Animals = { "заяц", "волк", "медведь", "енот", "выдра" };
            string[] Poddbs = { "синтия", "родинка", "бульдозер", "унитаз", "кобра" };
            string[] Cars = { "мерседес", "вольва", "тесла", "лада", "форд" };
            Console.WriteLine("Выбирите категорию?");
            Console.WriteLine("1  - Лесные животные\n2 - Клички в Поддубном\n3 - Название машин ");
            string Category = (Console.ReadLine());
            switch (Category)
            {
                case "1":
                    Animals.Chek();
                    break;
                case "2":
                    Poddbs.Chek();
                    break;
                case "3":
                    Cars.Chek();
                    break;
            }
            Console.ReadLine();
        }
    }
}
    
