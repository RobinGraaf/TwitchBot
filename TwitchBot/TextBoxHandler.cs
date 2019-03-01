using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot {
    static class TextBoxHandler {

        public static bool CheckForInput(TextBox textBox, out string output)
        {
            if (textBox.Text.Length > 0) {
                output = textBox.Text;
                textBox.BackColor = Color.White;
                return true;
            } else {
                textBox.BackColor = Color.Red;
                output = "";
                return false;
            }
        }
    }
}
