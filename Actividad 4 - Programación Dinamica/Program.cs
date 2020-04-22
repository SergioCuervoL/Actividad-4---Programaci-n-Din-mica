using System;

namespace Actividad_4_Programación_Dinamica
{
    class Program
    {
        int[,] varilla = {{1,2,3,4,5,6,7,8,9,10},
                          {1,5,8,9,10,17,17,20,24,30 }};

        public int n = 0;

        public int getVarilla()
        {
            Console.WriteLine("Ingrese el tamaño de la Varilla: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public void ejecutar()
        {
            this.n = getVarilla();
            Console.WriteLine(this.n);
        }

        static void Main(string[] args)
        {
            Program vari = new Program();
            vari.ejecutar();
        }
    }
}
