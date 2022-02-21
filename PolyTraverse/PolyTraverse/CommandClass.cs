using System.Collections.Generic;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System;
using Autodesk.AutoCAD.Geometry;

namespace PolyTraverse
{
    public class CommandClass
    {
        [CommandMethod("ВЫБРАТЬПОЛИХОД")]
        public void SelectTraverse()
        {
            Document document = Application.DocumentManager.MdiActiveDocument;
            Database database = document.Database;
            Editor editor = document.Editor;

            TypedValue[] polyValues = new TypedValue[] { new TypedValue(Convert.ToInt32(DxfCode.Start), "LWPOLYLINE") };

            SelectionSet selectedObjects = editor.GetSelection(new SelectionFilter(polyValues)).Value;
            if (selectedObjects == null || selectedObjects.Count == 0)
            {
                editor.WriteMessage("Полигонометрический ход не был выбран");
                return;
            }

            using (Transaction transaction = database.TransactionManager.StartTransaction())
            {
                MainForm mainForm = new MainForm();
                Polyline polyTraverse = transaction.GetObject(selectedObjects[0].ObjectId, OpenMode.ForRead) as Polyline;
                
                mainForm.selectedPolyTraverse = polyTraverse;
                int countVerticies = polyTraverse.NumberOfVertices;
                if(countVerticies < 2)
                {
                    editor.WriteMessage("Количество вершин полигонометрического хода должно быть больше одного");
                    return;
                }

                for(int i = 0; i < countVerticies; i++)
                {
                    Point2d currentPoint = polyTraverse.GetPoint2dAt(i);
                    mainForm.Coordinates.Rows.Add(currentPoint.X, currentPoint.Y);
                }
                mainForm.calculate();

                Application.ShowModelessDialog(mainForm);
                transaction.Commit();
            }
        }
    }
}
