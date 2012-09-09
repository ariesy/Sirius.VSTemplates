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

    'Web アプリケーションに対して Forms 認証および Windows 認証を有効にするには、web.config ファイルの該当する部分を編集してください。

End Class

Public Class User
    Inherits UserBase

    '注: プロファイル プロパティはここに追加できます 
    'プロファイルを有効にするには、web.config ファイルの該当する部分を編集してください。
    
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


