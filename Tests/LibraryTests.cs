using NUnit.Framework;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;

namespace LibraryTests
{
    public class Tests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_Test()
        {
            var book = new Book { Title = "Test", Author = "ABC", ISBN = "123" };

            library.AddBook(book);

            Assert.That(library.Books.Count, Is.EqualTo(1));
        }

        [Test]
        public void RegisterBorrower_Test()
        {
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "C1" };

            library.RegisterBorrower(borrower);

            Assert.That(library.Borrowers.Count, Is.EqualTo(1));
        }

        [Test]
        public void BorrowBook_Test()
        {
            var book = new Book { Title = "Test", Author = "ABC", ISBN = "123" };
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "C1" };

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "C1");

            Assert.IsTrue(book.IsBorrowed);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(1));
        }

        [Test]
        public void ReturnBook_Test()
        {
            var book = new Book { Title = "Test", Author = "ABC", ISBN = "123" };
            var borrower = new Borrower { Name = "John", LibraryCardNumber = "C1" };

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "C1");
            library.ReturnBook("123", "C1");

            Assert.IsFalse(book.IsBorrowed);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(0));
        }
    }
}