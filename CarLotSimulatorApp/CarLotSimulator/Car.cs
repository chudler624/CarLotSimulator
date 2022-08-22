using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
       public int Year { get; set; }
       public string Make { get; set; }
       public string Model { get; set; }
       public string EngineNoise { get; set; }
       public string HonkNoise { get; set; }    
       public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"Engine noise is {EngineNoise}");
        }

         public void MakeHonkNoise()
        {
            Console.WriteLine($"Honk noise is: {HonkNoise}");
        }






    }
}
