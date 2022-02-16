using System;

namespace Expendedoras_G2_2022_II
{
    class Cafe:Expendedora
    {
        public Cafe()
        {
            temperatura = 70;
            Console.WriteLine("***Disfruta tu mañana con un Café***");
            Console.WriteLine("Temperatura: {0} °C", temperatura);

        }
    }
}
