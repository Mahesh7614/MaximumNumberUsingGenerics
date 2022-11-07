﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGenerics
{
    public static class MaximumNumber
    {
        public static int MaximumIntegerNumber(int Number1, int Number2, int Number3)
        {
            if (Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) >= 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) >= 0)
            {
                return Number1;
            }
            if (Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) >= 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) >= 0)
            {
                return Number2;
            }
            if (Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) >= 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) >= 0)
            {
                return Number3;
            }
            return Number1;
        }
    }
}