﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.8009
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class Settings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings),Settings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As Settings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property UseDB() As Boolean
        Get
            Return CType(Me("UseDB"),Boolean)
        End Get
        Set
            Me("UseDB") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("c:\templates")>  _
    Public Property TemplateDir() As String
        Get
            Return CType(Me("TemplateDir"),String)
        End Get
        Set
            Me("TemplateDir") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Server() As String
        Get
            Return CType(Me("Server"),String)
        End Get
        Set
            Me("Server") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Table() As String
        Get
            Return CType(Me("Table"),String)
        End Get
        Set
            Me("Table") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property User() As String
        Get
            Return CType(Me("User"),String)
        End Get
        Set
            Me("User") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property Password() As String
        Get
            Return CType(Me("Password"),String)
        End Get
        Set
            Me("Password") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
    Public Property DBType() As Integer
        Get
            Return CType(Me("DBType"),Integer)
        End Get
        Set
            Me("DBType") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("localhost")>  _
    Public Property MMAServer() As String
        Get
            Return CType(Me("MMAServer"),String)
        End Get
        Set
            Me("MMAServer") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("25452")>  _
    Public Property MMAPort() As Integer
        Get
            Return CType(Me("MMAPort"),Integer)
        End Get
        Set
            Me("MMAPort") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Admin")>  _
    Public Property MMAUser() As String
        Get
            Return CType(Me("MMAUser"),String)
        End Get
        Set
            Me("MMAUser") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Admin")>  _
    Public Property MMAPassword() As String
        Get
            Return CType(Me("MMAPassword"),String)
        End Get
        Set
            Me("MMAPassword") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("dbid")>  _
    Public Property IDCollumn() As String
        Get
            Return CType(Me("IDCollumn"),String)
        End Get
        Set
            Me("IDCollumn") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("template")>  _
    Public Property TemplateCollumn() As String
        Get
            Return CType(Me("TemplateCollumn"),String)
        End Get
        Set
            Me("TemplateCollumn") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("24932")>  _
    Public Property MMAAdminPort() As Integer
        Get
            Return CType(Me("MMAAdminPort"),Integer)
        End Get
        Set
            Me("MMAAdminPort") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property IsAccelerator() As Boolean
        Get
            Return CType(Me("IsAccelerator"),Boolean)
        End Get
        Set
            Me("IsAccelerator") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property MatchingThreshold() As Integer
        Get
            Return CType(Me("MatchingThreshold"),Integer)
        End Get
        Set
            Me("MatchingThreshold") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property FingersMaximalRotation() As Byte
        Get
            Return CType(Me("FingersMaximalRotation"),Byte)
        End Get
        Set
            Me("FingersMaximalRotation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property FingersMatchingSpeed() As Global.Neurotec.Biometrics.NMatchingSpeed
        Get
            Return CType(Me("FingersMatchingSpeed"),Global.Neurotec.Biometrics.NMatchingSpeed)
        End Get
        Set
            Me("FingersMatchingSpeed") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property FacesMatchingSpeed() As Global.Neurotec.Biometrics.NMatchingSpeed
        Get
            Return CType(Me("FacesMatchingSpeed"),Global.Neurotec.Biometrics.NMatchingSpeed)
        End Get
        Set
            Me("FacesMatchingSpeed") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property IrisesMatchingSpeed() As Global.Neurotec.Biometrics.NMatchingSpeed
        Get
            Return CType(Me("IrisesMatchingSpeed"),Global.Neurotec.Biometrics.NMatchingSpeed)
        End Get
        Set
            Me("IrisesMatchingSpeed") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property IrisesMaxRotation() As Byte
        Get
            Return CType(Me("IrisesMaxRotation"),Byte)
        End Get
        Set
            Me("IrisesMaxRotation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property PalmsMatchingSpeed() As Global.Neurotec.Biometrics.NMatchingSpeed
        Get
            Return CType(Me("PalmsMatchingSpeed"),Global.Neurotec.Biometrics.NMatchingSpeed)
        End Get
        Set
            Me("PalmsMatchingSpeed") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property PalmsMaximalRotation() As Byte
        Get
            Return CType(Me("PalmsMaximalRotation"),Byte)
        End Get
        Set
            Me("PalmsMaximalRotation") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property FingersMatchingMode() As UInteger
        Get
            Return CType(Me("FingersMatchingMode"),UInteger)
        End Get
        Set
            Me("FingersMatchingMode") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Neurotec.Samples.Settings
            Get
                Return Global.Neurotec.Samples.Settings.Default
            End Get
        End Property
    End Module
End Namespace
