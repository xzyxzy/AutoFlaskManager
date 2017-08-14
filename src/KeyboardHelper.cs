using PoeHUD.Controllers;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace FlaskManager
{
    internal class KeyboardHelper
    {
        private readonly GameController _gameHandle;
        private float _curLatency;

        public KeyboardHelper(GameController g)
        {
            _gameHandle = g;
        }

        public void SetLatency(float latency)
        {
            _curLatency = latency;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr PostMessage(IntPtr hWnd, int msg, int wParam, uint lParam);
        /*
                [return: MarshalAs(UnmanagedType.Bool)]
                [DllImport("user32.dll", SetLastError = true)]
                private static extern bool PostMessage(IntPtr hWnd, uint msg, UIntPtr wParam, UIntPtr lParam);
        */
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(UInt16 vKey);
        [DllImport("USER32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        public void KeyDown(Keys key, bool shiftmod = false)
        {
            if (shiftmod)
            {
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, 0x10, 0x002A0001);
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, (int)key, 0x00100001);
            }
            else PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, (int)key, 0);
        }
        public void KeyDownTest(Keys key, bool shiftmod = false)
        {
            if (shiftmod)
            {
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, 0x10, 0x402A0001);
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, (int)key, 0x40100001);
            }
            else PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x100, (int)key, 0x40100001);
        }
        public static bool IsKeyDown(int nVirtKey)
        {
            bool state = false;
            short retVal = GetKeyState((int)nVirtKey);

            //If the high-order bit is 1, the key is down
            //otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
                state = true;

            //If the low-order bit is 1, the key is toggled.
            //if ((retVal & 1) == 1)
            //    state = toggled;

            return state;
        }

        public static bool IsKeyDownAsync(UInt16 vKey)
        {
            return (GetKeyState(vKey) & 0x8000) > 0 ? true : false;
        }

        public void KeyUp(Keys key, bool shiftmod = false)
        {
            if (shiftmod)
            {
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x101, (int)key, 0xC0100001);
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x101, 0x10, 0xC02A0001);
            }
            else PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x101, (int)key, 0);
        }
        public bool KeyPressRelease(Keys key, bool shiftmod = false)
        {
            KeyDown(key, shiftmod);
            var lat = (int)(_curLatency);
            if (lat < 1000)
            {
                Thread.Sleep(lat);
                return true;
            }
            else
            {
                Thread.Sleep(1000);
                return false;
            }
        }
/*
        private void Write(string text, params object[] args)
        {
            foreach (var character in string.Format(text, args))
            {
                PostMessage(_gameHandle.Window.Process.MainWindowHandle, 0x0102, new UIntPtr(character), UIntPtr.Zero);
            }
        }
*/
    }
}
