using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LotteryDrawJackpotInfo.Common
{

    public enum LotteriesProduct
    {
        None,
        TattsLotto,
        OzLotto,
        Powerball,
        Super66,
        Pools,
        MonWedLotto,
        LuckyLotteries2,
        LuckyLotteries5,
        LottoStrike,
        WedLotto,
        Keno,
        CoinToss,
        SetForLife,
        MultiProduct,
        InstantScratchIts,
        TwoDollarCasket,
        BonusDraws
    }

    public enum DrawTypes
    {
        Undefined,
        BaseWeek,
        Jackpot,
        Superdraw,
        Megadraw,
        DoubleDivs,
        TripleDivs,
        FourTimesDivs,
        DoubleDivsPlus1,
        TripleDivsPlus1,
        FourTimesDivsPlus1,
        CashCadeNextDiv,
        CashCadeAllDivs
    }

    public enum LotteriesCompany
    {
        None,
        Tattersalls,
        GoldenCasket,
        NSWLotteries,
        NTLotteries,
        SALotteries
    }
}