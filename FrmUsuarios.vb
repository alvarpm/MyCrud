Imports System.Data.SQLite
Imports System.Text.RegularExpressions
'Imports System.Runtime.InteropServices

Public Class FrmUsuarios
    Dim pathBD As String
    Dim nombretabla As String = "tabledb"
    Dim nombretabla1 As String = "MUNICIPIOS"

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim SQLiteCon As New SQLiteConnection(pathBD)
        If txtID.Text = "" Then
            MsgBox(" Seleccione o digite el ID para eliminar")
        Else
            Dim resp = MsgBox("Esta seguro de eliminar el ID " & txtID.Text, vbOKCancel, "CONFIRMACION")
            If resp = vbOK Then
                SQLiteCon.Open()

                Dim txtsql As String = "delete from " & nombretabla &
                                " where ID='" & txtID.Text & "'"


                Dim SQLCommand As New SQLiteCommand(txtsql, SQLiteCon)
                Try
                    SQLCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                SQLCommand.Dispose()


                Dim tabla As New DataTable
                txtsql = "Select * from " & nombretabla & " order by ID"

                MostrarDatos(txtsql, tabla, SQLiteCon)

                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                MsgBox("ID: " & txtID.Text & " fue eliminado exitosamente")
            End If
        End If
    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Dim SQLiteCon As New SQLiteConnection(pathBD)
        SQLiteCon.Open()

        Dim tabla As New DataTable
        Dim txtsql As String = "Select * from " & nombretabla & " order by ID"

        MostrarDatos(txtsql, tabla, SQLiteCon)

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub


    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim SQLiteCon As New SQLiteConnection(pathBD)
        If txtID.Text = "" Then
            MsgBox(" Seleccione o digite el ID para actualizar")
        Else

            SQLiteCon.Open()

            Dim txtsql As String = "update " & nombretabla &
                                    " set ID='" & txtID.Text & "', Nombre='" & txtname.Text & "', Telefono='" & txttel.Text & "', Email='" &
                                    txtemail.Text & "', Ciudad='" & ComboCiudad.SelectedValue & "',Genero='" & Cmbgenero.Text & "'" &
                                    " where ID='" & txtID.Text & "'"


            Dim SQLCommand As New SQLiteCommand(txtsql, SQLiteCon)
            Try
                SQLCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            SQLCommand.Dispose()


            Dim tabla As New DataTable
            txtsql = "Select * from " & nombretabla & " order by ID"

            MostrarDatos(txtsql, tabla, SQLiteCon)

            SQLiteCon.Close()
            SQLiteCon.Dispose()
            SQLiteCon = Nothing

            MsgBox("ID " & txtID.Text & " fue actualizado exitosamente")
        End If
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtID.Clear()
        txtname.Clear()
        txtemail.Clear()
        ComboCiudad.SelectedItem = Nothing
        txttel.Clear()
        Cmbgenero.SelectedItem = Nothing

    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim SQLiteCon As New SQLiteConnection(pathBD)
        SQLiteCon.Open()

        Dim tabla As New DataTable
        Dim txtsql As String = "Select * from " & nombretabla & " where ID = '" & txtID.Text & "'"

        MostrarDatos(txtsql, tabla, SQLiteCon)

        If tabla.Rows.Count > 0 Then
            For Each row As DataRow In tabla.Rows
                txtname.Text = CStr(row("Nombre"))
                ComboCiudad.Text = row("Ciudad").ToString
                txtemail.Text = row("Email").ToString
                txttel.Text = row("Telefono").ToString
                Cmbgenero.Text = row("Genero").ToString
            Next
        Else
            MsgBox(" ID " & txtID.Text & " no existe en la base de datos")
        End If

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub


    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim SQLiteCon As New SQLiteConnection(pathBD)
        Dim txtsql As String = ""

        If txtID.Text = "" Then
            MsgBox(" El Identificador ID no puede ir en blanco....")
        Else
            If Not IsNumeric(txttel.Text) Then
                MsgBox(" El numero telefonico debe tener solo numeros")
            End If
            If validar_Mail(txtemail.Text) Then
                If IDExiste() Then
                    MsgBox(" El ID ya existe. Utilice el boton actualizar o digite uno nuevo")
                Else
                    SQLiteCon.Open()
                    txtsql = "insert into " & nombretabla & " (ID, Nombre, Telefono, Email, Ciudad, Genero)" &
                                " values ('" & txtID.Text & "','" & txtname.Text & "','" & txttel.Text & "','" &
                                txtemail.Text & "','" & ComboCiudad.SelectedValue & "','" & Cmbgenero.Text & "')"

                    Dim SQLCommand As New SQLiteCommand(txtsql, SQLiteCon)
                    Try
                        SQLCommand.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    SQLCommand.Dispose()


                    Dim tabla As New DataTable
                    txtsql = "Select * from " & nombretabla & " order by ID"

                    MostrarDatos(txtsql, tabla, SQLiteCon)

                    SQLiteCon.Close()
                    SQLiteCon.Dispose()
                    SQLiteCon = Nothing

                    MsgBox("ID " & txtID.Text & " fue creado exitosamente")
                End If

            Else
                MsgBox("Direccion de correo " & txtemail.Text & " no posee una estructura valida")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pathBD = "Data Source=" & Application.StartupPath & "\DBCrud.db"

        Dim SQLiteCon As New SQLiteConnection(pathBD)
        SQLiteCon.Open()

        Dim tabla As New DataTable
        Dim txtsql As String = "Select * from " & nombretabla & " ORDER BY ID"
        MostrarDatos(txtsql, tabla, SQLiteCon)

        txtsql = "Select * from " & nombretabla1 & " ORDER BY DESCRIPCION"
        Dim ds As New DataSet
        MostrarMunicipios(txtsql, ds, SQLiteCon)

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub MostrarDatos(ByVal txtsql As String, ByVal tabla As DataTable, ByVal SQLiteCon As SQLiteConnection)
        Dim adaptador As New SQLiteDataAdapter(txtsql, SQLiteCon)
        adaptador.Fill(tabla)
        adaptador.Dispose()
        adaptador = Nothing

        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tabla
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 150
        DataGridView1.Columns(4).Width = 150

        Dim cont As Integer = 0
        For Each fila As DataGridViewRow In DataGridView1.Rows
            txtsql = "Select DESCRIPCION from " & nombretabla1 & " where CODIGO = '" & fila.Cells("Ciudad").Value.ToString & "'"
            Dim cmd As New SQLiteCommand(txtsql, SQLiteCon)
            Dim txtMunicipio As String = cmd.ExecuteScalar()
            DataGridView1.Rows(cont).Cells("Ciudad").Value = txtMunicipio
            cmd.Dispose()
            cont = cont + 1
        Next

        tabla.Dispose()
        tabla = Nothing
    End Sub
    Private Sub MostrarMunicipios(ByVal txtsql As String, ByVal tabla As DataSet, ByVal SQLiteCon As SQLiteConnection)
        Dim adaptador As New SQLiteDataAdapter(txtsql, SQLiteCon)
        adaptador.Fill(tabla)
        adaptador.Dispose()
        adaptador = Nothing

        ComboCiudad.DataSource = tabla.Tables(0)
        ComboCiudad.DisplayMember = "DESCRIPCION"
        ComboCiudad.ValueMember = "CODIGO"

        ComboCiudad.SelectedValue = "11001"

        tabla.Dispose()
        tabla = Nothing
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.RowIndex >= 0 Then
            txtID.Text = DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString
            txtname.Text = DataGridView1.Rows(e.RowIndex).Cells("Nombre").Value.ToString
            ComboCiudad.Text = DataGridView1.Rows(e.RowIndex).Cells("Ciudad").Value.ToString
            txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells("Email").Value.ToString
            txttel.Text = DataGridView1.Rows(e.RowIndex).Cells("Telefono").Value.ToString
            Cmbgenero.Text = DataGridView1.Rows(e.RowIndex).Cells("Genero").Value.ToString
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            buscarPorNombre()
        End If
    End Sub

    Private Function validar_Mail(ByVal eMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(eMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
    Private Function IDExiste() As Boolean
        ' retorna true o false   

        For Each fila As DataGridViewRow In DataGridView1.Rows
            If fila.Cells("ID").Value <> Nothing Then
                If txtID.Text = fila.Cells("ID").Value.ToString Then
                    Return True
                End If
            End If
        Next


        Return False
    End Function
    Private Sub buscarPorNombre()
        ' retorna true o false   

        Dim SQLiteCon As New SQLiteConnection(pathBD)
        SQLiteCon.Open()

        Dim tabla As New DataTable
        Dim txtsql As String = "Select * from " & nombretabla & " where nombre like " & "'%" & TextBox1.Text & "%'"

        MostrarDatos(txtsql, tabla, SQLiteCon)

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        Btndelete_Click(sender, e)
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub
End Class