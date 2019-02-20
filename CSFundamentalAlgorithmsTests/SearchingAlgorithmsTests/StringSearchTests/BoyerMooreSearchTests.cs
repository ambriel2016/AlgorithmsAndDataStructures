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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSFundamentalAlgorithms.SearchingAlgorithms.StringSearch;
using System.Collections.Generic;

namespace CSFundamentalAlgorithmsTests.SearchingAlgorithmsTests.StringSearchTests
{
    [TestClass]
    public class BoyerMooreSearchTests
    {
        [TestMethod]
        public void BoyerMooreSearch_MapCharToLastIndex_Test()
        {
            Dictionary<char, int> map1 = BoyerMooreSearch.MapCharToLastIndex("aabcdakka");
            Assert.AreEqual(5, map1.Keys.Count);
            Assert.AreEqual(8, map1['a']);
            Assert.AreEqual(2, map1['b']);
            Assert.AreEqual(3, map1['c']);
            Assert.AreEqual(7, map1['k']);
            Assert.AreEqual(4, map1['d']);
        }
    }
}
