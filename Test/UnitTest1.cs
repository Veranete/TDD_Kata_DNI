using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[ExpectedException(typeof(LengthException), "Exception type not allowed")]
		public void shouldFailWhenDniLongerThanMaxLenght()
		{
			var dni = new dni("0123456789");

		}
		[TestMethod]
		[ExpectedException(typeof(LengthException), "Exception type not allowed")]
		public void shouldFailWhenDniShorterThanMinLenght()
		{
			var dni = new dni("01234567");
		}
		[TestMethod]
		public void shouldFailWhenDniEndsWithANumber()
		{
			try
			{
				var dni = new dni("012345678");
			}
			catch (DomainException ex)
			{
				Assert.AreEqual("Ends with number", ex.Message);
			}
		}

	}
}
