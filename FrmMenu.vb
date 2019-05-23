Public Class FrmMenu
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmUsuarios.MdiParent = Me
        FrmUsuarios.WindowState = FormWindowState.Maximized
        FrmUsuarios.Show()
        FrmUsuarios.Focus()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        FrmAcerca.MdiParent = Me
        FrmAcerca.WindowState = FormWindowState.Maximized
        FrmAcerca.Show()
        FrmAcerca.Focus()
    End Sub
End Class
