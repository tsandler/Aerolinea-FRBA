using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboBoxItem(ComboBox comboBox)
        {
            this.bindCombobox(comboBox);
        }

        public ComboBoxItem() { }

        public override string ToString()
        {
            return Text;
        }

        public void bindCombobox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
        }
    }
}
