using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace OddsConverterTests
{
    [TestClass]
    public class OddsConverterTests
    {
        [TestMethod]
        public void ConvertOddsToSelections()
        {
            double[] odds = { 2.25, 3.25, 3.25 };
            var selections = OddsConverter.OddsConverter.ConvertOddsToSelections(odds);

            Assert.IsTrue(selections.Count() == 3);
            Assert.IsTrue(selections.All(x => Math.Round(x.Margin, 2) == 5.98));
        }
    }
}
