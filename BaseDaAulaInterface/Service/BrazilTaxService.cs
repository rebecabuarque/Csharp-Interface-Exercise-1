﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDaAulaInterface.Service
{
    class BrazilTaxService : iTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }

            else
            {
                return amount * 0.15;
            }
        }
    }
}
