using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PeopleGrafikusAlkalmazasEgysegTeszteles
{
    internal class People
    {
        List<int> eletkorok;

        public People()
        {
            eletkorok = new List<int>();
        }

        internal void UjSzemely(int eletkor)
        {
            if (eletkor < 0)
            {
                throw new ArgumentException("Az életkornak többnek kell lennie mint 0");
            }
            else eletkorok.Add(eletkor);
        }

        internal double AtlagEletkor(int minEletkor, int maxEletkor)
        {
            double AtlagEletkor = 0;
            int counter = 0;
            if(eletkorok.Count != 0)
            {
                foreach (var item in eletkorok)
                {
                    if (item > minEletkor && item < maxEletkor)
                    {
                        AtlagEletkor += item;
                        counter++;
                    }
                    else throw new ArgumentException("A minimum vagy maximum értékérvénytelen");
                }
            }
            else throw new InvalidOperationException("A lista nem tartalmaz elemet.");

            AtlagEletkor = AtlagEletkor / counter;
            return AtlagEletkor;
        }

        internal int SzemelyekKategorizalasa()
        {
            double szam = AtlagEletkor(0, 100);
            if (szam > 0 && szam <= 18) return 1;
            else if (szam >= 19 && szam <= 64) return 2;
            else return 3;
        }
    }
}
