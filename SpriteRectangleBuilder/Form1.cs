using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Xml.Linq;
using System.IO;

namespace SpriteRectangleBuilder
{
    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        List<string> spritesheets;
        Timer frameTimer;
        Bitmap zoomBitmap;
        Rectangle zoomRectangle;
        Rectangle frameBox;
        int spritesheetIndex = 0;
        int animationLength;
        int previewAnimationIndex = 0;
        int frameX;
        int frameY;
        int frameWidth;
        int frameHeight;
        int frameDisplacement;
        int zoomLevel;
        const int SPRITESHEET_COUNT = 11;
        const int DEFAULT_ZOOM_SIZE = 150;
        int frameDelay = 24;
        int frameIndex = 0;
        bool isLargeMarginActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frameTimer = timer1;
            string workingDirectory = "C:/TEMP/LinkToThePastArenaAssets/LinkToThePastArenaAssets/Textures";
            spritesheets = new List<string>();
            spritesheets.Add(workingDirectory + "/ChurchAreaSpriteSheet.png");
            spritesheets.Add(workingDirectory + "/EnemiesSpriteSheet1.png");
            spritesheets.Add(workingDirectory + "/EnemiesSpriteSheet2.png");
            spritesheets.Add(workingDirectory + "/LinkHouseAreaSpriteSheet.png");
            spritesheets.Add(workingDirectory + "/LinkPartsSpriteSheet.png");
            spritesheets.Add(workingDirectory + "/LinkSpriteSheet1.png");
            spritesheets.Add(workingDirectory + "/LinkSpriteSheet2.png");
            spritesheets.Add(workingDirectory + "/LinkSpriteSheet3.png");
            spritesheets.Add(workingDirectory + "/LinkSpriteSheet4.png");
            spritesheets.Add(workingDirectory + "/NPCSpriteSheet.png");
            spritesheets.Add(workingDirectory + "/LargeOpenGrassArea.png");
            zoomBitmap = new Bitmap(pctSpritesheet.Image);
            frameBox = new Rectangle(0, 0, 1, 1);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White, 1))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(Convert.ToInt16(Convert.ToInt32(row.Cells["FrameXLocation"].Value)),
                    Convert.ToInt16(row.Cells["FrameYLocation"].Value), Convert.ToInt16(row.Cells["GridFrameWidth"].Value),
                    Convert.ToInt16(row.Cells["GridFrameHeight"].Value)));
                }
                e.Graphics.DrawRectangle(pen, frameBox);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Bitmap sampleFrame = new Bitmap(pctSpritesheet.Image);
            if (btnPlay.Text == "Play")
            {
                animationLength = dataGridView1.Rows.Count - 1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index <= dataGridView1.Rows.Count - 2)
                    {
                        images.Add(sampleFrame.Clone(new Rectangle(Convert.ToInt16(Convert.ToInt32(row.Cells["FrameXLocation"].Value)),
                        Convert.ToInt16(row.Cells["FrameYLocation"].Value), Convert.ToInt16(row.Cells["GridFrameWidth"].Value),
                        Convert.ToInt16(row.Cells["GridFrameHeight"].Value)), sampleFrame.PixelFormat));
                    }
                }
                btnPlay.Text = "Stop";
                frameTimer.Start();
            }
            else if (btnPlay.Text == "Stop")
            {
                images.Clear();
                pctPreviewAnimation.Image = null;
                btnPlay.Text = "Play";
                frameTimer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (previewAnimationIndex >= images.Count)
            {
                previewAnimationIndex = 0;
            }
            else
            {
                pctPreviewAnimation.Image = images[previewAnimationIndex];
                previewAnimationIndex++;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (spritesheetIndex >= SPRITESHEET_COUNT)
            {
                spritesheetIndex = 0;
            }
            pctSpritesheet.Load(spritesheets[spritesheetIndex]);
            this.Refresh();
            spritesheetIndex++;
            zoomBitmap = new Bitmap(pctSpritesheet.Image);
        }

        private void pctSpritesheet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X - (frameBox.Width / 2) > pctSpritesheet.Location.X - pctSpritesheet.Left &&
                e.X + (frameBox.Width / 2) < pctSpritesheet.Image.Width &&
                e.Y - (frameBox.Height / 2) > pctSpritesheet.Location.Y - pctSpritesheet.Top &&
                e.Y + (frameBox.Height / 2) < pctSpritesheet.Image.Height)
            {
                frameBox.X = e.X - (frameBox.Width / 2);
                frameBox.Y = e.Y - (frameBox.Height / 2);
                pctZoomImage.Image = zoomBitmap.Clone(frameBox, pctSpritesheet.Image.PixelFormat);
                pctSpritesheet.Invalidate();
            }
            if (frameBox.Width != 0 || frameBox.Width != null)
            {
                lblRectWidth.Text = "R Width: " + (e.X - frameBox.X);
                lblRectHeight.Text = "R Height: " + (e.Y - frameBox.Y);
            }
        }

        private void pctSpritesheet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblRectX.Text = "Rect X: " + frameBox.X;
                lblRectY.Text = "Rect Y: " + frameBox.Y;
                lblRectWidth.Text = "R Width: " + frameBox.Width;
                lblRectHeight.Text = "R Height: " + frameBox.Height;                               
            }
            else if (e.Button == MouseButtons.Right)
            {
                isLargeMarginActive = !isLargeMarginActive;
                MessageBox.Show("Large Margin Mode is Active: " + isLargeMarginActive.ToString());
            }
            else if (e.Button == MouseButtons.Middle)
            {
                frameBox.Width = 1;
                frameBox.Height = 1;
                pctSpritesheet.Invalidate();
            }
        }

        private void pctSpritesheet_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[frameIndex].Cells["FrameNumber"].Value = frameIndex;
                dataGridView1.Rows[frameIndex].Cells["FrameXLocation"].Value = frameBox.X;
                dataGridView1.Rows[frameIndex].Cells["FrameYLocation"].Value = frameBox.Y;
                dataGridView1.Rows[frameIndex].Cells["GridFrameWidth"].Value = frameBox.Width;
                dataGridView1.Rows[frameIndex].Cells["GridFrameHeight"].Value = frameBox.Height;
                frameIndex++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rowNumber = 1;
            string xmlString = "";
            // OffsetSpriteRectangles();
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = ".xml";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    XDocument xDoc = new XDocument();
                    xmlString += "<FrameAnimation>\r\n";
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    { 
                        if (row.Index < dataGridView1.Rows.Count - 1)
                        {
                            xmlString += "  <SpriteRectangle>\r\n" +
                                "       <FrameNumber>" + row.Cells["FrameNumber"].Value + "</FrameNumber>\r\n" +
                                "       <FrameSpritesheet>" + spritesheets[spritesheetIndex - 1] + "</FrameSpritesheet>\r\n" +
                                "       <FrameXLocation>" + row.Cells["FrameXLocation"].Value + "</FrameXLocation>\r\n" +
                                "       <FrameYLocation>" + row.Cells["FrameYLocation"].Value + "</FrameYLocation>\r\n" +
                                "       <GridFrameWidth>" + row.Cells["GridFrameWidth"].Value + "</GridFrameWidth>\r\n" +
                                "       <GridFrameHeight>" + row.Cells["GridFrameHeight"].Value + "</GridFrameHeight>\r\n" +
                                "   </SpriteRectangle>\r\n";
                        }
                                  
                    }
                    xmlString += "</FrameAnimation>";
                    File.WriteAllText(dialog.FileName, xmlString);
                }
            }
        }

        private void ClearDataGrid()
        {
            frameIndex = 0;
            dataGridView1.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    XDocument xDoc = XDocument.Load(dialog.FileName);
                    ClearDataGrid();
                    foreach (XElement frame in xDoc.Root.Nodes())
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[frameIndex].Cells["FrameNumber"].Value = frame.Element("FrameNumber").Value;
                        dataGridView1.Rows[frameIndex].Cells["FrameXLocation"].Value = frame.Element("FrameXLocation").Value;
                        dataGridView1.Rows[frameIndex].Cells["FrameYLocation"].Value = frame.Element("FrameYLocation").Value;
                        dataGridView1.Rows[frameIndex].Cells["GridFrameWidth"].Value = frame.Element("GridFrameWidth").Value;
                        dataGridView1.Rows[frameIndex].Cells["GridFrameHeight"].Value = frame.Element("GridFrameHeight").Value;
                        frameIndex++;
                    }
                }
            }
        }

        private void pctSpritesheet_MouseEnter(object sender, EventArgs e)
        {
            pctSpritesheet.Focus();
        }

        private void pctSpritesheet_MouseWheel(object sender, MouseEventArgs e)
        {
            if (frameBox.X + frameBox.Width < pctSpritesheet.Location.X + pctSpritesheet.Width &&
            frameBox.Y + frameBox.Height < pctSpritesheet.Location.X + pctSpritesheet.Height)
            {
                if (e.Delta > 0)
                {
                    if (isLargeMarginActive)
                    {
                        frameBox.Width += 15;
                    }
                    else
                    {
                        frameBox.Width += 1;
                    }
                                      
                }
                else if (e.Delta < 0)
                {
                    if (isLargeMarginActive)
                    {
                        frameBox.Height += 15;
                    }
                    else
                    {
                        frameBox.Height += 1;
                    }         
                }
                pctSpritesheet.Invalidate();
                pctZoomImage.Invalidate();
            }
        }
    }
}
