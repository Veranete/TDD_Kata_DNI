using System;
using System.Runtime.Serialization;

namespace Domain
{
	public class DomainException : Exception
	{
		public DomainException(string message) : base(message)
		{
		}
	}
}