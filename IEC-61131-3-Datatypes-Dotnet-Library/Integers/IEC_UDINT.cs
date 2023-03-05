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
/// IEC-61131-3 UDINT (32-bit unsigned Integer value)
/// </summary>
public sealed class IEC_UDINT : IInteger<UInt32, IEC_UDINT>, IEquatable<IEC_UDINT>, IComparable<IEC_UDINT>
{
    public uint Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.UDINT;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_UDINT { Value = Value };

    public int CompareTo(IEC_UDINT? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_UDINT? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_UDINT)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_UDINT Abs() => (IEC_UDINT)this.Clone();

    public static implicit operator IEC_UDINT(UInt32 value) => new IEC_UDINT { Value = value };

    public static implicit operator UInt32(IEC_UDINT obj) => obj.Value;

    public static bool operator <(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_UDINT obj1, IEC_UDINT obj2) => obj1.Value != obj2.Value;

    public static IEC_UDINT operator >>(IEC_UDINT obj, int bits) => new IEC_UDINT { Value = (UInt32)((int)obj.Value >> bits) };

    public static IEC_UDINT operator <<(IEC_UDINT obj, int bits) => new IEC_UDINT { Value = (UInt32)((int)obj.Value << bits) };

    public static IEC_UDINT operator &(IEC_UDINT obj1, IEC_UDINT obj2) => new IEC_UDINT { Value = (UInt32)(obj1.Value & obj2.Value) };

    public static IEC_UDINT operator |(IEC_UDINT obj1, IEC_UDINT obj2) => new IEC_UDINT { Value = (UInt32)(obj1.Value | obj2.Value) };

    public static IEC_UDINT operator ^(IEC_UDINT obj1, IEC_UDINT obj2) => new IEC_UDINT { Value = (UInt32)(obj1.Value ^ obj2.Value) };

    public static IEC_UDINT operator ~(IEC_UDINT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
}