using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = Autodesk.Revit.UI.ComboBox;
using View = Autodesk.Revit.DB.View;


namespace AlphaBIM
{
    public class Lesson3WPFViewModel : ViewModelBase

    {
        public UIDocument UiDoc;
        public Document Doc;

        public Lesson3WPFViewModel(UIDocument uiDoc)
        {
            UiDoc = uiDoc;
            Doc = UiDoc.Document;

            txtBlock = "Revit API";
            txtBox = "Hello";
            isRadio1 = true;
            isCheck1 = true;
            

        }


        public void LayGiaTriChecked()
        {
            string r1;
            string r2;
            string ck1;
            string ck2;
            r1 = isRadio1.ToString();
            r2 = isRadio2.ToString();
            ck1 = isCheck1.ToString();
            ck2 = isCheck2.ToString();
            MessageBox.Show("RadioButton1 = " + r1 + "\n" +
                            "RadioButton2 = " + r2 + "\n" +
                            "CheckBox1 = " + ck1 + "\n" +
                            "CheckBox2 = " + ck2);
        }

        
        public bool isRadio1 { get; set; }
        public bool isRadio2 { get; set; }

        public bool isCheck1 { get; set; }
        public bool isCheck2 { get; set; }

        private string _txtBlock;
        public string txtBlock
        {
            get { return _txtBlock; }
            set
            {
                _txtBlock = value;
                OnPropertyChanged();
            }
        }

        private string _txtBox;
        public string txtBox
        {
            get { return _txtBox; }
            set
            {
                _txtBox = value;
                OnPropertyChanged();
            }

        }

    }


}