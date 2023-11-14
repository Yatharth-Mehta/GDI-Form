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
    public class TriangleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void TriangleTest()
        {
            Triangle triang = new Triangle(null ,null);
        }
    }
}