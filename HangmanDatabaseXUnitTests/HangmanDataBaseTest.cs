﻿using HangmanWPF.Models;
using Xunit;

namespace HangmanDatabaseXUnitTests
{
    public class HangmanDataBaseTest
    {

        [Fact]
        public void GetWordCountTest()
        {
            //Arrange
            HangmanDataFetcherSQLite db = new HangmanDataFetcherSQLite();

            //Act
            int actual = db.WordCount;

            //Assert
            Assert.True(actual > -1);
        }
    }
}
