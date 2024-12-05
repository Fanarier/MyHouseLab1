using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    public class HouseFactory
    {
        private readonly Dictionary<string, IHouse> _houses = new();

        public IHouse GetHouse(string type, string material, int floors)
        {
            string key = $"{type}-{material}-{floors}";

            if (!_houses.ContainsKey(key))
            {
                _houses[key] = new House(type, material, floors);
                Console.WriteLine($"Создан новый объект дома: {key}");
            }
            else
            {
                Console.WriteLine($"Используется существующий объект дома: {key}");
            }

            return _houses[key];
        }
    }
}
