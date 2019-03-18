using System;
using System.Collections.Generic;
using System.Linq;

namespace OddsConverter
{
    public static class OddsConverter
    {
        public static List<Selection> ConvertOddsToSelections(double[] odds)
        {
            var selections = odds.Select(x => new Selection(x)).ToList();

            var margin = selections.Sum(x => x.ImpliedProbability) - 100;

            foreach (var item in selections)
            {
                item.Margin = margin;
            }

            return selections;
        }
    }
}
