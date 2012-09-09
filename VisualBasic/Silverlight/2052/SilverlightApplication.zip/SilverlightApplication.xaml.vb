 Partial Public Class $safeitemrootname$
    Inherits Application

    public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Application_Startup(ByVal o As Object, ByVal e As StartupEventArgs) Handles Me.Startup
        ' 此处设置初始页
    End Sub
    
    Private Sub Application_Exit(ByVal o As Object, ByVal e As EventArgs) Handles Me.Exit

    End Sub
    
    Private Sub Application_UnhandledException(ByVal sender As object, ByVal e As ApplicationUnhandledExceptionEventArgs) Handles Me.UnhandledException

        ' 如果应用程序是在调试器外运行的，则使用浏览器的
        ' 异常机制报告该异常。在 IE 上，将在状态栏中用一个 
        ' 黄色警报图标来显示该异常，而 Firefox 则会显示一个脚本错误。
        If Not System.Diagnostics.Debugger.IsAttached Then

            ' 注意: 这使应用程序可以在已引发异常但尚未处理该异常的情况下
            ' 继续运行。 
            ' 对于生产应用程序，此错误处理应替换为向网站报告错误
            ' 并停止应用程序。
            e.Handled = True
            Deployment.Current.Dispatcher.BeginInvoke(New Action(Of ApplicationUnhandledExceptionEventArgs)(AddressOf ReportErrorToDOM), e)
        End If
    End Sub

   Private Sub ReportErrorToDOM(ByVal e As ApplicationUnhandledExceptionEventArgs)

        Try
            Dim errorMsg As String = e.ExceptionObject.Message + e.ExceptionObject.StackTrace
            errorMsg = errorMsg.Replace(""""c, "'"c).Replace(ChrW(13) & ChrW(10), "\n")

            System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(""Unhandled Error in Silverlight 2 Application " + errorMsg + """);")
        Catch
        
        End Try
    End Sub
    
End Class
