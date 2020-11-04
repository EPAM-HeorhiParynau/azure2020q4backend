using Azure2020q4.Service;
using Azure2020q4API.Common;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Azure2020q4API.UnitTests.Common
{
	[TestClass]
	public class ConverterTests
	{
		private Converter _converter;

		[TestInitialize]
		public void Init()
		{
			_converter = new Converter();
		}

		[TestMethod]
		public void ConverterHappyPath()
		{
			var outcome = Class1.Method();

			outcome.Should().Be(Class1.Method());
		}
	}
}