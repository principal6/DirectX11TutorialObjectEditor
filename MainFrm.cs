using System;
using System.Windows.Forms;
using System.IO;

using Microsoft.Xna.Framework;

using SSize = System.Drawing.Size;
using SPosition = System.Drawing.Point;

namespace DirectX11TutorialObjectEditor
{
    public partial class MainFrm : Form
    {
        private readonly string KAssetDir;
        private SPosition TextureMousePosition;
        private SPosition TextureMousePositionFixed;

        public static readonly int KScrollDelta = 20;

        public MainFrm()
        {
            InitializeComponent();

            KAssetDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\asset\\";
            
            SurfaceTexture = new MGSurfaceObjectSet(KAssetDir)
            {
                Parent = FixedInnerSplitter.Panel2,
                BackgroundColor = new Color(0.4f, 0.8f, 1.0f, 1.0f),
                Dock = DockStyle.Fill
            };
            SurfaceTexture.MouseMove += SurfaceTexture_MouseMove;
            SurfaceTexture.MouseDown += SurfaceTexture_MouseDown;

            SurfaceObject = new MGSurfaceObject(KAssetDir)
            {
                Parent = LeftVertSplitter.Panel1,
                BackgroundColor = new Color(0.6f, 0.8f, 1.0f, 1.0f),
                Dock = DockStyle.Fill
            };

            Manager = new ObjectSetManager();

            TBObjectName.KeyDown += LBObjectsTextBoxes_KeyDown;
            TBOffsetU.KeyDown += LBObjectsTextBoxes_KeyDown;
            TBOffsetV.KeyDown += LBObjectsTextBoxes_KeyDown;
            TBWidth.KeyDown += LBObjectsTextBoxes_KeyDown;
            TBHeight.KeyDown += LBObjectsTextBoxes_KeyDown;

            TBOffsetU.LostFocus += LBObjectsValueTextBoxes_LostFocus;
            TBOffsetV.LostFocus += LBObjectsValueTextBoxes_LostFocus;
            TBWidth.LostFocus += LBObjectsValueTextBoxes_LostFocus;
            TBHeight.LostFocus += LBObjectsValueTextBoxes_LostFocus;
        }

        private void LBObjectsValueTextBoxes_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "" && TBObjectName.Text != "")
            {
                tb.Text = "0";
            }
        }

        private void SurfaceTexture_MouseMove(object sender, MouseEventArgs e)
        {
            SPosition new_location = e.Location;
            new_location.X += SurfaceTexture.GetOffset().X * KScrollDelta;
            new_location.Y += SurfaceTexture.GetOffset().Y * KScrollDelta;
            new_location.X = Math.Max(new_location.X, 0);
            new_location.Y = Math.Max(new_location.Y, 0);

            TextureMousePosition = new_location;

            LabelMousePos.Text = "마우스 좌표 (" +
                TextureMousePosition.X.ToString() + ", " + TextureMousePosition.Y.ToString() + ")";

            LabelDistance.Text = "거리 (" +
                Math.Abs(TextureMousePosition.X - TextureMousePositionFixed.X).ToString() + ", " +
                Math.Abs(TextureMousePosition.Y - TextureMousePositionFixed.Y).ToString() + ")";

            SurfaceTexture.CurrentMousePosition = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                Rectangle selection = new Rectangle
                        (
                        Math.Min(TextureMousePosition.X, TextureMousePositionFixed.X),
                        Math.Min(TextureMousePosition.Y, TextureMousePositionFixed.Y),
                        Math.Abs(TextureMousePosition.X - TextureMousePositionFixed.X),
                        Math.Abs(TextureMousePosition.Y - TextureMousePositionFixed.Y)
                        );

                SurfaceTexture.SetSelection(selection);

                LabelSelection.Text = "선택 - 위치(" +
                    selection.X.ToString() + ", " + selection.Y.ToString() + ") - 크기(" +
                    selection.Width.ToString() + ", " + selection.Height.ToString() + ")";
            }

            SurfaceTexture.Invalidate();
        }

        private void SurfaceTexture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SurfaceTexture.ShouldDrawFixedGuideline = true;

                SPosition new_location = e.Location;
                new_location.X += SurfaceTexture.GetOffset().X * KScrollDelta;
                new_location.Y += SurfaceTexture.GetOffset().Y * KScrollDelta;

                TextureMousePositionFixed = SurfaceTexture.FixedMousePosition = new_location;

                LabelMousePosFixed.Text = "고정 좌표 (" +
                    TextureMousePositionFixed.X.ToString() + ", " + TextureMousePositionFixed.Y.ToString() + ")";

                SurfaceTexture.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                SurfaceTexture.SetSelection(new Rectangle(0, 0, 0, 0));

                LabelSelection.Text = "선택 - 위치(0, 0) - 크기(0, 0)";
            }
        }

        public MGSurfaceObjectSet SurfaceTexture { get; }

        public MGSurfaceObject SurfaceObject { get; }

        private ObjectSetManager Manager { get; }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Manager.ObjectSet == null) return;

            bool name_collision = true;
            int new_element_name_index = LBObjects.Items.Count;
            string new_element_name = "";

            while (name_collision == true)
            {
                new_element_name = "obj" + new_element_name_index;

                name_collision = false;

                foreach (object item in LBObjects.Items)
                {
                    if (new_element_name.CompareTo(item) == 0)
                    {
                        name_collision = true;
                        ++new_element_name_index;
                        continue;
                    }
                }
            }

            Rectangle selection = SurfaceTexture.GetSelection();

            ObjectSetElementData new_element = new ObjectSetElementData
            {
                ElementName = new_element_name,
                OffsetU = selection.X,
                OffsetV = selection.Y,
                Size = new SSize(selection.Width, selection.Height)
            };

            Manager.ObjectSet.Elements.Add(new_element);

            LBObjects.Items.Add(new_element_name);

            LBObjects.SelectedIndex = LBObjects.Items.Count - 1;
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            if (Manager.ObjectSet == null) return;
            if (Manager.ObjectSet.Elements.Count == 0) return;

            int post_index = Math.Max(LBObjects.SelectedIndex - 1, 0);

            Manager.ObjectSet.Elements.RemoveAt(LBObjects.SelectedIndex);
            LBObjects.Items.RemoveAt(LBObjects.SelectedIndex);

            if (Manager.ObjectSet.Elements.Count > 0)
            {
                LBObjects.SelectedIndex = post_index;
                LBObjects.Focus();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Manager.ObjectSet == null) return;
            if (Manager.ObjectSet.Elements.Count == 0) return;

            ObjectSetElementData element = Manager.ObjectSet.Elements[LBObjects.SelectedIndex];

            element.ElementName = TBObjectName.Text;

            try
            {
                element.OffsetU = Convert.ToInt32(TBOffsetU.Text);
                element.OffsetV = Convert.ToInt32(TBOffsetV.Text);
            }
            catch (System.FormatException error)
            {
                MessageBox.Show(error.Message + "\n( 오프셋은 숫자만 입력하실 수 있습니다. )", "값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                element.Size = new SSize(Convert.ToInt32(TBWidth.Text), Convert.ToInt32(TBHeight.Text));
            }
            catch (System.FormatException error)
            {
                MessageBox.Show(error.Message + "\n( 크기는 숫자만 입력하실 수 있습니다. )", "값 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LBObjects.Items[LBObjects.SelectedIndex] = TBObjectName.Text;
        }

        private void LBObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBObjects.SelectedIndex == -1) return;

            ObjectSetElementData element = Manager.ObjectSet.Elements[LBObjects.SelectedIndex];

            TBObjectName.Text = element.ElementName;

            TBOffsetU.Text = element.OffsetU.ToString();
            TBOffsetV.Text = element.OffsetV.ToString();

            TBWidth.Text = element.Size.Width.ToString();
            TBHeight.Text = element.Size.Height.ToString();

            SurfaceObject.DrawingRectangle = 
                new Rectangle(element.OffsetU, element.OffsetV, element.Size.Width, element.Size.Height);

            SurfaceObject.Invalidate();
        }

        private void LBObjectsTextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                btnUpdate.PerformClick();
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            OuterSplitter.Height = this.ClientSize.Height - MainMenu.Height - 3;
        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgSave.InitialDirectory = KAssetDir;
            DlgSave.Filter = "오브젝트 셋 파일 (*.xml)|*.xml";
            DlgSave.DefaultExt = ".xml";
            DlgSave.FileName = "";
            DlgSave.Title = "오브젝트 셋 저장하기";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                Manager.SaveToFile(DlgSave.FileName);
            }
        }

        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgOpen.InitialDirectory = KAssetDir;
            DlgOpen.Filter = "오브젝트 셋 파일 (*.xml)|*.xml";
            DlgOpen.DefaultExt = ".xml";
            DlgOpen.FileName = "";
            DlgOpen.Title = "오브젝트 셋 불러오기";

            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                Manager.LoadFromFile(DlgOpen.FileName);

                this.Text = "DirectX11Tutorial Object Editor: " + Manager.ObjectSet.ObjectSetName;

                SurfaceTexture.ClearTextures();
                SurfaceTexture.AddTextureFromFile(Manager.ObjectSet.TextureFileName);

                SurfaceObject.ClearTextures();
                SurfaceObject.AddTextureFromFile(Manager.ObjectSet.TextureFileName);

                SurfaceTexture.Invalidate();
                SurfaceObject.Invalidate();

                SSize texture_size = SurfaceTexture.GetTextureSize(0);

                hScrollBar1.LargeChange = KScrollDelta;
                hScrollBar1.Maximum = texture_size.Width / hScrollBar1.LargeChange;

                vScrollBar1.LargeChange = KScrollDelta;
                vScrollBar1.Maximum = texture_size.Height / vScrollBar1.LargeChange;

                LBObjects.Items.Clear();
                foreach (ObjectSetElementData element in Manager.ObjectSet.Elements)
                {
                    LBObjects.Items.Add(element.ElementName);
                }
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewObjectSet new_object_set = new NewObjectSet();
            new_object_set.ShowDialog();

            if (new_object_set.DialogResult == DialogResult.OK)
            {
                Manager.CreateNewObjectSet(
                    new_object_set.Controls["tbObjectSetName"].Text,
                    new_object_set.Controls["tbTextureFileName"].Text);

                this.Text = "DirectX11Tutorial Object Editor: " + Manager.ObjectSet.ObjectSetName;

                SurfaceTexture.ClearTextures();
                SurfaceTexture.AddTextureFromFile(Manager.ObjectSet.TextureFileName);
                
                SurfaceObject.ClearTextures();
                SurfaceObject.AddTextureFromFile(Manager.ObjectSet.TextureFileName);

                SurfaceTexture.Invalidate();
                SurfaceObject.Invalidate();

                LBObjects.Items.Clear();
            }

            new_object_set.Dispose();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SurfaceTexture.SetOfffsetX(e.NewValue);

            SurfaceTexture.Invalidate();
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SurfaceTexture.SetOfffsetY(e.NewValue);

            SurfaceTexture.Invalidate();
        }
    }
}
