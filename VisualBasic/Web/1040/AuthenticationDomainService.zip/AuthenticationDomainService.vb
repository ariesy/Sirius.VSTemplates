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

    'Per abilitare l'Autenticazione basata su form/di Windows per l'applicazione Web modificare la sezione appropriata del file web.config.

End Class

Public Class User
    Inherits UserBase

    'NOTA: è possibile aggiungere qui le proprietà del profilo 
    'Per abilitare i profili modificare la sezione appropriata del file web.config.
    
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


