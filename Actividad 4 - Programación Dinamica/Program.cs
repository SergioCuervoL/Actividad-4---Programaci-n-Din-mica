﻿using System;

namespace Actividad_4_Programación_Dinamica
{
    class Program
    {
        int[,] varilla = {{1,2,3,4,5,6,7,8,9,10},
                          {1,5,8,9,10,17,17,20,24,30 }};

        public int n = 0;
        public int res = 0;
        

        public int getVarilla()
        {
            int num = 0;
            Console.WriteLine("Ingrese el tamaño de la Varilla: ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        public void ejecutar()
        {
            this.n = getVarilla();
            int[] lb = buscarBeneficios(this.n);
            this.res = buscarMejorBeneficio(lb);
            Console.WriteLine("El beneficio total es de: "+this.res);
        }
        public int [] buscarBeneficios (int tv)
        {
            int [] listaBeneficios = new int [10];
            for (int i = 0; i < 10; i++)
            {
                int r = (int) Math.Floor(Convert.ToDouble (tv/ varilla[0, i]));
                listaBeneficios[i] = r * varilla[1, i];
            }
            return listaBeneficios;
        }
        public int buscarMejorBeneficio(int[] listaBenificios)
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
                    precio = varilla[1, i];
                }
            }
            Console.WriteLine("La longitud que mas beneficia es de: "+longitud);
            Console.WriteLine("El precio al que se deben vender es de: "+precio);
            return bmb;
        }

        static void Main(string[] args)
        {
            Program vari = new Program();
            vari.ejecutar();
        }
    }
}
