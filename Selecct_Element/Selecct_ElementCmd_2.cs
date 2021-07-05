
#region Namespaces

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Selecct_ElementCmd_2 : IExternalCommand
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

            List<ElementId> ids = uidoc.Selection.GetElementIds().ToList();


            string all = string.Empty;

            int count = ids.Count;



            foreach (ElementId i in ids)
            {
                Element e = doc.GetElement(i);

                string name = e.Name;

                ElementId id = e.Id;

                 all = all + "Element Name =" + name +  "_ElementID = "+ id + "\n";

                
            }
            MessageBox.Show(all + "Element Count =" + count, "Information Element", MessageBoxButtons.YesNo, MessageBoxIcon.Information);



            return Result.Succeeded;
        }
    }
}
