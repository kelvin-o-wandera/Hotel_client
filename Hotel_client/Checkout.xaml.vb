Imports System.IO.IsolatedStorage
Imports Hotel_client.Hotel_App.Models
Imports Newtonsoft.Json

Partial Public Class Checkout
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Dim lit As String
    Public Sub New()
        InitializeComponent()
        If settings.Contains("cartdatabase") Then
            Dim data As String = TryCast(settings("cartdatabase"), String)
            App.cartViewModel.LoadData(data)
            cartListBox.ItemsSource = App.cartViewModel.Cart
        End If
    End Sub
    Public Function generateGuid() As String
        Dim newGuid As String = Guid.NewGuid().ToString()
        Return newGuid
    End Function

    Private Sub Button_Tap(sender As Object, e As GestureEventArgs)
        idGuid.Text = generateGuid()
    End Sub

    Private Sub Button_Tap_1(sender As Object, e As GestureEventArgs)
        'Dim myList As List(Of [String]) = cartListBox.Items.Cast(Of [String])().ToList()
        lit += cartListBox.Items.ToString()
        Dim myOrder As New Order()
        myOrder.ShopperName = nameTxt.Text
        myOrder.OrderId = idGuid.Text
        myOrder.Orders = lit

        App.orderViewModel.AddOrder(myOrder)
        If settings.Contains("orderdatabase") Then
            settings("orderdatabase") = JsonConvert.SerializeObject(App.orderViewModel.order)
        Else
            settings.Add("orderdatabase", JsonConvert.SerializeObject(App.orderViewModel.order))
        End If
        displayMessage()
    End Sub
    Private Sub displayMessage()
        MessageBox.Show("Your order has been placed successfully!!")
        NavigationService.Navigate(New Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
