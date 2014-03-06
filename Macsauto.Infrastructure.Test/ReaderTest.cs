using System;
using Macsauto.Infrastructure.Connector.SmartCard;
using Macsauto.Infrastructure.Connector.SmartCard.Reader;

namespace Macsauto.Infrastructure.Test
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class ReaderTest
    {
        [SetUp]
        public void SetUp()
        {
            CardManager.Initialize();
        }

        [Test]
        public void CanListReader()
        {
            var readers = CardManager.CardReaders;

            Assert.NotNull(readers);
        }

        [Test]
        public void CanConnect()
        {
            
        }

        [Test]
        public void CanControl()
        {
            var reader = CardManager.CardReaders.First();

            //reader.Control();
        }

        [Test]
        public void CanSetParams()
        {
            var defaultParam = new PICCParams();

            defaultParam.DetectISO14443TypeACard()
                        .DetectISO14443TypeBCard()
                        .DetectFeliCa212KCard()
                        .DetectFeliCa424KCard()
                        .DetectTopazCard()
                        .EnableAutomaticATSGeneration()
                        .EnableAutomaticPICCPolling();

            Assert.Equals(defaultParam.GetParams()[3], 255);
        }
    }
}