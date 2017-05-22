using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {
    class ComboBoxItem {
        public string Name;
        public int Value;
        public ComboBoxItem(string Name, int Value) {
            this.Name = Name;
            this.Value = Value;
        }
        public override string ToString() {
            return this.Name;
        }

        //Lấy ra giá trị mong muốn
        //int selectedValue = ((ComboBoxItem)myComboBox.SelectedItem).Value;
    }
}
