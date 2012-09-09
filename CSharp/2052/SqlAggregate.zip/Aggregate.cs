using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedAggregate(Format.Native)]
public struct $safeitemname$
{
    public void Init()
    {
        // 在此处放置代码
    }

    public void Accumulate(SqlString Value)
    {
        // 在此处放置代码
    }

    public void Merge ($safeitemname$ Group)
    {
        // 在此处放置代码
    }

    public SqlString Terminate ()
    {
        // 在此处放置代码
        return new SqlString ("");
    }

    // 这是占位符成员字段
    private int var1;

}
