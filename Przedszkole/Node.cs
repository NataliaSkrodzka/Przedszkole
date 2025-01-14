using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przedszkole
{
    internal class Node
    {
        public string ImieInazwisko { get; set; }
        public double Saldo { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(string imieInazwisko)
        {
            ImieInazwisko = imieInazwisko;
            Saldo = 0;
            Next = null;
            Prev = null;
        }
    }
}

