using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenSurfEngine
{
    
    static class Drawing
    {
        private static GameWindow win;
        public static void Run(int width, int height) 
        {
            win = new GameWindow(width, height);
            SetDelegateFunctions();
        }
        private static void SetDelegateFunctions() 
        {
            win.Load += Loaded;
            win.RenderFrame += RenderF;
            win.Run(1.0/60.0);
        }
        private static void RenderF(object sender, EventArgs e) 
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            win.SwapBuffers();
        }
        private static void Loaded(object sender, EventArgs e) 
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
