Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web

<ServiceContract(Namespace:="")>$if$ ($targetframeworkversion$ <= 3.5) _$endif$
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>$if$ ($targetframeworkversion$ <= 3.5) _$endif$
Public Class $safeitemrootname$

    ' 要使用 HTTP GET，请添加 <WebGet()> 特性。(默认 ResponseFormat 为 WebMessageFormat.Json)
    ' 要创建返回 XML 的操作，
    '     请添加 <WebGet(ResponseFormat:=WebMessageFormat.Xml)>,
    '     并在操作正文中包括以下行:
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>$if$ ($targetframeworkversion$ <= 3.5) _$endif$
    Public Sub DoWork()
        ' 在此处添加操作实现
    End Sub

    ' 在此处添加更多操作，并为它们添加标记 <OperationContract()>

End Class
