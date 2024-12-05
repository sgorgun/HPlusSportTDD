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

            Assert. NotNull(response);
            Assert.Contains(item, response.Items);
        }
        
        [Test]
        public void ShouldReturnArticlesAddedToCart()
        {
            var item1 = new AddToCartItem()
            {
                Id = 1,
                Quantity = 5,
            };

            var request = new AddToCartRequest()
            {
                Item = item1,
            };

            var manager = new ShoppingCartManager();

            AddToCartResponse response = manager.AddToCart(request);

            var item2 = new AddToCartItem()
            {
                Id = 2,
                Quantity = 15,
            };

            request = new AddToCartRequest()
            {
                Item = item2,
            };

            response = manager.AddToCart(request);

            Assert. NotNull(response);
            Assert.Contains(item1, response.Items);
            Assert.Contains(item2, response.Items);
        }
    }
}
