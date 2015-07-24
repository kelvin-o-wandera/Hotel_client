Imports System.IO.IsolatedStorage
Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json

Partial Public Class Foods
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Public Sub New()
        InitializeComponent()
        If settings.Contains("fooddatabase") Then
            Dim data As String = TryCast(settings("fooddatabase"), String)
            App.foodViewModel.LoadData(data)

            foodlistbox.ItemsSource = App.foodViewModel.food
        End If
    End Sub
    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        MyBase.OnNavigatedTo(e)
        If foodlistbox.Items.Count > 0 Then
            emptyText.Visibility = System.Windows.Visibility.Collapsed
        Else
            emptyText.Visibility = System.Windows.Visibility.Visible
        End If
    End Sub

    Private Sub ListBoxItem_Tap(sender As Object, e As GestureEventArgs)
        Dim fd As Food = TryCast(foodlistbox.SelectedItem, Food)
        App.transitFood = fd
        Dim newCart As New Cart()
        newCart.FoodName = App.transitFood.FoodName
        newCart.Price = App.transitFood.Price
        App.cartViewModel.AddCart(newCart)
        If settings.Contains("cartdatabase") Then
            settings("cartdatabase") = JsonConvert.SerializeObject(App.cartViewModel.Cart)
        Else
            settings.Add("cartdatabase", JsonConvert.SerializeObject(App.cartViewModel.Cart))
        End If
        displayMessage()
    End Sub
    Private Sub displayMessage()
        MessageBox.Show("Food item successfully added to cart")
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/Checkout.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
