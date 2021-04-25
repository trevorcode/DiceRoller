using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRollerPWA.Models
{
    public class Die : IDie
    {
        public string Name { get; set; }
        public int Sides { get; set; }
        public int? Result { get; set; }

        public int RollDie()
        {
            Random newNumber = new Random();
            Result = newNumber.Next(1, Sides+1);
            return Result.Value;
        }
    }
}
