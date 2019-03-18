using System;
using System.Collections.Generic;
using System.Text;

namespace OddsConverter
{
    public class Selection
    {
        public Selection()
        {

        }

        public Selection(double odds)
        {
            Odds = odds;

            ImpliedProbability = (1 / Odds) * 100;
        }

        public double Odds { get; set; }

        public double TrueOdds
        {
            get
            {
                return Odds + (Odds * (Margin / 100));
            }
        }

        public double ImpliedProbability { get; private set; }

        public double TrueProbability
        {
            get
            {
                return (1 / TrueOdds) * 100;
            }
        }

        public double Margin { get; set; }

    }
}
