using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Dinner_2
{
    class DinnerPlace
    {
        public string m_dinnerPlace { get; set; }
        public double m_weight      { get; set; }
        public DinnerPlace(string dinnerPlace, double weight)
        {
            this.m_dinnerPlace = dinnerPlace;
            this.m_weight      = weight     ;
        }

        public static int CompareDinnerPlace(DinnerPlace d1, DinnerPlace d2)
        {
            if (d1.m_weight > d2.m_weight)
                return 1;
            else if (d1.m_weight < d2.m_weight)
                return -1;
            else
                return 0;
        }

        public void printDinnerPlace()
        {
            Console.WriteLine(this.m_dinnerPlace);
            Console.WriteLine(this.m_weight);
        }
    }

    class DinnerPlaceManager
    {
        public List<DinnerPlace> m_dinnerPlaces { get; set; }

        public DinnerPlaceManager(string filePath)
        {
            this.m_dinnerPlaces = new List<DinnerPlace>();
            using ( var r = new StreamReader(filePath) )
            {
                string line;
                while( (line = r.ReadLine()) != null )
                {
                    string[] strings = line.Split('/');
                    DinnerPlace dPlace = new DinnerPlace( strings[0], Double.Parse(strings[1]) );
                    this.m_dinnerPlaces.Add(dPlace);
                }
                double sum = this.m_dinnerPlaces.Sum(m => m.m_weight);
                this.m_dinnerPlaces.ForEach(m => m.m_weight = m.m_weight/sum);
                this.m_dinnerPlaces.Sort(DinnerPlace.CompareDinnerPlace) ;
            }

            foreach (var m in this.m_dinnerPlaces)
            {
                m.printDinnerPlace();
                Console.WriteLine(" ");
            }
        }

        public string selectDinnerPlace()
        {
            string place = "";
            double d = new Random().NextDouble();
            double sum = 0.0;
            foreach ( var m in this.m_dinnerPlaces )
            {
                if (d < m.m_weight + sum)
                {
                    place = m.m_dinnerPlace;
                    break;
                }
                sum += m.m_weight;
            }
            Console.WriteLine(place);
            return place;
        }

    }
}
