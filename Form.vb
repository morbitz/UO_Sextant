Public Class Form
    ' ability to read from memory
    Private Declare Function ReadProcessMemory Lib "kernel32" Alias "ReadProcessMemory" (ByVal hprocess As Integer, ByVal Address As Integer, ByRef Value As Integer, ByVal Size As Integer, ByRef BytesRead As Integer) As Integer
    ' make borderless form draggable
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub


    ' read memory 
    Public Function ReadMemToText(name As String, address As Integer)
        Dim hprocess As Process() = Process.GetProcessesByName(name)
        If hprocess.Length = 0 Then
            'Must Run UO or it automatically closes
            Close()
            End
        Else
            Dim value As Integer = 0
            ReadProcessMemory(hprocess(0).Handle, address, value, 4, 0)
            Return value
        End If
    End Function
    ' change combo box to match facet
    Dim Shard As String = ReadMemToText("client", &H98A648)
    Dim Directory As String = "C:\UO Sextant\" + Shard + "\"

    Dim worldname As String = ""
    Dim UserLocations As String
    Dim Locations() As String
    Dim named(1024) As String
    Dim x(1024) As Integer
    Dim y(1024) As Integer
    Public Function Updatedirections()
        worldchange = world
        Select Case world
            Case 0
                worldname = "Felucca"
            Case 1
                worldname = "Trammel"
            Case 2
                worldname = "Ilshenar"
            Case 3
                worldname = "Malas"
            Case 4
                worldname = "Tokuno Islands"
            Case 5
                worldname = "TerMur And Eodon"
            Case Else
                worldname = "None"
        End Select

        DirectionsCombo.SelectedIndex = -1
        DirectionsCombo.Items.Clear()
        LocationCheckBox.Items.Clear()
        DirectionsPicture.Visible = False
        If My.Computer.FileSystem.DirectoryExists(Directory) <> True Then
            My.Computer.FileSystem.CreateDirectory(Directory)
        End If
        If My.Computer.FileSystem.FileExists(Directory + worldname + ".txt") Then
            UserLocations = My.Computer.FileSystem.ReadAllText(Directory + worldname + ".txt")
        Else
            DirectionsCombo.SelectedIndex = -1
            DirectionsCombo.Items.Clear()
            LocationCheckBox.Items.Clear()
        End If
        Locations = Split(UserLocations, "+")
        Dim index As Integer = 0
        Dim count As Integer = 0

        While index < Locations.Length - 1
            named(count) = Locations(index)
            index += 1
            x(count) = Locations(index)
            index += 1
            y(count) = Locations(index)
            index += 1
            DirectionsCombo.Items.Add(named(count))
            LocationCheckBox.Items.Add(named(count))
            count += 1
        End While
        Return 0
    End Function
    ' update sextant coords
    Dim world As Integer = 10
    Dim worldchange As Integer = 15
    Dim xCoord As Integer = 0
    Dim yCoord As Integer = 0
    Dim worldString As String = "None"

    Public Function Looper()
        Try
            Dim elevation As Integer = 0
            Dim zerox As Integer = 1323 'zeros at Lord British's Throne
            Dim zeroy As Integer = 1624 'FOR ALL MAPS!
            Dim sextantEW As String = ""
            Dim sextantNS As String = ""
            Dim worldString As String = "None"
            xCoord = ReadMemToText("client", &HAB0204)
            yCoord = ReadMemToText("client", &HAB0200)
            elevation = ReadMemToText("client", &HAB0AA4)
            If elevation > 10000 Then
                elevation = elevation - 65536
            End If
            world = ReadMemToText("client", &HAB0208)
            If world <> worldchange Then
                Updatedirections()
            End If
            Select Case world
                Case 0
                    worldString = "Felucca"
                Case 1
                    worldString = "Trammel"
                Case 2
                    worldString = "Ilshenar"
                Case 3
                    worldString = "Malas"
                Case 4
                    worldString = "Tokuno Islands"
                Case 5
                    worldString = "TerMur And Eodon"
                Case Else
                    worldString = "None"
            End Select

            xCoordtext.Text = xCoord.ToString
            yCoordText.Text = yCoord.ToString
            worldText.Text = worldString.ToString
            elevationText.Text = elevation.ToString
            Dim calcMin As Integer = 0
            Dim calcDeg As Integer = 0
            ' Sextant Calculations
            'North and South
            If (yCoord > 0 And yCoord <= 1623) Or yCoord > 3672 Then
                calcDeg = 0
                If yCoord > 3672 Then
                    calcMin = Math.Floor((4096 - yCoord + zeroy) * 5.274)
                Else
                    If (zeroy - yCoord) Mod 7 = 0 Then
                        calcMin = Math.Floor((zeroy - yCoord) * 5.274) + 1
                    Else
                        calcMin = Math.Ceiling((zeroy - yCoord) * 5.274)
                    End If
                End If
                If calcMin >= 60 Then
                    calcDeg = Math.Floor(calcMin / 60)
                    calcMin = Math.Ceiling(calcMin Mod 60)
                End If
                sextantNS = calcDeg.ToString + "o " + calcMin.ToString + "'N"
            Else
                calcDeg = 0
                If (yCoord - zeroy) Mod 7 = 0 Then
                    calcMin = Math.Floor((yCoord - zeroy) * 5.274)
                Else
                    calcMin = Math.Ceiling((yCoord - zeroy) * 5.274) - 1
                End If
                If calcMin >= 60 Then
                    calcDeg = Math.Floor(calcMin / 60)
                    calcMin = Math.Ceiling(calcMin Mod 60)
                End If
                sextantNS = calcDeg.ToString + "o " + calcMin.ToString + "'S"
            End If

            'East and West
            If (xCoord >= 1323 And xCoord <= 3883) Then
                calcDeg = 0
                If (xCoord - zerox) Mod 4 = 0 Then
                    calcMin = Math.Ceiling((xCoord - zerox) * 4.22) - 1
                Else
                    calcMin = Math.Floor((xCoord - zerox) * 4.22)
                End If
                If calcMin >= 60 Then
                    calcDeg = Math.Floor(calcMin / 60)
                    calcMin = Math.Floor(calcMin Mod 60)
                End If
                sextantEW = calcDeg.ToString + "o " + calcMin.ToString + "'E"
            Else
                If xCoord > 3883 And xCoord <= 5120 Then
                    calcDeg = 0
                    calcMin = Math.Floor((5120 - xCoord + zerox) * 4.22)
                Else
                    calcDeg = 0
                    If (zerox - xCoord) Mod 4 = 0 Then
                        calcMin = Math.Floor((zerox - xCoord) * 4.22)
                    Else
                        calcMin = Math.Floor((zerox - xCoord) * 4.22)
                    End If
                End If
                If calcMin >= 60 Then
                    calcDeg = Math.Floor(calcMin / 60)
                    calcMin = Math.Floor(calcMin Mod 60)
                End If
                sextantEW = calcDeg.ToString + "o " + calcMin.ToString + "'W"
            End If
            ' End Sextant Calculations
            SextantReadingText.Text = sextantNS + ", " + sextantEW
            Return 0
        Catch ex As Exception

            'MsgBox(ex)
        End Try
        Return 0

    End Function


    Public Function DirectMe(x As Integer, y As Integer)
        Dim DistanceL As Integer = 0
        Dim DistanceR As Integer = 0
        Dim DistanceU As Integer = 0
        Dim DistanceD As Integer = 0
        Dim DistanceX As Integer = 0
        Dim DistanceY As Integer = 0
        Dim Angle As Integer = 0
        Dim Quadrant As Integer = 0
        ' determine quadrant
        'x coord 0 to 5120 = ( 64^2 + 32^2 )
        If xCoord > x Then
            DistanceL = xCoord - x
            DistanceR = 5120 - xCoord + x
        ElseIf xCoord < x Then
            DistanceL = 5120 - x + xCoord
            DistanceR = x - xCoord
        Else
            DistanceL = 0
            DistanceR = 0
        End If
        'y coord 0 to 4096 = 64^2
        If yCoord > y Then
            DistanceD = yCoord - y
            DistanceU = 4096 - yCoord + y
        ElseIf yCoord < y Then
            DistanceD = 4096 - y + yCoord
            DistanceU = y - yCoord
        Else
            DistanceD = 0
            DistanceU = 0
        End If
        If DistanceL = 0 And DistanceR = 0 Then
            ' on y axis, only calculate up and down
            Quadrant = 0
            'Quadrants 2 and 3
        ElseIf DistanceL < DistanceR Then
            DistanceX = DistanceL
            ' up
            If DistanceU < DistanceD Then
                Quadrant = 1
                DistanceY = DistanceU
                Angle = Math.Floor(Math.Atan(DistanceY / DistanceX) * 180 / Math.PI)
            Else
                ' down
                Quadrant = 4
                DistanceY = DistanceD
                Angle = Math.Floor(Math.Atan(DistanceY / DistanceX) * 180 / Math.PI)
            End If
            'Quadrants 1 and 4
        ElseIf DistanceL > DistanceR Then
            DistanceX = DistanceR
            ' up
            If DistanceU < DistanceD Then
                Quadrant = 2
                DistanceY = DistanceU
                Angle = Math.Floor(Math.Atan(DistanceY / DistanceX) * 180 / Math.PI)
            Else
                ' down
                Quadrant = 3
                DistanceY = DistanceD
                Angle = Math.Floor(Math.Atan(DistanceY / DistanceX) * 180 / Math.PI)
            End If
        End If
        'DebugText.Text = "X Dist: " + DistanceX.ToString + " Y Dist: " + DistanceY.ToString + " Angle: " + Angle.ToString + " Quadrant: " + Quadrant.ToString

        '22,67
        If Quadrant = 0 Then
            If DistanceU < DistanceD Then
                DirectionsPicture.Image = My.Resources.down_left
            ElseIf DistanceU > DistanceD Then
                DirectionsPicture.Image = My.Resources.up_right
            ElseIf DistanceX = 0 And DistanceY = 0 Then
                DirectionsPicture.Image = My.Resources._stop
            End If
        End If
        If Angle <= 22 Then 'left and right
            If Quadrant = 1 OrElse Quadrant = 4 Then
                DirectionsPicture.Image = My.Resources.up_left
            ElseIf Quadrant = 2 OrElse Quadrant = 3 Then
                DirectionsPicture.Image = My.Resources.down_right
            End If
        End If
        If Angle > 22 And Angle < 67 Then '45 degree
            If Quadrant = 1 Then
                DirectionsPicture.Image = My.Resources.left
            ElseIf Quadrant = 2 Then
                DirectionsPicture.Image = My.Resources.down
            ElseIf Quadrant = 3 Then
                DirectionsPicture.Image = My.Resources.right
            Else
                DirectionsPicture.Image = My.Resources.up
            End If
        End If

        If Angle >= 67 And Angle < 90 Then  ' up and down
            If Quadrant = 1 OrElse Quadrant = 2 Then
                DirectionsPicture.Image = My.Resources.down_left
            ElseIf Quadrant = 3 OrElse Quadrant = 4 Then
                DirectionsPicture.Image = My.Resources.up_right
            End If
        End If

        Return 0
    End Function


    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Looper()
        If DirectionsCombo.SelectedIndex <> -1 Then
            DirectMe(DirectX, DirectY)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.unnaturalnature.com/uothief/")
    End Sub

    Private Sub AddLocationButton_Click(sender As Object, e As EventArgs) Handles AddLocationButton.Click

        If My.Computer.FileSystem.DirectoryExists(Directory) <> True Then
            My.Computer.FileSystem.CreateDirectory(Directory)
        End If
        If UserInputText.Text <> "" Then
            Try
                My.Computer.FileSystem.WriteAllText(Directory + worldText.Text + ".txt", "" & UserInputText.Text + "+" + xCoordtext.Text + "+" + yCoordText.Text + "+" + vbCrLf, True)
                UserInputText.Text = ""
                Updatedirections()

            Catch
                MsgBox("This Name IS Not Allowed!")
            End Try
        End If

    End Sub
    Dim DirectX As Integer = 0
    Dim DirectY As Integer = 0
    Private Sub DirectionsCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DirectionsCombo.SelectedIndexChanged
        Dim inte As Integer = 0
        If DirectionsCombo.SelectedIndex <> -1 Then
            inte = DirectionsCombo.SelectedIndex
        End If
        DirectX = x(inte)
        DirectY = y(inte)
        DirectionsPicture.Visible = True
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim newList As String = My.Computer.FileSystem.ReadAllText(Directory + worldname + ".txt")
        If newList <> "" Then
            Dim lines() As String = Split(newList, vbCrLf)
            If LocationCheckBox.SelectedIndex <> -1 Then
                Dim delLine As Integer = LocationCheckBox.SelectedIndex
                lines(delLine) = ""
                LocationCheckBox.Items.RemoveAt(delLine)
                newList = ""
                For index As Integer = 0 To lines.Length - 1
                    If lines(index) <> "" Then
                        newList += lines(index) + vbCrLf
                    End If
                Next
                My.Computer.FileSystem.DeleteFile(Directory + worldText.Text + ".txt")
                My.Computer.FileSystem.WriteAllText(Directory + worldText.Text + ".txt", newList, False)
            End If
        End If
    End Sub
End Class