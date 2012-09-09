using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;


public partial class Triggers
{
    // 为目标输入现有表或视图并取消对特性行的注释
    // [Microsoft.SqlServer.Server.SqlTrigger (Name="$safeitemname$", Target="Table1", Event="FOR UPDATE")]
    public static void $safeitemname$ ()
    {
		// 用您的代码替换
		SqlContext.Pipe.Send("Trigger FIRED");
    }
}
