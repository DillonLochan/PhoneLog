﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class PhoneLogEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PhoneLogEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Calls() As DbSet(Of [Call])
    Public Overridable Property Employees() As DbSet(Of Employee)
    Public Overridable Property ForeignCompanies() As DbSet(Of ForeignCompany)

End Class
