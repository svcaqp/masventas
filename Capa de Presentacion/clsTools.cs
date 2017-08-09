using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    class clsTools
    {
        public static void OnlyDouble(object sender, KeyEventArgs e)
        {
            TextBox tBox = (TextBox)sender;

            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
               || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
               || (e.KeyCode == Keys.Decimal && !(tBox.Text.Contains('.'))
                   && !(tBox.Text.Length == 0)
                   && !((tBox.Text.Length == 1)
                      && (tBox.Text.Contains('-') || tBox.Text.Contains('+'))))
               || (e.KeyCode == Keys.OemPeriod && !(tBox.Text.Contains('.'))
                   && !(tBox.Text.Length == 0)
                   && !((tBox.Text.Length == 1)
                      && (tBox.Text.Contains('-') || tBox.Text.Contains('+'))))
               || (e.KeyCode == Keys.Subtract && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.OemMinus && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.Add && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || (e.KeyCode == Keys.Oemplus && ((tBox.Text.Length == 0) ||
                   tBox.Text.EndsWith("e") || tBox.Text.EndsWith("E")))
               || e.KeyCode == Keys.Delete
               || e.KeyCode == Keys.Back
               || e.KeyCode == Keys.Left
               || e.KeyCode == Keys.Right
               || (e.KeyCode == Keys.E) && !(tBox.Text.Contains('e')) &&
                   (tBox.Text.Contains('.') && !tBox.Text.EndsWith("."))))
            {
                e.SuppressKeyPress = true;
            }
            
        }

    }
}
