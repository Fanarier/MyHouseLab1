using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHouse
{
    public class House : IHouse
    {
        private readonly string _type;       // Тип
        private readonly string _material;  // Материал
        private readonly int _floors;       // Кол этажей

        public House(string type, string material, int floors)
        {
            _type = type;
            _material = material;
            _floors = floors;
        }

        public void Build(string address)
        {
            Console.WriteLine($"Построен {_type} из {_material} с {_floors} этажами по адресу {address}.");
        }
    }
}
