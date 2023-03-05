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

using IEC_61131_3_Datatypes_Dotnet.Interfaces;


namespace IEC_61131_3_Datatypes_Dotnet.Integers;


/// <summary>
/// IEC-61131-3 DINT (32-bit signed Integer value)
/// </summary>
public sealed class IEC_DINT : IInteger<Int32, IEC_DINT>, IEquatable<IEC_DINT>, IComparable<IEC_DINT>
{
    public int Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.DINT;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_DINT { Value = Value };

    public int CompareTo(IEC_DINT? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_DINT? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_DINT)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_DINT Abs() => new IEC_DINT { Value = (Int32)((Value < 0) ? Value * -1 : Value) };

    public static implicit operator IEC_DINT(Int32 value) => new IEC_DINT { Value = value };

    public static implicit operator Int32(IEC_DINT obj) => obj.Value;

    public static bool operator <(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_DINT obj1, IEC_DINT obj2) => obj1.Value != obj2.Value;

    public static IEC_DINT operator >>(IEC_DINT obj, int bits) => new IEC_DINT { Value = (Int32)((int)obj.Value >> bits) };

    public static IEC_DINT operator <<(IEC_DINT obj, int bits) => new IEC_DINT { Value = (Int32)((int)obj.Value << bits) };

    public static IEC_DINT operator &(IEC_DINT obj1, IEC_DINT obj2) => new IEC_DINT { Value = (Int32)(obj1.Value & obj2.Value) };

    public static IEC_DINT operator |(IEC_DINT obj1, IEC_DINT obj2) => new IEC_DINT { Value = (Int32)(obj1.Value | obj2.Value) };

    public static IEC_DINT operator ^(IEC_DINT obj1, IEC_DINT obj2) => new IEC_DINT { Value = (Int32)(obj1.Value ^ obj2.Value) };

    public static IEC_DINT operator ~(IEC_DINT obj) => new IEC_DINT { Value = (Int32)obj.Value };
}
