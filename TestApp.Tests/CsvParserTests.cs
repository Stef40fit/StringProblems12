using NUnit.Framework;
using System;

namespace TestApp.Tests
{
    [TestFixture]
    public class CsvParserTests
    {
        [Test]
        public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
        {
            // Arrange
            string input = "";
            string[] expected = Array.Empty<string>();

            // Act
            string[] result = CsvParser.ParseCsv(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
        {
            // Arrange
            string input = "stop";
            string[] expected = { "stop" };

            // Act
            string[] result = CsvParser.ParseCsv(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
        {
            // Arrange
            string input = "stop,the,code";
            string[] expected = { "stop", "the", "code" };

            // Act
            string[] result = CsvParser.ParseCsv(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
        {
            // Arrange
            string input = "      stop   ,     the  ,   code       ";
            string[] expected = {"stop","the","code"};

            // Act
            string[] result = CsvParser.ParseCsv(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
