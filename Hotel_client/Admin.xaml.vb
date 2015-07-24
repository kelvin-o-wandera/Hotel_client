Imports System.IO.IsolatedStorage

Partial Public Class Admin
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Public Sub New()
        InitializeComponent()
        If settings.Contains("orderdatabase") Then
            Dim data As String = TryCast(settings("orderdatabase"), String)
            App.orderViewModel.LoadData(data)

            orderlistbox.ItemsSource = App.orderViewModel.order
        End If
        If settings.Contains("cartdatabase") Then
            Dim data As String = TryCast(settings("cartdatabase"), String)
            App.cartViewModel.LoadData(data)

            FoodnameListBox.ItemsSource = App.cartViewModel.Cart
        End If
    End Sub

    Private Sub ApplicationBarIconButton_Click(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/AddFood.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub ApplicationBarIconButton_Click_1(sender As Object, e As EventArgs)
        NavigationService.Navigate(New Uri("/AddHotel.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
