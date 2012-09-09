Imports System.Web
Public Class $safeitemrootname$ 
    Implements IHttpModule

    Private WithEvents _context As HttpApplication

    ''' <summary>
    '''  您将需要在网站的 web.config 文件中配置此模块，
    '''  并向 IIS 注册此模块，然后才能使用。有关详细信息，
    '''  请参见下面的链接: http://go.microsoft.com/?linkid=8101007
    ''' </summary>
#Region "IHttpModule 成员"

    Public Sub Dispose() Implements IHttpModule.Dispose

        ' 此处放置清除代码

    End Sub

    Public Sub Init(ByVal context As HttpApplication) Implements IHttpModule.Init
        _context = context
    End Sub

#End Region

    Public Sub OnLogRequest(ByVal source As Object, ByVal e As EventArgs) Handles _context.LogRequest

        ' 处理 LogRequest 事件以便为它提供自定义日志记录
        ' 实现

    End Sub
End Class
