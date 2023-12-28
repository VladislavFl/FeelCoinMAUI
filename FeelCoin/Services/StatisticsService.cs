using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeelCoin.Services.Interfaces;

namespace FeelCoin.Services
{
    public class StatisticsService : IStatisticsService
    {
        public string GetMessage()
        {
            return "Привет от VladdOS!";
        }
    }
}
