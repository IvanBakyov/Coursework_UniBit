using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    class Star
    {
        string imeZvezda;
        int temperatura;
        double osvetenost;
        double masa;
        double razmer;
        string klasZvezda;

        //zadavane na harakteristikite na zvezdite
        public string ImeZvezda
        {
            set { imeZvezda = value; }
        }
        public string KlasZvezda
        {
            set { klasZvezda = value; }
        }
        public int Temperatura
        {
            set { temperatura = value; }
        }
        public double Osvetenost
        {
            set { osvetenost = value; }
        }
        public double Masa
        {
            set { masa = value; }
        }
        public double Razmer
        {
            set { razmer = value; }
        }


        public Star(string imeZvezda, string klasZvezda, int temperatura, double osvetenost, double masa, double razmer)
        {
            this.ImeZvezda = imeZvezda;
            this.KlasZvezda = klasZvezda;
            this.Temperatura = temperatura;
            this.Osvetenost = osvetenost;
            this.Masa = masa;
            this.Razmer = razmer;
        }

        //izpisvane na informaciq 
        public void ShowStarInfo()
        {
            Console.WriteLine($"Star name: {this.imeZvezda}");
            Console.WriteLine($"Star class: {this.klasZvezda}");
            Console.WriteLine($"Star temperature: {this.temperatura}");
            Console.WriteLine($"Star luminosity: {this.osvetenost}");
            Console.WriteLine($"Star mass: {this.masa}");
            Console.WriteLine($"Star size: {this.razmer}");
        }
    }
}
