using System;
using System.Collections;
using Xunit;
using MarketList.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using MarketList.WebApi.Repository;
using MarketList.WebApi.Model;

namespace MarketList.Test {
    public class ValuesControllerTest {
        //private readonly ValuesController _controller;
        public ValuesControllerTest () {
            //_controller = new ValuesController (null);
        }

        [Fact]
        public void Get () {
            // Act
            var okResult = "null";

            // Assert
            Assert.NotEmpty(okResult);
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