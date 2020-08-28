using LotteryDrawJackpotInfo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryDrawJackpotInfo.Models
{
    public class DrawsRequestItem
    {
        public LotteriesCompany CompanyId { get; set; }
        public int MaxDrawCount { get; set; }
        public string[] OptionalProductFilter { get; set; }
    }
}