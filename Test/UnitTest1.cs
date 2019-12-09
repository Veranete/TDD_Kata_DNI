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
		[ExpectedException(typeof(DomainException), "Ends with number")]
		public void shouldFailWhenDniEndsWithANumber()
		{
			var dni = new dni("012345678");
		}
		[TestMethod]
		[ExpectedException(typeof(DomainException), "Ends with invalid letter")]
		public void shouldFailWhenDniEndsWithAnInvalidLetter()
		{
			var dni = new dni("01234567I");
		}
		[TestMethod]
		[ExpectedException(typeof(DomainException), "Has letters in the middle")]
		public void shouldFailWhenDniHasLettersInTheMiddle()
		{
			var dni = new dni("012AB567R");
		}
		[TestMethod]
		[ExpectedException(typeof(DomainException), "Starts with invalid letter")]
		public void shouldFailWhenDniStartsWithALetterOtherThanXYZ()
		{
			var dni = new dni("A1234567R");
		}
		[TestMethod]
		[ExpectedException(typeof(InvalidArgumentException), "Exception type not allowed")]
		public void shouldFailWhenInvalidDni()
		{
			var dni = new dni("00000000S");
		}
	}
}
