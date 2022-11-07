using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGenerics
{
    public class MaximumNumber
    {
        public M MaxNumber<M>(M value1, M value2, M value3)
        {
            if (value1.CompareTo(value2) > 0 && value1.CompareTo(value3) > 0 ||
                value1.CompareTo(value2) >= 0 && value1.CompareTo(value3) > 0 ||
                value1.CompareTo(value2) > 0 && value1.CompareTo(value3) >= 0)
            {
                return value1;
            }
            if (value2.CompareTo(value1) > 0 && value2.CompareTo(value3) > 0 ||
                value2.CompareTo(value1) >= 0 && value2.CompareTo(value3) > 0 ||
                value2.CompareTo(value1) > 0 && value2.CompareTo(value3) >= 0)
            {
                return value2;
            }
            if (value3.CompareTo(value1) > 0 && value3.CompareTo(value2) > 0 ||
                value3.CompareTo(value1) >= 0 && value3.CompareTo(value2) > 0 ||
                value3.CompareTo(value1) > 0 && value3.CompareTo(value2) >= 0)
            {
                return value3;
            }
            return value1;
        }
    }
}
