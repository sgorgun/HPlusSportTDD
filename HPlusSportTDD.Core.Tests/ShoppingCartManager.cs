
namespace HPlusSportTDD.Core
{
    internal class ShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;
        public ShoppingCartManager()
        {
            _shoppingCart = new List<AddToCartItem>();
        }

        internal AddToCartResponse AddToCart(AddToCartRequest request)
        {
            var item = _shoppingCart.Find(i => i.Id == request.Item.Id);
            if (item != null)
            {
                item.Quantity += request.Item.Quantity;
            }
            else
            {
                _shoppingCart.Add(request.Item);
            }

            return new AddToCartResponse()
            {
                Items = _shoppingCart.ToArray()
            };
        }
    }
}