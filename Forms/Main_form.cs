using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ision.Forms
{
    public partial class Main_form : Form
    {
        public string ID;
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Main_form()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            IdGen.Create();
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            ID = IdGen.Get();
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            MessageBox.Show(ID);
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
