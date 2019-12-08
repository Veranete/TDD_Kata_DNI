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
			checkDniHasValidLength(dni);

			throw new DomainException("Ends with number");
		}

		private void checkDniHasValidLength(string dni)
		{
			if (dni.Length != VALID_LENGTH)
				throw new LengthException("Too long or too short");
		}
	}
}
