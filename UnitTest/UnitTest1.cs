using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Polkovnikova;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum20_and50_return70()
        {

            Polkovnikova.Test program = new Polkovnikova.Test();
            program.Sum(20, 50);
        }
    }
}
