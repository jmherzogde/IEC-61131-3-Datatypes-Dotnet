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

using System.Text.RegularExpressions;

namespace IEC_61131_3_Datatypes_Dotnet.Durations;


/// <summary>
/// Basic Duration Format Class.
/// This class provides basic Methods to format IEC_TIME and IEC_LTIME
/// to string.
/// </summary>
public class DurationFormat
{
    public string ToString(UInt32 value)
    {
        TimeSpan timeSpan = TimeSpan.FromMilliseconds(value);
        var days = timeSpan.Days;
        var hours = timeSpan.Hours;
        var minutes = timeSpan.Minutes;
        var seconds = timeSpan.Seconds;
        var milliseconds = timeSpan.Milliseconds;

        return this.buildTimeString(Convert.ToInt32(days),
            Convert.ToInt32(hours), Convert.ToInt32(minutes), Convert.ToInt32(seconds), Convert.ToInt32(milliseconds), -1, -1);
    }

    public string ToString(UInt64 value)
    {
        ulong nanoseconds = 0;
        ulong microseconds = 0;
        ulong milliseconds = 0;
        ulong seconds = 0;
        ulong minutes = 0;
        ulong hours = 0;
        ulong days = 0;


        days = (value - (value % 86400000000000)) / 86400000000000;
        value -= days * 86400000000000;

        hours = (value - (value % 3600000000000)) / 3600000000000;
        value -= hours * 3600000000000;

        minutes = (value - (value % 60000000000)) / 60000000000;
        value -= minutes * 60000000000;

        seconds = (value - (value % 1000000000)) / 1000000000;
        value -= seconds * 1000000000;

        milliseconds = (value - (value % 1000000)) / 1000000;
        value -= milliseconds * 1000000;

        microseconds = value / 1000;
        nanoseconds = value - (microseconds * 1000);

        return this.buildTimeString(Convert.ToInt32(days),
            Convert.ToInt64(hours), Convert.ToInt64(minutes), Convert.ToInt64(seconds), Convert.ToInt64(milliseconds), Convert.ToInt64(microseconds), Convert.ToInt64(nanoseconds));
    }

    public static UInt32 FromStringToTIME(string timeString)
    {
        int days = 0, hours = 0, minutes = 0, seconds = 0, milliseconds = 0;
        const string pattern = @"(\d+)([a-zA-Z]+)";
        MatchCollection matches = Regex.Matches(timeString, pattern);
        foreach(Match match in matches)
        {
            int number = int.Parse(match.Groups[1].Value);
            string unit = match.Groups[2].Value;

            switch(unit)
            {
                case "d": days = number; break;
                case "h": hours = number; break;
                case "m": minutes = number; break;
                case "s": seconds = number; break;
                case "ms": milliseconds = number; break;
                default: break;
            }
        }

        UInt32 value = (UInt32)milliseconds;
        value += (UInt32)(seconds * 1000);
        value += (UInt32)(minutes * 60000);
        value += (UInt32)(hours * 3600000);
        value += (UInt32)(days * 86400000);

        return value;
    }

    public static UInt64 FromStringToLTIME(string ltimeString)
    {
        int days = 0, hours = 0, minutes = 0, seconds = 0, milliseconds = 0, microseconds = 0, nanoseconds = 0;
        const string pattern = @"(\d+)([a-zA-Z]+)";
        MatchCollection matches = Regex.Matches(ltimeString, pattern);
        foreach (Match match in matches)
        {
            int number = int.Parse(match.Groups[1].Value);
            string unit = match.Groups[2].Value;

            switch (unit)
            {
                case "d": days = number; break;
                case "h": hours = number; break;
                case "m": minutes = number; break;
                case "s": seconds = number; break;
                case "ms": milliseconds = number; break;
                case "us": microseconds = number; break;
                case "ns": nanoseconds = number; break;
                default: break;
            }
        }

        UInt64 value = (UInt64)nanoseconds;
        value += (UInt64)microseconds * (UInt64)1000;
        value += (UInt64)milliseconds * (UInt64)1000000;
        value += (UInt64)seconds * (UInt64)1000000000;
        value += (UInt64)minutes * (UInt64)60000000000;
        value += (UInt64)hours * (UInt64)3600000000000;
        value += (UInt64)days * (UInt64)86400000000000;
        return value;
    }

    private string buildTimeString(long days, long hours, long minutes, long seconds, long milliseconds, long microseconds, long nanoseconds)
    {
        var returnString = (nanoseconds > 0) ? "LTIME#" : "T#";

        if (days > 0)
            returnString += days.ToString() + "d";
        if (hours > 0)
            returnString += hours.ToString() + "h";
        if (minutes > 0)
            returnString += minutes.ToString() + "m";
        if (seconds > 0)
            returnString += seconds.ToString() + "s";
        if (milliseconds > 0 || days == 0 && hours == 0 && minutes == 0 && seconds == 0 && microseconds == -1 && nanoseconds == -1)
            returnString += milliseconds.ToString() + "ms";
        if (microseconds > 0)
            returnString += microseconds.ToString() + "us";
        if (nanoseconds > 0 || days == 0 && hours == 0 && minutes == 0 && seconds == 0 && milliseconds == 0 && microseconds == 0)
            returnString += nanoseconds.ToString() + "ns";
        return returnString;
    }
}