' Author :     Patrick Andrew Love- 1683445
' Date   :     02/25/2019
' Purpose:     This Windows Classic Desktop application converts inches to meters or from meters
'              to inches when building plans need to be converted between Imperial and Metric
'              systems.

Public Class frmBuildingPlans
    Private Sub frmBuildingPlans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInchToMeter.Checked = True
        radMetersToInches.Checked = False
        lblOutput.Text = ""
        txtInchMeter.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Handles what happens when the user clicks the calculate button
        'Calculation and display of output in inches/Imperial or meters/Metric
        Dim decUserInput As Decimal
        Dim decConvertedToMeters As Decimal
        Dim decConvteredToInches As Decimal

        'Did the user enter a numeric value or nothing at all?
        If IsNumeric(txtInchMeter.Text) And txtInchMeter.Text <> "" Then
            decUserInput = Convert.ToDecimal(txtInchMeter.Text)
            'is metric greater than 0?
            If decUserInput > 0 Then
                'Determine metric to convert (inches/meters)
                If radInchToMeter.Checked Then
                    'calculate inches to meters
                    decConvertedToMeters = decUserInput * 0.0254
                    lblOutput.Text = "Your amount converted is " & decConvertedToMeters.ToString("N1") & " meters"
                ElseIf radMetersToInches.Checked Then
                    'calculate meters to inches
                    decConvteredToInches = decUserInput * 39.37008
                    lblOutput.Text = "Your amount converted is " & decConvteredToInches.ToString("N1") & " inches"
                End If
                'Display output
                'lblOutput.Text = "Your amount converted is " & decConvertUserInput.ToString("N1") & " meters
                'Or " & decUserInput.ToString("N1") & " inches."
            Else
                'Display error message if user entered a negative value
                MsgBox("You have entered" & decUserInput.ToString() & ". Enter a positive number.",, "Input Error")
                txtInchMeter.Text = ""
                txtInchMeter.Focus()
            End If
        Else
            'Display error message if user entered invalid numbers
            MsgBox("Enter the Valid Number(s)",, "Input Error")
            txtInchMeter.Text = ""
            txtInchMeter.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
        radInchToMeter.Checked = True
        radMetersToInches.Checked = False
        txtInchMeter.Clear()
        txtInchMeter.Focus()
    End Sub
End Class
