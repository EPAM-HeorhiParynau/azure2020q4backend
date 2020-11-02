using Azure2020q4.Service;

namespace Azure2020q4API.Common
{
	public class Converter
	{
		public string Convert(int input)
		{
			return new SharedLibrary.Utilities().ConverNumber(input) + Class1.Method();
		}
	}
}