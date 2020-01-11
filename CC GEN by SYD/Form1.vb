Imports System.IO
Public Class Form1
    Dim rand As New Random
    Private Sub GhostButtonGenerate_Click(sender As Object, e As EventArgs) Handles GhostButtonGenerate.Click
        Dim quan As Integer = CType(TextBoxQuantity.Text, Integer)
        'clear the listbox first
        ListBox1.Items.Clear()
        'this will add x's to the userbin val
        Dim sb As New System.Text.StringBuilder
        For num = 1 To 16 - TextBoxBin.Text.Length
            sb.Append("x")
        Next
        TextBoxBin.Text = TextBoxBin.Text & sb.ToString()

        If (TextBoxBin.Text.Equals("453590")) Then

            MessageBox.Show("Please enter your BIN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If (TextBoxCVV.Text.Length = 3) Or (TextBoxCVV.Text.Equals("Leave blank to randomize") Or (TextBoxCVV.Text.Equals(""))) Then
                For num = 1 To quan
                    If (GhostRadiobuttonValid.Checked) Then
                        generateCC()
                        ' MessageBox.Show(ListBox1.Items.Count.ToString & " cc produced", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        generateCCMixed()
                        ' MessageBox.Show(ListBox1.Items.Count.ToString & " cc produced", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If


                Next
                If (GhostRadiobuttonValid.Checked) Then
                    MessageBox.Show(ListBox1.Items.Count.ToString & " cc produced", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(ListBox1.Items.Count.ToString & " cc produced", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Invalid CVV. CVV number is 3 digits long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    'this function will generate valid cc only
    Sub generateCC()

        'retrieving month
        Dim userMonth = getMonth()
        'retrieving year
        Dim userYear = getYear()
        'retrieving cvv
        Dim userCVV = getCVV()

        Dim r As String = "0123456789"

        Dim bin As String = TextBoxBin.Text.Replace("x", "")
        Dim userBin As String = bin
        Dim characterString As Integer = 16 - bin.Length
        Dim sb As New System.Text.StringBuilder
        sb.Append(userBin)
        For i As Integer = 1 To characterString
            Dim index As Integer = rand.Next(0, r.Length)
            sb.Append(r.Substring(index, 1))

        Next
        If (checkValid(sb.ToString)) Then
            sb.Append("|" & userMonth)
            sb.Append("|" & userYear)
            sb.Append("|" & userCVV)
            ListBox1.Items.Add(sb.ToString())
        End If

    End Sub

    'this function will generate mixed cc
    Sub generateCCMixed()

        'retrieving month
        Dim userMonth = getMonth()
        'retrieving year
        Dim userYear = getYear()
        'retrieving cvv
        Dim userCVV = getCVV()

        Dim r As String = "0123456789"

        Dim bin As String = TextBoxBin.Text.Replace("x", "")
        Dim userBin As String = bin
        Dim characterString As Integer = 16 - bin.Length
        Dim sb As New System.Text.StringBuilder
        sb.Append(userBin)
        For i As Integer = 1 To characterString
            Dim index As Integer = rand.Next(0, r.Length)
            sb.Append(r.Substring(index, 1))

        Next

        sb.Append("|" & userMonth)
        sb.Append("|" & userYear)
        sb.Append("|" & userCVV)
        ListBox1.Items.Add(sb.ToString())


    End Sub

    'function for getting the month
    Function getMonth() As String
        Dim monthNum As String = Nothing
        Dim monthArray() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        Dim index As Integer = rand.Next(0, monthArray.Length)
        If (ComboBoxMonth.SelectedItem = "January") Then
            monthNum = "01"
        ElseIf (ComboBoxMonth.SelectedItem = "February") Then
            monthNum = "02"
        ElseIf (ComboBoxMonth.SelectedItem = "March") Then
            monthNum = "03"
        ElseIf (ComboBoxMonth.SelectedItem = "April") Then
            monthNum = "04"
        ElseIf (ComboBoxMonth.SelectedItem = "May") Then
            monthNum = "05"
        ElseIf (ComboBoxMonth.SelectedItem = "June") Then
            monthNum = "06"
        ElseIf (ComboBoxMonth.SelectedItem = "July") Then
            monthNum = "07"
        ElseIf (ComboBoxMonth.SelectedItem = "August") Then
            monthNum = "08"
        ElseIf (ComboBoxMonth.SelectedItem = "September") Then
            monthNum = "09"
        ElseIf (ComboBoxMonth.SelectedItem = "October") Then
            monthNum = "10"
        ElseIf (ComboBoxMonth.SelectedItem = "November") Then
            monthNum = "11"
        ElseIf (ComboBoxMonth.SelectedItem = "December") Then
            monthNum = "12"
        Else
            monthNum = monthArray(index)
        End If
        Return monthNum
    End Function
    'function for getting the year
    Function getYear()
        Dim yearNum As String = Nothing
        Dim yearArray() As String = {"2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028"}
        Dim index As Integer = rand.Next(0, yearArray.Length)
        If (ComboBoxYear.SelectedItem = "2020") Then
            yearNum = "2020"
        ElseIf (ComboBoxYear.SelectedItem = "2021") Then
            yearNum = "2021"
        ElseIf (ComboBoxYear.SelectedItem = "2022") Then
            yearNum = "2022"
        ElseIf (ComboBoxYear.SelectedItem = "2023") Then
            yearNum = "2023"
        ElseIf (ComboBoxYear.SelectedItem = "2024") Then
            yearNum = "2024"
        ElseIf (ComboBoxYear.SelectedItem = "2025") Then
            yearNum = "2025"
        ElseIf (ComboBoxYear.SelectedItem = "2026") Then
            yearNum = "2026"
        ElseIf (ComboBoxYear.SelectedItem = "2027") Then
            yearNum = "2027"
        ElseIf (ComboBoxYear.SelectedItem = "2028") Then
            yearNum = "2028"
        Else
            yearNum = yearArray(index)
        End If

        Return yearNum
    End Function
    'function for getting the CVV
    Function getCVV()
        Dim cvv As String = Nothing
        Dim strCVV As String = "012456789"
        Dim characterString As Integer = 3
        Dim sb As New System.Text.StringBuilder
        If (TextBoxCVV.Text.Equals("Leave blank to randomize") Or (TextBoxCVV.Text.Equals(""))) Then
            For i As Integer = 1 To characterString
                Dim index As Integer = rand.Next(0, strCVV.Length)
                sb.Append(strCVV.Substring(index, 1))
            Next
        Else
            sb.Append(TextBoxCVV.Text)
                cvv = TextBoxCVV.Text

            End If
        cvv = sb.ToString()
        Return cvv
    End Function


    Private Sub GhostButtonExport_Click(sender As Object, e As EventArgs) Handles GhostButtonExport.Click
        Dim sfd As New SaveFileDialog() ' this creates an instance of the SaveFileDialog called "sfd"
        sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        sfd.FilterIndex = 1
        sfd.RestoreDirectory = True
        If sfd.ShowDialog() = DialogResult.OK Then
            Dim FileName As String = sfd.FileName ' retrieve the full path to the file selected by the user
            Dim sw As New System.IO.StreamWriter(FileName, False) ' create a StreamWriter with the FileName selected by the User
            For num = 0 To ListBox1.Items.Count - 1
                sw.WriteLine(ListBox1.Items(num).ToString()) ' Write the contents of TextBox to the file
            Next
            sw.WriteLine()
            sw.WriteLine()
            MessageBox.Show("All CC are exported successfully", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sw.Close() ' close the file
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        Me.Icon = My.Resources.flash_icon
        Timer1.Enabled = True
        'set the radiobutton valid to be checked during runtime
        GhostRadiobuttonValid.Checked = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (ListBox1.Items.Count <= 0) Then
            MessageBox.Show("Nothing to copy here", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim copy_buffer As New System.Text.StringBuilder
            For Each item As Object In ListBox1.Items
                copy_buffer.AppendLine(item.ToString)
            Next
            If copy_buffer.Length > 0 Then
                Clipboard.SetText(copy_buffer.ToString)
                MessageBox.Show("Copied CC to Clipboard", "Flash BIN CCGen", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Select Case MessageBox.Show("Are you sure you want to close ?", "Flash BIN CCGen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No
                Return
        End Select
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 100
        LabelScroll.Left = LabelScroll.Left - 10
        If LabelScroll.Left < 0 - LabelScroll.Width Then
            LabelScroll.Left = PanelScroll.Width
        End If
    End Sub

    Private Sub TextBoxBin_Leave(sender As Object, e As EventArgs) Handles TextBoxBin.Leave
        Dim sb As New System.Text.StringBuilder
        For num = 1 To 16 - TextBoxBin.Text.Length
            sb.Append("x")
        Next
        TextBoxBin.Text = TextBoxBin.Text & sb.ToString()
    End Sub

    Private Sub TextBoxBin_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    'function for checking cc validity
    Function checkValid(ByVal cardNo As String) As Boolean
        Dim checkSum As Integer = 0
        Dim doubleFlag As Boolean = (cardNo.Length Mod 2 = 0)
        Dim digit As Char
        Dim digitVal As Integer
        Try

            For Each digit In cardNo
                digitVal = Integer.Parse(digit)
                If (doubleFlag) Then
                    digitVal *= 2
                    If (digitVal > 9) Then
                        digitVal -= 9
                    End If
                End If
                checkSum += digitVal
                doubleFlag = Not doubleFlag
            Next


        Catch ex As Exception

        End Try
        Return (checkSum Mod 10 = 0)
    End Function
End Class
