Public Class ListBasic
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim MyList As List(Of SListTest) = New List(Of SListTest)


        'OK NOW PLEASE REMIND ME

        'Is list index is 1 first or ZERO
        For n As Integer = 0 To 10

            Dim w As New SListTest
            w.Num1 = n + 1
            w.Num2 = n + 2

            MyList.Add(w)
            w = Nothing
        Next n

        Dim first = MyList(0)
        'First item Is: MyList(0) Or (1)???  ' because List's index starts with zero, first item is MyList(0)
        'Second item Is: MyList(1) Or (2)???  ' then second itme is MyList(1)
        'Get last item In List:  MyList(Mylist.Count-1) ????  ' the last item in MyList is MyList(MyList.Count-1)  
        'Count size Of MyList: MyList.count ???  ' MyList.Count always returns the count of the element is the list, so in your case it is 11
        'Determine the number Of items In a list: MyList.count -1 Or MyList.count ???  duplicate with the previous question

        ' Looping through a list

        ' For n As Integer = 1 To MyList.count  ????

        'Next
        For index = 0 To MyList.Count - 1
            Response.Write((MyList(index).Num1 + MyList(index).Num2) & "<br/>")
        Next
        For Each item In MyList
            Response.Write((item.Num1 + item.Num2) & "<br/>")
        Next
    End Sub
    Public Class SListTest
        Public Property Num1 As Integer
        Public Property Num2 As Integer
    End Class
End Class