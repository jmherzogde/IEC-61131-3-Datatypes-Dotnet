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
/// IEC-61131-3 IEC_LTIME (64-bit duration datatype)
/// </summary>
public sealed class IEC_LTIME : DurationFormat, IDuration<UInt64>, IEquatable<IEC_LTIME>, IComparable<IEC_LTIME>
{
    public ulong Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.LTIME;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_LTIME { Value = Value };

    public int CompareTo(IEC_LTIME? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_LTIME? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_LTIME)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => this.ToString(Value);

    public bool TryFromString(string ltimeString)
    {
        try { Value = DurationFormat.FromStringToLTIME(ltimeString); return true; } catch (OverflowException) { return false; }
    }

    public static implicit operator IEC_LTIME(UInt64 value) => new IEC_LTIME { Value = value };

    public static implicit operator IEC_LTIME(string value) => new IEC_LTIME { Value = DurationFormat.FromStringToLTIME(value) };

    public static implicit operator UInt64(IEC_LTIME obj) => obj.Value;

    public static bool operator <(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value < obj2.Value;

    public static bool operator >(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value > obj2.Value;

    public static bool operator <=(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value <= obj2.Value;

    public static bool operator >=(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value >= obj2.Value;

    public static bool operator ==(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value == obj2.Value;

    public static bool operator !=(IEC_LTIME obj1, IEC_LTIME obj2) => obj1.Value != obj2.Value;
}
