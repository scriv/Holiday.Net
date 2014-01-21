using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;

namespace Holiday.Tests
{
    public class TaskExtensionsFacts
    {
        public class TimeoutMethod : TaskExtensionsFacts
        {
            [Test]
            public void Throws_when_timeout_occurs()
            {
                // Arrange
                var task = new HttpClient().GetAsync("http://cheese").Timeout(TimeSpan.FromSeconds(1));

                // Act/Assert
                Assert.That(() => task.Wait(), Throws.InstanceOf<AggregateException>().With.InnerException.InstanceOf<TimeoutException>());
            }

            [Test]
            public void Does_not_throw_when_the_task_completes_within_the_allotted_time()
            {
                // Arrange
                var task = new HttpClient().GetAsync("http://www.google.com/").Timeout(TimeSpan.FromSeconds(1));

                // Act
                task.Wait();

                // Assert
                Assert.That(task.Result, Is.Not.Null);
                Assert.That(task.Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            }
        }
    }
}