using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using YoyoApp.Client.Models;

namespace YoyoApp.Client.Services
{
    public class ShuttleService
    {
        public List<ShuttleData> GetShuttleData()
        {
            // Mocked Data
            var data = new List<ShuttleData>()
            {
                new ShuttleData()
                {
                    AccumulatedShuttleDistance = 40,
                    SpeedLevel = 5,
                    ShuttleNo = 1,
                    Speed = 10,
                    LevelTime = 15,
                    CommulativeTime = 24,
                    StartTime = 0
                },
                new ShuttleData()
                {
                    AccumulatedShuttleDistance = 80,
                    SpeedLevel = 9,
                    ShuttleNo = 2,
                    Speed = 12,
                    LevelTime = 13,
                    CommulativeTime = 46,
                    StartTime = 37
                }
            };
            return data;
        }
    }
}
