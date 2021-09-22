using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        //These fields were added later
        private StreamingContentRepository _repo;
        private StreamingContent _matrix;

        //TestInitialize added later
        [TestInitialize]


        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange --Getting what we need to run our tests. Making a book and a shelf.
            //Book
            StreamingContent content = new StreamingContent();
            //Shelf
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool success = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(success);
        }

        //Testing READ method (GET)
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectList()
        {
            //Arrange
            StreamingContent matrix = new StreamingContent("Matrix", "Mind Bending Sci-Fi Drama", 1.75, 8.7, "SciFi", MaturityRating.PG13);
            StreamingContentRepository repo = new StreamingContentRepository();

            repo.AddContentToDirectory(matrix);

            //Act
            List<StreamingContent> contents = repo.GetContents();

            bool success = contents.Contains(matrix);

            //Assert
            Assert.IsTrue(success);
        }
    }
}
