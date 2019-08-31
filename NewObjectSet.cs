using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectX11TutorialObjectEditor
{
    public partial class NewObjectSet : Form
    {
        public NewObjectSet()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbObjectSetName.Text == "")
            {
                MessageBox.Show("오브젝트 셋 이름을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbTextureFileName.Text == "")
            {
                MessageBox.Show("텍스처 파일 이름을 입력해 주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
