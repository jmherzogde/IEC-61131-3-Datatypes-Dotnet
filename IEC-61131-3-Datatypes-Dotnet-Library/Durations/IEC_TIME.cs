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

namespace IEC_61131_3_Datatypes_Dotnet.Durations;


/// <summary>
/// IEC-61131-3 IEC_TIME (32-bit duration datatype) 
/// </summary>
public sealed class IEC_TIME : DurationFormat, IDuration<UInt32>, IEquatable<IEC_TIME>, IComparable<IEC_TIME>
{
    public uint Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.TIME;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_TIME { Value = Value };

    public int CompareTo(IEC_TIME? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_TIME? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_TIME)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => ToString(Value);

    public bool TryFromString(string timeString)
    {
        try { Value = FromStringToTIME(timeString); return true; } catch (Exception) { return false; }
    }

    public static implicit operator IEC_TIME(UInt32 value) => new IEC_TIME { Value = value };

    public static implicit operator IEC_TIME(string value) => new IEC_TIME { Value = FromStringToTIME(value) };

    public static implicit operator UInt32(IEC_TIME obj) => obj.Value;

    public static bool operator <(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_TIME obj1, IEC_TIME obj2) => obj1.Value != obj2.Value;
}
