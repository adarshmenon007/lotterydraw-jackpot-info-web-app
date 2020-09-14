using LotteryDrawJackpotInfo.ApiServices;
using LotteryDrawJackpotInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LotteryDrawJackpotInfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApiHelper.InitializeClient();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> TattersallsGetInformation()
        {
            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.Tattersalls;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString(), Common.LotteriesProduct.Super66.ToString(), Common.LotteriesProduct.Pools.ToString(),
                Common.LotteriesProduct.MonWedLotto.ToString(), Common.LotteriesProduct.LuckyLotteries2.ToString(), Common.LotteriesProduct.LuckyLotteries5.ToString(),
                Common.LotteriesProduct.LottoStrike.ToString(), Common.LotteriesProduct.WedLotto.ToString(), Common.LotteriesProduct.Keno.ToString(),
                Common.LotteriesProduct.CoinToss.ToString(), Common.LotteriesProduct.SetForLife.ToString(), Common.LotteriesProduct.MultiProduct.ToString(),
                Common.LotteriesProduct.InstantScratchIts.ToString(), Common.LotteriesProduct.TwoDollarCasket.ToString(), Common.LotteriesProduct.BonusDraws.ToString()};

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            ViewBag.Message = "Tattersalls open draws information";

            return View(drawResults.Draws);
        }

        public async Task<ActionResult> GoldenCasketGetInformation()
        {
            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.GoldenCasket;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString(), Common.LotteriesProduct.Super66.ToString(), Common.LotteriesProduct.Pools.ToString(),
                Common.LotteriesProduct.MonWedLotto.ToString(), Common.LotteriesProduct.LuckyLotteries2.ToString(), Common.LotteriesProduct.LuckyLotteries5.ToString(),
                Common.LotteriesProduct.LottoStrike.ToString(), Common.LotteriesProduct.WedLotto.ToString(), Common.LotteriesProduct.Keno.ToString(),
                Common.LotteriesProduct.CoinToss.ToString(), Common.LotteriesProduct.SetForLife.ToString(), Common.LotteriesProduct.MultiProduct.ToString(),
                Common.LotteriesProduct.InstantScratchIts.ToString(), Common.LotteriesProduct.TwoDollarCasket.ToString(), Common.LotteriesProduct.BonusDraws.ToString()};

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            ViewBag.Message = "Golden Casket open draws information";

            return View(drawResults.Draws);
        }

        public async Task<ActionResult> NSWLotteriesGetInformation()
        {
            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.NSWLotteries;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString(), Common.LotteriesProduct.Super66.ToString(), Common.LotteriesProduct.Pools.ToString(),
                Common.LotteriesProduct.MonWedLotto.ToString(), Common.LotteriesProduct.LuckyLotteries2.ToString(), Common.LotteriesProduct.LuckyLotteries5.ToString(),
                Common.LotteriesProduct.LottoStrike.ToString(), Common.LotteriesProduct.WedLotto.ToString(), Common.LotteriesProduct.Keno.ToString(),
                Common.LotteriesProduct.CoinToss.ToString(), Common.LotteriesProduct.SetForLife.ToString(), Common.LotteriesProduct.MultiProduct.ToString(),
                Common.LotteriesProduct.InstantScratchIts.ToString(), Common.LotteriesProduct.TwoDollarCasket.ToString(), Common.LotteriesProduct.BonusDraws.ToString()};

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            ViewBag.Message = "NSW Lotteries open draws information";

            return View(drawResults.Draws);
        }

        public async Task<ActionResult> NTLotteriesGetInformation()
        {
            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.NTLotteries;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString(), Common.LotteriesProduct.Super66.ToString(), Common.LotteriesProduct.Pools.ToString(),
                Common.LotteriesProduct.MonWedLotto.ToString(), Common.LotteriesProduct.LuckyLotteries2.ToString(), Common.LotteriesProduct.LuckyLotteries5.ToString(),
                Common.LotteriesProduct.LottoStrike.ToString(), Common.LotteriesProduct.WedLotto.ToString(), Common.LotteriesProduct.Keno.ToString(),
                Common.LotteriesProduct.CoinToss.ToString(), Common.LotteriesProduct.SetForLife.ToString(), Common.LotteriesProduct.MultiProduct.ToString(),
                Common.LotteriesProduct.InstantScratchIts.ToString(), Common.LotteriesProduct.TwoDollarCasket.ToString(), Common.LotteriesProduct.BonusDraws.ToString()};

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            ViewBag.Message = "NT Lotteries open draws information";

            return View(drawResults.Draws);
        }

        public async Task<ActionResult> SALotteriesGetInformation()
        {
            DrawsRequestItem requestContent = new DrawsRequestItem();
            requestContent.CompanyId = Common.LotteriesCompany.SALotteries;
            requestContent.MaxDrawCount = 30;
            requestContent.OptionalProductFilter = new string[] { Common.LotteriesProduct.TattsLotto.ToString(), Common.LotteriesProduct.OzLotto.ToString(),
                Common.LotteriesProduct.Powerball.ToString(), Common.LotteriesProduct.Super66.ToString(), Common.LotteriesProduct.Pools.ToString(),
                Common.LotteriesProduct.MonWedLotto.ToString(), Common.LotteriesProduct.LuckyLotteries2.ToString(), Common.LotteriesProduct.LuckyLotteries5.ToString(),
                Common.LotteriesProduct.LottoStrike.ToString(), Common.LotteriesProduct.WedLotto.ToString(), Common.LotteriesProduct.Keno.ToString(),
                Common.LotteriesProduct.CoinToss.ToString(), Common.LotteriesProduct.SetForLife.ToString(), Common.LotteriesProduct.MultiProduct.ToString(),
                Common.LotteriesProduct.InstantScratchIts.ToString(), Common.LotteriesProduct.TwoDollarCasket.ToString(), Common.LotteriesProduct.BonusDraws.ToString()};

            var drawResults = await OpenDrawsProcessor.GetOpenDrawsInformation(requestContent);

            ViewBag.Message = "SA Lotteries open draws information";

            return View(drawResults.Draws);
        }
    }
}