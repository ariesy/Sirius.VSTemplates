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

    'Pour activer l'authentification Forms/Windows pour l'application Web, modifiez la section appropriée du fichier web.config.

End Class

Public Class User
    Inherits UserBase

    'REMARQUE : les propriétés de profil peuvent être ajoutées ici 
    'Pour activer des profils, modifiez la section appropriée du ficher web.config.
    
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


