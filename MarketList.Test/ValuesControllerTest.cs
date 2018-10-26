using System;
using System.Collections;
using Xunit;
using MarketList.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MarketList.Test {
    public class ValuesControllerTest {
        private readonly ValuesController _controller;
        public ValuesControllerTest () {
            _controller = new ValuesController ();
        }

        [Fact]
        public void Get () {
            // Act
            var okResult = _controller.Get ();

            // Assert
            Assert.NotEmpty(okResult.Value);
        }

        [Fact]
        public void GetbyId () {
            // Act
            var okResult = _controller.Get (5);

            // Assert
            Assert.Equal("value", okResult.Value);
        }
    }
}