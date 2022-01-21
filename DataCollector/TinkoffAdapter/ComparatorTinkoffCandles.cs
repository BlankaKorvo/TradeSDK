﻿using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinkoff;
using Tinkoff.Trading.OpenApi.Models;
using Tinkoff.Trading.OpenApi.Network;

namespace DataCollector.TinkoffAdapter.DataHelper
{
    class ComparatorTinkoffCandles : IEqualityComparer<CandlePayload>
    {
        public bool Equals(CandlePayload c1, CandlePayload c2)
        {
            Log.Information("Start Equals method");
            if (c1.Time == c2.Time)
            {
                Log.Information("{0} {1} candle = {2} {3} candle", c1.Figi, c1.Time, c2.Figi, c2.Time);
                return true;
            }
            else
            {
                Log.Information("{0} {1} candle != {2} {3} candle", c1.Figi, c1.Time, c2.Figi, c2.Time);
                return false;
            }
        }

        public int GetHashCode(CandlePayload c)
        {
            string hCode = (c.High  * c.Low * c.Open).ToString() +c.Figi + c.Interval.ToString() + c.Time.ToString();
            return hCode.GetHashCode();
        }
    }
}