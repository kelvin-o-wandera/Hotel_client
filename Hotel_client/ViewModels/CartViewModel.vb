
Imports System.Collections.ObjectModel
Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json

Namespace ViewModels
    Public Class CartViewModel
        Private _cart As New ObservableCollection(Of Cart)()

        Public Sub New()
        End Sub
        Public Property Cart() As ObservableCollection(Of Cart)
            Get
                Return _cart
            End Get
            Set(value As ObservableCollection(Of Cart))
                _cart = value
            End Set
        End Property
        Public Sub AddCart(newCart As Cart)
            _cart.Add(newCart)
        End Sub
        Public Sub RemoveCart(oldCart As Cart)
            _cart.Remove(oldCart)
        End Sub
        Public Sub LoadData(json As String)
            _cart = JsonConvert.DeserializeObject(Of ObservableCollection(Of Cart))(json)
        End Sub

    End Class
End Namespace


