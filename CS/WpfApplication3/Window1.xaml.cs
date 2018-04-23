using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;

namespace WpfApplication3 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            #region #1

            // Create a bar check item.
            BitmapImage imItalic = new BitmapImage(new Uri("pack://application:,,/Images/italic16x16.png"));
            BitmapImage imItalicLarge = new BitmapImage(new Uri("pack://application:,,/Images/italic32x32.png"));
            BarCheckItem checkBtnItalic = new BarCheckItem() { Content = "Italic", Glyph = imItalic, LargeGlyph = imItalicLarge };
            checkBtnItalic.GlyphSize = GlyphSize.Small;
            checkBtnItalic.CheckedChanged += new ItemClickEventHandler(checkBtnItalic_CheckChanged);
            barManager1.Items.Add(checkBtnItalic);
            // Add the item to a bar
            barManager1.Bars["barFormat"].ItemLinks.Add(checkBtnItalic.CreateLink());
            // Create a category and add the bar item to the category.
            BarManagerCategory category1 = new BarManagerCategory() { Name = "My category" };
            barManager1.Categories.Add(category1);
            checkBtnItalic.Category = category1;
            
            #endregion #1
        }

        void checkBtnItalic_CheckChanged(object sender, ItemClickEventArgs e) {
            //...
        }

        void checkBtnBold_CheckChanged(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
			//...
        }
    }
}
