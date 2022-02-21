using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace PolyTraverse
{
    public partial class MainForm : Form
    {
        public Polyline selectedPolyTraverse;
        public Point meanPoint;
        public List<Point> points;
        public List<double> lengthSides, lengthsToCenter, lengthsToCenterInSquare;
        public double lengthTravers, lenghtInSquare;
        public double closing;
        public double R = 648000 / Math.PI;

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Расчёт полигонометрического хода в AutoCAD\nРазработчик: Шмаков Максим\nВерсия от 20.02.2022", "PolyTraverse");
        }

        public bool firstCriterion = true, secondCriterion = true, thirdCriterion = false;
        private void Calculate_Click(object sender, EventArgs e)=>
            calculate();


        private void SaveReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog.FileName, Output.Text);
        }

        private void OpenData_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] coordinatesXY = lines[i].Split(new char[] { ' ' });
                        Coordinates.Rows.Add(coordinatesXY[0], coordinatesXY[1]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения данных. Необходимый формат: X Y", "Расчёт полигонометрического хода");
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> lines = new List<string>();
                    for (int i = 0; i < Coordinates.Rows.Count - 1; i++)
                        lines.Add($"{Coordinates.Rows[i].Cells[0].Value} {Coordinates.Rows[i].Cells[1].Value}");
                    File.WriteAllLines(saveFileDialog.FileName, lines.ToArray());
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения данных", "Расчёт полигонометрического хода");
            }
        }

        public void calculate()
        {
            try
            {
                if (Coordinates.RowCount < 3)
                {
                    MessageBox.Show("Количество пунктов должно быть больше одного", "Расчёт полигонометрического хода");
                    return;
                }

                firstCriterion = true;
                secondCriterion = true;
                thirdCriterion = false;

                //Clear output
                Output.Clear();
                log("<---Начало вычислений--->");
                newLine();

                //Parse coordinates
                points = new List<Point>();
                foreach (DataGridViewRow row in Coordinates.Rows)
                    if (Coordinates.Rows.IndexOf(row) != Coordinates.RowCount - 1)
                        points.Add(new Point(Convert.ToDouble(row.Cells[0].Value), Convert.ToDouble(row.Cells[1].Value)));
                log($"Количество пунктов: {points.Count}");

                //Output Points
                for (int i = 0; i < points.Count; i++)
                    log($"Точка {i + 1}: X = {points[i].x}; Y = {points[i].y}");
                newLine();

                //Calculate mean point
                meanPoint = new Point(0, 0);
                foreach (Point point in points)
                {
                    meanPoint.x += point.x;
                    meanPoint.y += point.y;
                }

                meanPoint.x /= points.Count;
                meanPoint.y /= points.Count;

                log($"Центр тяжести хода: X = {meanPoint.x}; Y = {meanPoint.y}");

                //Calculate length to mean point and square
                lengthsToCenter = new List<double>();
                lengthsToCenterInSquare = new List<double>();
                foreach (Point point in points)
                {
                    lengthsToCenter.Add(point.distance(meanPoint));
                    lengthsToCenterInSquare.Add(Math.Pow(point.distance(meanPoint), 2));
                }
                log($"Количество длин сторон до центра тяжести: {lengthsToCenter.Count}");
                for (int i = 0; i < lengthsToCenter.Count; i++)
                    log($"Сторона {i + 1} до центра тяжести: {lengthsToCenter[i]} в квадрате {lengthsToCenterInSquare[i]}");
                newLine();

                //Calculate length sides
                lengthSides = new List<double>();
                for (int i = 1; i < points.Count; i++)
                    lengthSides.Add(points[i].distance(points[i - 1]));

                log($"Количество сторон: {lengthSides.Count}");
                for (int i = 0; i < lengthSides.Count; i++)
                    log($"Длина стороны пунктов {i + 1}-{i + 2}: {lengthSides[i]}");
                newLine();


                //Calculate length travers
                lengthTravers = lengthSides.Sum();
                log($"Длина хода: {lengthTravers}");

                //Calculate length in square
                lenghtInSquare = lengthsToCenterInSquare.Sum();
                log($"Сумма длин сторон до центра тяжести в квадрате: {lenghtInSquare}");

                //Calculate closing
                closing = getFirstPoint().distance(getLastPoint());
                log($"Длина замыкающей: {closing}");
                newLine();

                //Checking criteries
                //First
                log("Первый критерий:");
                double lengthBetweenClosingAndMeanPoint = perpendicularPointToLine(meanPoint, getFirstPoint(), getLastPoint());
                log($"Расстояние от центра тяжести до замыкающей: {lengthBetweenClosingAndMeanPoint}");
                for (int i = 0; i < points.Count; i++)
                {
                    double lengthBetweenPointAndMeanPoint = Math.Abs(perpendicularPointToLine(points[i], getFirstPoint(), getLastPoint()) -
                        lengthBetweenClosingAndMeanPoint);
                    if (lengthBetweenPointAndMeanPoint <= closing / PT_CONSTANTS.FIRST)
                        log($"✓ Расстояние от пункта {i + 1} до центра тяжести входит в критерий: {lengthBetweenPointAndMeanPoint} < {closing / PT_CONSTANTS.FIRST}");
                    else
                    {
                        log($"✕ Расстояние от пункта {i + 1} до центра тяжести не входит в критерий: {lengthBetweenPointAndMeanPoint} > {closing / PT_CONSTANTS.FIRST}");
                        firstCriterion = false;
                    }
                }

                if (firstCriterion)
                    log($"✓ Первый критерий выполняется");
                else
                    log($"✕ Первый критерий не выполняется");
                newLine();


                //Second
                log("Второй критерий:");
                double closingDirectionAngle = directionAngle(getFirstPoint(), getLastPoint());
                log($"Дирекционный угол хода: {closingDirectionAngle}");
                for (int i = 1; i < points.Count; i++)
                {
                    double directionAngleTwoPoints = directionAngle(points[i - 1], points[i]);
                    double diff = Math.Abs(directionAngleTwoPoints - closingDirectionAngle);
                    if (diff <= PT_CONSTANTS.SECOND)
                        log($"✓ Угол между стороной {i}-{i + 1} и замыкающей входит в критерий: {diff} < {PT_CONSTANTS.SECOND}");
                    else
                    {
                        log($"✕ Угол между стороной {i}-{i + 1} и замыкающей не входит в критерий: {diff} > {PT_CONSTANTS.SECOND}");
                        secondCriterion = false;
                    }
                }
                if (secondCriterion)
                    log($"✓ Второй критерий выполняется");
                else
                    log($"✕ Второй критерий не выполняется");
                newLine();


                //Third
                if (lengthTravers / closing <= PT_CONSTANTS.THIRD)
                {
                    log($"✓ Третий критерий выполняется: {(lengthTravers / closing)} < {PT_CONSTANTS.THIRD}");
                    thirdCriterion = true;
                }
                else log($"✕ Третий критерий не выполняется: {(lengthTravers / closing)} > {PT_CONSTANTS.THIRD}");
                newLine();

                //Ending 
                List<double> msSum = new List<double>();
                for (int i = 0; i < lengthSides.Count; i++)
                    msSum.Add(Math.Pow(PT_CONSTANTS.ACCURACY_LENGTH_FIRST + PT_CONSTANTS .ACCURACY_LENGTH_SECOND * lengthSides[i] / 1000, 2));
                double ms = msSum.Sum() / 1000;

                if (firstCriterion && secondCriterion && thirdCriterion)
                {
                    log($"Все критерии выполнены. Ход вытянутый");
                    newLine();
                    double squareM = ms + Math.Pow(PT_CONSTANTS.ACCURACY_ANGLE, 2) / Math.Pow(R, 2) * Math.Pow(closing, 2) * (lengthSides.Count + 3) / 12;
                    double M = Math.Sqrt(squareM);
                    log($"Ожидаемая СКО в положении конечной точки вытянутого хода M = {M}м (M^2 = {squareM})");
                    log($"Предельная относительная невязка хода равна 1:{1 / (2 * M / lengthTravers)}");
                }
                else
                {
                    log($"Не все критерии были выполнены. Ход изогнутый");
                    newLine();
                    double squareM = ms + Math.Pow(PT_CONSTANTS.ACCURACY_ANGLE, 2) * lenghtInSquare / Math.Pow(R, 2);
                    double M = Math.Sqrt(squareM);
                    log($"Ожидаемая СКО в положении конечной точки изогнутого хода M = {M}м (M^2 = {squareM})");
                    log($"Предельная относительная невязка хода равна 1:{1 / (2 * M / lengthTravers)}");
                }
                newLine();
                log("<---Конец вычислений--->");
            }
            catch
            {
                MessageBox.Show("Проверьте данные", "Расчёт полигонометрического хода");
            }
        }

        void log(string outputText)
        {
            Output.Text += outputText + Environment.NewLine;
        }
        void newLine()
        {
            Output.Text += Environment.NewLine;
        }

        Point getFirstPoint() => points[0];

        Point getLastPoint() => points[points.Count - 1];

        private void RefreshTraverse_Click(object sender, EventArgs e)
        {
            if (selectedPolyTraverse != null)
            {
                Coordinates.Rows.Clear();
                int countVerticies = selectedPolyTraverse.NumberOfVertices;
                for (int i = 0; i < countVerticies; i++)
                {
                    Point2d currentPoint = selectedPolyTraverse.GetPoint2dAt(i);
                    Coordinates.Rows.Add(currentPoint.X, currentPoint.Y);
                }

                calculate();
            }
            else
                MessageBox.Show("Ход был удалён", "Расчёт полигонометрического хода");
        }

        double perpendicularPointToLine(Point point, Point firstPointLine, Point secondPointLine)
        {
            double A = firstPointLine.y - secondPointLine.y;
            double B = secondPointLine.x - firstPointLine.x;
            double C = firstPointLine.x * secondPointLine.y - secondPointLine.x * firstPointLine.y;
            return Math.Abs(A * point.x + B * point.y + C) / Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)); 
        }

        double directionAngle(Point firstPoint, Point secondPoint)
        {
            double dx = secondPoint.y - firstPoint.y;
            double dy = secondPoint.x - firstPoint.x;
            double rumb = Math.Atan(Math.Abs(dy / dx)) * 180 / Math.PI;

            if (dx > 0 && dy > 0)
                return rumb;
            else if (dx < 0 && dy > 0)
                return 180 - rumb;
            else if (dx < 0 && dy < 0)
                return rumb + 180;
            else if (dx > 0 && dy < 0)
                return 360 - rumb;
            else if (dx == 0) {
                if (dy > 0) return 90;
                else if (dy < 0) return 270;
            }
            else if(dy == 0) {
                if (dx > 0) return 0;
                else if (dx < 0) return 180;
            }
            
            return 0;
        }

        private void Curvature_Click(object sender, EventArgs e)
        {
            CurvatureForm curvatureForm = new CurvatureForm();
            curvatureForm.First.Text = PT_CONSTANTS.FIRST.ToString();
            curvatureForm.Second.Text = PT_CONSTANTS.SECOND.ToString();
            curvatureForm.Third.Text = PT_CONSTANTS.THIRD.ToString();
            curvatureForm.ShowDialog();
        }

        private void Tool_Click(object sender, EventArgs e)
        {
            AccuracyToolForm accuracyToolForm = new AccuracyToolForm();
            accuracyToolForm.AccuracyAngle.Text = PT_CONSTANTS.ACCURACY_ANGLE.ToString();
            accuracyToolForm.AccuracyLengthFirst.Text = PT_CONSTANTS.ACCURACY_LENGTH_FIRST.ToString();
            accuracyToolForm.AccuracyLengthSecond.Text = PT_CONSTANTS.ACCURACY_LENGTH_SECOND.ToString();
            accuracyToolForm.ShowDialog();
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }

    public class Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double distance(Point other) => Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2));
    }
}
