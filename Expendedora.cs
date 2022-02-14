using System;
using System.Threading;

namespace Expendedoras_G2_2022_II
{
    class Expendedora
    {
        #region Atributos
        string marca;
        string modelo;
        byte temperatura;
        float precio;
        ushort cantProductos;
        #endregion
        //Constructor de la clase
        public Expendedora()
        {
            marca = "ADM";
            temperatura = 18;
            Saludar();
            LimpiarPantalla();     
            Console.WriteLine("Marca: {0}", marca);
            LimpiarPantalla();
            Console.WriteLine("Temperatura: {0} °C", temperatura);
            LimpiarPantalla();
            string codigo= MostrarCodigoProducto();
            LimpiarPantalla();
            MostrarPrecio(codigo);
            
        }
        //Constructor con parámetros
        public Expendedora(string marca)
        {
          //this.marca: atributo
            this.marca = marca; //marca: es un parámetro
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca: {0} ", this.marca);

        }

        public Expendedora(string modelo,string marca )
        {
            this.modelo = modelo;
            this.marca = marca;
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Modelo: {0}", modelo);

        }

        #region Métodos
        void Saludar()
        {
            Console.WriteLine("***Bienvenido a tu expendedora***");
        }

        void LimpiarPantalla()
        {
            Thread.Sleep(2000); //el parámetro está en milisegundos
            Console.Clear();
        }
        
        string MostrarCodigoProducto()
        {
            Console.WriteLine(" 1A) Crujitos \n 2B) Totis ");
            Console.WriteLine( "Ingresa el código del producto a elegir: "  );
            string codigo = Console.ReadLine(); //Variable local 
            return codigo;
        }
        
        void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "1A":
                    precio =precio + 13; //Todo atributo tiene un valor por default
                                         //Para este caso es 0.0
                    break;
                case "2B":
                    precio = 10;
                    break;            
            }
            Console.WriteLine("El precio es: ${0}", precio);
        }

        #endregion
        
    }
}
