using System.IO;
using Microsoft.Extensions.Configuration;

namespace UnitTests
{
	public abstract class BaseTest
	{
		protected BaseTest()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
			Configuration = builder.Build();
		}
		protected IConfiguration Configuration { get; private set; }
	}
}
