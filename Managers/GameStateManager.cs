using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BuildingWorlds.Core;

namespace BuildingWorlds.Managers
{
    internal partial class GameStateManager : Component
    {
        internal override void LoadContent(ContentManager content)
        {
            
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.CurrentScene)
            {
                // case Data.Scenes.Menu:
                //     break;
                case Data.Scenes.Game:
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
                    break;
                // case Data.Scenes.Settings:
                //     break;
            }
        }
    }
}
