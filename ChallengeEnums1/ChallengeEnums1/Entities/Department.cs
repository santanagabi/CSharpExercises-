using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEnums1.Entities
{
    class Department
    {
        public string Name { get; set; }

        // Construtor padrão
        public Department()
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
