'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class [Call]
    Public Property ID As Integer
    Public Property [Date] As Nullable(Of Date)
    Public Property PhoneNumber As String
    Public Property Duration As Nullable(Of Integer)
    Public Property Time As Nullable(Of System.TimeSpan)
    Public Property EmployeeID As Nullable(Of Integer)
    Public Property EmployeeName As String
    Public Property ForeignCompanyID As Nullable(Of Integer)
    Public Property ForeignCompanyName As String

    Public Overridable Property Employee As Employee
    Public Overridable Property ForeignCompany As ForeignCompany

End Class
