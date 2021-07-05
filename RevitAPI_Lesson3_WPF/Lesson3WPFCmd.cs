
#region Namespaces

using System;
using System.IO;
using System.Reflection;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace AlphaBIM
{
    [Transaction(TransactionMode.Manual)]
    public class Lesson3WPFCmd : IExternalCommand
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


            // code here
            //Lesson3_WPFViewModel viewModel = new Lesson3_WPFViewModel(uidoc);
            //Lesson3_WPFWindow window = new Lesson3_WPFWindow(viewModel);
            Lesson3WPFViewModel viewModel = new Lesson3WPFViewModel(uidoc);
            Lesson3WPFWindow window = new Lesson3WPFWindow(viewModel);
            window.ShowDialog();


            return Result.Succeeded;
        }
    }
}
