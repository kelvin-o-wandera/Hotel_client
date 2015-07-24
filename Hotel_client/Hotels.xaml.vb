Imports System.IO.IsolatedStorage

Partial Public Class Hotels
    Inherits PhoneApplicationPage
    Dim settings As IsolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings
    Public Sub New()
        InitializeComponent()
        If settings.Contains("hoteldatabase") Then
            Dim data As String = TryCast(settings("hoteldatabase"), String)
            App.hotelViewModel.LoadData(data)

            hotelsListbox.ItemsSource = App.hotelViewModel.hotel
        End If
    End Sub

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        MyBase.OnNavigatedTo(e)
        If hotelsListbox.Items.Count > 0 Then
            emptyText.Visibility = System.Windows.Visibility.Collapsed
        Else
            emptyText.Visibility = System.Windows.Visibility.Visible
        End If
    End Sub

    Private Sub ListBoxItem_Tap(sender As Object, e As GestureEventArgs)
        NavigationService.Navigate(New Uri("/Foods.xaml", UriKind.RelativeOrAbsolute))
    End Sub
End Class
