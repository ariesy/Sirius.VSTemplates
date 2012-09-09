using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native)]
public struct $safeitemname$: INullable
{
    public override string ToString()
    {
        // 用您的代码替换下列代码
        return "";
    }

    public bool IsNull
    {
        get
        {
            // 在此处放置代码
            return m_Null;
        }
    }

    public static $safeitemname$ Null
    {
        get
        {
            $safeitemname$ h = new $safeitemname$();
            h.m_Null = true;
            return h;
        }
    }

    public static $safeitemname$ Parse(SqlString s)
    {
        if (s.IsNull)
            return Null;
        $safeitemname$ u = new $safeitemname$();
        // 在此处放置代码
        return u;
    }

    // 这是占位符方法
    public string Method1()
    {
        //在此处插入方法代码
        return "$IT_UDT_CS_Loc_1$";
    }

    // 这是占位符静态方法
    public static SqlString Method2()
    {
        //在此处插入方法代码
        return new SqlString("$IT_UDT_CS_Loc_1$");
    }

    // 这是占位符字段成员
    public int var1;
    // 私有成员
    private bool m_Null;
}


