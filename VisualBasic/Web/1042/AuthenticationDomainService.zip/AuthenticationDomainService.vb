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

    '웹 응용 프로그램에서 Forms/Windows 인증을 사용하려면 web.config 파일에서 해당 섹션을 편집하십시오.

End Class

Public Class User
    Inherits UserBase

    '참고: 여기에 프로필 속성을 추가할 수 있습니다. 
    '프로필을 사용하려면 web.config 파일에서 해당 섹션을 편집하십시오.
    
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


