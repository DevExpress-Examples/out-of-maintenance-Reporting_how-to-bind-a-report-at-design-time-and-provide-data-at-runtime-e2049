Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
' ...

Namespace WindowsApplication35
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim report As New XtraReport1()
			report.DataSource = CreateData()
			report.ShowPreview()
		End Sub

		Private Function CreateData() As List(Of Data)
			Dim data As New List(Of Data)()

			Dim item1 As New Data()
			item1.Date = DateTime.Now
			item1.Id = 0
			item1.Name = "First"
			data.Add(item1)

			Dim item2 As New Data()
			item2.Date = DateTime.Now
			item2.Id = 1
			item2.Name = "Second"
			data.Add(item2)

			Dim item3 As New Data()
			item3.Date = DateTime.Now
			item3.Id = 2
			item3.Name = "Third"
			data.Add(item3)

			Return data
		End Function

	End Class
End Namespace