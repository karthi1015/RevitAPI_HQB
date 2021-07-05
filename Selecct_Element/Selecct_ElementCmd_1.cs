
#region Namespaces

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Selecct_ElementCmd_1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Khi chạy bằng Add-in Manager thì comment 2 dòng bên dưới để tránh lỗi
            // When running with Add-in Manager, comment the 2 lines below to avoid errors
            //string dllFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //AssemblyLoader.LoadAllRibbonAssemblies(dllFolder);

            Reference r = uidoc.Selection.PickObject(ObjectType.Element);

            Element e = doc.GetElement(r);
            string all = string.Empty;

            string name = e.Name;

            ElementId eid = e.Id;

            all = all + "Element Name =" + name + "\n" + "ElementID = " + eid ;

            MessageBox.Show(all,"Information Element",MessageBoxButtons.YesNo,MessageBoxIcon.Information);


            // code here


            return Result.Succeeded;
        }
    }
}
