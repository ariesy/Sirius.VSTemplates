Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web

Public Class $safeitemname$
    ' TODO: 将 [[class name]] 替换为您的数据类名
    Inherits DataService(Of [[class name]])

    ' 仅调用此方法一次以初始化涉及服务范围的策略。
    Public Shared Sub InitializeService(ByVal config As $dataserviceconfig$)
        ' TODO: 设置规则以指明哪些实体集和服务操作是可见的、可更新的，等等。
        ' 示例:
        ' config.SetEntitySetAccessRule("MyEntityset", EntitySetRights.AllRead)
        ' config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All)
        $protocolversion$
    End Sub

End Class
