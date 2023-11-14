
using System;

namespace EjercicioPolimorfismo
{
    class Villano
    {
        public string? Nombre { get; set; }

        public void Robando()
        {
            Console.WriteLine("¡" + Nombre + " está atacando!");
        }
    }
    class Catwoman : Villano
    {
        public string? ArmaFavorita { get; set; }
        public string? Habilidades { get; set; }

        public new void Robando()
        {
            Console.WriteLine("¡" + Nombre + " está robando el museo");
        }
    }

    class HiedraVenonosa : Villano
    {
        public string? TipoDePlanta { get; set; }
        public bool UsarFeromonas { get; set; }

        public void LiberarFeromonas()
        {
            Console.WriteLine("¡" + Nombre + " está liberando feromonas!");
        }
    }

    class HarleyQuinn : Villano
    {
        public string? ArmaFavorita { get; set; }
        public bool UsarAcrobacias { get; set; }

        public void RealizarAcrobacias()
        {
            Console.WriteLine("¡" + Nombre + " está realizando acrobacias!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Catwoman Catwoman = new Catwoman();
            Catwoman.Nombre = "Catwoman";
            Catwoman.ArmaFavorita = "Latigo";
            Catwoman.Habilidades = "Ocultarse y pasar desapercibida";
            Catwoman.Robando();

            HiedraVenonosa hiedraVenonosa = new HiedraVenonosa();
            hiedraVenonosa.Nombre = "Hiedra Venenosa";
            hiedraVenonosa.TipoDePlanta = "Veneno";
            hiedraVenonosa.UsarFeromonas = true;
            hiedraVenonosa.LiberarFeromonas();

            HarleyQuinn harleyQuinn = new HarleyQuinn();
            harleyQuinn.Nombre = "Harley Quinn";
            harleyQuinn.ArmaFavorita = "Mazo";
            harleyQuinn.UsarAcrobacias = true;
            harleyQuinn.RealizarAcrobacias();

            Console.ReadLine();
        }
    }
}