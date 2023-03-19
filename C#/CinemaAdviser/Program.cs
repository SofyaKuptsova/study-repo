using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет найти фильм, который будет вам по душе.");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, триллер, боевик.");
            String genre = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");
            
            if(genre == "комедия")
            {
                Console.WriteLine("* Иван Васильевич меняет профессию");
                Console.WriteLine("* Операцыя «Ы» и другие приключения Шурика");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            } 
            else if (genre == "фантастика")
            {
                Console.WriteLine("* Грань будущего");
                Console.WriteLine("* Пятый элемент");
                Console.WriteLine("* Люди Х");
            }
            else if (genre == "триллер")
            {
                Console.WriteLine("* Бойцовский клуб");
                Console.WriteLine("* Остров проклятых");
                Console.WriteLine("* Игра");
            }
            else if (genre == "боевик")
            {
                Console.WriteLine("* Крепкий орешек");
                Console.WriteLine("* Брат");
                Console.WriteLine("* Безумный Макс");
            }
            else
            {
                Console.WriteLine("* Зеленая миля");
                Console.WriteLine("* Побег из Шоушенка");
                Console.WriteLine("* Хатико");
            }

            Console.ReadLine();
        }
    }
}
