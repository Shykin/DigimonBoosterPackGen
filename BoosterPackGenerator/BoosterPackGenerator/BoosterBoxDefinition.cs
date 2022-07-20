using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterPackGenerator
{
    public class BoosterBoxDefinition
    {
        public int Commons;
        public int Uncommons;
        public int Rares;
        public int SuperRares;
        public int SecretRares;

        public BoosterBoxDefinition(int commons, int uncommons, int rares, int superRares, int secretRares)
        {
            Commons = commons;
            Uncommons = uncommons;
            Rares = rares;
            SuperRares = superRares;
            SecretRares = secretRares;
        }

        public int TotalCards
        {
            get
            {
                return Commons + Uncommons + Rares + SecretRares + SuperRares;
            }
        }
    }
}
