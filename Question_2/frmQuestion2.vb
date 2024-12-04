REM EXAMINATION MARKING GUIDELINE
REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On

Public Class frmQuestion2
    'Code to create loop counter variable and three parallel, single dimension arrays to store seven item
    Dim intLoopCounter As Integer = 0
    Dim dblArrDistance(6) As Double
    Dim dblArrFuelUsed(6) As Double
    Dim dblArrConsumption(6) As Double

    'A function that will recieve copies of the travelled distance and the fuel used as parameters. 
    Private Function CalcConsumption(ByRef Distance As Double, ByRef FuelUsed As Double) As Double
        If Distance > 0 And FuelUsed > 0 Then
            Return (FuelUsed / Distance) * 100
        Else
            Return 0 'return zero if the distance or fuelUsed is zero or negative (to avoid division by zero)
        End If

    End Function
    Private Sub btnQuestion2_3_Click(sender As Object, e As EventArgs) Handles btnQuestion2_3.Click
        ''check if the loopcounter is within bounds
        'If intLoopCounter < 7 Then
        '    'Store data in the arrays
        '    dblArrDistance(intLoopCounter) = CDbl(txtDistance.Text)
        '    dblArrFuelUsed(intLoopCounter) = CDbl(txtFuel.Text)
        '    'calculate and store fuel consumption
        '    dblArrConsumption(intLoopCounter) = CalcConsumption(dblArrDistance(intLoopCounter), dblArrFuelUsed(intLoopCounter))
        '    'increment loop counter

        '    intLoopCounter += 1
        '    'reset input fields
        '    txtDistance.Clear()
        '    txtFuel.Clear()
        '    If intLoopCounter >= 7 Then
        '        MsgBox("Maximum limit reached. Cannot add more data.")\
        '        Exit Sub
        '    End If
        'End If

        ' Check if the loop counter is within bounds
        If intLoopCounter >= 7 Then
            ' If the maximum limit has been reached, terminate the procedure
            MessageBox.Show("Maximum limit reached. Cannot add more data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        ' Store data in the arrays
        dblArrDistance(intLoopCounter) = CDbl(txtDistance.Text)
        dblArrFuelUsed(intLoopCounter) = CDbl(txtFuel.Text)

        ' Calculate and store fuel consumption
        Dim consumption As Double = CalcConsumption(dblArrDistance(intLoopCounter), dblArrFuelUsed(intLoopCounter))
        dblArrConsumption(intLoopCounter) = consumption

        ' Increment loop counter
        intLoopCounter += 1

        ' Reset input fields
        txtDistance.Clear()
        txtFuel.Clear()

        ' Check if the maximum limit is reached again after incrementing the counter
        If intLoopCounter >= 7 Then
            ' If the maximum limit has been reached, prevent the user from entering more data
            txtDistance.Enabled = False
            txtFuel.Enabled = False

            ' Clear the ListBox
            lstAnalysis.Items.Clear()

            ' Create headings
            lstAnalysis.Items.Add("No" & vbTab & "Distance" & vbTab & "Fuel Used" & vbTab & "Consumption ")
            lstAnalysis.Items.Add("......................................................................")
            ' Iterate through the array and calculate and display fuel consumption
            For i As Integer = 0 To 6
                If dblArrDistance(i) > 0 And dblArrFuelUsed(i) > 0 Then
                    lstAnalysis.Items.Add(i + 1 & vbTab & dblArrDistance(i) & vbTab & vbTab & dblArrFuelUsed(i) & vbTab & consumption.ToString("F"))
                Else
                    ' If data is missing or invalid, display a message indicating so
                    lstAnalysis.Items.Add(i + 1 & vbTab & "Invalid data" & vbTab & "Invalid data" & vbTab & "Invalid data")
                End If
                Dim dblTotalDistance As Double
                Dim dblTotalFuel As Double
                Dim dblTotalConsumption As Double
                ' Check if there is valid data at the current index
                If dblArrDistance(i) > 0 And dblArrFuelUsed(i) > 0 Then
                    dblTotalDistance = dblArrDistance(i)
                    dblTotalFuel = dblArrFuelUsed(i)
                    dblTotalConsumption = CalcConsumption(dblArrDistance(i), dblArrFuelUsed(i))
                End If
                lstAnalysis.Items.Add("......................................................................................")
                lstAnalysis.Items.Add("Total distance: " & dblTotalDistance & " kms travelled")
            Next

        End If

       


       
       
        '    End Sub
        '    If intLoopCounter > 0 Then
        '    averageDistance = totalDistance / intLoopCounter
        '    averageFuelUsed = totalFuelUsed / intLoopCounter
        '    averageFuelConsumption = totalFuelConsumption / intLoopCounter
        'Else
        '    averageDistance = 0
        '    averageFuelUsed = 0
        '    averageFuelConsumption = 0
        'End If

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmQuestion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
