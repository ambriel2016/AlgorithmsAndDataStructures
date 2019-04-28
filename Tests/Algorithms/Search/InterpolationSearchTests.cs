﻿#region copyright
/* 
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
 * along with CSFundamentals.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System.Collections.Generic;
using CSFundamentals.Algorithms.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSFundamentalsTests.Algorithms.Search
{
    /// <summary>
    /// Tests methods in <see cref="InterpolationSearch"/> class. 
    /// </summary>
    [TestClass]
    public class InterpolationSearchTests
    {
        /// <summary>
        /// Tests the correctness of Interpolation search algorithm on an array with distinct elements. 
        /// </summary>
        [TestMethod]
        public void Search_DistinctElements()
        {
            SearchTests.DistinctElements_ExpectsToSuccessfullyGetTheIndexOfTheirPosition(InterpolationSearch.Search);
        }

        /// <summary>
        /// Tests the correctness of Interpolation search algorithm on an array with duplicate elements. 
        /// </summary>
        [TestMethod]
        public void Search_DuplicateElements()
        {
            SearchTests.DuplicateElements_ExpectsToGetTheIndexOfOneOfTheDupliatesNoMatterHowManyTimeSearchIsPerformed(InterpolationSearch.Search);
        }

        /// <summary>
        /// Tests the correctness of Interpolation search algorithm when the key does not exist in the array. 
        /// </summary>
        [TestMethod]
        public void Search_NonExistingElements()
        {
            SearchTests.NonExistingElements_ExpectsToGetMinusOne(InterpolationSearch.Search);
        }

        /// <summary>
        /// Tests the correctness of computing the index at which to start search when using Interpolation algorithm. 
        /// </summary>
        [TestMethod]
        public void GetStartIndex()
        {
            var values = new List<int> { 3, 7, 10, 14, 21, 27, 27, 32, 38, 45, 53 };

            Assert.AreEqual(39, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 200));
            Assert.AreEqual(10, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 53));
            Assert.AreEqual(0, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, -1));
            Assert.AreEqual(2, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 14));
            Assert.AreEqual(4, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 27));
            Assert.AreEqual(5, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 32));
            Assert.AreEqual(0, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 7));
            Assert.AreEqual(0, InterpolationSearch.GetStartIndex(values, 0, values.Count - 1, 4));
        }
    }
}
