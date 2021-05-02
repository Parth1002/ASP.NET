using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlDecimal RectAreaFunction(decimal RectLength, decimal RectWidth)
    {
        // Put your code here
        return new SqlDecimal(RectLength * RectWidth);

    }
};

