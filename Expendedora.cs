using System;
using System.Threading;

namespace Expendedoras_G2_2022_II
{
    abstract class Expendedora
    {
        #region Atributos
       internal string marca;
       internal  string modelo;
       internal byte temperatura;
       internal float precio;
       internal ushort cantProductos;

        #endregion
        #region Propiedades
        public byte Temperatura {
            //Leer
            get => temperatura;
            //Escribir
            set
            {
                if (value < 15 || value > 20   )
                {
                    temperatura = 15;
                }else
                {
                    temperatura = value;
                }                
            }
        }
        #endregion


        #region Constructores
        //Constructor de la clase
        public Expendedora()
        {
            Saludar();
            LimpiarPantalla();
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
        #endregion

        #region Métodos
        internal void Saludar()
        {
            Console.WriteLine("***Bienvenido a tu expendedora***");
        }
        //public es un modificador de acceso
        public void ElevarTemperatura()
        {
            Temperatura++;
            LimpiarPantalla();
            Console.WriteLine("Temperatura: {0} ", Temperatura);
            
        }
        internal void LimpiarPantalla()
        {
            Thread.Sleep(2000); //el parámetro está en milisegundos
            Console.Clear();
        }
        
        internal string MostrarCodigoProducto()
        {
            Console.WriteLine(" 1A) Crujitos \n 2B) Totis ");
            Console.WriteLine( "Ingresa el código del producto a elegir: "  );
            string codigo = Console.ReadLine(); //Variable local 
            return codigo;
        }
        
        internal void MostrarPrecio(string codigo)
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
