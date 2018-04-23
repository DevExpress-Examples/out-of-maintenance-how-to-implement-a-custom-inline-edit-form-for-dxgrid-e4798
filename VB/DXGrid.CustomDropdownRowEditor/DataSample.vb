﻿' Developer Express Code Central Example:
' How to implement custom dropdown row editor for DXGrid
' 
' This example demonstrates how to edit grid rows using a separate inline edit
' form with editors generated automatically based on the underlying row data
' object. To see this approach in action, click the "Edit" hyperlink in the "#"
' grid column. To close the edit form, click "Edit" again.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4798

' Developer Express Code Central Example:
' How to implement custom dropdown row editor for DXGrid
' 
' This example demonstrates how to edit grid row using the dropdown panel with
' editors generated automatically based on the underlying row data object. To see
' this approach in action, click the "Edit" hyperlink in the "#" grid column. To
' close dropdown panel click "Edit" again.
' This functionality is achieved by
' creating the attached behavior which generates the necessary DataRowTemplate for
' the grid row. The custom template can also be defined and assigned to the
' GridHelper.CustomTemplate property, so the custom template will be used instead
' the autogenerated template.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4798

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace DXGrid.CustomDropdownRowEditor
    Public Class DataSample
        Implements INotifyPropertyChanged

        Private _IsProcessed As Boolean
        Private _Amount As Integer
        Private _OrderDate As Date
        Private _Name As String

        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
                NotifyPropertyChanged("Name")
            End Set
        End Property
        Public Property OrderDate() As Date
            Get
                Return _OrderDate
            End Get
            Set(ByVal value As Date)
                _OrderDate = value
                NotifyPropertyChanged("OrderDate")
            End Set
        End Property
        Public Property Amount() As Integer
            Get
                Return _Amount
            End Get
            Set(ByVal value As Integer)
                _Amount = value
                NotifyPropertyChanged("Amount")
            End Set
        End Property
        Public Property IsProcessed() As Boolean
            Get
                Return _IsProcessed
            End Get
            Set(ByVal value As Boolean)
                _IsProcessed = value
                NotifyPropertyChanged("IsProcessed")
            End Set
        End Property

        Public Shared Function GetData(ByVal count As Integer) As List(Of DataSample)
            Dim rnd As New Random()
            Dim data As New List(Of DataSample)()
            For i As Integer = 0 To count - 1
                Dim ds As New DataSample()
                ds.Name = "Name-" & i
                ds.OrderDate = New Date(2013, rnd.Next(1, 6), rnd.Next(1, 29))
                ds.Amount = rnd.Next(5, 10)
                ds.IsProcessed = If(rnd.Next(1, 3) = 1, True, False)
                data.Add(ds)
            Next i
            Return data
        End Function
  


#Region "INotifyPropertyChanged Members"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Private Sub NotifyPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))

        End Sub





#End Region
    End Class
End Namespace
