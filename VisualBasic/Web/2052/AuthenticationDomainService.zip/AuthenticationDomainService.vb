Option Strict Off
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.ServiceModel.DomainServices.Hosting
Imports System.ServiceModel.DomainServices.Server
Imports System.ServiceModel.DomainServices.Server.ApplicationServices

<EnableClientAccess()> _
Public Class $safeitemname$
    Inherits AuthenticationBase(Of User)

    '若要对 Web 应用程序启用 Forms/Windows 身份验证，请编辑 web.config 文件的相应部分。

End Class

Public Class User
    Inherits UserBase

    '注意: 此处可以添加配置文件属性
    '若要启用配置文件，请编辑 web.config 文件的相应部分。
    
    'Private myProfile As String
    'Public Property MyProfileProperty() As String
    '    Get
    '        Return myProfile
    '    End Get
    '    Set(ByVal value As String)
    '        myProfile = value
    '    End Set
    'End Property

End Class


