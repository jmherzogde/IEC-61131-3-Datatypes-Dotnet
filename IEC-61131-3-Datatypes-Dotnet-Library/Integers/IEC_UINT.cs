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
/// IEC-61131-3 SINT (16-bit unsigned Integer value)
/// </summary>
public sealed class IEC_UINT : IInteger<UInt16, IEC_UINT>, IEquatable<IEC_UINT>, IComparable<IEC_UINT>
{
    public ushort Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.UINT;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_UINT { Value = Value };

    public int CompareTo(IEC_UINT? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_UINT? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_SINT)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_UINT Abs() => (IEC_UINT)this.Clone();

    public static implicit operator IEC_UINT(UInt16 value) => new IEC_UINT { Value = value };

    public static implicit operator UInt16(IEC_UINT obj) => obj.Value;

    public static bool operator <(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_UINT obj1, IEC_UINT obj2) => obj1.Value != obj2.Value;

    public static IEC_UINT operator >>(IEC_UINT obj, int bits) => new IEC_UINT { Value = (ushort)((int)obj.Value >> bits) };

    public static IEC_UINT operator <<(IEC_UINT obj, int bits) => new IEC_UINT { Value = (ushort)((int)obj.Value << bits) };

    public static IEC_UINT operator &(IEC_UINT obj1, IEC_UINT obj2) => new IEC_UINT { Value = (ushort)(obj1.Value & obj2.Value) };

    public static IEC_UINT operator |(IEC_UINT obj1, IEC_UINT obj2) => new IEC_UINT { Value = (ushort)(obj1.Value | obj2.Value) };

    public static IEC_UINT operator ^(IEC_UINT obj1, IEC_UINT obj2) => new IEC_UINT { Value = (ushort)(obj1.Value ^ obj2.Value) };

    public static IEC_UINT operator ~(IEC_UINT obj) => new IEC_UINT { Value = (ushort)obj.Value };
}
