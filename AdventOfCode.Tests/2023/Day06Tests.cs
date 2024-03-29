﻿using AdventOfCode._2023;
using Moq;
using NUnit.Framework;
using Shouldly;

namespace AdventOfCode.Tests._2023
{
    [TestFixture]
    public class Day06Tests
    {
        private Mock<IInputLoader> loader;

        [SetUp]
        public void Setup()
        {
            loader = new Mock<IInputLoader>();
            loader.Setup(x => x.LoadArray<string>(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(
                [
                    "Time:      7  15   30",
                    "Distance:  9  40  200"
                ]);
        }

        [Test]
        public void PartA()
        {
            // Arrange
            var sut = CreateSut();

            // Act
            var result = sut.PartA();

            // Assert
            result.ShouldBe(288);
        }

        [Test]
        public void PartB()
        {
            // Arrange
            var sut = CreateSut();

            // Act
            var result = sut.PartB();

            // Assert
            result.ShouldBe(71503);
        }

        private Day06 CreateSut() => new(loader.Object);
    }
}
