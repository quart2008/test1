
using Appeon.CoreService.Data;
using Appeon.CoreService.Data.SqlServer;

namespace WebApplication1
{
    /// <summary>
    /// This context needs to be injected into the ConfigureServices method in the Startup class. Note: ("key" should be replaced with your own connection string name). code show as below:
    /// services.AddDataContext<QaDataContext>(m => m.UseSqlServer(Configuration["ConnectionStrings:key"]));
    /// </summary>
    public class QaDataContext : SqlServerDataContext
	{
		public QaDataContext(string connection) : 
            this(new SqlServerDataContextOptions<QaDataContext>(connection))
        {
        }
        
		public QaDataContext(IDataContextOptions<QaDataContext> options) : base(options)
        {
        }
	}
}
