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

using IEC_61131_3_Datatypes_Dotnet.BitStrings;


namespace IEC_BOOL_TESTS
{
    [TestClass]
    public class IEC_BOOL_BasicTests
    {
        [TestMethod]
        public void DefaultInitTest()
        {
            var variable1 = new IEC_BOOL();
            Assert.IsTrue(variable1.GetType() == typeof(IEC_BOOL));
            Assert.AreEqual(variable1.Value, false);

            IEC_BOOL variable2 = true;
            Assert.IsTrue(variable2.GetType() == typeof(IEC_BOOL));
            Assert.AreEqual(variable2.Value, true);

            IEC_BOOL variable3 = new IEC_BOOL { Value = true };
            Assert.IsTrue(variable3.GetType() == typeof(IEC_BOOL));
            Assert.AreEqual(variable3.Value, true);
        }

        [TestMethod]
        public void CompareTest()
        {
            var variable1 = new IEC_BOOL();
            var variable2 = new IEC_BOOL();
            Assert.IsTrue(variable1.CompareTo(variable2) == 0);
            variable1 = true;
            Assert.IsTrue(variable1.CompareTo(variable2) > 0);
        }

        [TestMethod]
        public void EqualsTest()
        {
            var variable1 = new IEC_BOOL();
            var variable2 = new IEC_BOOL();
            Assert.IsTrue(variable1.Equals(variable2));

            variable2 = true;
            Assert.IsFalse(variable1.Equals(variable2));
        }
    }
}