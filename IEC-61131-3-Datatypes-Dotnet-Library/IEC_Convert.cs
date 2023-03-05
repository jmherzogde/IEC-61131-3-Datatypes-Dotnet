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
using IEC_61131_3_Datatypes_Dotnet.Integers;

namespace IEC_61131_3_Datatypes_Dotnet;


/// <summary>
/// Capsulse IEC Explicit Type Conversion Methods
/// </summary>
public static class IEC_Convert
{
    #region Explicit Conversions for IEC_BYTE
    public static IEC_BYTE ToBYTE(IEC_WORD obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_WORD obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = (byte)obj.Value; return true; } catch(OverflowException) { return false; }
    }
    public static IEC_BYTE ToByte(IEC_DWORD obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_DWORD obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToByte(IEC_SINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_SINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToBYTE(IEC_USINT obj) => new IEC_BYTE { Value = obj.Value };
    public static bool TryToBYTE(IEC_USINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE { Value = obj.Value };
        return true;
    }
    public static IEC_BYTE ToBYTE(IEC_INT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_INT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToBYTE(IEC_UINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_UINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }

    }
    public static IEC_BYTE ToBYTE(IEC_DINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_DINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToBYTE(IEC_UDINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_UDINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToBYTE(IEC_LINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_LINT obj, out IEC_BYTE result)
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_BYTE ToBYTE(IEC_ULINT obj) => new IEC_BYTE { Value = (byte)obj.Value };
    public static bool TryToBYTE(IEC_ULINT obj, out IEC_BYTE result) 
    {
        result = new IEC_BYTE();
        try { result.Value = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_WORD
    public static IEC_WORD ToWORD(IEC_BYTE obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_BYTE obj, out IEC_WORD result) 
    {
        result= new IEC_WORD();
        try { result.Value = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_DWORD obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_DWORD obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result.Value = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_LWORD obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_LWORD obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_SINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_SINT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_USINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_USINT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_INT obj) => new IEC_WORD { Value = (UInt16)obj.Value }; 
    public static bool TryToWORD(IEC_INT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_UINT obj) => new IEC_WORD { Value = obj.Value };
    public static bool TryToWORD(IEC_UINT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_DINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_DINT obj, out IEC_WORD result) 
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_UDINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_UDINT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_LINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_LINT obj, out IEC_WORD result)
    {
        result = new IEC_WORD();
        try { result.Value = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_WORD ToWORD(IEC_ULINT obj) => new IEC_WORD { Value = (UInt16)obj.Value };
    public static bool TryToWORD(IEC_ULINT obj, out IEC_WORD result) 
    {
        result = new IEC_WORD();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_DWORD
    public static IEC_DWORD ToDWORD(IEC_BYTE obj) => new IEC_DWORD { Value = (UInt32)obj.Value };
    public static IEC_DWORD ToDWORD(IEC_WORD obj) => new IEC_DWORD { Value = (UInt32)obj.Value };
    public static IEC_DWORD ToDWORD(IEC_LWORD obj) => new IEC_DWORD { Value = (UInt32)obj.Value };
    public static bool TryToDWORD(IEC_LWORD obj, out IEC_DWORD result)
    {
        result = new IEC_DWORD();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_LWORD
    public static IEC_LWORD ToLWORD(IEC_BYTE obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_BYTE obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_WORD obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_WORD obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_DWORD obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_DWORD obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_SINT obj) => new IEC_LWORD { Value = (UInt32)obj.Value };
    public static bool TryToLWORD(IEC_SINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_USINT obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_USINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_INT obj) => new IEC_LWORD { Value = (UInt32)obj.Value };
    public static bool TryToLWORD(IEC_INT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_UINT obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_UINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_DINT obj) => new IEC_LWORD { Value = (UInt32)obj.Value };
    public static bool TryToLWORD(IEC_DINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_UDINT obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_UDINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_LINT obj) => new IEC_LWORD { Value = (UInt32)obj.Value };
    public static bool TryToLWORD(IEC_LINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LWORD ToLWORD(IEC_ULINT obj) => new IEC_LWORD { Value = obj.Value };
    public static bool TryToLWORD(IEC_ULINT obj, out IEC_LWORD result)
    {
        result = new IEC_LWORD();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_SINT
    public static IEC_SINT ToSINT(IEC_BYTE obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_BYTE obj, out IEC_SINT result) 
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_WORD obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_WORD obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_DWORD obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_DWORD obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_LWORD obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_LWORD obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_USINT obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_USINT obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_INT obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_INT obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_UINT obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_UINT obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_DINT obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_DINT obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_SINT ToSINT(IEC_UDINT obj) => new IEC_SINT { Value = (sbyte)obj.Value };
    public static bool TryToSINT(IEC_UDINT obj, out IEC_SINT result)
    {
        result = new IEC_SINT();
        try { result = Convert.ToSByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_USINT
    public static IEC_USINT ToUSINT(IEC_BYTE obj) => new IEC_USINT { Value = obj.Value };
    public static bool TryToUSINT(IEC_BYTE obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_WORD obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_WORD obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_DWORD obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_DWORD obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_LWORD obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_LWORD obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_SINT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_SINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_INT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_INT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_UINT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_UINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_DINT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_DINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_UDINT obj) => new IEC_USINT { Value= (byte)obj.Value };
    public static bool TryToUSINT(IEC_UDINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_LINT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_LINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_USINT ToUSINT(IEC_ULINT obj) => new IEC_USINT { Value = (byte)obj.Value };
    public static bool TryToUSINT(IEC_ULINT obj, out IEC_USINT result)
    {
        result = new IEC_USINT();
        try { result = Convert.ToByte(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_INT
    public static IEC_INT ToINT(IEC_BYTE obj) => new IEC_INT {  Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_BYTE obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_WORD obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_WORD obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_DWORD obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_DWORD obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_LWORD obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_LWORD obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_SINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_SINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_USINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_USINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_UINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_UINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_DINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_DINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_UDINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_UDINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_LINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_LINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_INT ToINT(IEC_ULINT obj) => new IEC_INT { Value = (Int16)obj.Value };
    public static bool TryToINT(IEC_ULINT obj, out IEC_INT result)
    {
        result = new IEC_INT();
        try { result = Convert.ToInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_UINT
    public static IEC_UINT ToUINT(IEC_BYTE obj) => new IEC_UINT { Value = obj.Value };
    public static bool TryToUINT(IEC_BYTE obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_WORD obj) => new IEC_UINT { Value = obj.Value };
    public static bool TryToUINT(IEC_WORD obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_DWORD obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_DWORD obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_LWORD obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_LWORD obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_SINT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_SINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_USINT obj) => new IEC_UINT { Value = obj.Value };
    public static bool TryToUINT(IEC_USINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_INT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_INT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_DINT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_DINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_UDINT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_UDINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_LINT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_LINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UINT ToUINT(IEC_ULINT obj) => new IEC_UINT { Value = (UInt16)obj.Value };
    public static bool TryToUINT(IEC_ULINT obj, out IEC_UINT result)
    {
        result = new IEC_UINT();
        try { result = Convert.ToUInt16(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_DINT
    public static IEC_DINT ToDINT(IEC_BYTE obj) => new IEC_DINT { Value = obj.Value };
    public static bool TryToDINT(IEC_BYTE obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch(OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_WORD obj) => new IEC_DINT { Value = obj.Value };
    public static bool TryToDINT(IEC_WORD obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_DWORD obj) => new IEC_DINT { Value = (Int32)obj.Value };
    public static bool TryToDINT(IEC_DWORD obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_LWORD obj) => new IEC_DINT { Value = (Int32)obj.Value };
    public static bool TryToDINT(IEC_LWORD obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_SINT obj) => new IEC_DINT { Value = obj.Value };
    public static bool TryToDINT(IEC_SINT obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_UINT obj) => new IEC_DINT { Value = obj.Value };
    public static bool TryToDINT(IEC_UINT obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_INT obj) => new IEC_DINT { Value = obj.Value };
    public static bool TryToDINT(IEC_INT obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_LINT obj) => new IEC_DINT { Value = (Int32)obj.Value };
    public static bool TryToDINT(IEC_LINT obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_DINT ToDINT(IEC_ULINT obj) => new IEC_DINT { Value = (Int32)obj.Value };
    public static bool TryToDINT(IEC_ULINT obj, out IEC_DINT result)
    {
        result = new IEC_DINT();
        try { result = Convert.ToInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_UDINT
    public static IEC_UDINT ToUDINT(IEC_BYTE obj) => new IEC_UDINT { Value = obj.Value };
    public static bool TryToUDINT(IEC_BYTE obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_WORD obj) => new IEC_UDINT { Value = obj.Value };
    public static bool TryToUDINT(IEC_WORD obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_DWORD obj) => new IEC_UDINT { Value = obj.Value };
    public static bool TryToUDINT(IEC_DWORD obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_LWORD obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_LWORD obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_SINT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_SINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_USINT obj) => new IEC_UDINT { Value = obj.Value };
    public static bool TryToUDINT(IEC_USINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_INT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_INT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_UINT obj) => new IEC_UDINT { Value = obj.Value };
    public static bool TryToUDINT(IEC_UINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_DINT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_DINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_LINT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_LINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_UDINT ToUDINT(IEC_ULINT obj) => new IEC_UDINT { Value = (UInt32)obj.Value };
    public static bool TryToUDINT(IEC_ULINT obj, out IEC_UDINT result)
    {
        result = new IEC_UDINT();
        try { result = Convert.ToUInt32(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_LINT
    public static IEC_LINT ToLINT(IEC_BYTE obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_BYTE obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_WORD obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_WORD obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_DWORD obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_DWORD obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_LWORD obj) => new IEC_LINT { Value = (Int64)obj.Value };
    public static bool TryToLINT(IEC_LWORD obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_SINT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_SINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_USINT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_USINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_INT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_INT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_UINT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_UINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_DINT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_DINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_UDINT obj) => new IEC_LINT { Value = obj.Value };
    public static bool TryToLINT(IEC_UDINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_LINT ToLINT(IEC_ULINT obj) => new IEC_LINT { Value = (Int64)obj.Value };
    public static bool TryToLINT(IEC_ULINT obj, out IEC_LINT result)
    {
        result = new IEC_LINT();
        try { result = Convert.ToInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion

    #region Explicit Conversions for IEC_ULINT
    public static IEC_ULINT ToULINT(IEC_BYTE obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_BYTE obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_WORD obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_WORD obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_DWORD obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_DWORD obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_LWORD obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_LWORD obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_SINT obj) => new IEC_ULINT { Value = (UInt64)obj.Value };
    public static bool TryToULINT(IEC_SINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_USINT obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_USINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_INT obj) => new IEC_ULINT { Value = (UInt64)obj.Value };
    public static bool TryToULINT(IEC_INT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_UINT obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_UINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_DINT obj) => new IEC_ULINT { Value = (UInt64)obj.Value };
    public static bool TryToULINT(IEC_DINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_UDINT obj) => new IEC_ULINT { Value = obj.Value };
    public static bool TryToULINT(IEC_UDINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    public static IEC_ULINT ToULINT(IEC_LINT obj) => new IEC_ULINT { Value = (UInt64)obj.Value };
    public static bool TryToULINT(IEC_LINT obj, out IEC_ULINT result)
    {
        result = new IEC_ULINT();
        try { result = Convert.ToUInt64(obj.Value); return true; } catch (OverflowException) { return false; }
    }
    #endregion
}
