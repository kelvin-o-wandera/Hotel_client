Imports Newtonsoft.Json
Imports System.IO.IsolatedStorage

Partial Public Class AddHotel
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Public Sub New()
        InitializeComponent()
    End Sub

   

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim myHotel As New Hotel()
        myHotel.HotelName = hotelNameTxt.Text
        myHotel.Location = locationTxt.Text
        myHotel.Time = timeTxt.Text

        App.hotelViewModel.AddHotel(myHotel)
        If settings.Contains("hoteldatabase") Then
            settings("hoteldatabase") = JsonConvert.SerializeObject(App.hotelViewModel.hotel)
        Else
            settings.Add("hoteldatabase", JsonConvert.SerializeObject(App.hotelViewModel.hotel))
        End If
        NavigationService.Navigate(New Uri("/Hotels.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
