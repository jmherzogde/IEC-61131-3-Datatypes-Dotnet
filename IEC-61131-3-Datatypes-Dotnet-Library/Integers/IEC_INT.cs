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
/// IEC-61131-3 INT (16-bit signed Integer value)
/// </summary>
public sealed class IEC_INT : IInteger<Int16, IEC_INT>, IEquatable<IEC_INT>, IComparable<IEC_INT>
{
    public short Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.INT;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_INT { Value = Value };

    public int CompareTo(IEC_INT? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_INT? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_INT)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_INT Abs() => new IEC_INT { Value = (Int16)((Value < 0) ? Value * -1 : Value) };

    public static implicit operator IEC_INT(Int16 value) => new IEC_INT { Value = value };

    public static implicit operator Int16(IEC_INT obj) => obj.Value;

    public static bool operator <(IEC_INT obj1, IEC_INT obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_INT obj1, IEC_INT obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_INT obj1, IEC_INT obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_INT obj1, IEC_INT obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_INT obj1, IEC_INT obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_INT obj1, IEC_INT obj2) => obj1.Value != obj2.Value;

    public static IEC_INT operator >>(IEC_INT obj, int bits) => new IEC_INT { Value = (Int16)((int)obj.Value >> bits) };

    public static IEC_INT operator <<(IEC_INT obj, int bits) => new IEC_INT { Value = (Int16)((int)obj.Value << bits) };

    public static IEC_INT operator &(IEC_INT obj1, IEC_INT obj2) => new IEC_INT { Value = (Int16)(obj1.Value & obj2.Value) };

    public static IEC_INT operator |(IEC_INT obj1, IEC_INT obj2) => new IEC_INT { Value = (Int16)(obj1.Value | obj2.Value) };

    public static IEC_INT operator ^(IEC_INT obj1, IEC_INT obj2) => new IEC_INT { Value = (Int16)(obj1.Value ^ obj2.Value) };

    public static IEC_INT operator ~(IEC_INT obj) => new IEC_INT { Value = (Int16)obj.Value };
}