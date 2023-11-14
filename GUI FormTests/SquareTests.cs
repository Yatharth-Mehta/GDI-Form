using Microsoft.VisualStudio.TestTools.UnitTesting;
using Darkside_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkside_Form.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Square sq = new Square(50, 90);

            sq.draw(null, null);

        }

    }
}