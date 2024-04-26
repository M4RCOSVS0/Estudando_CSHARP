using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1Vetores
{
    internal class Hotel
    {
        public string Name {  get; private set; }
        public string Email { get; private set; }
        private int _quarto;

        public Hotel(string name, string email)
        {
            Name = name;
            Email = email;

        }

        public int Quarto
        {
            get { return _quarto; }
            set
            {
                if (value >= 0 && value < 10)
                {
                    _quarto = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }


    }
}
