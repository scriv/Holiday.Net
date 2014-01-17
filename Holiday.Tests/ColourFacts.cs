using NUnit.Framework;

namespace Holiday.Tests
{
    public class ColourFacts
    {
        public class EqualsOperator
        {
            [Test]
            public void Identical_instances_are_equal()
            {
                // Arrange
                var instance1 = new Colour(100, 100, 100);
                var instance2 = new Colour(100, 100, 100);

                // Act
                var areEqual = instance1 == instance2;

                // Assert
                Assert.That(areEqual);
            }

            [Test]
            public void Different_instances_are_not_equal()
            {
                // Arrange
                var instance1 = new Colour(100, 100, 100);
                var instance2 = new Colour(200, 200, 200);

                // Act
                var areEqual = instance1 != instance2;

                // Assert
                Assert.That(areEqual);
            }
        }
    }
}
