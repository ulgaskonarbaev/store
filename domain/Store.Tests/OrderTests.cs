using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Store.Tests
{
    public class OrderTests
    {
        public void Order_WithNullItems_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentNullException>(() => new Order(1, null));
        }

        public void TotalCount_WithEmptyItems_ReturnsZero()
        {
            var order = new Order(1 , new OrderItem[0]);
            Assert.Equal(0, order.TotalCount);
        }
    }
}
