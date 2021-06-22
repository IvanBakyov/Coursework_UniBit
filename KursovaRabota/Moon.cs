using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    class Moon
    {
        string imeLuna;

        public string ImeLuna
        {
            set { imeLuna = value; }
        }

        public Moon(string imeLuna)
        {
            this.ImeLuna = imeLuna;
        }

        public void ShowMoonInfo()
        {
            Console.WriteLine($"Moon name: {this.imeLuna}");
        }
    }
}
