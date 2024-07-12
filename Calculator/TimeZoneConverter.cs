using System;

namespace Calculator
{
    public class TimeZoneConverter
    {
        
        private static readonly TimeSpan JapanOffset = TimeSpan.FromHours(9); // UTC+9:00 for JST
        private static readonly TimeSpan CanadaOffset = TimeSpan.FromHours(-5); // UTC-5:00 for EST

        public static DateTime ConvertJapanToCanada(DateTime japanTime)
        {
            
            return japanTime + (CanadaOffset - JapanOffset);
        }
    }
}
