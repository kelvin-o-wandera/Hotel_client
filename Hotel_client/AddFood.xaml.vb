Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json
Imports System.IO.IsolatedStorage

Partial Public Class AddFood
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        Dim myFood As New Food()
        myFood.FoodName = foodNameTxt.Text
        myFood.Price = priceTxt.Text

        App.foodViewModel.AddFood(myFood)
        If settings.Contains("fooddatabase") Then
            settings("fooddatabase") = JsonConvert.SerializeObject(App.foodViewModel.food)
        Else
            settings.Add("fooddatabase", JsonConvert.SerializeObject(App.foodViewModel.food))
        End If
        NavigationService.Navigate(New Uri("/Foods.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
