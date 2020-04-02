using System;

namespace PriceCalculator.Model
{
    public class Generator
    {
        public int Nights { get; }
        public int Price { get; }
        public double Comission { get; }
        public int People { get; }
        public int Expences { get; }
        public bool ChildPlace { get; }

        public Generator(int nights, int price, int comission, int people, int expences, bool childPlace)
        {
            if (nights == 0 || price == 0 || comission == 0 || people == 0 || expences == 0)
                throw new ArgumentNullException("Параметр(ы) не могут равняться нулю");
            Nights = nights;
            Price = price;
            Comission = comission;
            People = people;
            Expences = expences;
            ChildPlace = childPlace;
        }

    }
}
