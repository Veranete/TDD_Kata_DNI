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

			if (!Regex.IsMatch(dni, @"^[XYZ\d]\d{7,7}[^UIOÑ\d]$"))
				throw new DomainException("Bad format");

			throw new InvalidArgumentException("Invalid dni");
		}

		private void checkDniHasValidLength(string dni)
		{
			if (dni.Length != VALID_LENGTH)
				throw new LengthException("Too long or too short");
		}

	}
}
