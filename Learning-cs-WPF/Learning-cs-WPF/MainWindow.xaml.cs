using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Learning_cs_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// https://www.youtube.com/watch?v=Vjldip84CXQ&list=PLrW43fNmjaQVYF4zgsD0oL9Iv6u23PI6M

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is {this.txtDescription.Text}");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            this.chkWeld.IsChecked = this.chkAssembly.IsChecked = this.chkPlasma.IsChecked =
                this.chkLaser.IsChecked = this.chkPurchase.IsChecked = this.chkLathe.IsChecked =
                this.chkDrill.IsChecked = this.chkFold.IsChecked = this.chkRoll.IsChecked =
                this.chkSaw.IsChecked = false;

        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            /// casting workes with this parentheses. sender, which is an object is cast into the thing left of itself in ()
            /// .Content accesses now the object sender cast as Checkbox, this Content is automatically cast into string
            /// but manually casting into string is done by (string) left of ((CheckBox)...
            this.txtLength.Text += $"{(string)((CheckBox)sender).Content} ";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /// the messy looking way
            /// this.txtNote.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
            if (this.txtNote == null)
                return;
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.txtNote.Text = (string)value.Content;

        }

        private void txtSupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.txtMass.Text = this.txtSupplierName.Text;
        }
    }
}
