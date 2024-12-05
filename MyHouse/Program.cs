using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    class Program
    {
        static void Main()
        {
            var factory = new HouseFactory();

            // Создаем и строим дома
            var house1 = factory.GetHouse("Хрущевка", "Кирпич", 5);
            house1.Build("ул. Ленина, д. 1");

            var house2 = factory.GetHouse("Панельная высотка", "Панель", 12);
            house2.Build("ул. Пушкина, д. 10");

            var house3 = factory.GetHouse("Хрущевка", "Кирпич", 5);
            house3.Build("ул. Ленина, д. 2"); // Использует тот же объект, что и house1

            var house4 = factory.GetHouse("Коттедж", "Дерево", 2);
            house4.Build("ул. Садовая, д. 5");

            Console.ReadKey();
        }
    }
}
