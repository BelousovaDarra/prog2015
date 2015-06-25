using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace А1А2
{
    public class Class1
    {
        public Class1()
        {
            Employments = new List<EmployedData>();
        }

        public List<EmployedData> Employments { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Otchestvo { get; set; }
        public string Telephone { get; set; }
        public string Pasport { get; set; }
        public string University { get; set; }
        public string Room { get; set; }
        public string Cost { get; set; }
        public string Get { get; set; }
        public string Group { get; set; }
        public string Live { get; set; }

        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }
        public DateTime Date4 { get; set; } 


    }

    public class EmployedData
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Obshe { get; set; }
        public string Komn { get; set; }

        public override string ToString()
        {
            return string.Format("Номер общежития: {0}, Номер комнаты {1}, Дата заселения: {2}, Дата выселения: {3}", Obshe, Komn, Start, End);
        }
    }
}
