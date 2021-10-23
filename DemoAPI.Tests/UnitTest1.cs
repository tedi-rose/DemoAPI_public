using System;
using System.Linq;
using DemoAPI.WebApi.Controllers;
using Xunit;

namespace DemoAPI.Tests
{
	public class UnitTest1
	{
		MonitorController monitor = new MonitorController();

		[Fact]
		public void Test1()
		{

		}

		[Fact]
		public void GetReturnsValues()
		{
			var values = monitor.Get();

			Assert.Equal("val-1", values.First());
		}
	}
}
