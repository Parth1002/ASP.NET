using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedAggregate(Format.Native)]
public struct MyAgg_Total
{
    int total;
    public void Init()
    {
        total=0;
    }

    public void Accumulate(SqlInt32 Value)
    {
        total+=Value.Value;
    }

    public void Merge(MyAgg_Total Group)
    {
       total+=Group.total;
    }

    public SqlInt32 Terminate()
    {
       
        return new SqlInt32(total);
    }

   
}
