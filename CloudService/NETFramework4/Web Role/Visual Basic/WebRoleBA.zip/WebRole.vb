﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Microsoft.WindowsAzure
Imports Microsoft.WindowsAzure.Diagnostics
Imports Microsoft.WindowsAzure.ServiceRuntime

Public Class WebRole
    Inherits RoleEntryPoint

    Public Overrides Function OnStart() As Boolean

        AddHandler RoleEnvironment.Changing, AddressOf RoleEnvironmentChanging

        Return MyBase.OnStart()

    End Function

    Private Sub RoleEnvironmentChanging(ByVal sender As Object, ByVal e As RoleEnvironmentChangingEventArgs)

        If (e.Changes.Any(Function(change) TypeOf change Is RoleEnvironmentConfigurationSettingChange)) Then
            e.Cancel = True
        End If

    End Sub

End Class

