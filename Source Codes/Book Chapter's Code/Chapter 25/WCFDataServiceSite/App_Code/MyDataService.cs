using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;

public class MyDataService : DataService<MyClassDataContext>
{
    // This method is called only once to initialize service-wide policies.
    public static void InitializeService(DataServiceConfiguration config)
    {
        // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
        // Examples:
        //config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead);
        config.SetEntitySetAccessRule("*", EntitySetRights.All);
        // config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
        config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        config.UseVerboseErrors = true; //for debugging-purpose only
    }
}
