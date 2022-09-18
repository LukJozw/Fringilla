using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fringilla
{
    public partial class MainForm : Form
    {
        private OpenFileDialog ofd;

        // Global variables
        public Bitmap bmpOriginal;
        public Bitmap bmpGrey;
        public Bitmap bmpSwirl;

        public Graphics gLineBckg;
        public Graphics gLineFilm;

        // Main Window load Form and constructor
        private void MainForm_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*bmp) | *.bmp";
            ofd.DefaultExt = "bmp";
            if(Fringilla.Properties.Settings.Default.dirBitmap != string.Empty)
            {
                ofd.InitialDirectory = Fringilla.Properties.Settings.Default.dirBitmap;
            }
            //ofd.AddExtension = true;
        }
        private void SetInitialValues()
        {
            ToolStripMessageSend("Hello There :), my name is Fringilla. Choose the >Tools< and load bitmap to start");
            Fringilla.Properties.Settings.Default.fLoadBMP = false;
            angleUpDown.Enabled = false;
            trackLineY.Enabled = false;
            trackLineX.Enabled = false;
            lineLenUpDown.Enabled = false;

            gLineBckg = mapPointPanel.CreateGraphics();
            gLineBckg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gLineFilm = mapPointPanel.CreateGraphics();
            gLineFilm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
        private void RichTextBoxLines(RichTextBox box, int lines)
        {
            for (int i = lines; i > 0; i--)
            {
                box.AppendText(System.Environment.NewLine);
            }
        }
        public void CanvasClear(Graphics drawingArea)
        {
            drawingArea.Clear(Color.Transparent);
            //this.Invalidate();
        }
        private void RichTextBoxLineInsert(RichTextBox box, int position, string lineText, Boolean add)
        {
            string[] lines = box.Lines;
            if (add)
            {

                lines[position] += lineText;
            }
            else
            {
                lines[position] = lineText;
            }
            box.Lines = lines;
        }
        private Boolean IfTextBoxLineIsEmpty(RichTextBox box, int line)
        {
            string[] lines = box.Lines;
            if (lines[line] == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean ifRtBoxContainCoord(RichTextBox box, int line, int coordinate)
        {
            string[] lines = box.Lines;
            if (lines[line].Contains(Convert.ToString(coordinate)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int[] GetIntArrayFromRtbLine(RichTextBox box, int line, char splitter)
        {
            string[] lines = box.Lines;
            string[] stringVal = lines[line].Split(splitter);
            int[] intVal = Array.ConvertAll(stringVal, s => int.TryParse(s, out var x) ? x : -1);
            return intVal;
        }
        private string[] GetStringArrayFromRtbLine(RichTextBox box, int line, char splitter)
        {
            string[] lines = box.Lines;
            string[] stringVal = lines[line].Split(splitter);
            return stringVal;
        }
        private void ToolStripMessageSend(string msg)
        {
            toolStripStatusLabel.Text = "Fringilla: " + msg;
        }
        private void CanvasClear()
        {
            mapPointPanel.InvalidateEx();
            //mapPointPanel.Invalidate();
        }
        private double[,] SeriesIntoArray(Chart chart, int area, int serie)
        {
            ChartArea ca = chart.ChartAreas[area];
            int vectorLength = (int)chart.ChartAreas[area].AxisX.Maximum - (int)chart.ChartAreas[area].AxisX.Minimum;
            double[,] ans = new double[2, vectorLength];

            for (int i = 0; i < vectorLength; i++)
            {
                ans[0, i] = chart.Series[serie].Points[i].XValue;
                ans[1, i] = chart.Series[serie].Points[i].YValues[0];
            }

            return ans;
        }

        public MainForm()
        {
            InitializeComponent();
            SetInitialValues();
        }
        // General Functions

        private void LineSelectRefresh(Point coordinates)
        {
            Graphics paper = mapPointPanel.CreateGraphics();

            if (rbZero.Checked == true)
            {
                int alphaCounterBckg = Fringilla.Properties.Settings.Default.noZeroBckg;
                int alphaCounterFilm = Fringilla.Properties.Settings.Default.noZeroFilm;
                // cannot be empty co default is Bckg
                Color penColor = Color.Red;
                Chart chart = chartBckg;
                // coordinates of line and zero-order point in richTextBox 
                int rtbCoord = 10;
                int rtb0ord = 12;


                if (panelBckg.BackColor == Color.PaleGoldenrod && alphaCounterBckg != 0)
                {
                    // all data on chartBckg
                    chart = chartBckg;
                    // specific setup for 0-order mark for Bckg
                    penColor = Color.Red;
                    // coordinates of Bckg line and 0-ord point
                    rtbCoord = 10;
                    rtb0ord = 12;
                }
                if (panelFilm.BackColor == Color.PaleGoldenrod && alphaCounterFilm != 0)
                {
                    // all data on chartBckg
                    chart = chartFilm;
                    // specific setup for 0-order mark for Film
                    penColor = Color.Orange;
                    // coordinates of Film line and 0-ord point
                    rtbCoord = 17;
                    rtb0ord = 19;
                }

                // before the point of mark will be aded the alligning method will be undertaken
                // copying points from the XYChart of filterred values upper are X lower are Y
                double[,] data = SeriesIntoArray(chart, 0, 1);
                // preparing data into two separated vectors for next procedure
                double[] xValues = new double[data.Length / 2];
                double[] yValues = new double[data.Length / 2];

                for (int j = 0; j < data.Length / 2; j++)
                {
                    xValues[j] = data[0, j];
                    yValues[j] = data[1, j];
                }
                // now I will find indexes of maximum values
                double[] maxInd = UserMathFringes.FindMaxIndexes(xValues, yValues, Fringilla.Properties.Settings.Default.filterLength);
                double[] diffs = new double[maxInd.Length];
                // checking the coordinate.X because coordinate.Y is on the line
                int i = 0;
                foreach (int index in maxInd)
                {
                    diffs[i] = (int)Math.Abs((xValues[index] / Fringilla.Properties.Settings.Default.xFactor) - coordinates.X);
                    i++;
                }
                i = Array.IndexOf(diffs, (int)diffs.Min());
                // and adding of alligned point (the 0-order point in this case
                // as was mentioned the y coordinate is on the line

                // depending of choosen chart
                if (panelBckg.BackColor == Color.PaleGoldenrod && alphaCounterBckg != 0)
                {
                    if (IfTextBoxLineIsEmpty(richTextBox, rtbCoord))
                    {
                        // do nothing
                    }
                    else
                    {
                        Point coords = new Point();

                        string[] lines = richTextBox.Lines;
                        string[] coordsD = lines[rtbCoord].Split(':');

                        coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                        coordinates.Y = coords.Y;
                    }
                }

                if (panelFilm.BackColor == Color.PaleGoldenrod && alphaCounterFilm != 0)
                {
                    if (IfTextBoxLineIsEmpty(richTextBox, rtbCoord))
                    {
                        // do nothing
                    }
                    else
                    {
                        Point coords = new Point();

                        string[] lines = richTextBox.Lines;
                        string[] coordsD = lines[rtbCoord].Split(':');

                        coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                        coordinates.Y = coords.Y;
                    }
                }
                // Now the full corect of coorditates
                coordinates = new Point((int)(xValues[(int)maxInd[i]] / Fringilla.Properties.Settings.Default.xFactor), coordinates.Y);
                // Draw the mark
                PictureTools.DrawMeCircle(paper, coordinates, penColor, 2, 4);

                if (chart.Series.Count == 2)
                {
                    chart.Series.Add("0-order");
                    chart.Series[2].ChartArea = "ChartArea1";
                    chart.Series[2].MarkerColor = Color.Navy;
                    chart.Series[2].MarkerSize = 10;
                    chart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                    chart.Series[2].Points.AddXY(xValues[(int)maxInd[i]], yValues[(int)maxInd[i]]);
                    chart.Update();
                }

                // Give feedback to richTextBox
                RichTextBoxLineInsert(richTextBox, rtb0ord, $"0-order X position: {xValues[(int)maxInd[i]]}",false);
                // Draw the marks
                PictureTools.DrawMeCircle(paper, coordinates, penColor, 2, 4);

                ToolStripMessageSend($"X position: {coordinates.X}, Y position: {coordinates.Y}");
                if (panelBckg.BackColor == Color.PaleGoldenrod)
                {
                    alphaCounterBckg--;
                    Fringilla.Properties.Settings.Default.noZeroBckg = alphaCounterBckg;
                }
                if (panelFilm.BackColor == Color.PaleGoldenrod)
                {
                    alphaCounterFilm--;
                    Fringilla.Properties.Settings.Default.noZeroFilm = alphaCounterFilm;
                }

                if (Fringilla.Properties.Settings.Default.noZeroBckg == 0 && Fringilla.Properties.Settings.Default.noZeroFilm == 0)
                {
                    ToolStripMessageSend("Now mark all visible maxima to find a distance.");
                    Fringilla.Properties.Settings.Default.flagOrder = true;
                }
            }

            if (rbDist.Checked == true)
            {
                // cannot be empty co default is Bckg
                Color penColor = Color.Red;
                Chart chart = chartBckg;
                // coordinates of line and zero-order point in richTextBox 
                int rtbCoord = 10;
                int rtbDist = 12;


                if (panelBckg.BackColor == Color.PaleGoldenrod)
                {
                    // all data on chartBckg
                    chart = chartBckg;
                    // specific setup for 0-order mark for Bckg
                    penColor = Color.DarkRed;
                    // coordinates of Bckg line and 0-ord point
                    rtbCoord = 10;
                    rtbDist = 13;   // rtbDistBckg = 13;
                }
                if (panelFilm.BackColor == Color.PaleGoldenrod)
                {
                    // all data on chartBckg
                    chart = chartFilm;
                    // specific setup for 0-order mark for Film
                    penColor = Color.DarkOrange;
                    // coordinates of Film line and 0-ord point
                    rtbCoord = 17;
                    rtbDist = 20;   // rtbDistFilm = 20;
                }

                // To determine distance, next again we must found the local maxima
                // copying points from the XYChart of filterred values upper are X lower are Y
                double[,] data = SeriesIntoArray(chart, 0, 1);
                // preparing data into two separated vectors for next procedure
                double[] xValues = new double[data.Length / 2];
                double[] yValues = new double[data.Length / 2];

                for (int j = 0; j < data.Length / 2; j++)
                {
                    xValues[j] = data[0, j];
                    yValues[j] = data[1, j];
                }
                // now I will find indexes of maximum values
                double[] maxInd = UserMathFringes.FindMaxIndexes(xValues, yValues, Fringilla.Properties.Settings.Default.filterLength);
                double[] diffs = new double[maxInd.Length];

                // checking the coordinate.X because coordinate.Y is on the line
                int indexNearest = 0;
                foreach (int index in maxInd)
                {
                    diffs[indexNearest] = (int)Math.Abs((xValues[index] / Fringilla.Properties.Settings.Default.xFactor) - coordinates.X);
                    indexNearest++;
                }
                indexNearest = Array.IndexOf(diffs, (int)diffs.Min());

                // and adding of alligned point (the 0-order point in this case
                // as was mentioned the y coordinate is on the line
                if (panelBckg.BackColor == Color.PaleGoldenrod)
                {
                    if (chart.Series.Count == 3)
                    {
                        chart.Series.Add("Distance");
                        chart.Series[3].ChartArea = "ChartArea1";
                        chart.Series[3].MarkerColor = Color.DarkGreen;
                        chart.Series[3].MarkerSize = 7;
                        chart.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                        chart.Series[3].Points.AddXY(xValues[(int)maxInd[indexNearest]], yValues[(int)maxInd[indexNearest]]);
                        chart.Update();

                        RichTextBoxLineInsert(richTextBox, rtbDist, $"Distance points X position; {xValues[(int)maxInd[indexNearest]]}", false);
                        Fringilla.Properties.Settings.Default.noDistBckg = maxInd.Length;
                    }
                    else
                    {
                        if (Fringilla.Properties.Settings.Default.noDistBckg != 0)
                        {
                            if (ifRtBoxContainCoord(richTextBox, rtbDist, (int)xValues[(int)maxInd[indexNearest]]))
                            {
                                ToolStripMessageSend("The point was already choosen, pick another");
                            }
                            else
                            {
                                chart.Series[3].Points.AddXY(xValues[(int)maxInd[indexNearest]], yValues[(int)maxInd[indexNearest]]);
                                chart.Update();

                                RichTextBoxLineInsert(richTextBox, rtbDist, $"; {xValues[(int)maxInd[indexNearest]]}", true);
                                
                            }
                        }
                    }
                    
                    Fringilla.Properties.Settings.Default.fDraw = true;
                }            
                if (panelFilm.BackColor == Color.PaleGoldenrod)
                {
                    if (chart.Series.Count == 3)
                    {
                        chart.Series.Add("Distance");
                        chart.Series[3].ChartArea = "ChartArea1";
                        chart.Series[3].MarkerColor = Color.DarkGreen;
                        chart.Series[3].MarkerSize = 7;
                        chart.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                        chart.Series[3].Points.AddXY(xValues[(int)maxInd[indexNearest]], yValues[(int)maxInd[indexNearest]]);
                        chart.Update();

                        RichTextBoxLineInsert(richTextBox, rtbDist, $"Distance points X position; {xValues[(int)maxInd[indexNearest]]}", false);
                        Fringilla.Properties.Settings.Default.noDistFilm = maxInd.Length;
                    }
                    else
                    {
                        if (Fringilla.Properties.Settings.Default.noDistFilm != 0)
                        {
                            if(ifRtBoxContainCoord(richTextBox,rtbDist, (int)xValues[(int)maxInd[indexNearest]]))
                            {
                                ToolStripMessageSend("The point was already choosen, pick another");
                            }
                            else
                            {
                                chart.Series[3].Points.AddXY(xValues[(int)maxInd[indexNearest]], yValues[(int)maxInd[indexNearest]]);
                                chart.Update();

                                RichTextBoxLineInsert(richTextBox, rtbDist, $"; {xValues[(int)maxInd[indexNearest]]}", true);
                            }
                        }        
                    }

                    Fringilla.Properties.Settings.Default.fDraw = true;
                }
            
                if(panelBckg.BackColor == Color.PaleGoldenrod && Fringilla.Properties.Settings.Default.noDistBckg > 0 && Fringilla.Properties.Settings.Default.fDraw == true)
                {
                    // Take the coordinate Y from line (rtb)
                    Point coords = new Point();

                    string[] lines = richTextBox.Lines;
                    string[] coordsD = lines[rtbCoord].Split(':');

                    coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                    coordinates.Y = coords.Y;

                    // Now the full corect of coorditates
                    coordinates = new Point((int)(xValues[(int)maxInd[indexNearest]] / Fringilla.Properties.Settings.Default.xFactor), coordinates.Y);
                    // Draw the mark
                    PictureTools.DrawMeCircle(paper, coordinates, penColor, 2, 4);

                    Fringilla.Properties.Settings.Default.noDistBckg--;
                    Fringilla.Properties.Settings.Default.fDraw = false;
                }
                if(panelFilm.BackColor == Color.PaleGoldenrod && Fringilla.Properties.Settings.Default.noDistFilm > 0 && Fringilla.Properties.Settings.Default.fDraw == true)
                {
                    // Take the coordinate Y from line (rtb)
                    Point coords = new Point();

                    string[] lines = richTextBox.Lines;
                    string[] coordsD = lines[rtbCoord].Split(':');

                    coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                    coordinates.Y = coords.Y;

                    // Now the full corect of coorditates
                    coordinates = new Point((int)(xValues[(int)maxInd[indexNearest]] / Fringilla.Properties.Settings.Default.xFactor), coordinates.Y);
                    // Draw the mark
                    PictureTools.DrawMeCircle(paper, coordinates, penColor, 2, 4);

                    Fringilla.Properties.Settings.Default.noDistFilm--;
                    Fringilla.Properties.Settings.Default.fDraw = false;
                }
                
                // flagDistance condition
                if(chartBckg.Series.Count == 4 && chartFilm.Series.Count == 4)
                {
                    // on the beginning of this program section all Counters are 0 so setting the flag conditions only bsed on this, caused error
                    if(Fringilla.Properties.Settings.Default.noDistBckg == 0 && Fringilla.Properties.Settings.Default.noDistFilm == 0)
                    {
                        Fringilla.Properties.Settings.Default.flagDistance = true;
                    }
                } 

                if (Fringilla.Properties.Settings.Default.flagOrder && Fringilla.Properties.Settings.Default.flagDistance)
                {
                    int rtbDistBckg = 13;
                    int rtbDistFilm = 20;

                    int[] distBckg0 = GetIntArrayFromRtbLine(richTextBox, rtbDistBckg, ';');
                    int[] distFilm0 = GetIntArrayFromRtbLine(richTextBox, rtbDistFilm, ';');

                    int[] orderBckg = GetIntArrayFromRtbLine(richTextBox, 12, ':');
                    int[] orderFilm = GetIntArrayFromRtbLine(richTextBox, 19, ':');

                    int[] distBckg = new int[distBckg0.Length - 1];
                    int[] distFilm = new int[distFilm0.Length - 1];

                    int j = 0;
                    for(int i = 1; i < distBckg0.Length; i++)
                    {
                        distBckg[j] = distBckg0[i];
                        j++;
                    }

                    j = 0;
                    for (int i = 1; i < distFilm0.Length; i++)
                    {
                        distFilm[j] = distFilm0[i];
                        j++;
                    }

                    Array.Sort(distBckg);
                    Array.Sort(distFilm);

                    double sd = 0;
                    double sd0 = 0;

                    int k = 0;

                    for(int i = (distBckg.Length - 1); i > 0; i--)
                    {
                        sd = sd + ((double)distBckg[i] - (double)distBckg[i - 1]);
                        k++;
                    }
                    sd /= k;

                    k = 0;
                    for (int i = (distFilm.Length-1); i > 0; i--)
                    {
                        sd0 = sd0 + ((double)distFilm[i] - (double)distFilm[i - 1]);
                        k++;
                    }
                    sd0 /= k;

                    sd = Math.Round(sd, 1);
                    sd0 = Math.Round(sd0, 1);

                    double l = (sd + sd0) / 2;
                    double z = Math.Abs(orderBckg[1] - orderFilm[1]);
                    int n = (int)z / (int)l;
                    double lambda = 0;
                    
                    // set lambda
                    if(Fringilla.Properties.Settings.Default.fBmpColor == true)
                    {
                        lambda = (double)Fringilla.Properties.Settings.Default.wavePoly;
                    }
                    else
                    {
                        lambda = (double)Fringilla.Properties.Settings.Default.waveMono;
                    }

                    double thickness = Math.Round((n * (lambda / 2)) + ((z / l) * (lambda / 2)), 1);

                    string[] lines = richTextBox.Lines;
                
                    lines[22] = $"Average distance: {l} ; Bckg - {sd} ; Film - {sd0}";
                    lines[23] = $"0 order shift: {z} ; n - {n} ; Lambda - {lambda}";
                    lines[24] = $"Thickness: {thickness} nm";

                    richTextBox.Lines = lines;
                    label4.ForeColor = Color.Red;
                    label4.Text = $"{thickness} nm";
                }
            }

            
        }
        private void LineSelectRefresh()
        {

            if (rbLine.Checked == true)      // if line mode was choosen
            {
                // corrected value of trackLine
                int trackFlipValY = trackLineY.Maximum - trackLineY.Value + trackLineY.Minimum;
                Point coordinates = new Point(trackLineX.Value, trackFlipValY);

                int lineLength = (int)lineLenUpDown.Value;

                if (lineLength % 2 == 0)
                {
                    // lineLength is even - do nothing
                }
                else
                {
                    lineLength--;   // lineLength is odd and must be 1 point shorter, it's safer
                }

                // Including initial correction due to bonding conditions and error avoiding (done at pictureBox level)
                if (coordinates.X < (0.5 * lineLength))
                {
                    // left condition
                    ToolStripMessageSend($"Warning ! The X position: {coordinates.X} is too low.");
                    coordinates.X = (int)((0.5 * lineLength) + 1);
                    trackLineX.Value = coordinates.X;   // move line right
                }
                else
                {
                    ToolStripMessageSend($"X position: {coordinates.X}, Y position: {coordinates.Y}");
                }

                if (coordinates.X > (mainPictureBox.Width - (0.5 * lineLength)))
                {
                    //right condition
                    ToolStripMessageSend($"Warning ! The X position: {coordinates.X} is too high.");
                    coordinates.X = (int)(mainPictureBox.Width - (0.5 * lineLength));
                    trackLineX.Value = coordinates.X;   // move line left
                }
                else
                {
                    ToolStripMessageSend($"X position: {coordinates.X}, Y position: {coordinates.Y}");
                }

                // Including correction from scaled image settled in pictureBox to real HiRes bitmap
                int corrCoorX = (int)(Fringilla.Properties.Settings.Default.xFactor * coordinates.X);
                int corrCoorY = (int)(Fringilla.Properties.Settings.Default.yFactor * coordinates.Y);
                int corrLength = (int)(Fringilla.Properties.Settings.Default.xFactor * lineLength);

                int startX = (int)(corrCoorX - (0.5 * corrLength));
                int endX = (int)(corrCoorX + (0.5 * corrLength));

                // initial conditions to start the chain
                if (Fringilla.Properties.Settings.Default.fLoadBMP == true && bmpSwirl != null)
                {
                    // FIRST STAGE - Angle was not settled yet
                    if (rbLine.Checked == true)
                    {
                        // line buffer for data vector and its indexer
                        double[] lineVector = new double[corrLength];
                        double[] xVector = new double[corrLength];
                        int j = 0;

                        // declaration of coefficients and defaultly set to greyscale
                        decimal convRed = 1;
                        decimal convGreen = 1;
                        decimal convBlue = 1;

                        if (Fringilla.Properties.Settings.Default.fBmpColor == true)
                        {
                            convRed = Fringilla.Properties.Settings.Default.redCoefficient;
                            convGreen = Fringilla.Properties.Settings.Default.greenCoefficient;
                            convBlue = Fringilla.Properties.Settings.Default.blueCoefficient;

                            RichTextBoxLineInsert(richTextBox, 6, $"Color conversion coefficients; R:{convRed}, G:{convGreen}, B:{convBlue}", false);
                        }
                        else
                        {
                            RichTextBoxLineInsert(richTextBox, 6, $"Color conversion coefficients; not used", false);
                        }

                        for (int i = startX; i < endX; i++)         // preparing lineVector
                        {
                            Color oc = bmpSwirl.GetPixel(i, corrCoorY);
                            double grayScale = (double)((oc.R * convRed) + (oc.G * convGreen) + (oc.B * convBlue));
                            lineVector[j] = grayScale;
                            xVector[j] = (double)i;
                            j++;
                        }

                        var chart = chartBckg;

                        int penWidth = 2;

                        if (panelBckg.BackColor == Color.PaleGoldenrod)
                        {
                            // marker sets for line selection
                            Color penColor = Color.PaleVioletRed;
                            Pen lineSelectPen = new Pen(penColor, penWidth);
                            PictureTools.DrawMeAim(gLineBckg, coordinates, lineSelectPen, lineLength);

                            chart = chartBckg;
                            chart.Series[0].Color = Color.PaleVioletRed;

                            string[] lines = richTextBox.Lines;
                            lines[8] = "--- Background line parameters -----";

                            lines[10] = $"Center coordinates; X: {coordinates.X} Y: {coordinates.Y}";
                            lines[11] = $"Line length: {lineLength}";
                            richTextBox.Lines = lines;

                            if (lines[17] != string.Empty && lines[18] != string.Empty)
                            {
                                Graphics paper = mapPointPanel.CreateGraphics();
                                penWidth = 2;
                                Color penC = Color.PaleGreen;
                                Pen lineSelPen = new Pen(penC, penWidth);
                                Point coords = new Point();
                                int lineLen;
                                string[] coordsD = lines[17].Split(':');

                                coords.X = Convert.ToInt32(Regex.Match(coordsD[1], @"\d+").Value);
                                coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                                lineLen = Convert.ToInt32(Regex.Match(lines[18], @"\d+").Value);

                                PictureTools.DrawMeAim(gLineFilm, coords, lineSelPen, lineLen);
                            }
                        }
                        if (panelFilm.BackColor == Color.PaleGoldenrod)
                        {
                            // marker sets for line selection
                            Color penColor = Color.PaleTurquoise;
                            Pen lineSelectPen = new Pen(penColor, penWidth);
                            PictureTools.DrawMeAim(gLineFilm, coordinates, lineSelectPen, lineLength);

                            chart = chartFilm;
                            chart.Series[0].Color = Color.PaleGreen;

                            string[] lines = richTextBox.Lines;
                            lines[15] = "--- Film line parameters -----------";

                            lines[17] = $"Center coordinates; X: {coordinates.X} Y: {coordinates.Y}";
                            lines[18] = $"Line length: {lineLength}";
                            richTextBox.Lines = lines;

                            if (lines[10] != string.Empty && lines[11] != string.Empty)
                            {
                                Graphics paper = mapPointPanel.CreateGraphics();
                                penWidth = 2;
                                Color penC = Color.PaleVioletRed;
                                Pen lineSelPen = new Pen(penC, penWidth);
                                Point coords = new Point();
                                int lineLen;
                                string[] coordsD = lines[10].Split(':');

                                coords.X = Convert.ToInt32(Regex.Match(coordsD[1], @"\d+").Value);
                                coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                                lineLen = Convert.ToInt32(Regex.Match(lines[11], @"\d+").Value);

                                PictureTools.DrawMeAim(gLineBckg, coords, lineSelPen, lineLen);
                            }
                        }

                        var objChart = chart.ChartAreas[0];
                        chart.Series.Clear();

                        objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                        objChart.AxisX.Minimum = startX;
                        objChart.AxisX.Maximum = endX;

                        objChart.AxisY.Minimum = lineVector.Min();
                        objChart.AxisY.Maximum = lineVector.Max();

                        // Preparing dataset for original lines
                        chart.Series.Add("Line");
                        chart.Series[0].ChartArea = "ChartArea1";
                        chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                        chart.Series[0].YValuesPerPoint = 1;

                        chart.Series[0].Points.DataBindXY(xVector, lineVector);
                        // preparing dataset for filtered line
                        double[] filterVector = new double[lineVector.Length];
                        filterVector = UserMathFringes.SGFilter(lineVector, Fringilla.Properties.Settings.Default.filterLength, Fringilla.Properties.Settings.Default.filterLoops, 4);

                        chart.Series.Add("Filtered");

                        if (panelBckg.BackColor == Color.PaleGoldenrod) { chart.Series[1].Color = Color.Red; }
                        if (panelFilm.BackColor == Color.PaleGoldenrod) { chart.Series[1].Color = Color.Red; }

                        chart.Series[1].ChartArea = "ChartArea1";
                        chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

                        chart.Series[1].Points.DataBindXY(xVector, filterVector);
                    }
                }
            }

        }

        // Component Functions
        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout newForm = new FormAbout();
            newForm.Show();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm();
            newForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)        // The zero stage
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bmpOriginal = new Bitmap(ofd.FileName);
                toolStripStatusLabelFile.Text = $"      Actual file: {ofd.FileName}";

                Fringilla.Properties.Settings.Default.fBmpColor = PictureTools.IsPictureIsColor(bmpOriginal);        // color flag stored in settings

                if (Fringilla.Properties.Settings.Default.fBmpColor == true)
                {
                    ToolStripMessageSend("Color picture loaded !!!");
                }
                else
                {
                    ToolStripMessageSend("Greyscale picture loaded !!!");
                }

                // if the file was never loaded before
                if (Fringilla.Properties.Settings.Default.fLoadBMP == false)
                {
                    SetInitialValues();

                    // Setting trackBars properties
                    trackLineY.Enabled = true;
                    trackLineY.Minimum = 0;
                    trackLineY.Maximum = mainPictureBox.Height;
                    trackLineY.Value = (int)(0.5 * mainPictureBox.Height);

                    trackLineX.Enabled = true;
                    trackLineX.Minimum = 0;
                    trackLineX.Maximum = mainPictureBox.Width;
                    trackLineX.Value = (int)(0.5 * mainPictureBox.Width);

                    // Setting lineLenght UpDown
                    lineLenUpDown.Enabled = true;
                    lineLenUpDown.Maximum = mainPictureBox.Width;
                    lineLenUpDown.Minimum = 0;
                    lineLenUpDown.Value = (decimal)(0.8 * mainPictureBox.Width);

                    // Enabling controlls for next step
                    angleUpDown.Enabled = true;
                    panelProcessing.Enabled = true;

                    // setting picture
                    PictureTools.UpdateImageWindow(mainPictureBox, bmpOriginal);
                }
                else
                {
                    // in case of re-opening bmp
                    if (bmpSwirl != null)
                    {
                        // setting fast mounted swirl from new bmpOriginal
                        bmpSwirl = new Bitmap(PictureTools.RotateImage(bmpOriginal, (float)angleUpDown.Value));
                        PictureTools.UpdateImageWindow(mainPictureBox, bmpSwirl);
                        // and prompt to line select stage
                        CanvasClear();
                        LineSelectRefresh();
                    }
                    else
                    {
                        // setting picture
                        PictureTools.UpdateImageWindow(mainPictureBox, bmpOriginal);
                    }
                }

                // convert factor of original bitmap to imageBox window
                Fringilla.Properties.Settings.Default.xFactor = (float)bmpOriginal.Width / (float)mainPictureBox.Width;
                Fringilla.Properties.Settings.Default.yFactor = (float)bmpOriginal.Height / (float)mainPictureBox.Height;

                // setting load flag to true
                Fringilla.Properties.Settings.Default.fLoadBMP = true;          // settling 0-step acomplished flag

                panelBckg.BackColor = Color.PaleGoldenrod;
                rbLine.Checked = true;

                // preparing of richTextBox and output stream header status

                richTextBox.Clear();
                RichTextBoxLines(richTextBox, 24);
                label4.Text = "";
                Fringilla.Properties.Settings.Default.flagDistance = false;

                string[] lines = richTextBox.Lines;

                lines[0] = "Sumary of input data";
                lines[1] = "------------------------------------";

                lines[3] = $"Target: {Path.GetFileName(ofd.FileName)}";

                if (Fringilla.Properties.Settings.Default.fBmpColor == true)    // depend on flag color or grey
                {
                    lines[4] = "BMP type: color";
                }
                else
                {
                    lines[4] = "BMP type: grey";
                }
                richTextBox.Lines = lines;
                LineSelectRefresh();
            }
        }

        // second stage
        private void trackLineY_Scroll(object sender, EventArgs e)
        {
            CanvasClear();
        }
        private void trackLineX_Scroll(object sender, EventArgs e)
        {
            CanvasClear();
        }
        private void lineLenUpDown_ValueChanged(object sender, EventArgs e)
        {
            CanvasClear();
        }
        private void trackLineY_MouseUp(object sender, MouseEventArgs e)
        {
            LineSelectRefresh();
        }
        private void trackLineX_MouseUp(object sender, MouseEventArgs e)
        {
            LineSelectRefresh();
        }
        private void lineLenUpDown_MouseUp(object sender, MouseEventArgs e)
        {
            LineSelectRefresh();
        }
        private void angleUpDown_MouseUp(object sender, MouseEventArgs e)
        {
            LineSelectRefresh();
        }
        private void angleUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Fringilla.Properties.Settings.Default.fLoadBMP == true)
            {
                CanvasClear();

                float angleRot = (float)angleUpDown.Value;
                bmpSwirl = new Bitmap(PictureTools.RotateImage(bmpOriginal, angleRot));
                PictureTools.UpdateImageWindow(mainPictureBox, bmpSwirl);
                ToolStripMessageSend($"Picture rotate by: {angleRot}");

                //sending angle data into sumary
                RichTextBoxLineInsert(richTextBox, 5, $"Rotation angle: {angleRot}", false);

                Fringilla.Properties.Settings.Default.noZeroBckg = 1;
                Fringilla.Properties.Settings.Default.noZeroFilm = 1;

                rbLine.Checked = true;
                LineSelectRefresh();
            }
        }
        private void mapPointPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            LineSelectRefresh(coordinates);
        }
        private void chartBckg_Click(object sender, EventArgs e)
        {
            panelBckg.BackColor = Color.PaleGoldenrod;
            chartBckg.BackColor = Color.PaleGoldenrod;

            panelFilm.BackColor = Control.DefaultBackColor;
            chartFilm.BackColor = Control.DefaultBackColor;

            string[] lines = richTextBox.Lines;
            if (lines[10] != string.Empty && lines[11] != string.Empty)
            {
                int penWidth = 2;
                Color penC = Color.PaleVioletRed;
                Pen lineSelPen = new Pen(penC, penWidth);
                Point coords = new Point();
                int lineLen;
                string[] coordsD = lines[10].Split(':');

                coords.X = Convert.ToInt32(Regex.Match(coordsD[1], @"\d+").Value);
                coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                lineLen = Convert.ToInt32(Regex.Match(lines[11], @"\d+").Value);

                int trackFlipValY = trackLineY.Maximum - coords.Y + trackLineY.Minimum;
                trackLineY.Value = trackFlipValY;
                PictureTools.DrawMeAim(gLineBckg, coords, lineSelPen, lineLen);
            }

        }
        private void chartFilm_Click(object sender, EventArgs e)
        {
            panelFilm.BackColor = Color.PaleGoldenrod;
            chartFilm.BackColor = Color.PaleGoldenrod;

            panelBckg.BackColor = Control.DefaultBackColor;
            chartBckg.BackColor = Control.DefaultBackColor;

            string[] lines = richTextBox.Lines;
            if (lines[17] != string.Empty && lines[18] != string.Empty)
            {
                int penWidth = 2;
                Color penC = Color.PaleGreen;
                Pen lineSelPen = new Pen(penC, penWidth);
                Point coords = new Point();
                int lineLen;
                string[] coordsD = lines[17].Split(':');

                coords.X = Convert.ToInt32(Regex.Match(coordsD[1], @"\d+").Value);
                coords.Y = Convert.ToInt32(Regex.Match(coordsD[2], @"\d+").Value);
                lineLen = Convert.ToInt32(Regex.Match(lines[18], @"\d+").Value);

                int trackFlipValY = trackLineY.Maximum - coords.Y + trackLineY.Minimum;
                trackLineY.Value = trackFlipValY;
                PictureTools.DrawMeAim(gLineFilm, coords, lineSelPen, lineLen);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileDialogExport = new SaveFileDialog();

            string[] lines = GetStringArrayFromRtbLine(richTextBox, 3, ':');
            string[] filenameAndExt = lines[1].Split('.');
            string filename = filenameAndExt[0];
            string defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (Fringilla.Properties.Settings.Default.dirReport != string.Empty)
            {
                defaultFolder = Fringilla.Properties.Settings.Default.dirReport;
            }
     
            FileDialogExport.Title = "Select File";
            FileDialogExport.InitialDirectory = defaultFolder;
            FileDialogExport.Filter = "All files |*.*| Text File (*.txt)|*.txt";
            FileDialogExport.DefaultExt = "txt";
            FileDialogExport.FileName = filename;
            FileDialogExport.FilterIndex = 1;
            FileDialogExport.ShowDialog();

            if (FileDialogExport.FileName != "")
            {
                string patch = FileDialogExport.FileName;
                TextWriter writer = new StreamWriter(patch);

                writer.Write(richTextBox.Text);

                writer.Close();
            }
        }
    }
}
