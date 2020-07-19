Option Explicit On
Option Strict Off
Option Infer Off

Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Configuration

Public Class Form1

    'Variables used throughout program
    Dim decPremiumListTotal As Decimal
    Dim decConnectionsListTotal As Decimal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Builds list box with numbers 0 to 20 and highlights the first selection
        For decPremium As Decimal = 0 To 20 Step 1
            PremiumListBox1.Items.Add(decPremium.ToString("N0"))
        Next decPremium
        PremiumListBox1.SelectedIndex = 0

        'Builds list box with numbers 0 to 100 and highlights the first selection
        For decConnections As Decimal = 0 To 100 Step 1
            ConnectionsListBox2.Items.Add(decConnections.ToString("N0"))
        Next decConnections
        ConnectionsListBox2.SelectedIndex = 0

    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles ResidentialRadioButton2.CheckedChanged

        'Clears total due info if radio button is changed
        DueLabel4.Text = String.Empty

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles BusinessRadioButton1.CheckedChanged

        'Clears total due info if radio button is changed
        DueLabel4.Text = String.Empty

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PremiumListBox1.SelectedIndexChanged
       
        'Clears total due info if premium list box is changed
        DueLabel4.Text = String.Empty

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConnectionsListBox2.SelectedIndexChanged
        
        'Clears total due only if connections list box is changed since business total could change due to num of connections
        If BusinessRadioButton1.Checked Then
            DueLabel4.Text = String.Empty
        End If

    End Sub
    Private Sub frmForm1_FormClosing(sender As Object, e As EventArgs) Handles ExitButton2.Click

        'Confirms the user wants to exit app
        Dim dlgButton As DialogResult
        dlgButton =
            MsgBox(" Exit Application ?", MsgBoxStyle.YesNo)
        If dlgButton = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ExitButton2_Click(sender As Object, e As EventArgs) Handles ExitButton2.Click



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles DueLabel4.Click

    End Sub
    Private Function CalculateBusinessServiceFee(ByVal basicFee As Decimal, ByVal overTen As Decimal) As Decimal
        Const decProcess As Decimal = 16.50
        Dim decBasicFee As Decimal = 80.0
        Dim decPremiums As Decimal = decPremiumListTotal * 50.00
        Dim decOverTen As Decimal = decBasicFee + (decConnectionsListTotal - 10) * 4
        Dim decTotalFees As Decimal = decPremiums + decProcess
        

        'Sends error message if no connections are selected.
        'Determines charges up to 10 connections, then $4 each thereafter
      
          
        If BusinessRadioButton1.Checked And
        decConnectionsListTotal < 11 
            CalculateBusinessServiceFee = decBasicFee + decTotalFees

        Else
            CalculateBusinessServiceFee = decOverTen + decTotalFees
            Return CalculateBusinessServiceFee
        
       End If
       


    End Function

    Private Function CalculatePersonalTotal(ByVal personalTotal As Decimal) As Decimal

        Const decPersonalServiceFee As Decimal = 30.0
        Const decPersonalProcessFee As Decimal = 4.5
        Const decPersonalPremiumChannel As Decimal = 5.0
        Dim decPersonalPay As Decimal

        'Calculates residential customer totals based on input
        If ResidentialRadioButton2.Checked

            Decimal.TryParse(PremiumListBox1.SelectedItem, decPremiumListTotal)
            Decimal.TryParse(ConnectionsListBox2.SelectedItem, decConnectionsListTotal)
            decPersonalPay = (decPremiumListTotal * decPersonalPremiumChannel) + (decPersonalProcessFee + decPersonalServiceFee)
            Return decPersonalPay

        End If
      




    End Function
    Private Sub CalculateButton1_Click(sender As Object, e As EventArgs) Handles CalculateButton1.Click
        Dim decFar As Decimal
        Dim decBasic As Decimal
        Dim decTenOver As Decimal
        Dim decBusinessResult As Decimal

        'Calls function to calculate Business customer totals and displays
        If BusinessRadioButton1.Checked And 
           ConnectionsListBox2.SelectedIndex <2
            MsgBox("  Business customers must have at least one Connection !  ")

            ElseIf Decimal.TryParse(ConnectionsListBox2.SelectedItem, decConnectionsListTotal)
            Decimal.TryParse(PremiumListBox1.SelectedItem, decPremiumListTotal)
            decbusinessResult = CalculateBusinessServiceFee(decBasic, decTenOver)
            DueLabel4.Text = decBusinessResult.ToString("N2")
            End If

        If ResidentialRadioButton2.Checked
            'Calls function to calculate Residential customer totals and displays
            Decimal.TryParse(PremiumListBox1.SelectedItem, decPremiumListTotal)
            Decimal.TryParse(ConnectionsListBox2.SelectedItem, decConnectionsListTotal)
            DueLabel4.Text = CalculatePersonalTotal(decFar).ToString("N2")

        End If

    End Sub

End Class

