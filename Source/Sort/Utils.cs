﻿/* 
 * Copyright (c) 2019 (PiJei) 
 * 
 * This file is part of CSFundamentalAlgorithms project.
 *
 * CSFundamentalAlgorithms is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * CSFundamentalAlgorithms is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with CSFundamentalAlgorithms.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;

namespace CSFundamentalAlgorithms.Sort
{
    public partial class Utils
    {
        public static void Swap<T>(List<T> values, int index1, int index2)
        {
            T temp = values[index1];
            values[index1] = values[index2];
            values[index2] = temp;
        }

        /// <summary>
        /// Gets the max element in the array. Alternatively we could use Linq.Max operator. However using this version so that the time complexity is obvious.
        /// </summary>
        /// <param name="values">Specifies a list of values (of type T, e.g., int). </param>
        /// <returns>maximum element in the array. </returns>
        public static T GetMaxElement<T>(List<T> values) where T : IComparable<T>
        {
            /* This method assumes values has at least one member. Otherwise this will throw a null reference exception . */
            T max = values[0];
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Computes the number of digits in a number. 
        /// An alternative is : 
        /// digitsCount = (n == 0 ? 1 : Math.Floor(Math.Log10(Math.Abs(n)) + 1));
        /// </summary>
        /// <param name="number">Specifies the integer for which we want to compute its digit count. </param>
        /// <returns>The number of digits in the given integer number. </returns>
        public static int GetDigitsCount(int number)
        {
            number = Math.Abs(number); /* To be able to compute the number of digits for negative integers as well. */
            int digitsCount = 1; /* In case number is 0, this approach will cover its digit count as well. */
            number = number / 10;
            while (number > 0)
            {
                digitsCount++;
                number = number / 10;
            }
            return digitsCount;
        }

        /// <summary>
        /// Gets the i(th) = whichDigit of the given integer number. For example in number 145, second digit is 4, and the third is 1, and th first is 5. 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="whichDigit"></param>
        /// <returns>The i(th) = whichDigit(th) digit from the right, or the least significant digit. </returns>
        public static int GetNthDigitFromRight(int number, int whichDigit)
        {
            int digit = (int)((Math.Abs(number) / Math.Pow(10, whichDigit - 1)) % 10);
            return digit;
        }
    }
}