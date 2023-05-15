using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27Prac26.Models
{
    public class SweetsSet
    {
        public string TypeSweets { get; set; }
        public string TypeFrill { get; set; }
        public decimal Price { get; set; }


        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Sweet {TypeSweets}")
                .AppendLine($"TypeFrill {TypeFrill}")
                .AppendLine($"Price {Price}").ToString();

        }
    }
}
