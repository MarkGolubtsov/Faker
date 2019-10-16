using System;
using NUnit.Framework;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Faker.Faker faker = new Faker.Faker();
            Console.WriteLine(faker.create<Faker.Entity>());
            Console.WriteLine("123");
            Assert.True(true);
        }
    }
}