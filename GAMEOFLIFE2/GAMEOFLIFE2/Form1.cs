using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GAMEOFLIFE2
{

    public partial class Form1 : Form
    {
        bool NeighborCheck = true;
        bool headsUpCheck = true;
        bool checkOn = true;
        int liveCells = 0;
        float width = 20;
        float height = 20;
        uint xLength = 20;
        uint yLength = 20;
        Random rng = new Random();
        // int seed = rng.Next();

        bool[,] universe = new bool[20, 20];
        bool[,] scratchPad = new bool[20, 20];
        Timer timer = new Timer();
        int generations = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Enabled = false;
            timer.Tick += Timer_Tick;
        }

        private void NextGeneration()
        {
            int NeighborCounter = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    NeighborCounter = GetNeighborFinite(x, y);
                    if (universe[x, y])
                    {
                        if (NeighborCounter == 2 || NeighborCounter == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                        else
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                    if (!universe[x, y])
                    {
                        if (NeighborCounter == 3)
                            scratchPad[x, y] = true;
                    }
                }
            }
            liveCells = 0;

            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                for (int x = 0; x < scratchPad.GetLength(0); x++)
                {
                    universe[x, y] = scratchPad[x, y];
                    if (universe[x, y])
                    {
                        liveCells++;
                    }
                }
            }
            generations++;
        }
        //CALCULATE THE NEXT GENERATION

        private int GetNeighborFinite(int x, int y)
        //WILL GET NUMBER OF NEIGHBORS
        {
            int FiniteNeighborCounter = 0;
            if (x - 1 >= 0 && x - 1 < xLength - 1)
                if (universe[x - 1, y])
                {
                    FiniteNeighborCounter++;
                }
            if (x - 1 >= 0 && x - 1 < xLength - 1 && y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x - 1, y - 1])
                {
                    FiniteNeighborCounter++;
                }
            if (x - 1 >= 0 && x - 1 < xLength - 1 && y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x - 1, y + 1])
                {
                    FiniteNeighborCounter++;
                }
            if (y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x, y - 1])
                {
                    FiniteNeighborCounter++;
                }
            if (y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x, y + 1])
                {
                    FiniteNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1)
                if (universe[x + 1, y])
                {
                    FiniteNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1 && y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x + 1, y - 1])
                {
                    FiniteNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1 && y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x + 1, y + 1])
                {
                    FiniteNeighborCounter++;
                }
            return FiniteNeighborCounter;
        }

        private int Toroidal(int x, int y)
        {
            int ToroidalNeighborCounter = 0;
            if (x - 1 >= 0 && x - 1 < xLength - 1)
                if (universe[x - 1, y])
                {
                    ToroidalNeighborCounter++;
                }
            if (x - 1 >= 0 && x - 1 < xLength - 1 && y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x - 1, y - 1])
                {
                    ToroidalNeighborCounter++;
                }
            if (x - 1 >= 0 && x - 1 < xLength - 1 && y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x - 1, y + 1])
                {
                    ToroidalNeighborCounter++;
                }
            if (y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x, y - 1])
                {
                    ToroidalNeighborCounter++;
                }
            if (y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x, y + 1])
                {
                    ToroidalNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1)
                if (universe[x + 1, y])
                {
                    ToroidalNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1 && y - 1 >= 0 && y - 1 < yLength - 1)
                if (universe[x + 1, y - 1])
                {
                    ToroidalNeighborCounter++;
                }
            if (x + 1 >= 0 && x + 1 < xLength - 1 && y + 1 >= 0 && y + 1 < yLength - 1)
                if (universe[x + 1, y + 1])
                {
                    ToroidalNeighborCounter++;
                }



            return ToroidalNeighborCounter;
        }
        //UNUSED

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            float width = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            float height = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);
            float x = e.X / width;
            float y = e.Y / height;
            universe[(int)x, (int)y] = !universe[(int)x, (int)y];
            if (universe[(int)x, (int)y])
            {
                liveCells++;
            }
            if (!universe[(int)x, (int)y])
            {
                liveCells--;
            }
            graphicsPanel1.Invalidate();
        }
        //WILL DRAW RECTANGLES TO THE PANEL

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            width = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            height = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    RectangleF rect = RectangleF.Empty;
                    rect.X = x * width;
                    rect.Y = y * height;
                    rect.Width = width;
                    rect.Height = height;

                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(Brushes.Gray, rect);
                    }

                    Font aFont = new Font("Times New Roman", 12);
                    StringFormat aFormat = new StringFormat();
                    aFormat.Alignment = StringAlignment.Center;
                    aFormat.LineAlignment = StringAlignment.Center;

                    if (NeighborCheck)
                    {

                        if (GetNeighborFinite(x, y) == 3)
                        {
                            e.Graphics.DrawString(GetNeighborFinite(x, y).ToString(), aFont, Brushes.DarkGreen, rect, aFormat);
                        }
                        else
                        {
                            e.Graphics.DrawString(GetNeighborFinite(x, y).ToString(), aFont, Brushes.Red, rect, aFormat);
                        }
                    }
                    else
                    {
                        // Draw Live Cells
                        if (universe[x, y] == true)
                        {
                            e.Graphics.FillRectangle(Brushes.Gray, rect);
                        }
                    }
                    if (!checkOn)
                    {
                        e.Graphics.DrawRectangle(Pens.White, rect.X, rect.Y, rect.Width, rect.Height);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
                    }
                }
            }
            CellsLabel.Text = "Cells: " + liveCells.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString();
        }
        //PAINTS THE RECTANGLES

        private void PlayButton_Click(object sender, EventArgs e)
        {
            nextButton.Visible = false;
            timer.Start();

            // CoLorDialog dlg = 
        }
        //STARTS THE GAME

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    scratchPad[x, y] = false;
                }
            }
            timer.Stop();
            generations = 0;
            liveCells = 0;
            GenerationsHeadup.Visible = true;
            cellCountHeadup.Visible = true;
            boundaryTypeHeadUp.Visible = true;
            UniverseSizeHeadUp.Visible = true;
            GenerationsHeadup.Text = "Generations: " + generations.ToString();
            statusStripGenerations.Text = "Generations: " + generations.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString();
          
           
            graphicsPanel1.Invalidate();
        }
        //CREATES A COMPLETELY NEW UNIVERSE FROM THE MENU STRIP

        private void pauseButton_Click(object sender, EventArgs e)
        {
            nextButton.Visible = true;
            timer.Stop();
        }
        //PAUSES THE GAME

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextGeneration();
            statusStripGenerations.Text = "Generations: " + generations.ToString();
            GenerationsHeadup.Text = "Generations: " + generations.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString();
            graphicsPanel1.Invalidate();
        }
        //ADVANCES THE UNIVERSE BY ONE GENERATION

        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
            statusStripGenerations.Text = "Generations: " + generations.ToString();
            GenerationsHeadup.Text = "Generations: " + generations.ToString();
            graphicsPanel1.Invalidate();
        }
        //WILL KEEP TRACK OF THE TIMER TICKS FOR THE GENERATIONS

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    scratchPad[x, y] = false;
                }
            }
            timer.Stop();
            generations = 0;
            liveCells = 0;
            GenerationsHeadup.Visible = true;
            cellCountHeadup.Visible = true;
            boundaryTypeHeadUp.Visible = true;
            UniverseSizeHeadUp.Visible = true;
            GenerationsHeadup.Text = "Generations: " + generations.ToString();
            statusStripGenerations.Text = "Generations: " + generations.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString(); 
            graphicsPanel1.Invalidate();
        }
        //CREATES A COMPLETELY NEW UNIVERSE FROM THE FILE OPTION

        private void RandomUniverse()
        //RANDOM ALIVE FUNCTION
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (rng.Next() % 2 == 0)
                    {
                        universe[x, y] = true;
                        liveCells++;
                    }
                    else
                    {
                        universe[x, y] = false;
                    }
                }
            }
            timer.Stop();
            CellsLabel.Text = "Cells: " + liveCells.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString();
            // seedLabel.Text = "Seed: " + seed.ToString();
            graphicsPanel1.Invalidate();

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPTIONS dlg = new OPTIONS();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (dlg.timerChanger.Value != 20)
                {
                    timer.Stop();
                    generations = 0;
                    statusStripGenerations.Text = "Generations: " + generations.ToString();
                    liveCells = 0;
                    graphicsPanel1.Invalidate();
                    timer.Interval = (int)dlg.timerChanger.Value;
                }
                width = (int)dlg.Widther.Value;
                xLength = (uint)dlg.Widther.Value;
                height = (int)dlg.Heighter.Value;
                yLength = (uint)dlg.Heighter.Value;
                universe = new bool[(int)dlg.Widther.Value, (int)dlg.Heighter.Value];
                scratchPad = new bool[(int)dlg.Widther.Value, (int)dlg.Heighter.Value];
                UniverseSizeHeadUp.Text = "Universe Size: {Width = " + dlg.Widther.Value + ", Height = " + dlg.Heighter.Value + "}";
                graphicsPanel1.Invalidate();

            }
        }
        //GENERAL MODAL DIALOG OPTIONS

        private void gridVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridVisibleContextItem.CheckState = GridVisToolStripItem.CheckState;
            checkOn = !checkOn;
            graphicsPanel1.Invalidate();
        }
        //TOOL STRIP GRID VISIBILITY ITEM

        private void headsUpVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            headsUpContextItem.CheckState = headsUpVisibleToolStripMenuItem.CheckState;
            headsUpCheck = !headsUpCheck;
            if (!headsUpCheck)
            {
                GenerationsHeadup.Visible = false;
                cellCountHeadup.Visible = false;
                boundaryTypeHeadUp.Visible = false;
                UniverseSizeHeadUp.Visible = false;
            }
            else
            {
                GenerationsHeadup.Visible = true;
                cellCountHeadup.Visible = true;
                boundaryTypeHeadUp.Visible = true;
                UniverseSizeHeadUp.Visible = true;
            }
            graphicsPanel1.Invalidate();
        }
        //TOOL STRIP HEADS-UP VISIBILITY ITEM

        private void neighborCountVisibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neighborCountContextItem.CheckState = neighborCountToolStripItem.CheckState;
            NeighborCheck = !NeighborCheck;
            graphicsPanel1.Invalidate();
        }
        //TOOL STRIP MENU ITEM FOR NEIGHBOR VISIBILITY

        private void fromTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomUniverse();
        }
        //RANDOMIZER RANDOM RANDOMIZER UR A RANDOMIZER O RANDOMIZER O UR A RANDOMIZER BABY

        private void gridVisibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridVisToolStripItem.CheckState = gridVisibleContextItem.CheckState;
            checkOn = !checkOn;
            graphicsPanel1.Invalidate();
        }
        //CONTEXT GRID VISIBILITY ITEM

        private void neighborCountVisibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            neighborCountToolStripItem.CheckState = neighborCountContextItem.CheckState;
            NeighborCheck = !NeighborCheck;
            graphicsPanel1.Invalidate();
        }
        //CONTEXT NEIGHBOR VISIBILITY ITEM

        private void headsUpVisibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            headsUpVisibleToolStripMenuItem.CheckState = headsUpContextItem.CheckState;
            headsUpCheck = !headsUpCheck;

            if (!headsUpCheck)
            {
                GenerationsHeadup.Visible = false;
                cellCountHeadup.Visible = false;
                boundaryTypeHeadUp.Visible = false;
                UniverseSizeHeadUp.Visible = false;
            }
            else
            {
                GenerationsHeadup.Visible = true;
                cellCountHeadup.Visible = true;
                boundaryTypeHeadUp.Visible = true;
                UniverseSizeHeadUp.Visible = true;
            }
            graphicsPanel1.Invalidate();
        }
        //CONTEXT HEADS-UP VISIBILITY ITEM

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextButton.Visible = false;
            timer.Start();
        }
        //CONTEXT START BUTTON

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextButton.Visible = true;
            timer.Stop();
        }
        //CONTEXT PAUSE BUTTON

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
            statusStripGenerations.Text = "Generations: " + generations.ToString();
            GenerationsHeadup.Text = "Generations: " + generations.ToString();
            cellCountHeadup.Text = "Cells: " + liveCells.ToString();
            graphicsPanel1.Invalidate();
        }
        //CONTEXT PLAY BUTTON

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //WILL EXIT THE PROGRAM

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        String currentRow = string.Empty;
                        if (universe[x, y])
                        {
                            writer.WriteLine("O");
                        }
                        else if (!universe[x, y])
                            writer.WriteLine(".");
                    }
                }
                writer.Close();
            }
        }
        //WILL SAVE THE UNIVERSE TO A TEXT FILE

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    maxHeight++;
                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.

                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        //  if (row[xPos] = "O")
                        //      universe[x, y] = true;
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                    }
                    // Close the file.
                   
                }
                reader.Close();

            }
        }
        //WILL MAKE AN OPEN DIALOG AND LOAD IN A UNIVERSE

        private void fromCurrentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //WILL GENERATE A RANDOM UNIVERSE FROM THE CURRENT SEED

        private void fromNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //WILL GENERATE A RANDOM UNIVERSE BASED ON AN INPUT SEED

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(dlg.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.

                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    maxHeight++;
                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                }

                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.

                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.
                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        //  if (row[xPos] = "O")
                        //      universe[x, y] = true;
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                    }
                    // Close the file.

                }
                reader.Close();

            }
        }
        //DOES THE SAME THING AS THE OTHER OPEN

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2; dlg.DefaultExt = "cells";

            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        String currentRow = string.Empty;
                        if (universe[x, y])
                        {
                            writer.WriteLine("O");
                        }
                        else if (!universe[x, y])
                            writer.WriteLine(".");
                    }
                }
                writer.Close();
            }
        }
      //DOES THE SAME THING AS THE SAVE


    }
}

