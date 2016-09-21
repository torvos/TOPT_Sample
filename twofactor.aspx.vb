Imports System.IO
Imports System.Net

Public Class twofactor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Private Sub btnEnable2Factor_Click(sender As Object, e As EventArgs) Handles btnEnable2Factor.Click

        Dim url As String = "http://api.authy.com/protected/json/users/new?api_key=YOURKEYHERE”
        Dim wrq = CType(Net.WebRequest.Create(url), HttpWebRequest)
        Dim postString As String = "user[email]=" + TextBox1.Text + "&user[cellphone]=" + TextBox2.Text + "&user[country_code]=1"
        wrq.Method = "POST"
        wrq.ContentType = "application/x-www-form-urlencoded"
        wrq.ContentLength = postString.Length

        Dim wrqWriter As New StreamWriter(wrq.GetRequestStream())
        wrqWriter.Write(postString)
        wrqWriter.Close()

        Try
            Dim responseReader As New StreamReader(wrq.GetResponse().GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()
            'litResults.Text += wrq.Headers.ToString() + "<br>"
            litResults.Text += responseData + "<br><br>"
            'litResults.Text += url + "<br><br>"

        Catch ex As WebException

            Dim httpResponse As HttpWebResponse = ex.Response
            Dim responseReader As New StreamReader(ex.Response.GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()

            'litResults.Text += httpResponse.StatusCode.ToString() + "<br>"
            litResults.Text += responseData + "<br><Br>"
            'litResults.Text += url + "<br><br>"

        End Try

    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim url As String = "http://api.authy.com/protected/json/verify/" + txtTOKEN.Text + "/" + txtAUTHY_ID.Text + "?api_key=YOURKEYHERE"
        Dim wrq = CType(Net.WebRequest.Create(url), HttpWebRequest)
        wrq.Method = "GET"
        wrq.ContentType = "application/x-www-form-urlencoded"

        Try
            Dim responseReader As New StreamReader(wrq.GetResponse().GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()
            'litResults.Text += wrq.Headers.ToString() + "<br>"
            litResults.Text += responseData + "<br><br>"
            'litResults.Text += url + "<br><br>"

        Catch ex As WebException

            Dim httpResponse As HttpWebResponse = ex.Response
            Dim responseReader As New StreamReader(ex.Response.GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()

            ' litResults.Text += httpResponse.StatusCode.ToString() + "<br>"
            litResults.Text += responseData + "<br><br>"
            'litResults.Text += url + "<br><br>"

        End Try
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Dim url As String = "http://api.authy.com/protected/json/sms/" + txtAUTHY_ID.Text + "?api_key=YOURKEYHERE&force=true&shortcode=true"
        Dim wrq = CType(Net.WebRequest.Create(url), HttpWebRequest)
        wrq.Method = "GET"
        wrq.ContentType = "application/x-www-form-urlencoded"

        Try
            Dim responseReader As New StreamReader(wrq.GetResponse().GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()
            'litResults.Text += wrq.Headers.ToString() + "<br>"
            litResults.Text += responseData + "<br><br>"
            'litResults.Text += url + "<br><br>"

        Catch ex As WebException

            Dim httpResponse As HttpWebResponse = ex.Response
            Dim responseReader As New StreamReader(ex.Response.GetResponseStream())
            Dim responseData As String = responseReader.ReadToEnd()

            ' litResults.Text += httpResponse.StatusCode.ToString() + "<br>"
            litResults.Text += responseData + "<br><br>"
            'litResults.Text += url + "<br><br>"

        End Try
    End Sub
End Class