using Microsoft.Extensions.Options;
using Student.BL.AppCinfigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.BL.Helpers
{
	public class Utilities : IUtilities
	{
		private readonly FileConfig _fileConfig;

		public Utilities(
			IOptionsMonitor<FileConfig> options
		
			)
		{
			_fileConfig = options.CurrentValue;
		}
		public string getValue()
		{
			return _fileConfig.maxLength.ToString();
		}
	}
}
