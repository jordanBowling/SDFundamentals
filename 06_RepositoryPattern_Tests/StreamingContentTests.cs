using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        //Arrange
        //Act
        //Assert
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrange
            StreamingContent content = new StreamingContent();

            //Act
            content.Title = "Little Shop of Horrors";

            //Assert
            string expected = "Little Shop of Horrors";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);

        }

        //Multiple Data Points
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG13, false)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldSetCorrectEnum(MaturityRating maturity, bool isFamilyFriendly)
        {
            //AA
            //Arrange
            StreamingContent content = new StreamingContent("Title", "Description", .5, 99, "Animation", maturity);

            //Act
            MaturityRating actualMaturity = content.RatingMaturity;
            MaturityRating expectedMaturity = maturity;

            //Assert
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
