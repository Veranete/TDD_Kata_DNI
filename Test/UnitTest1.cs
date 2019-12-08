using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void shouldFailWhenDniLongerThanMaxLenght()
		{
			try
			{
				var dni = new dni("0123456789");
			}
			catch (LengthException ex)
			{
				Assert.AreEqual("Too Long", ex.Message);
			}
		}
		[TestMethod]
		public void shouldFailWhenDniShorterThanMinLenght()
		{
			try
			{
				var dni = new dni("01234567");
			}
			catch (LengthException ex)
			{
				Assert.AreEqual("Too Short", ex.Message);
			}
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
