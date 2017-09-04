// Alec Watson
// GUI

// This is a test comment to see if GitHub catches it.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LightsOut
{
	public partial class MainForm : Form
	{
		private enum gridSize { ThreeByThree, FourByFour, FiveByFive }				// Enum to keep track of the current board size configuration (3x3, 4x4, 5x5)

		private const int GridOffset = 50;                                          // Distance from upper-left side of window
		private const int newGameButtonHorizontalOffset = 100;                      // Number of pixels from the center that the newGameButton is offset
		private const int buttonVerticalOffset = 70;								// Number of pixels the newGameButton and exitButtons are vertically offset from the bottom of the window

		private int gridLength;														// Size in pixels of the grid
		private int numCells;                                                       // Number of cells in grid
		private int cellLength;														// The Lenth of the cells in the grid
		private gridSize currentGridSize;											// Keeps track of the grid's current size
		private bool[,] grid;                                                       // Stores on/off state of cells in grid
		private Dictionary<ToolStripMenuItem, gridSize> gridSizeOptionsDictionary;	// Stores grid size options as well as the menu items to select them
		private Random rand;                                                        // Used to generate random numbers

		public MainForm()
		{
			currentGridSize = gridSize.ThreeByThree;

			InitializeComponent();
			rand = new Random();    // Initializes random number generator

			gridSizeOptionsDictionary = new Dictionary<ToolStripMenuItem, gridSize>
			{
				{ threeByThreeToolStripMenuItem, gridSize.ThreeByThree },
				{ fourByFourToolStripMenuItem, gridSize.FourByFour },
				{ fiveByFiveToolStripMenuItem, gridSize.FiveByFive }
			};

			createNewGame();
		}

		private void createNewGame(gridSize size = gridSize.ThreeByThree)
		{
			numCells = getNumCells(size);

			grid = new bool[numCells, numCells];

			// Fill grid with either white or black
			for (int r = 0; r < numCells; r++)
			{
				for (int c = 0; c < numCells; c++)
				{
					grid[r, c] = rand.Next(2) == 1;
				}
			}

			if (this.Visible)
			{
				// Redraw grid
				this.Invalidate();
			}

			currentGridSize = size;
		}

		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			cellLength = calculateCellLength(gridLength, numCells);
			gridLength = calculateGridLength();

			for (int r = 0; r < numCells; r++)
			{
				for (int c = 0; c < numCells; c++)
				{
					// Get proper pen and brush for on/off
					// grid section
					Brush brush;
					Pen pen;

					if (grid[r, c])
					{
						pen = Pens.Black; brush = Brushes.White;   // On
					}
					else
					{
						pen = Pens.White;
						brush = Brushes.Black;   // Off
					}

					// Determine (x,y) coord of row and col to draw rectangle
					int x = c * cellLength + GridOffset;
					int y = r * cellLength + GridOffset;

					// Draw outline and inner rectangle
					g.DrawRectangle(pen, x, y, cellLength, cellLength);
					g.FillRectangle(brush, x + 1, y + 1, cellLength - 1, cellLength - 1);
				}
			}
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			// Make sure click was inside the grid
			if (e.X < GridOffset || e.X > cellLength * numCells + GridOffset || e.Y < GridOffset || e.Y > cellLength * numCells + GridOffset)
			{
				return;
			}

			// Find row, col of mouse press
			int r = (e.Y - GridOffset) / cellLength;

			int c = (e.X - GridOffset) / cellLength;

			// Invert selected box and all surrounding boxes
			for (int i = r - 1; i <= r + 1; i++)
			{
				for (int j = c - 1; j <= c + 1; j++)
				{
					if (i >= 0 && i < numCells && j >= 0 && j < numCells)
					{
						grid[i, j] = !grid[i, j];
					}
				}
			}

			// Redraw grid
			this.Invalidate();

			// Check to see if puzzle has been solved
			if (PlayerWon())
			{
				// Display winner dialog box
				MessageBox.Show(this, "Congratulations!  You've won!", "Lights Out!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			Control control = (Control)sender;

			// Ensure the Form remains square (Height = Width).
			if (control.Size.Height != control.Size.Width)
			{
				control.Size = new Size(control.Size.Width, control.Size.Width);
			}

			newGameButton.Location = calculateNewGameButtonPoint(control);
			exitButton.Location = calculateExitButtonPoint(control);

			this.Invalidate();
		}

		private void gridSizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem selectedToolStripMenuItem = (ToolStripMenuItem)sender;

			uncheckSizeOptions();
			checkToolStripMenuItem(selectedToolStripMenuItem);

			gridSize selectedGridSize = gridSizeOptionsDictionary[selectedToolStripMenuItem];

			createNewGame(selectedGridSize);
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			createNewGame(currentGridSize);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			createNewGame(currentGridSize);
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm aboutBox = new AboutForm();
			aboutBox.ShowDialog(this);
		}

		private bool PlayerWon()
		{
			foreach (bool tileState in grid)
			{
				if (tileState)
				{
					return false;
				}
			}

			return true;
		}

		private void uncheckSizeOptions()
		{
			foreach(ToolStripMenuItem gridSizeToolStripMenuItem in gridSizeOptionsDictionary.Keys)
			{
				gridSizeToolStripMenuItem.Checked = false;
			}
		}

		private void checkToolStripMenuItem(ToolStripMenuItem toolStripMenuItem)
		{
			toolStripMenuItem.Checked = true;
		}

		private int calculateCellLength(int gridLength, int numCells)
		{
			return gridLength / numCells;
		}

		private int getNumCells(gridSize size = gridSize.ThreeByThree)
		{
			switch(size)
			{
				default:
				case gridSize.ThreeByThree:
					return 3;
				case gridSize.FourByFour:
					return 4;
				case gridSize.FiveByFive:
					return 5;
			}
		}

		private int calculateGridLength()
		{
			return this.Width - 125;
		}

		private Point calculateNewGameButtonPoint(Control control)
		{
			return new Point((control.Size.Width / 2) - newGameButtonHorizontalOffset, control.Size.Width - buttonVerticalOffset);
		}

		private Point calculateExitButtonPoint(Control control)
		{
			return new Point((control.Size.Width / 2), control.Size.Width - buttonVerticalOffset);
		}
	}
}
