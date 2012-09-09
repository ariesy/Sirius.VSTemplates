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

    '若要為 Web 應用程式啟用 Forms/Windows 驗證，請編輯 web.config 檔案的適當區段。

End Class

Public Class User
    Inherits UserBase

    '注意: 這裡可以加入設定檔屬性 
    '若要啟用設定檔，請編輯 web.config 檔案的適當區段。
    
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


