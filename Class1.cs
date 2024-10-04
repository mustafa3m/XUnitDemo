using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit; // Assurez-vous d'ajouter cette directive using.

namespace XUnitDemo
{
    public class Class1
    {
        //[Fact]
        [InlineData(true)]
        [InlineData(false)]
        [Theory]
        private void TestMethod1(bool x)
        {
            
        }

        



    }
}
