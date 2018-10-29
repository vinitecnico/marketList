using System;
using System.Collections;
using MarketList.WebApi.Controllers;
using MarketList.WebApi.Model;
using MarketList.WebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MarketList.Test {
    public class ValuesControllerTest {
        private readonly ValuesController controller;

        public ValuesControllerTest () {
            this.controller = new ValuesController (null);
        }

        [Fact]
        public async void Get () {
            // Act
            var okResult = await controller.Get ();
            // Assert
            Assert.NotEmpty (okResult);
        }

        [Fact]
        public void GetbyId () {
            // Act
            //var okResult = _controller.Get (5);

            // Assert
            //Assert.Equal("value", okResult.Value);
        }
    }
}