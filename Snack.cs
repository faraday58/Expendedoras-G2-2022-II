using System;


namespace Expendedoras_G2_2022_II
{
    class Snack:Expendedora
    {
        public Snack()
        {
            marca = "ADM";
            Temperatura = 18;
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarPantalla();
            Console.WriteLine("Temperatura: {0} °C", Temperatura);
            LimpiarPantalla();
            string codigo = MostrarCodigoProducto();
            LimpiarPantalla();
            MostrarPrecio(codigo);
        }

    }
}
