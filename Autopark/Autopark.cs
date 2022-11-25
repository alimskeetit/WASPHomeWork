using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public class Autopark
    {
        string name;
        Car[] cars;

        public Autopark(string name, Car[] cars)
        {
            this.name = name;
            this.cars = cars;
        }

        public Autopark(){ }

        public override string ToString()
        {
            StringBuilder @string = new StringBuilder();
            
            foreach (Car car in cars)
            {
                @string.Append(car.ToString() + '\n');    
            }

            return @string.ToString();
        }
    }
}
