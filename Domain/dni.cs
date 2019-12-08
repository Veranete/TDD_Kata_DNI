using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class dni
	{
		const short VALID_LENGTH = 9;
		public dni(string dni)
		{
			if (dni.Length != VALID_LENGTH)
				throw checkDniHasValidLength(dni);

			throw new DomainException("Ends with number");
		}

		private static LengthException checkDniHasValidLength(string dni)
		{
			return new LengthException(dni.Length < VALID_LENGTH ? "Too Short" : "Too Long");
		}
	}
}
