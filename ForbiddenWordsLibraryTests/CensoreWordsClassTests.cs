using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenWordsLibrary;
using System;

namespace ForbiddenWordsLibraryTests
{
    [TestClass]
    public class CensoreWordsClassTests
    {
        /// <summary>
        /// Замена звёздочками слова редиска
        /// </summary>
        [TestMethod]
        public void Censore_CensoreWord_ReturnedStars()
        {
            //Arrange
            string text= "редиска";
            string excepted = "***";
            //Act

            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Замена звёздочками слова редиска Редиска
        /// </summary>
        [TestMethod]
        public void Censore_CensoreWordUpper_ReturnedStars()
        {
            //Arrange
            string text = "редиска Редиска";
            string excepted = "*** ***";
            //Act

            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка на пустую строку
        /// </summary>
        [TestMethod]
        public void Censore_StringEmpty_ReturnedStars()
        {
            //Arrange
            string text = string.Empty;
            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => CensoreWordsClass.Censore(text));
        }
        /// <summary>
        /// Проверка на предложения с редиской
        /// </summary>
        [TestMethod]
        public void Censore_StringSentence_ReturnedStars()
        {
            //Arrange
            string text = "Это было давно и неправда.Я шёл по тёмной улице,а на встречу мне редиска. Я её спрашиваю:\"Редиска-редиска, как твои дела?\"";
            string excepted = "Это было давно и неправда.Я шёл по тёмной улице,а на встречу мне ***. Я её спрашиваю:\"***-***, как твои дела?\"";
            //Act

            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка разных букв (внутри будет спрятана редиска) плюсом разные буквы(строчные и заглавные)
        /// </summary>
        [TestMethod]
        public void Censore_StringSymbols_ReturnedStars()
        {
            //Arrange
            string text = "рарврарврарврарврарвррЕдИскарарарараррар";
            string excepted = "рарврарврарврарврарвр***рарарараррар";
            //Act

            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Проверка на заглавные буквы и строчные
        /// </summary>
        [TestMethod]
        public void Censore_UpperCaseandLower_ReturnedStars()
        {
            //Arrange
            string text = "Мне без разницы, какая РЕДИСКА, хоть большая, хоть маленькая, редиска и такая и такая вкусная.";
            string excepted = "Мне без разницы, какая ***, хоть большая, хоть маленькая, *** и такая и такая вкусная.";
            //Act
            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Обычная строка без редисок
        /// </summary>
        [TestMethod]
        public void Censore_Normal_ReturnedNormal()
        {
            //Arrange
            string text = "Это обычная строка, чего ты ждёшь?";
            string excepted = "Это обычная строка, чего ты ждёшь?";
            //Act
            string actual = CensoreWordsClass.Censore(text);
            //Assert
            Assert.AreEqual(excepted, actual);
        }

    }
}
