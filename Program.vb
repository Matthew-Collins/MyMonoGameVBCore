Namespace MyMonoGame
    Class Program
        <STAThread>
        Public Shared Sub Main()
            Using game = New Game1()
                game.Run()
            End Using
        End Sub
    End Class
End Namespace

