using System;
using System.Linq;
using GCodeParser.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParserTests
{
    [TestClass]
    public class ParsingFilterTest
    {
        [TestMethod]
        public void ReturnsDefaultFilterOnEmpty()
        {
            var actualFilter = ParsingFilter.Filter;

            string[] expected = { "G28", "G92", "G90", "\n", };

            CollectionAssert.AreEqual(expected, actualFilter);
        }

        [TestMethod]
        public void DefaultFilterNotEmpty()
        {
            var defaultFilter = ParsingFilter.Filter;

            Assert.IsNotNull(defaultFilter);
        }

        [TestMethod]
        public void ReturnsDefaultOnEmptyFilter()
        {
            string[] badFilters = { "", string.Empty, null, "     " };
            ParsingFilter.Filter = badFilters;

            string[] expected = { "G28", "G92", "G90", "\n" };

            CollectionAssert.AreEqual(expected, ParsingFilter.Filter);
        }

        [TestMethod]
        public void FilterOverridesDefault()
        {
            string[] newFilter = { "A", "1", "Word" };
            ParsingFilter.Filter = newFilter;

            CollectionAssert.AreEqual(newFilter, ParsingFilter.Filter);
        }
    }
}
