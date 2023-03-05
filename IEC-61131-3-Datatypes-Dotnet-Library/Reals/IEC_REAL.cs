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

namespace IEC_61131_3_Datatypes_Dotnet.Reals;


/// <summary>
/// IEC-61131-3 REAL (32-bit floating point value)
/// </summary>
public sealed class IEC_REAL : IReal<float, IEC_REAL>, IEquatable<IEC_REAL>, IComparable<IEC_REAL>
{
    public float Value { get; set; }

    public IEC_ValueType ValueType => IEC_ValueType.REAL;

    object IIECGenericDatatype.Value => Value;

    public object Clone() => new IEC_REAL { Value = Value };

    public int CompareTo(IEC_REAL? other)
    {
        if (other?.GetType() == null) return 1;
        return Value.CompareTo(other.Value);
    }

    public bool Equals(IEC_REAL? other) => Value.Equals(other?.Value);

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType()) return false;
        return Equals((IEC_REAL)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public IEC_REAL Abs() => new IEC_REAL { Value = (float)(Value < 0.0 ? Value * -1.0 : Value) };

    public IEC_REAL Round(int decimals)
    {
        var value = Math.Round(Value, decimals);
        return new IEC_REAL { Value = (float)value };
    }

    public int Compare(IEC_REAL other, float delta)
    {
        var result = Value - other.Value;
        if (result > delta && result > 0.0f)
            return 1;
        else if (result > delta && result < 0.0f)
            return -1;
        else
            return 0;
    }

    public bool IsLowerThan(IEC_REAL other, float delta) => Math.Abs(Value - other.Value) > delta && Value < other.Value;

    public bool IsGreaterThan(IEC_REAL other, float delta) => Math.Abs(Value - other.Value) > delta && Value > other.Value;

    public bool IsEqualTo(IEC_REAL other, float delta) => Math.Abs(Value - other.Value) <= delta;    
 
    public static implicit operator IEC_REAL(float value) => new IEC_REAL { Value = value };

    public static implicit operator float(IEC_REAL obj) => obj.Value;
}
