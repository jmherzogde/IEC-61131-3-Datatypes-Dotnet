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

namespace IEC_61131_3_Datatypes_Dotnet.BitStrings;


/// <summary>
/// IEC-61131-3 BYTE (8-bit unsigned value)
/// </summary>
public sealed class IEC_BYTE : IBitString<byte>, IEquatable<IEC_BYTE>, IEquatable<object>, IComparable<IEC_BYTE>
{
    public byte Value { get; set; } = default;

    public IEC_ValueType ValueType => IEC_ValueType.BYTE;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_BYTE { Value = Value };

    public int CompareTo(IEC_BYTE? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_BYTE? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_BYTE)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static implicit operator IEC_BYTE(byte value) => new IEC_BYTE { Value = value };

    public static implicit operator byte(IEC_BYTE obj) => obj.Value;

    public static bool operator <(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_BYTE obj1, IEC_BYTE obj2) => obj1.Value != obj2.Value;

    public static IEC_BYTE operator >>(IEC_BYTE obj, int bits) => new IEC_BYTE { Value = (byte)((int)obj.Value >> bits) };

    public static IEC_BYTE operator <<(IEC_BYTE obj, int bits) => new IEC_BYTE { Value = (byte)((int)obj.Value << bits) };

    public static IEC_BYTE operator &(IEC_BYTE obj1, IEC_BYTE obj2) => new IEC_BYTE { Value = (byte)(obj1.Value & obj2.Value) };

    public static IEC_BYTE operator |(IEC_BYTE obj1, IEC_BYTE obj2) => new IEC_BYTE { Value = (byte)(obj1.Value | obj2.Value) };

    public static IEC_BYTE operator ^(IEC_BYTE obj1, IEC_BYTE obj2) => new IEC_BYTE { Value = (byte)(obj1.Value ^ obj2.Value) };

    public static IEC_BYTE operator ~(IEC_BYTE obj) => new IEC_BYTE { Value = (byte)obj.Value };
}
