using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNums
{
    class RationalNumber
    {
        private int enumerator;
        private int denumerator;

        public int Enumerator
        {
            get
            {
                return this.enumerator;
            }
            set
            {
                this.enumerator = value;
            }
        }
        public int Denumerator
        {
            get
            {
                return this.denumerator;
            }
            set
            {
                this.denumerator = value;
            }
        }
        //pi666ki
        public RationalNumber(int en, int den)
        {
            this.Enumerator = en;
            this.Denumerator = den;
        }

        public int BiggestDivider()
        {
            int ch=1;
            for (int i = 2; i <= enumerator && i <= denumerator; i++)
            {
                if (enumerator % i == 0 && denumerator % i == 0) ch = i;
            }
            return ch;
        }

        public void MakeUndivisible()
        {
            int ch = BiggestDivider();

            enumerator /= ch;
            denumerator /= ch;
        }

        public override string ToString()
        {
            return enumerator + "/" + denumerator;
        }
    }
}
