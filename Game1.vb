Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Namespace MyMonoGame
    Public Class Game1
        Inherits Game

        Private graphics As GraphicsDeviceManager
        Private spriteBatch As SpriteBatch

        Public Sub New()
            graphics = New GraphicsDeviceManager(Me)
            Content.RootDirectory = "Content"
            IsMouseVisible = True
        End Sub

        Protected Overrides Sub Initialize()
            MyBase.Initialize()
        End Sub

        Protected Overrides Sub LoadContent()
            spriteBatch = New SpriteBatch(GraphicsDevice)
        End Sub

        Protected Overrides Sub Update(ByVal gameTime As GameTime)
            If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed OrElse Keyboard.GetState().IsKeyDown(Keys.Escape) Then [Exit]()
            MyBase.Update(gameTime)
        End Sub

        Protected Overrides Sub Draw(ByVal gameTime As GameTime)
            GraphicsDevice.Clear(Color.CornflowerBlue)
            MyBase.Draw(gameTime)
        End Sub
    End Class
End Namespace
