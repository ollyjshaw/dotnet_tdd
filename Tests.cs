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
      var echoer = new Echo();
      Assert.Equal("hello", echoer.echo("hello"));
      Assert.Equal("world", echoer.echo("world"));
    }
  }
}
