﻿using OOPLab2.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2.Entities
{
    public class Bear: Animal
    {
        public Bear(string name, float weight, ILogger logger) : base(name, weight, logger)
        {
        }

        public override string GetAnimalTypeName() => "bear";

        public override void MakeSound()
        {
            _logger.Log($"The bear {Name} says: Raaaaaawr");
        }
    }
}
