

namespace TowerDefense
{
    public class General
    {
        public static string GetBasePath()
        {
            string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            return Directory.GetParent(workingDirectory).Parent.FullName + "\\TowerDefense\\";
        }

        public static string GetAssetsPath()
        {
            return GetBasePath() + "Assets\\";
        }

        public static string GetScriptsPath()
        {
            return GetAssetsPath() + "Scripts\\";
        }

        public static string GetSpritesPath()
        {
            return GetAssetsPath() + "Sprites\\";
        }
    }
}
