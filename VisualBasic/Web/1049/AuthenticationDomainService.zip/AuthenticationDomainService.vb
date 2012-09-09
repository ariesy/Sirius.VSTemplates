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

    'Чтобы включить проверку подлинности Forms/Windows для веб-приложения, измените соответствующий раздел файла web.config.

End Class

Public Class User
    Inherits UserBase

    'ПРИМЕЧАНИЕ. Свойства профиля можно добавить сюда 
    'Чтобы включить профили, измените соответствующий раздел файла web.config.
    
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


