using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoPapirOlloOOP
{
    internal class Kpo
    {
        private string tip1;
        private string tip2;
        private string eredmény;

        
        public Kpo() { }

        
        public Kpo(string tip1, string tip2)
        {
            this.tip1 = tip1;
            this.tip2 = tip2;
        }

        
        public void SetTip1(string tip1)
        {
            this.tip1 = tip1;
        }

        
        public void SetTip2(string tip2)
        {
            this.tip2 = tip2;
        }

        
        public void SetEredmény()
        {
            if (tip1 == tip2)
            {
                eredmény = "Döntetlen";
            }
            else if ((tip1 == "Kő" && tip2 == "Olló") ||
                     (tip1 == "Papír" && tip2 == "Kő") ||
                     (tip1 == "Olló" && tip2 == "Papír"))
            {
                eredmény = "Az első játékos nyert!";
            }
            else
            {
                eredmény = "A második játékos nyert!";
            }
        }

        
        public string GetEredmény()
        {
            return eredmény;
        }
    }
}
