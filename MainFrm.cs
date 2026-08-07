using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using WindowsInput;

namespace FortniteMacroEdit
{
    public partial class MainFrm : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();
        InputSimulator inputSimulator = new InputSimulator();
        bool macroBool = false;
        bool isPressing = false;
        Keys macroKey;
        short delay = 32; //initial value

        public MainFrm()
        {
            InitializeComponent();
        }

        private void ButtonMacroEdit_Click(object sender, EventArgs e)
        {
            macroBool = !macroBool;
            buttonMacroEdit.Text = (macroBool ? "Enabled" : "Disabled");
            switch (macroBool)
            {
                case true:
                    if (comboBoxKey.SelectedItem == null)
                    {
                        MessageBox.Show("Please select your edit key", "Error");
                        buttonMacroEdit.Text = "Disabled";
                        break;
                    }
                    else
                    {
                        gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
                        gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
                        break;
                    }

                case false:
                    gkh.KeyDown -= new KeyEventHandler(gkh_KeyDown);
                    gkh.KeyUp -= new KeyEventHandler(gkh_KeyUp);
                    break;
            }
        }

        private void TextBoxDelay_TextChanged(object sender, EventArgs e)
        {
            switch (Int16.TryParse(textBoxDelay.Text, out short parse))
            {
                case false:
                    MessageBox.Show("Only numbers allowed. Setting delay to default value (32 ms).", "Error");
                    textBoxDelay.Text = "32";
                    delay = 32;
                    break;

                case true:
                    delay = parse;
                    break;
            }
        }

        private void ComboBoxKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKey != null)
            {
                macroKey = (Keys)comboBoxKey.SelectedItem;
                gkh.HookedKeys.Clear();
                gkh.HookedKeys.Add(macroKey);
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            inputSimulator.Mouse.LeftButtonUp();
            isPressing = false;
        }

        async void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPressing == false)
            {
                await Task.Delay(delay);
                inputSimulator.Mouse.LeftButtonDown();
                isPressing = true;
            }

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                if (key != Keys.Modifiers)
                    comboBoxKey.Items.Add(key);
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gkh.unhook();
        }

    }
}
