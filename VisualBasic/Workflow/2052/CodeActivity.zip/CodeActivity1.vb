Imports System.Activities

Public NotInheritable Class $safeitemname$
    Inherits CodeActivity
    
    '定义一个字符串类型的活动输入参数
    Property Text() As InArgument(Of String)

        ' 如果活动返回值，则从 CodeActivity(Of TResult) 派生
        ' 并从 Execute 方法返回该值。
    Protected Overrides Sub Execute(ByVal context As CodeActivityContext)
        '获取 Text 输入参数的运行时值
        Dim text As String
        text = context.GetValue(Me.Text)
    End Sub
End Class
