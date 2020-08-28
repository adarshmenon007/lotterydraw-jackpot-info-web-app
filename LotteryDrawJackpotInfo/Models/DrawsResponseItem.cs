using LotteryDrawJackpotInfo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LotteryDrawJackpotInfo.Models
{
    public class DrawsResponseItem
    {
        [Display(Name = "Product")]
        public LotteriesProduct ProductId { get; set; }

        [Display(Name = "Draw Number")]
        public int DrawNumber { get; set; }

        [Display(Name = "Product Name")]
        public string DrawDisplayName { get; set; }

        [Display(Name = "Draw Date")]
        public DateTime DrawDate { get; set; }

        [Display(Name = "Logo")]
        public string DrawLogoUrl { get; set; }

        [Display(Name = "Draw Type")]
        public DrawTypes DrawType { get; set; }

        [Display(Name = "Jackpot Value")]
        public decimal Div1Amount { get; set; }

        [Display(Name = "Jackpot Value Estimated")]
        public bool IsDiv1Estimated { get; set; }

        [Display(Name = "Jackpot Value Unknown")]
        public bool IsDiv1Unknown { get; set; }

        [Display(Name = "Draw Close Date & Time")]
        public DateTime DrawCloseDateTimeUTC { get; set; }

        [Display(Name = "Draw EndSell Date & Time")]
        public DateTime DrawEndSellDateTimeUTC { get; set; }

        [Display(Name = "Draw Countdown Timer Date & Time")]
        public double DrawCountDownTimerSeconds { get; set; }
    }
}