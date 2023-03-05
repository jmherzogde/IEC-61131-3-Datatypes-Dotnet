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
using IEC_61131_3_Datatypes_Dotnet.Interfaces;


namespace IEC_61131_3_Datatypes_Dotnet.Integers;


/// <summary>
/// IEC-61131-3 USINT (8-bit unsigned Integer value)
/// </summary>
public sealed class IEC_USINT : IInteger<byte, IEC_USINT>, IEquatable<IEC_USINT>, IComparable<IEC_USINT>
{
    public byte Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.USINT;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_USINT { Value = Value };

    public int CompareTo(IEC_USINT? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_USINT? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_USINT)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_USINT Abs() => (IEC_USINT)this.Clone();

    public static implicit operator IEC_USINT(byte value) => new IEC_USINT { Value = value };

    public static implicit operator byte(IEC_USINT obj) => obj.Value;

    public static bool operator <(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_USINT obj1, IEC_USINT obj2) => obj1.Value != obj2.Value;

    public static IEC_USINT operator >>(IEC_USINT obj, int bits) => new IEC_USINT { Value = (byte)((int)obj.Value >> bits) };

    public static IEC_USINT operator <<(IEC_USINT obj, int bits) => new IEC_USINT { Value = (byte)((int)obj.Value << bits) };

    public static IEC_USINT operator &(IEC_USINT obj1, IEC_USINT obj2) => new IEC_USINT { Value = (byte)(obj1.Value & obj2.Value) };

    public static IEC_USINT operator |(IEC_USINT obj1, IEC_USINT obj2) => new IEC_USINT { Value = (byte)(obj1.Value | obj2.Value) };

    public static IEC_USINT operator ^(IEC_USINT obj1, IEC_USINT obj2) => new IEC_USINT { Value = (byte)(obj1.Value ^ obj2.Value) };

    public static IEC_USINT operator ~(IEC_USINT obj) => new IEC_USINT { Value = (byte)obj.Value };
}