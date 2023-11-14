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
   
    public class CircleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Circle c = new Circle(40);

            c.draw(null, null);
            
        }
    }
}