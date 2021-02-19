using System;
using System.Collections.Generic;
using System.Text;

namespace RecordTypeProject.Class
{
    public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
    {
        protected virtual bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
            return true;
        }
    }

    public record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
        : DegreeDays(BaseTemperature, TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
    }

    public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
        : DegreeDays(BaseTemperature, TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
    }
}