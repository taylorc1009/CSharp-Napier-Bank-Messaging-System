using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class ValidateComponent
    {

        public ValidateComponent()
        {
        }


        /// <summary>
        /// @return
        /// </summary>
        public abstract bool validate();

    }
}