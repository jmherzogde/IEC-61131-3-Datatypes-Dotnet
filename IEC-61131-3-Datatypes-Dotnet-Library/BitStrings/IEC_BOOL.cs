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
/// IEC-61131-3 BOOL (1-bit boolean value)
/// </summary>
public sealed class IEC_BOOL : IBitString<bool>, IEquatable<IEC_BOOL>, IComparable<IEC_BOOL>
{
    public bool Value { get; set; } = default;

    public IEC_ValueType ValueType => IEC_ValueType.BOOL;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_BOOL { Value = Value };

    public int CompareTo(IEC_BOOL? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_BOOL? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_BOOL)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static implicit operator IEC_BOOL(bool value) => new IEC_BOOL { Value = value };

    public static implicit operator bool(IEC_BOOL obj) => obj.Value;

    public static bool operator ==(IEC_BOOL obj1, IEC_BOOL obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_BOOL obj1, IEC_BOOL obj2) => obj1.Value != obj2.Value;

}