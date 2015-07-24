
Imports System.Collections.ObjectModel
Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json

Namespace ViewModels
    Public Class OrderViewModel
        Private _order As New ObservableCollection(Of Order)()

        Public Sub New()
        End Sub
        Public Property order() As ObservableCollection(Of Order)
            Get
                Return _order
            End Get
            Set(value As ObservableCollection(Of Order))
                _order = value
            End Set
        End Property
        Public Sub LoadData(json As String)
            _order = JsonConvert.DeserializeObject(Of ObservableCollection(Of Order))(json)
        End Sub
        Public Sub AddOrder(newOrder As Order)
            _order.Add(newOrder)
        End Sub
        Public Sub RemoveOrder(oldOrder As Order)
            _order.Remove(oldOrder)
        End Sub
    End Class
End Namespace

