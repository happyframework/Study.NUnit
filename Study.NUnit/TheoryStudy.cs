using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Study.NUnit
{
    public class TheoryStudy
    {
        [Datapoints]
        public int[] IntValues = new int[] { -1, 0, 1, 2, 3 };

        [Datapoints]
        public string[] StringValues = 
                                new string[] { null, string.Empty, "段光伟", "李妞妞" };

        [Theory]
        public void Assume_Study(int x, string y)
        {
            Assume.That(x > 0);
            Assume.That(!string.IsNullOrEmpty(y));

            Assert.IsTrue(x > 0);
            Assert.IsTrue(!string.IsNullOrEmpty(y));
        }
    }
}
