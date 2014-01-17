using NUnit.Framework;

namespace Holiday.Tests
{
    public class ColourTranslatorFacts
    {
        public class ToHtmlMethod
        {
            [Test]
            public void Converts_white_to_ffffff()
            {
                // Arrange
                var colour = Colour.White;
                var expectedColour = "#FFFFFF";

                // Act
                var actualColour = ColourTranslator.ToHtml(colour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }
        }

        public class FromHtmlMethod
        {
            [Test]
            public void Converts_ffffff_to_white()
            {
                // Arrange
                var htmlColour = "#FFFFFF";
                var expectedColour = Colour.White;

                // Act
                var actualColour = ColourTranslator.FromHtml(htmlColour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }

            [Test]
            public void Converts_fff_to_white()
            {
                // Arrange
                var htmlColour = "#FFF";
                var expectedColour = Colour.White;

                // Act
                var actualColour = ColourTranslator.FromHtml(htmlColour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }

            [Test]
            public void Converts_000000_to_black()
            {
                // Arrange
                var htmlColour = "#000000";
                var expectedColour = Colour.Black;

                // Act
                var actualColour = ColourTranslator.FromHtml(htmlColour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }

            [Test]
            public void Converts_ff0000_to_red()
            {
                // Arrange
                var htmlColour = "#FF0000";
                var expectedColour = Colour.Red;

                // Act
                var actualColour = ColourTranslator.FromHtml(htmlColour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }

            [Test]
            public void Converts_f00_to_red()
            {
                // Arrange
                var htmlColour = "#F00";
                var expectedColour = Colour.Red;

                // Act
                var actualColour = ColourTranslator.FromHtml(htmlColour);

                // Assert
                Assert.That(actualColour, Is.EqualTo(expectedColour));
            }
        }
    }
}