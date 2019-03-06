using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ConsoleApp2.Utile util = new ConsoleApp2.Utile();

            int x = 3;
            int y = 4;
            Assert.Equal(7, util.Add(x, y));
        }
    }
}
