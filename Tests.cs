using System;
using Xunit;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
      [Fact]
      public void MathsWorks()
      {
          Assert.Equal(4, 2+2);
      }

      [Fact]
      public void HelloTest()
      {
          Assert.Equal("hello", new Echo().echo("hello"));
      }

    }
}
