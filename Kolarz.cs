using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormyPdstawy
{
    public class Kolarz
    {
        private static int nextId = 0;

        public int Id { get; private set; }
        public bool Wpisowe { get; set; }
        public byte Wiek { get; set; }
        public string? Team { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public int Ranking { get; set; }
        public string? Email { get; set; }

        public void nowyNumer()
        {  Id = nextId++; }
    }
}
