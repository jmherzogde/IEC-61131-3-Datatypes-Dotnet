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
/// IEC6113-1 WORD (16-bit unsigned value)
/// </summary>
public sealed class IEC_WORD : IBitString<UInt16>, IEquatable<IEC_WORD>, IEquatable<object>, IComparable<IEC_WORD>
{
    public ushort Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.WORD;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_WORD { Value = Value };

    public int CompareTo(IEC_WORD? other)
    {
        if (other?.GetType() == null) throw new NullReferenceException();
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_WORD? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_WORD)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public int CompareTo(object? other)
    {
        if(other == null || other.GetType() != GetType()) throw new ArgumentNullException();
        return this.CompareTo(other as IEC_WORD);
    }

    public static implicit operator IEC_WORD(UInt16 value) => new IEC_WORD { Value = value };

    public static implicit operator UInt16(IEC_WORD obj) => obj.Value;

    public static bool operator <(IEC_WORD obj1, IEC_WORD obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_WORD obj1, IEC_WORD obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_WORD obj1, IEC_WORD obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_WORD obj1, IEC_WORD obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_WORD obj1, IEC_WORD obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_WORD? obj1, IEC_WORD obj2) => obj1?.Value != obj2.Value;

    public static IEC_WORD operator >>(IEC_WORD obj, int bits) => new IEC_WORD { Value = (UInt16)((int)obj.Value >> bits) };

    public static IEC_WORD operator <<(IEC_WORD obj, int bits) => new IEC_WORD { Value = (UInt16)((int)obj.Value << bits) };

    public static IEC_WORD operator &(IEC_WORD obj1, IEC_WORD obj2) => new IEC_WORD { Value = (UInt16)(obj1.Value & obj2.Value) };

    public static IEC_WORD operator |(IEC_WORD obj1, IEC_WORD obj2) => new IEC_WORD { Value = (UInt16)(obj1.Value | obj2.Value) };

    public static IEC_WORD operator ^(IEC_WORD obj1, IEC_WORD obj2) => new IEC_WORD { Value = (UInt16)(obj1.Value ^ obj2.Value) };

    public static IEC_WORD operator ~(IEC_WORD obj) => new IEC_WORD { Value = (UInt16)obj.Value };
}
