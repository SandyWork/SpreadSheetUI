
Public Class fm_master
    Dim lastState As FormWindowState = FormWindowState.Minimized

    ''mwidth used to store the cummulative width of all the columns in datagridview - dgv ( table equivalent in .net)
    ''dgv1 is the id of datagridview
    ''

    Dim mwidth As Integer = 0

    ''_load method loads automatically when the form is opened or refreshed ( like constructor ) 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Retrieves each column's width, sums it up and stores it in mwidth

        For Each col In dgv1.Columns
            mwidth += col.width
        Next
        '' 
        'MsgBox(mwidth)
        '' 
    End Sub

    '' This is a method  used to handle the width of columns ,   	       
    ''	such that it resizes itself according to the size of the dgv
    '' dgv itself resizes automatically according the the size of the window , but the columns inside don't 
    '' hence this code is written

    Private Sub resizeCol(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim colWidth As Integer, gridWidth As Integer

        'Execute the below code only if the size of the window changes
        'This is to prevent from running the below set of lines under following conditions :
        'Maximize button is pressed when window is already maximized
        'Minimize button is pressed when window is already minimized
        If (Not WindowState = lastState) Then
            lastState = WindowState

            colWidth = mwidth
            gridWidth = dgv1.Width

            '' 
            'MsgBox(mwidth & " " & gridWidth)
            '' 

            ''DataGridViewAutoSizeColumnMode is used to set the sizing type of the columns in dgv
            '' Fill mode : dgv width is equally distributed among its columns
            '' ColumnHeader mode : dgv width is set according to its column header

            If colWidth < gridWidth Then

                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            ElseIf colWidth > gridWidth Then
                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.ColumnHeader

            End If
        End If
    End Sub
End Class
