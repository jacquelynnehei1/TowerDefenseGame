using SFML.Graphics;

namespace TowerDefense.Assets.Scripts
{
    public class TextureManager
    {
        private static TextureManager _instance;
        private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        public static TextureManager instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TextureManager();
                }

                return _instance;
            }
        }

        public TextureManager()
        {
            if (_instance == null)
            {
                _instance = this;
            }
        }

        public Texture GetTexture(string textureName)
        {
            if (!string.IsNullOrWhiteSpace(textureName))
            {
                if (_textures.ContainsKey(textureName))
                {
                    return _textures[textureName];
                }
                else
                {
                    AddTexture(textureName);
                }

            }

            return null;
        }

        public void AddTexture(string textureName)
        {
            if (!_textures.ContainsKey(textureName))
            {
                Texture texture = new Texture(General.GetSpritesPath() + textureName);
                _textures.Add(textureName, texture);
            }
        }
    }
}
