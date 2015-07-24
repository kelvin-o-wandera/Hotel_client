

Imports System.Collections.ObjectModel
Imports Newtonsoft.Json

Namespace ViewModels
    Public Class HotelViewModel
        Private _hotel As New ObservableCollection(Of Hotel)()

        Public Sub New()
        End Sub
        Public Property hotel() As ObservableCollection(Of Hotel)
            Get
                Return _hotel
            End Get
            Set(value As ObservableCollection(Of Hotel))
                _hotel = value
            End Set
        End Property
        Public Sub LoadData(json As String)
            _hotel = JsonConvert.DeserializeObject(Of ObservableCollection(Of Hotel))(json)
        End Sub
        Public Sub AddHotel(newHotel As Hotel)
            _hotel.Add(newHotel)
        End Sub
        Public Sub RemoveHotel(oldHotel As Hotel)
            _hotel.Remove(oldHotel)
        End Sub
    End Class
End Namespace


