using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using SSize = System.Drawing.Size;
using SPosition = System.Drawing.Point;

namespace DirectX11TutorialObjectEditor
{
    public class MGSurfaceObjectSet : MGSurface
    {
        private Texture2D m_BackgroundTexture;
        private Texture2D m_MouseGuidelineTexture;
        private Texture2D m_MouseGuidelineFixedTexture;
        private Texture2D m_SelectionTexture;
        private SPosition m_Offset;
        private Rectangle m_Selection;

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
            m_BackgroundTexture = new Texture2D(Editor.graphics, 1, 1);
            m_MouseGuidelineTexture = new Texture2D(Editor.graphics, 1, 1);
            m_MouseGuidelineFixedTexture = new Texture2D(Editor.graphics, 1, 1);
            m_SelectionTexture = new Texture2D(Editor.graphics, 1, 1);

            Color[] data = new Color[1];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.CornflowerBlue;
            }
            m_BackgroundTexture.SetData(data);

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

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = new Color(1.0f, 0.0f, 0.0f, 0.5f);
            }
            m_SelectionTexture.SetData(data);
        }

        protected override void Draw()
        {
            base.Draw();

            BeginDrawing();

            foreach (MGTextureData i in m_Textures)
            {
                Editor.spriteBatch.Draw(i.Texture, 
                    new Vector2(-m_Offset.X * MainFrm.KScrollDelta, -m_Offset.Y * MainFrm.KScrollDelta),
                    i.Rect, i.BlendColor * ((float)i.BlendColor.A / 255.0f));
            }

            Rectangle rect_dest;
            Rectangle rect_src = new Rectangle(0, 0, 1, 1);

            if (ShouldDrawFixedGuideline == true)
            {
                rect_dest = new Rectangle(FixedMousePosition.X - m_Offset.X * MainFrm.KScrollDelta, 0, 1, this.Height);
                Editor.spriteBatch.Draw(m_MouseGuidelineFixedTexture, rect_dest, rect_src, Color.White);

                rect_dest = new Rectangle(0, FixedMousePosition.Y - m_Offset.Y * MainFrm.KScrollDelta, this.Width, 1);
                Editor.spriteBatch.Draw(m_MouseGuidelineFixedTexture, rect_dest, rect_src, Color.White);
            }

            rect_dest = new Rectangle(CurrentMousePosition.X, 0, 1, this.Height);
            Editor.spriteBatch.Draw(m_MouseGuidelineTexture, rect_dest, rect_src, Color.White);

            rect_dest = new Rectangle(0, CurrentMousePosition.Y, this.Width, 1);
            Editor.spriteBatch.Draw(m_MouseGuidelineTexture, rect_dest, rect_src, Color.White);


            rect_dest = m_Selection;
            rect_dest.X -= m_Offset.X * MainFrm.KScrollDelta;
            rect_dest.Y -= m_Offset.Y * MainFrm.KScrollDelta;
            Editor.spriteBatch.Draw(m_SelectionTexture, rect_dest, rect_src, Color.White);

            EndDrawing();
        }

        public void SetOfffsetX(int Offset)
        {
            m_Offset.X = Offset;
        }

        public void SetOfffsetY(int Offset)
        {
            m_Offset.Y = Offset;
        }

        public SPosition GetOffset()
        {
            return m_Offset;
        }

        public void SetSelection(Rectangle Selection)
        {
            m_Selection = Selection;
        }

        public Rectangle GetSelection()
        {
            return m_Selection;
        }
    }
}
