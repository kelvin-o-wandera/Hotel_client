
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Hotel_App.Models
    Public Class Food
        Public Property FoodName() As String
            Get
                Return m_FoodName
            End Get
            Set(value As String)
                m_FoodName = Value
            End Set
        End Property
        Private m_FoodName As String
        Public Property Price() As String
            Get
                Return m_Price
            End Get
            Set(value As String)
                m_Price = Value
            End Set
        End Property
        Private m_Price As String
    End Class
End Namespace


