using DevComponents.DotNetBar.Keyboard;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeoVMT
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            keyboardControl1.Keyboard = CreateNumericKeyboard();


        }
        private Keyboard CreateNumericKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            LinearKeyboardLayout klNumLockOn = new LinearKeyboardLayout();

            

            klNumLockOn.AddKey("7");
            klNumLockOn.AddKey("8");
            klNumLockOn.AddKey("9");
          
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("4");
            klNumLockOn.AddKey("5");
            klNumLockOn.AddKey("6");
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("1");
            klNumLockOn.AddKey("2");
            klNumLockOn.AddKey("3");
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("0", width: 21);
  
            klNumLockOn.AddKey("Enter", "{ENTER}", height: 21);





            keyboard.Layouts.Add(klNumLockOn);


            return keyboard;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            keyboardControl1.Show();

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            keyboardControl1.Show();

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            keyboardControl1.Show();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            keyboardControl1.Show();
        }
    }
}
