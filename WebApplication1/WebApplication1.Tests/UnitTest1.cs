using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true); // A simple passing test
        }

        [Fact]
        public void Test2()
        {
            Xunit.Assert.Equal(2, 1 + 1); // Another simple passing test
        }
    }
}

