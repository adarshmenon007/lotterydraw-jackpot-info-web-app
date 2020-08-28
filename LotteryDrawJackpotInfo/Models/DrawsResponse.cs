using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryDrawJackpotInfo.Models
{
    public class DrawsResponse
    {
        public List<DrawsResponseItem> Draws { get; set; }
        public List<ErrorInfoItem> ErrorInfo { get; set; }
        public bool Success { get; set; }
    }
}