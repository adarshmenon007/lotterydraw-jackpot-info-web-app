using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryDrawJackpotInfo.Models
{
    public class ErrorInfoItem
    {
        public int SystemId { get; set; }
        public int ErrorNo { get; set; }
        public string DisplayMessage { get; set; }
        public string SupportErrorReference { get; set; }
    }
}