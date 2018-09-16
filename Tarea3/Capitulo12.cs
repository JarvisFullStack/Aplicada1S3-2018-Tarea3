using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    class Capitulo12
    {
        /// <summary>
        /// Factorial de un numero n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>int </returns>
        public static int factorial(int n)
        {
            return n = (n < 2) ? n : n * factorial(n - 1);
        }
    }
}
