using System;
using Fisher.Bookstore.Models;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void AddBookPrice()
        {
            //Arrange 
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                AddBookPrice = 9.99
            };

            //Act 
            book.ApplyMemberDiscount();

            //Assert
            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, book.Price);
        }
    }
}
