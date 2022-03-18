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
using System.Windows.Shapes;

namespace tasks
{
    /// <summary>
    /// Interaction logic for Text.xaml
    /// </summary>
    public partial class Text : Window
    {
        public Text()
        {
            InitializeComponent();
        }
        //Set text
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtOne.Document.Blocks.Clear();
            txtOne.Document.Blocks.Add(new Paragraph(new Run("Default text replaced.")));

        }
        //Done
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtOne.Focus();
            txtOne.SelectAll();
        }
        //Clear Done
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtOne.Document.Blocks.Clear();

        }
        //Prepend Done
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            string richText = new TextRange(txtOne.Document.ContentStart, txtOne.Document.ContentEnd).Text;
            txtOne.Document.Blocks.Clear();

            txtOne.Document.Blocks.Add(new Paragraph(new Run("** Add Your Text **" + richText)));
        }
        //Cut Done
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(txtOne.Document.ContentStart, txtOne.Document.ContentEnd).Text;
            txtOne.SelectAll();
            txtOne.Cut();
            // txtOne.Document.Blocks.Clear();

        }
        //Done
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtOne.Paste();
        }
        //Done
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtOne.Undo();
        }
        //Append  => moves to the next line
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(txtOne.Document.ContentStart, txtOne.Document.ContentEnd).Text;
            txtOne.Document.Blocks.Clear();

            txtOne.Document.Blocks.Add(new Paragraph(new Run(richText + "** Add Your Text **")));

        }
        //Insert
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //string richText = new TextRange(txtOne.Document.ContentStart, txtOne.Document.ContentEnd).Text;

            //txtOne.Document.Blocks.Clear();

            //txtOne.Document.Blocks.Add(new Paragraph(new Run(richText + "** Text Inserted **")));
            txtOne.BeginChange();
            if(txtOne.Selection.Text != String.Empty)
            {
                txtOne.Selection.Text = String.Empty;
            }
            TextPointer t = txtOne.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
            txtOne.CaretPosition.InsertTextInRun("***InsertedText***");
            txtOne.CaretPosition = t;
            txtOne.EndChange();
            Keyboard.Focus(txtOne);
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content)
            {
                case "Editable":
                    txtOne.IsReadOnly = false;

                    break;
                case "Readonly":
                    txtOne.IsReadOnly = true;
                    break;
                case "Left":
                    txtOne.SelectAll();
                    al.TextAlignment = TextAlignment.Left;
                    break;
                case "Center":
                    txtOne.SelectAll();
                    al.TextAlignment = TextAlignment.Center;
                    break;
                case "Right":
                    txtOne.SelectAll();
                    al.TextAlignment = TextAlignment.Right;
                    break;
            }
        }
    }
}
