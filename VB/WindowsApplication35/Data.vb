Imports Microsoft.VisualBasic
Imports System
' ...

Namespace WindowsApplication35
	Friend Class Data
		Public Sub New()
		End Sub
		Private _id As Integer
		Private _name As String
		Private _date As DateTime
		Public Property Id() As Integer
			Get
				Return Me._id
			End Get
			Set(ByVal value As Integer)
				Me._id = value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return Me._name
			End Get
			Set(ByVal value As String)
				Me._name = value
			End Set
		End Property
		Public Property [Date]() As DateTime
			Get
				Return Me._date
			End Get
			Set(ByVal value As DateTime)
				Me._date = value
			End Set
		End Property
	End Class
End Namespace
