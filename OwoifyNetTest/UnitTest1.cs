using NUnit.Framework;
using Owoify;

namespace OwoifyNetTest
{
    public class Tests
    {
        private const string _source = "Hello World! This is the string to owo! Kinda cute, isn't it?";
        
        /// <summary>
        /// Per #1 PR in owoify-py, when owoifying the string "NIDORINO," it used to throw in Python.
        /// Which means it might be a good thing to test it beforehand.
        /// </summary>
        private const string _nidorino = "NIDORINO";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Owoify()
        {
            Assert.AreNotEqual(Owoifier.Owoify(_source), _source);
        }

        [Test]
        public void OwoifyWithOwo()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(_source));
            Assert.DoesNotThrow(() => Owoifier.Owoify(_nidorino));
            Assert.IsNotNull(Owoifier.Owoify(_source));
            Assert.IsNotEmpty(Owoifier.Owoify(_source));
        }

        [Test]
        public void OwoifyWithUwu()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uwu));
            Assert.DoesNotThrow(() => Owoifier.Owoify(_nidorino, Owoifier.OwoifyLevel.Uwu));
            Assert.IsNotNull(Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uwu));
            Assert.IsNotEmpty(Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uwu));
        }

        [Test]
        public void OwoifyWithUvu()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uvu));
            Assert.DoesNotThrow(() => Owoifier.Owoify(_nidorino, Owoifier.OwoifyLevel.Uvu));
            Assert.IsNotNull(Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uvu));
            Assert.IsNotEmpty(Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uvu));
        }

        [Test]
        public void OwoifiedOwoIsNotEqualToUwu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(_source), Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uwu));
        }

        [Test]
        public void OwoifiedOwoIsNotEqualToUvu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(_source), Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uvu));
        }

        [Test]
        public void OwoifiedUwuIsNotEqualToUvu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uwu), Owoifier.Owoify(_source, Owoifier.OwoifyLevel.Uvu));
        }
    }
}