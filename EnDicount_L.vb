Public Class EnDicount_L
    Public Shadows Event TextChanged(sender As Object, e As EventArgs)
    Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)
    Public Shadows Event LostFocus(ByVal sender As Object, ByVal e As EventArgs)
    Public Sub ENCurency_Replace(ByVal ObjText As Object)
        With ObjText
            .Text = Replace(.Text, ".00", Nothing)
            .Text = Replace(.Text, ",", "")
            .Text = Replace(.Text, " ", "")
        End With
    End Sub

    Public Sub ENCurency_LostFocus(ByVal ObjTextBox As TextBox)
        Dim f As Double
        ObjTextBox.TextAlign = HorizontalAlignment.Right
        If ObjTextBox.Text = "" Or Not IsNumeric(ObjTextBox.Text) Then
            Exit Sub
        End If
        f = Str(ObjTextBox.Text)
        'ObjTextBox.Text = Format(f, "##,#0.00")
        ObjTextBox.SelectionStart = Len(ObjTextBox.Text)
    End Sub

    Private Sub txtCur_Click(ByVal sender As Object, ByVal e As EventArgs) Handles txtCur.Click
        ENCurency_Replace(txtCur)
    End Sub

    Private Sub txtCur_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCur.GotFocus
        ENCurency_Replace(txtCur)
    End Sub

    Private Sub txtCur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCur.KeyPress
        'ENTextBoxNumeric(txtCur, e)
        RaiseEvent KeyPress(sender, e)
    End Sub

    Private Sub txtCur_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtCur.LostFocus
        If txtCur.Text = "" Then txtCur.Text = Val(0)
        RaiseEvent LostFocus(sender, e)
        ENCurency_LostFocus(txtCur)
    End Sub

    Overrides Property Text As String
        Get
            'ENCurency_Replace(txtCur)
            Text = txtCur.Text
            'ENCurency_LostFocus(txtCur)
        End Get
        Set(ByVal v As String)
            txtCur.Text = v
            Invalidate()
            ENCurency_LostFocus(txtCur)
        End Set
    End Property

    Private Sub ENTextBoxNumeric(ByVal ObjText As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            'If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 43 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) = 43 Then
                    Return
                End If
                e.Handled = True
            End If

        End If
    End Sub

    Property TextReadOnly As Boolean
        Get
            Return txtCur.ReadOnly
        End Get
        Set(value As Boolean)
            txtCur.ReadOnly = value
        End Set
    End Property

    Private Sub txtCur_TextChanged(sender As Object, e As EventArgs) Handles txtCur.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            txtCur.Font = value
            Width = txtCur.Width
            MyBase.Font = value
        End Set
    End Property

    Private Sub ENDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
