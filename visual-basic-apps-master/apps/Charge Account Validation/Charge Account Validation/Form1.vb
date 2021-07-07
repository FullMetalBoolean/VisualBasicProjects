﻿' Written by Valery Samovich 
' July 12, 2015
Option Strict On
Option Explicit On

Public Class Form1

    ' Declar array of valid account numbers. 
    Dim intNumbers() As Integer = {5658845, 4520125, 7895122, 8777541, 8451277, 1302850,
                                   8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
                                   1005231, 6545231, 3852085, 7576651, 7881200, 4581002}

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim intAccountNumber As Integer     ' To hold account number
        Dim blnSearch As Boolean = False    ' Hold search flag
        Dim intIndex As Integer = 0         ' Hold an array index

        ' Try to convert the value entered by the user to a Integer.
        ' If it will not convert, display an error message and return false. 
        If Not Integer.TryParse(txtInput.Text, intAccountNumber) Then
            MessageBox.Show("Enter a numeric value for the account number.")
            Exit Sub
        End If

        ' Determine whether the value entered is negative.
        ' If it is, display an error message and return false.
        If intAccountNumber < 0 Then
            MessageBox.Show("Enter a positive numeric value for account number.")
            Exit Sub
        End If

        ' Sequential search to determine wheather a number appears in the array.
        Do While intIndex < intNumbers.Length
            ' Compare input number to array value
            If intAccountNumber = intNumbers(intIndex) Then
                blnSearch = True
                Exit Do
            Else
                intIndex += 1
            End If
        Loop

        ' Determine wheather it is valid account number.
        If blnSearch Then
            ' Display message if account is valid.
            MessageBox.Show("Account number is valid.")
        Else
            ' Display message if account is invalid.
            MessageBox.Show("Account number is invalid.")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This procedure clear the input.
        txtInput.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

End Class
