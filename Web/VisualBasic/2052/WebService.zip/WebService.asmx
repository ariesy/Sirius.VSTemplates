<%@ WebService Language="VB" Class="$safeitemrootname$" %>

Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

$if$ ($targetframeworkversion$ >= 3.5)'若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
' <System.Web.Script.Services.ScriptService()> _
$endif$<WebService(Namespace := "http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _  
Public Class $safeitemrootname$
    Inherits System.Web.Services.WebService 
    
	<WebMethod()> _
	Public Function HelloWorld() As String
		Return "Hello World"
	End Function

End Class
