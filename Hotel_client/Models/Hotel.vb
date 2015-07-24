Public Class Hotel
    Public Property HotelName() As String
        Get
            Return m_HotelName
        End Get
        Set(value As String)
            m_HotelName = value
        End Set
    End Property
    Private m_HotelName As String
    Public Property Location() As String
        Get
            Return m_Location
        End Get
        Set(value As String)
            m_Location = value
        End Set
    End Property
    Private m_Location As String
    Public Property Time() As String
        Get
            Return m_Time
        End Get
        Set(value As String)
            m_Time = value
        End Set
    End Property
    Private m_Time As String
End Class
