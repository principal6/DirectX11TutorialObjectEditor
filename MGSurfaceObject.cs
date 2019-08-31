using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DirectX11TutorialObjectEditor
{
    public class MGSurfaceObject : MGSurface
    {
        public MGSurfaceObject(string AssetDir) : base(AssetDir) {}

        public Rectangle DrawingRectangle { set; get; } = new Rectangle(0, 0, 0, 0);

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.graphics.Clear(BackgroundColor);

            BeginDrawing();

            if (m_Textures.Count > 0)
            {
                Editor.spriteBatch.Draw(m_Textures[0].Texture, new Vector2(0, 0), DrawingRectangle, Color.White);
            }

            EndDrawing();
        }
    }
}
