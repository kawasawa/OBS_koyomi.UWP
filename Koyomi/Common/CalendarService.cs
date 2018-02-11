using System;
using System.Collections.Generic;
using System.Linq;

namespace Koyomi.Common
{
    public static class CalendarService
    {
        public static IDictionary<T, DateTime> AdjustDate<T>(DateTime date, IDictionary<T, DateTime> dateMap)
            where T : struct
        {
            var diff = date.Year - BasisDate.BASIS_YEAR;
            return dateMap.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.AddYears(diff));
        }

        public static (DateTime lower, DateTime upper) GetRange<T>(DateTime date, T kind)
            where T : struct
        {
            (DateTime lower, DateTime upper) range;
            var diff = date.Year - BasisDate.BASIS_YEAR;
            if (kind is FourSeasonKind k1)
            {
                range = GetRange(k1, AdjustDate(date, BasisDate.FourSeason));
            }
            else if (kind is SolarTermKind k2)
            {
                range = GetRange(k2, AdjustDate(date, BasisDate.SolarTerm));
            }
            else if (kind is SolarTermMicroKind k3)
            {
                range = GetRange(k3, AdjustDate(date, BasisDate.SolarTermMicro));
            }
            else if (kind is StarSignKind k4)
            {
                range = GetRange(k4, AdjustDate(date, BasisDate.StarSign));
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            if (range.lower < range.upper)
            {
                if (date < range.lower)
                {
                    range.lower = range.lower.AddYears(-1);
                    range.upper = range.upper.AddYears(-1);
                }
            }
            else
            {
                if (date < range.lower)
                {
                    range.lower = range.lower.AddYears(-1);
                }
                else
                {
                    range.upper = range.upper.AddYears(1);
                }
            }
            return range;
        }

        public static (DateTime lower, DateTime upper) GetRange<T>(T kind, IDictionary<T, DateTime> dateMap)
           where T : struct
        {
            var kinds = (T[])Enum.GetValues(typeof(T));
            var i = Array.IndexOf(kinds, kind);
            return (dateMap[kinds[i]], dateMap[i == kinds.Length - 1 ? kinds[0] : kinds[i + 1]].AddDays(-1));
        }

        public static T GetKind<T>(DateTime date, IDictionary<T, DateTime> dateMap)
            where T : struct
        {
            var kinds = (T[])Enum.GetValues(typeof(T));
            for (int i = 0; i < kinds.Length - 1; i++)
            {
                if (dateMap[kinds[i]] <= date && date < dateMap[kinds[i + 1]])
                {
                    return kinds[i];
                }
            }
            return kinds[kinds.Length - 1];
        }
    }
}
