using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Apple
    {
        #region Fields
        private float amountLeft;
        private bool organic;

        #region Properties
        public float AmountLeft
        {
            get
            {
                return amountLeft;
            }
        }

        #endregion

        public bool Organic
        {
            get
            {
                return organic;
            }
        }

        #endregion

        #region Constructors
        public Apple(bool organic, float size)
        {
            this.organic = organic;
            this.amountLeft = size;
        }

        #endregion

        #region Methods
        public void TakeBite(float size)
        {
            if (size >= amountLeft)
            {
                amountLeft = 0;
            } else if (amountLeft != 0)
            {
                amountLeft -= size;
            }
        }

        #endregion


    }
}
