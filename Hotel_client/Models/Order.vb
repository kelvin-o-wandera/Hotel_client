
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Hotel_App.Models
    Public Class Order
        Public Property ShopperName() As String
            Get
                Return m_ShopperName
            End Get
            Set(value As String)
                m_ShopperName = Value
            End Set
        End Property
        Private m_ShopperName As String
        Public Property OrderId() As String
            Get
                Return m_OrderId
            End Get
            Set(value As String)
                m_OrderId = Value
            End Set
        End Property
        Private m_OrderId As String
        Public Property Orders() As String
            Get
                Return m_Orders
            End Get
            Set(value As String)
                m_Orders = value
            End Set
        End Property
        Private m_Orders As String
    End Class
End Namespace


