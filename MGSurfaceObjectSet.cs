using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using SPosition = System.Drawing.Point;

namespace DirectX11TutorialObjectEditor
{
    public class MGSurfaceObjectSet : MGSurface
    {
        private Texture2D m_MouseGuidelineTexture;
        private Texture2D m_MouseGuidelineFixedTexture;

        public bool ShouldDrawFixedGuideline { set; get; } = false;

        public SPosition FixedMousePosition { set; get; }

        public SPosition CurrentMousePosition { set; get; }

        public MGSurfaceObjectSet(string AssetDir) : base(AssetDir) {}
        
        protected override void Initialize()
        {
            base.Initialize();

            CreateMouseGuidelineTextures();
        }

        private void CreateMouseGuidelineTextures()
        {
            m_MouseGuidelineTexture = new Texture2D(Editor.graphics, 1, 1);
            m_MouseGuidelineFixedTexture = new Texture2D(Editor.graphics, 1, 1);

            Color[] data = new Color[1];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.OrangeRed;
            }
            m_MouseGuidelineTexture.SetData(data);

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.CadetBlue;
            }
            m_MouseGuidelineFixedTexture.SetData(data);
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.graphics.Clear(BackgroundColor);

            BeginDrawing();

            DrawAllTextures();


            Rectangle rect_dest;
            Rectangle rect_src = new Rectangle(0, 0, 1, 1);

            if (ShouldDrawFixedGuideline == true)
            {
                rect_dest = new Rectangle(FixedMousePosition.X, 0, 1, this.Height);
                Editor.spriteBatch.Draw(m_MouseGuidelineFixedTexture, rect_dest, rect_src, Color.White);

                rect_dest = new Rectangle(0, FixedMousePosition.Y, this.Width, 1);
                Editor.spriteBatch.Draw(m_MouseGuidelineFixedTexture, rect_dest, rect_src, Color.White);
            }

            rect_dest = new Rectangle(CurrentMousePosition.X, 0, 1, this.Height);
            Editor.spriteBatch.Draw(m_MouseGuidelineTexture, rect_dest, rect_src, Color.White);

            rect_dest = new Rectangle(0, CurrentMousePosition.Y, this.Width, 1);
            Editor.spriteBatch.Draw(m_MouseGuidelineTexture, rect_dest, rect_src, Color.White);

            EndDrawing();
        }
    }
}
