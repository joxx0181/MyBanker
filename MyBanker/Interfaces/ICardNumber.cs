using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    interface ICardNumber
    {
        string GetCardNumber(string preFIX);
    }
}
