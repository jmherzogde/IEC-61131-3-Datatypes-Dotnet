// This file is part of IEC-61131-3-Datatypes-Dotnet-Library
// 
// Copyright (C) 2023 Jean Marcel Herzog
//
// This program is free software; you can distribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using IEC_61131_3_Datatypes_Dotnet.Integers;

namespace IEC_UINT_TESTS
{
    [TestClass]
    public class IEC_UINT_BasicTests
    {
        [TestMethod]
        public void DefaultInitTest()
        {
            var variable1 = new IEC_UINT();
            Assert.IsTrue(variable1.GetType() == typeof(IEC_UINT));
            Assert.AreEqual(variable1.Value, (UInt16)0);

            IEC_UINT variable2 = 127;
            Assert.IsTrue(variable2.GetType() == typeof(IEC_UINT));
            Assert.AreEqual(variable2.Value, (UInt16)127);

            var variable3 = new IEC_UINT() { Value = 90 };
            Assert.IsTrue(variable3.GetType() == typeof(IEC_UINT));
            Assert.AreEqual(variable3.Value, (UInt16)90);
        }

        [TestMethod]
        public void CompareTest()
        {
            var variable1 = new IEC_UINT();
            var variable2 = new IEC_UINT();
            Assert.IsTrue(variable1.CompareTo(variable2) == 0);

            variable1 = 120;

            Assert.IsTrue(variable1.CompareTo(variable2) > 0);
            Assert.IsTrue(variable2.CompareTo(variable1) < 0);
        }

        [TestMethod]
        public void EqualsTest()
        {
            var variable1 = new IEC_UINT();
            var variable2 = new IEC_UINT();
            Assert.IsTrue(variable1.Equals(variable2));

            variable2 = 90;
            Assert.IsFalse(variable1.Equals(variable2));
        }
    }
}