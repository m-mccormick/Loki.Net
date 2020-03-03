namespace Loki.Net.IntegrationTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using NUnit.Framework;

    public class Tests
    {
        #region Public

        #region Methods

        [Test]
        public void IntegrationTest1()
        {
            foreach (string file in Directory.GetFiles(Directory.GetCurrentDirectory()).OrderBy(x => x))
            {
                Console.WriteLine(file);
            }

            Assert.IsTrue(File.Exists("docker-compose.yml"));
        }

        #endregion

        #endregion
    }
}