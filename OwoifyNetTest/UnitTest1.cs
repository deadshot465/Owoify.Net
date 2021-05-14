using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Owoify;

namespace OwoifyNetTest
{
    public class Tests
    {
        private const string Source = "Hello World! This is the string to owo! Kinda cute, isn't it?";
        private const string PokemonNameListPath = "assets/pokemons.txt";
        private const string WarAndPeacePath = "assets/war_and_peace_chapter01-20.txt";

        private readonly List<string> _pokemonNameList = File.ReadAllLines(PokemonNameListPath).ToList();
        private readonly string _warAndPeaceText = File.ReadAllText(WarAndPeacePath);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Owoify()
        {
            Assert.AreNotEqual(Owoifier.Owoify(Source), Source);
        }

        [Test]
        public void OwoifyWithOwo()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(Source));
            var text = Owoifier.Owoify(Source);
            Assert.IsNotNull(text);
            Assert.IsNotEmpty(text);
        }

        [Test]
        public void OwoifyWithUwu()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uwu));
            var text = Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uwu);
            Assert.IsNotNull(text);
            Assert.IsNotEmpty(text);
        }

        [Test]
        public void OwoifyWithUvu()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uvu));
            var text = Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uvu);
            Assert.IsNotNull(text);
            Assert.IsNotEmpty(text);
        }

        [Test]
        public void OwoifiedOwoIsNotEqualToUwu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(Source), Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uwu));
        }

        [Test]
        public void OwoifiedOwoIsNotEqualToUvu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(Source), Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uvu));
        }

        [Test]
        public void OwoifiedUwuIsNotEqualToUvu()
        {
            Assert.AreNotEqual(Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uwu), Owoifier.Owoify(Source, Owoifier.OwoifyLevel.Uvu));
        }
        
        [Test]
        public void OwoifyPokemonNames()
        {
            _pokemonNameList.ForEach(name =>
            {
                Assert.DoesNotThrow(() => Owoifier.Owoify(name));
                Assert.DoesNotThrow(() => Owoifier.Owoify(name, Owoifier.OwoifyLevel.Uwu));
                Assert.DoesNotThrow(() => Owoifier.Owoify(name, Owoifier.OwoifyLevel.Uvu));
                var owoifiedNameWithOwo = Owoifier.Owoify(name);
                var owoifiedNameWithUwu = Owoifier.Owoify(name, Owoifier.OwoifyLevel.Uwu);
                var owoifiedNameWithUvu = Owoifier.Owoify(name, Owoifier.OwoifyLevel.Uvu);
                Assert.IsNotNull(owoifiedNameWithOwo);
                Assert.IsNotNull(owoifiedNameWithUwu);
                Assert.IsNotNull(owoifiedNameWithUvu);
                Assert.IsNotEmpty(owoifiedNameWithOwo);
                Assert.IsNotEmpty(owoifiedNameWithUwu);
                Assert.IsNotEmpty(owoifiedNameWithUvu);

            });
        }

        [Test]
        public void OwoifyLongText()
        {
            Assert.DoesNotThrow(() => Owoifier.Owoify(_warAndPeaceText));
            Assert.DoesNotThrow(() => Owoifier.Owoify(_warAndPeaceText, Owoifier.OwoifyLevel.Uwu));
            Assert.DoesNotThrow(() => Owoifier.Owoify(_warAndPeaceText, Owoifier.OwoifyLevel.Uvu));
            var owoifiedTextWithOwo = Owoifier.Owoify(_warAndPeaceText);
            var owoifiedTextWithUwu = Owoifier.Owoify(_warAndPeaceText, Owoifier.OwoifyLevel.Uwu);
            var owoifiedTextWithUvu = Owoifier.Owoify(_warAndPeaceText, Owoifier.OwoifyLevel.Uvu);
            Assert.IsNotNull(owoifiedTextWithOwo);
            Assert.IsNotNull(owoifiedTextWithUwu);
            Assert.IsNotNull(owoifiedTextWithUvu);
            Assert.IsNotEmpty(owoifiedTextWithOwo);
            Assert.IsNotEmpty(owoifiedTextWithUwu);
            Assert.IsNotEmpty(owoifiedTextWithUvu);
        }
    }
}