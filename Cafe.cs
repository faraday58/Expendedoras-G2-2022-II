using System;

namespace Expendedoras_G2_2022_II
{
    class Cafe:Expendedora
    {
        #region Propiedades
        public override byte Temperatura { 
            get => base.Temperatura; 
            set
            {
                if ( value < 15 || value  > 70 )
                {
                    temperatura = 60;
                }
                else
                {
                    temperatura = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Cafe()
        {
            Temperatura = 70;
            Console.WriteLine("***Disfruta tu mañana con un Café***");
            for (int i = 0; i < 20; i++)
            {
                ElevarTemperatura();
            }
            Console.WriteLine("Temperatura: {0} °C", Temperatura);
            MostrarPrecio(MostrarCodigoProducto());
            
        }

        public Cafe(bool  Mantenimiento)
        {
            marca = "Nescafe";
            if(Mantenimiento)
            {
                LimpiarPantalla();
                Console.WriteLine("Marca {0}: ", marca);
                LimpiarPantalla();
                Console.WriteLine("Entrando a modo mantenimiento ");               

            }
            else
            {
                LimpiarPantalla();
                Console.WriteLine("Marca {0}", marca);
                LimpiarPantalla();
                Console.WriteLine("Saliendo modo mantenimiento");
            }

        }
        #endregion

        #region Métodos
        
        internal override string MostrarCodigoProducto()
        {
            Console.WriteLine("A1)Latte \n A2)Expresso \n Ingresa el código del Café ");
            string codigo = Console.ReadLine();
            return codigo;
           // return base.MostrarCodigoProducto();
        }

        internal override void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "A1":
                    precio = 20;
                    break;
                case "A2":
                    precio = 15;
                    break;
            }
            Console.WriteLine("El precio es: ${0}", precio);

         //   base.MostrarPrecio(codigo);
        }
        

        #endregion
    }
}
