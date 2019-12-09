using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
	public class dni
	{
		const short VALID_LENGTH = 9;
		public dni(string dni)
		{
			checkDniHasValidLength(dni);

			if (Regex.IsMatch(dni, @"[UIOÑ\d]$"))
				throw new DomainException("Ends with invalid letter");
			if (!Regex.IsMatch(dni, @"\d{7,7}.$"))
				throw new DomainException("Has letters in the middle");
			if (!Regex.IsMatch(dni, @"^[XYZ0-9]"))
				throw new DomainException("Starts with invalid letter");

			throw new InvalidArgumentException("Invalid dni");
		}

		private void checkDniHasValidLength(string dni)
		{
			if (dni.Length != VALID_LENGTH)
				throw new LengthException("Too long or too short");
		}

	}
}
