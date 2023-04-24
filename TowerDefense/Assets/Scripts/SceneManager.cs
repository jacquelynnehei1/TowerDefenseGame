using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Assets.Scripts
{
    public class SceneManager
    {
        private Dictionary<string, Scene> _scenes = new Dictionary<string, Scene>();
        private string _currentScene;

        public SceneManager() 
        {
            Scene mainMenu = new Scene();
            Scene game = new Scene();

            _scenes.Add("Main Menu", mainMenu);
            _scenes.Add("Game", game);
        }

        public void HandleInput()
        {
            _scenes[_currentScene].HandleInput();
        }

        public void Update()
        {
            _scenes[_currentScene].Update();
        }

        public void Draw(GameWindow window)
        {
            _scenes[_currentScene].Draw(window);
        }
    }
}
