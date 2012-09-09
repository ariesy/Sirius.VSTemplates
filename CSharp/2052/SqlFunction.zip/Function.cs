using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString $safeitemname$()
    {
        // 在此处放置代码
        return new SqlString ("$IT_SQL_CS_Loc_1$");
    }
};

