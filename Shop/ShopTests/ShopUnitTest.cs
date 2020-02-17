using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop;

namespace ShopTests
{    
    [TestClass]
    public class ShopUnitTest
    {
        public Store GenerationStore()
        {
            Store store = new Store();
            store.Add(new Book(1, "Small Gods", 240, "Fantasy", "Terry Pratchett", 1992));
            store.Add(new Book(2, "Winnie-the-Pooh", 360, "Children's literature", "A. A. Milne", 1926));
            store.Add(new Book(3, "Jane Eyre", 180, "Novel", "Charlotte Bronte", 1847));
            store.Add(new Book(4, "David Copperfield", 270, "Novel", "Charles Dickens", 1850));
            store.Add(new Book(5, "The Little Prince", 310, "Children's literature", "Antoine de Saint-Exupery", 1943));
            store.Add(new Notebook(6, "Notebook with flowers", 50, 96));
            store.Add(new Notebook(7, "Notebook with butterfly", 50, 96));
            store.Add(new Notebook(8, "Notebook with castle", 45, 48));
            store.Add(new Notebook(9, "Notebook with cat", 32, 24));
            store.Add(new FeltPen(10, "10 Felt pens", 105, 10));
            store.Add(new FeltPen(11, "15 Felt pens", 140, 15));
            store.Add(new FeltPen(12, "20 Felt pens", 180, 20));
            return store;
        }
        [TestMethod]
        public void AddStoreTest()
        {
            Store store = GenerationStore();

            Assert.AreEqual(12, store.Count());
        }

        [TestMethod]
        public void DeleteStoreTest()
        {
            Store store = GenerationStore();
            
            store.Delete(5);

            Assert.AreEqual(11, store.Count());
        }

        [TestMethod]
        public void SearchStoreTest()
        {
            Store store = GenerationStore();

            List<Product> suitableProducts = store.Search("tt");

            Assert.AreEqual(4, suitableProducts.Count);
        }

        [TestMethod]
        public void SortByNameStoreTest()
        {
            Store store = GenerationStore();

            store.Sort(new NameComparer());

            Assert.AreEqual(10, store.GetProduct(0).ID);
            Assert.AreEqual(2, store.GetProduct(11).ID);
        }

        [TestMethod]
        public void SortByPriceStoreTest()
        {
            Store store = GenerationStore();

            store.Sort(new PriceComparer());

            Assert.AreEqual(9, store.GetProduct(0).ID);
            Assert.AreEqual(2, store.GetProduct(11).ID);
        }

        [TestMethod]
        public void SortByIDStoreTest()
        {
            Store store = GenerationStore();

            store.Sort();

            Assert.AreEqual(1, store.GetProduct(0).ID);
            Assert.AreEqual(12, store.GetProduct(11).ID);
        }

        [TestMethod]
        public void ChangePriceProductsTest()
        {
            Book book = new Book(4, "David Copperfield", 270, "Novel", "Charles Dickens", 1850);
            Notebook notebook = new Notebook(9, "Notebook with cat", 32, 24);
            FeltPen feltPen = new FeltPen(10, "10 Felt pens", 105, 10);

            book.ChangePrice(-70);
            notebook.ChangePrice(12);
            feltPen.ChangePrice(-5);

            Assert.AreEqual(200, book.Price);
            Assert.AreEqual(44, notebook.Price);
            Assert.AreEqual(100, feltPen.Price);
        }
    }
}
