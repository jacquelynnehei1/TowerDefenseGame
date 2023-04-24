using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TowerDefense.Assets.Scripts
{
    public class GameEngine
    {
        public GameWindow gameWindow;
        public TextureManager textureManager;
        public SceneManager sceneManager;

        public GameEngine()
        {
            gameWindow = new GameWindow();
            gameWindow.title = "Tower Defense";

            textureManager = new TextureManager();
            sceneManager = new SceneManager();
        }

        public void Run()
        {
            while (gameWindow.isOpen)
            {
                HandleEvents();
                HandleInput();
                Update();
                Draw();
            }
        }

        private void HandleEvents()
        {
            gameWindow.HandleEvents();
        }

        private void HandleInput()
        {
            gameWindow.HandleInput();
        }

        private void Update()
        {
            gameWindow.Update();
        }

        private void Draw()
        {
            gameWindow.BeginDraw();

            sceneManager.Draw(gameWindow);

            gameWindow.EndDraw();
        }
    }
}
