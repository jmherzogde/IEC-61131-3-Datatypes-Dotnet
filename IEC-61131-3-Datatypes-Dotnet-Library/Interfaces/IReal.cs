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

namespace IEC_61131_3_Datatypes_Dotnet.Interfaces;


public interface IReal<T, U> : IIECGenericDatatype where T : IComparable, IEquatable<T>
    where U : class
{
    new T Value { get; set; }

    U Abs();

    int Compare(U other, T delta);

    bool IsLowerThan(U other, T delta);

    bool IsGreaterThan(U other, T delta);

    bool IsEqualTo(U other, T delta);

    U Round(int decimals);
}
