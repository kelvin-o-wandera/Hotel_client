Imports System.Collections.ObjectModel
Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json

Namespace ViewModels
    Public Class FoodViewModel
        Private _food As New ObservableCollection(Of Food)()

        Public Sub New()
        End Sub
        Public Property food() As ObservableCollection(Of Food)
            Get
                Return _food
            End Get
            Set(value As ObservableCollection(Of Food))
                _food = value
            End Set
        End Property
        Public Sub LoadData(json As String)
            _food = JsonConvert.DeserializeObject(Of ObservableCollection(Of Food))(json)
        End Sub
        Public Sub AddFood(newFood As Food)
            _food.Add(newFood)
        End Sub
        Public Sub RemoveFood(oldFood As Food)
            _food.Remove(oldFood)
        End Sub
    End Class
End Namespace


