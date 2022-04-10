using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BuildingWorlds.Core;
using BuildingWorlds.Scenes;

namespace BuildingWorlds.Managers
{
    internal partial class GameStateManager : Component
    {
        private GameScene gameScene = new GameScene();
        internal override void LoadContent(ContentManager content)
        {
            gameScene.LoadContent(content);
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.CurrentScene)
            {
                // case Data.Scenes.Menu:
                //     break;
                case Data.Scenes.Game:
                    gameScene.Update(gameTime);
                    break;
                // case Data.Scenes.Settings:
                //     break;
            }
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (Data.CurrentScene)
            {
                // case Data.Scenes.Menu:
                //     break;
                case Data.Scenes.Game:
                    gameScene.Draw(spriteBatch);
                    break;
                // case Data.Scenes.Settings:
                //     break;
            }
        }
    }
}
