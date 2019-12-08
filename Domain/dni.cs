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

			if (Regex.IsMatch(dni, @"\d$"))
				throw new DomainException("Ends with number");

			if (Regex.IsMatch(dni, @"[UIOÑ]$"))
				throw new DomainException("Ends with invalid letter");

			throw new DomainException("Has letters in the middle");
		}

		private void checkDniHasValidLength(string dni)
		{
			if (dni.Length != VALID_LENGTH)
				throw new LengthException("Too long or too short");
		}

	}
}
