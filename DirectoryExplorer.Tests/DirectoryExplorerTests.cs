using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using MagicFilesLib;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        Mock<IDirectExplorer> d;

        [OneTimeSetUp]
        public void Initialize()
        {
          d = new Mock<IDirectExplorer>();
        }

        [Test]
        public void DirectoryExplorer_Test()
        {
            
            d.Setup(obj => obj.GetFiles());
            var directoryExplorer = d.Object;
            var explorer = new DirectExplorer();
            var result = explorer.GetFiles();
            Assert.That(result,Is.Not.Null);
            Assert.That(result, Has.Count.EqualTo(2));
            CollectionAssert.Contains(result, _file1);
        }

    }
}
