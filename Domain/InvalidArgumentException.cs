using System;

namespace Domain
{
	public class InvalidArgumentException : Exception
	{
		public InvalidArgumentException(string message) : base(message: message)
		{

		}
	}
}