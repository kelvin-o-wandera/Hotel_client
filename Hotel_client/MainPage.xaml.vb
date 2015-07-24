Partial Public Class MainPage
    Inherits PhoneApplicationPage
    ' Constructor

    Public Sub New()
        InitializeComponent()
    End Sub

    

    Private Sub Image_Tap_3(sender As Object, e As GestureEventArgs)
        NavigationService.Navigate(New Uri("/Hotels.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub Image_Tap(sender As Object, e As GestureEventArgs)
        NavigationService.Navigate(New Uri("/Checkout.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub Image_Tap_1(sender As Object, e As GestureEventArgs)
        NavigationService.Navigate(New Uri("/Hotels.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub Image_Tap_2(sender As Object, e As GestureEventArgs)
        NavigationService.Navigate(New Uri("/Admin.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
