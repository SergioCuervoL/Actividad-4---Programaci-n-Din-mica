using System;

namespace Actividad_Programación_Dinamica
{
    class Program
    {
        int[,] tamvarilla = {{1,2,3,4,5,6,7,8,9,10},
                            {1,5,8,9,10,17,17,20,24,30 }};

        public int m = 0;
        public int res = 0;
        
        public int getVarilla()
        {
            int num = 0;
            Console.WriteLine("Ingrese el tamaño de la Varilla: ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public int [] solucionOptima (int tv)
        {
            int [] listaBeneficios = new int [10];
            for (int i = 0; i < 10; i++)
            {
                int r = (int) Math.Floor(Convert.ToDouble (tv/ tamvarilla[0, i]));
                listaBeneficios[i] = r * tamvarilla[1, i];
            }
            return listaBeneficios;
        }

        public int buscarSolucionMasOptima(int[] listaBenificios)
        {
            int bmb = listaBenificios[0];
            int precio = 0;
            int longitud = 0;
            for (int i = 1; i < listaBenificios.Length; i++)
            {
                if (bmb < listaBenificios[i])
                {
                    bmb = listaBenificios[i];
                    longitud = i+1;
                    precio = tamvarilla[1, i];
                }
            }
            Console.WriteLine("La longitud en la que se va a dividir: "+longitud);
            Console.WriteLine("El precio al que se vende es: "+precio);
            return bmb;
        }

        public void proceso()
        {
            this.m = getVarilla();
            int[] lb = solucionOptima(this.m);
            this.res = buscarSolucionMasOptima(lb);
            Console.WriteLine("El valor total es de: " + this.res);
        }

        static void Main(string[] args)
        {
            Program vari = new Program();
            vari.proceso();
        }
    }
}
