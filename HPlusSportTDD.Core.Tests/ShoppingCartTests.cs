﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    internal class ShoppingCartTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ShouldReturnArticleAddedToCart()
        {
            var item = new AddToCartItem()
            {
                Id = 1,
                Quantity = 5,
            };

            var request = new AddToCartRequest()
            {
                Item = item,
            };

            var manager = new ShoppingCartManager();

            AddToCartResponse response = manager.AddToCart(request);

            Assert.NotNull(response);
            Assert.Contains(item, response.Items);
        }
    }
}
