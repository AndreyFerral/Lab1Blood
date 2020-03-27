using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalizBlood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizBlood.Tests {
    [TestClass]
    public class AnalizBloodTests {
        [TestMethod]
        public void GlukozaTestLeftSide() {
            Equals(0.01, "Пониженный уровень глюкозы: Недостаточное и нерегулярное питание, гормональные заболевания");
        }

        [TestMethod]
        public void GlukozaTestCentral() {
            Equals(4.5, "Уровень глюкозы в норме");
        }

        [TestMethod]
        public void GemoglobinTestRightSide() {
            Equals(139.9, "female", "Уровень гемоглобина в норме");
        }

        [TestMethod]
        public void GlukozaTestNegativeValue() {
            Equals(-6.5, "Введены некорректные данные");
        }

        [TestMethod]
        public void GemoglobinTestWrongGender() {
            Equals(130, "hello", "Введен некорректный пол");
        }

        [TestMethod]
        public void GemoglobinTestRightGenderFemale()
        {
            Equals(150, "female", "Повышенный уровень гемоглобина: Обезвоживании организма, заболевание крови и некоторые виды сердечной недостаточности");
        }

        [TestMethod]
        public void GemoglobinTestRightGenderMale()
        {
            Equals(100, "male", "Пониженный уровень гемоглобина: Анемия, кровопотеря, скрытое внутреннее кровотечение, поражение внутренних органов");
        }

        private void Equals(double x, string resultat) {
            Assert.AreEqual(resultat, AnalizBlood.Glukoza(x));
        }

        private void Equals(double x, string gender, string resultat) {
            Assert.AreEqual(resultat, AnalizBlood.Gemoglobin(x, gender));
        }
    }
}