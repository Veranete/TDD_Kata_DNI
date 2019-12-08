using System;
namespace Domain
{
	public class LengthException : Exception
	{
		public LengthException(string message):base(message)
		{
			
		}
	}
}