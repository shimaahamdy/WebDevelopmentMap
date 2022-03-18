using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tasks
{
    /// <summary>
    /// Interaction logic for Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void ColorChanged(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":
                    inkC.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    inkC.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    inkC.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case "Magenta":
                    inkC.DefaultDrawingAttributes.Color = Colors.Magenta;
                    break;
            }
        }

        private void ModeChanged(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":
                    inkC.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "Select":
                    inkC.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case "PointErase":
                    inkC.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "StrokeErase":
                    inkC.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void DrawShapeChange(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {

                case "Ellipse":
                    inkC.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
                case "Rectangle":
                    inkC.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;

            }
        }

        private void BrushSizeChange(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Small":
                    inkC.DefaultDrawingAttributes.Width = 5;
                    inkC.DefaultDrawingAttributes.Height = 5;
                    break;
                case "Medium":
                    inkC.DefaultDrawingAttributes.Width = 10;
                    inkC.DefaultDrawingAttributes.Height = 10;
                    break;
                case "Large":
                    inkC.DefaultDrawingAttributes.Width = 20;
                    inkC.DefaultDrawingAttributes.Height = 20;
                    break;
                
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            inkC.Strokes.Clear();
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            inkC.CopySelection();
        }

        private void Cut(object sender, RoutedEventArgs e)
        {
            inkC.CutSelection();
        }

        private void Past(object sender, RoutedEventArgs e)
        {
            inkC.Paste();
            
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                               FileMode.Create);
                inkC.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                inkC.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }
    }
}
