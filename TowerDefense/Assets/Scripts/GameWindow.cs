using SFML.System;
using SFML.Window;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Assets.Scripts
{
    public class GameWindow
    {
        #region Private Variables
        private uint _width, _height;
        private string _title;
        private Vector2u _resolution;
        private bool _isFullScreen;
        private bool _isOpen;
        private bool _useVSync;
        private RenderWindow _renderWindow;
        #endregion

        #region Properties
        public RenderWindow window
        {
            get
            {
                if (_renderWindow == null)
                {
                    _resolution = new Vector2u(VideoMode.DesktopMode.Width, VideoMode.DesktopMode.Height);

                    _width = resolution.X;
                    _height = resolution.Y;

                    _renderWindow = new RenderWindow(new VideoMode(_width, _height), _title);
                }

                return _renderWindow;
            }
        }

        public Vector2u resolution { get { return _resolution; } }
        public uint width { get { return _width; } }
        public uint height { get { return _height; } }
        public bool isFullScreen { get { return _isFullScreen; } }
        public bool isOpen { get { return _isOpen; } }
        public string title { get { return _title; } set { _title = value; } }
        #endregion

        /// <summary>
        /// Creates a new GameWindow with default values. The window will be fullscreen by default.
        /// </summary>
        public GameWindow() 
        {
            //set the resolution, width and height values using the video mode settings
            this._resolution = new Vector2u(VideoMode.DesktopMode.Width, VideoMode.DesktopMode.Height);
            this._width = resolution.X;
            this._height = resolution.Y;
            this._isOpen = true;
            this._useVSync = true;
            this._title = "";

            //create a new fullscreen window
            this._renderWindow = new RenderWindow(new VideoMode(_width, _height), _title, Styles.Fullscreen);
            this._renderWindow.SetVerticalSyncEnabled(this._useVSync);
        }

        /// <summary>
        /// Creates a new GameWindow with provided values. 
        /// </summary>
        /// <param name="resolution"></param>
        /// <param name="title"></param>
        /// <param name="isFullScreen"></param>
        public GameWindow(Vector2u resolution, string title, bool isFullScreen, bool useVSync)
        {
            //set the resolution, width and height values
            this._resolution = resolution;
            this._width = resolution.X;
            this._height = resolution.Y;
            this._isFullScreen = isFullScreen;
            this._isOpen = true;
            this._useVSync = useVSync;

            //check if we should set the screen to fullscreen
            Styles windowStyle = isFullScreen ? Styles.Fullscreen : Styles.Default;

            //create the new window
            this._renderWindow = new RenderWindow(new VideoMode(_width, _height), title, windowStyle);  
            this._renderWindow.SetVerticalSyncEnabled(this._useVSync);
        }

        public void Close()
        {
            //if you need to add logic before closing, add it here...
            _renderWindow.Close();
        }

        public void HandleEvents()
        {
            _renderWindow.DispatchEvents();
        }

        public void HandleInput()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
            {
                Close();
            }
        }

        public void Update()
        {

        }

        public void BeginDraw()
        {
            _renderWindow.Clear();
        }

        public void Draw(Drawable drawable)
        {
            _renderWindow.Draw(drawable);
        }

        public void EndDraw()
        {
            _renderWindow.Display();
        }
    }
}
