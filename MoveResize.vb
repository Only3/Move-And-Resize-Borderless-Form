    
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Me.Capture = False
        If Cursor <> Cursors.Default Then
            Me.WndProc(Message.Create(Parent.Handle, &HA1, New IntPtr(&H11), IntPtr.Zero))
        Else : Me.WndProc(Message.Create(Parent.Handle, &HA, New IntPtr(&H2), IntPtr.Zero))
        End If
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If e.X > Me.Width - 5 And e.Y > Me.Height - 5 Then
            Cursor = Cursors.SizeNWSE
        Else
            Cursor = Cursors.Default
        End If
        MyBase.OnMouseMove(e)
    End Sub
