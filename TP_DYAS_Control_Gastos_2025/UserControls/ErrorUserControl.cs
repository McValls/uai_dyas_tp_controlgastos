using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DYAS_Control_Gastos_2025.UserControls
{
    public class ErrorUserControl : UserControl
    {
        protected virtual bool InputValido(Func<bool> funcionDeValidacion, TextBox inputComponent)
        {
            bool result = true;
            if (funcionDeValidacion())
            {
                result = false;
                inputComponent.BackColor = Color.Red;
                var timer = new Timer();
                timer.Interval = 3000; // 3 seconds
                timer.Tick += (s, args) =>
                {
                    inputComponent.BackColor = Color.White;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
            else
            {
                inputComponent.BackColor = Color.White;
            }
            return result;
        }
    }
}
