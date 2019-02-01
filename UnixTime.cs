using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.UnixTime
{

    /// <summary>
    /// Time Format : UTC and Local 
    /// </summary>
    public enum Format
    {
        UTC = 1,
        Local
    }

    /// <summary>
    /// C# Unix Time Converter
    /// </summary>
    public static class UnixTime
    {
        const Int32 _secondInDays = 86400;

        static DateTime epochtime = DateTime.Parse("1970-01-01T00:00:00Z").ToUniversalTime();

        static DateTime epoctimeStart;

        static double IntEpochTime = 0;
        static double countDays = 0;

        /// <summary>
        /// Convert Date Time to Unix Time Stamp
        /// </summary>
        /// <param name="_dateTime">Date Time</param>
        /// <returns></returns>
        public static Int32 ToEpoch(DateTime _dateTime)
        {
            Int32 result = 0;

            try
            {
                epoctimeStart = _dateTime.ToUniversalTime();

                countDays = epoctimeStart.Subtract(epochtime).TotalDays;
                IntEpochTime = (countDays * _secondInDays);

                if (IntEpochTime > Int32.MaxValue)
                {
                    throw new SGException("Integer overflow : Unix time is a signed 32-bit number");
                }
                else
                {
                    result = (Int32)IntEpochTime;
                }
            }
            catch (SGException ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Convert Unix Time Stamp to Date Time
        /// </summary>
        /// <param name="epoch">Unix Time Stamp</param>
        /// <param name="TimeFormat">Time Format</param>
        /// <returns></returns>
        public static DateTime ToDateTime(Int32 epoch, Format TimeFormat = Format.Local)
        {
            DateTime _originalTime = DateTime.Now;

            try
            {
                if (TimeFormat == Format.Local)
                {
                    _originalTime = epochtime.AddSeconds(epoch).ToLocalTime();
                }
                if (TimeFormat == Format.UTC)
                {
                    _originalTime = epochtime.AddSeconds(epoch).ToUniversalTime();
                }
            }
            catch (SGException ex)
            {
                throw ex;
            }

            return _originalTime;
        }
    }
}
