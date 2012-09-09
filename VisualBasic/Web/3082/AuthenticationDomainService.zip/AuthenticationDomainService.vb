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

    'Para habilitar la autenticación de Forms o Windows para la aplicación web, edite la sección correspondiente del archivo web.config.

End Class

Public Class User
    Inherits UserBase

    'NOTA: las propiedades de perfil se pueden agregar aquí 
    'Para habilitar perfiles, edite la sección correspondiente del archivo web.config.
    
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


