using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AddSentenceToRichTextBox
{
    public partial class Form1 : Form
    {
        private Bitmap loadedImage;
        private List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримати поточний час
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            // Отримати текст із TextBox
            string sentence = textBox1.Text;

            // Додати текст до RichTextBox з часом
            richTextBox1.AppendText(currentTime + ": " + sentence + "\n");

            // Очистити TextBox
            textBox1.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadedImage = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = loadedImage;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png|BMP Image|*.bmp";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ImageFormat format = ImageFormat.Bmp;
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                format = ImageFormat.Jpeg;
                                break;
                            case 2:
                                format = ImageFormat.Png;
                                break;
                        }
                        loadedImage.Save(saveFileDialog.FileName, format);
                    }
                }
            }
        }

        private void suppressColorButton_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    for (int x = 0; x < loadedImage.Width; x++)
                    {
                        Color pixelColor = loadedImage.GetPixel(x, y);
                        Color newColor;

                        if (radioRed.Checked)
                        {
                            newColor = Color.FromArgb(0, pixelColor.G, pixelColor.B);
                        }
                        else if (radioGreen.Checked)
                        {
                            newColor = Color.FromArgb(pixelColor.R, 0, pixelColor.B);
                        }
                        else // radioBlue.Checked
                        {
                            newColor = Color.FromArgb(pixelColor.R, pixelColor.G, 0);
                        }

                        loadedImage.SetPixel(x, y, newColor);
                    }
                }
                pictureBox.Image = loadedImage;
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(pictureBox.Width);
            int y = rand.Next(pictureBox.Height);
            Color color = Color.FromName(comboBoxColors.SelectedItem.ToString());
            float startAngle = float.Parse(textBoxStartAngle.Text); // Отримання кута сектора
            float sweepAngle = float.Parse(textBoxSweepAngle.Text); // Отримання ширини сектора


            Shape shape;
            switch (comboBoxShapes.SelectedItem.ToString())
            {
                case "Circle":
                    shape = new Circle(x, y, 50, color);
                    break;
                case "Rectangle":
                    shape = new RectangleShape(x, y, 100, 50, color);
                    break;
                case "Star":
                    shape = new Star(x, y, 50, color);
                    break;
                case "Sector":
                    shape = new Sector(x, y, 50, startAngle, sweepAngle, color);
                    break;
                default:
                    throw new Exception("Unknown shape selected");
            }
            shapes.Add(shape);
            pictureBox.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        // Вложенные классы фигур

        public abstract class Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Color Color { get; set; }

            protected Shape(int x, int y, Color color)
            {
                X = x;
                Y = y;
                Color = color;
            }

            public abstract void Draw(Graphics g);
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }

            public Circle(int x, int y, int radius, Color color) : base(x, y, color)
            {
                Radius = radius;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color))
                {
                    g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
                }
            }
        }

        public class RectangleShape : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public RectangleShape(int x, int y, int width, int height, Color color) : base(x, y, color)
            {
                Width = width;
                Height = height;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color))
                {
                    g.FillRectangle(brush, X, Y, Width, Height);
                }
            }
        }

        public class Star : Shape
        {
            public int Size { get; set; }

            public Star(int x, int y, int size, Color color) : base(x, y, color)
            {
                Size = size;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color))
                {
                    Point[] points = new Point[10];
                    for (int i = 0; i < 10; i++)
                    {
                        double angle = i * Math.PI / 5;
                        int r = i % 2 == 0 ? Size : Size / 2;
                        points[i] = new Point((int)(X + r * Math.Cos(angle)), (int)(Y + r * Math.Sin(angle)));
                    }
                    g.FillPolygon(brush, points);
                }
            }
        }

        public class Sector : Shape
        {
            public int Radius { get; set; }
            public float StartAngle { get; set; }
            public float SweepAngle { get; set; }

            public Sector(int x, int y, int radius, float startAngle, float sweepAngle, Color color) : base(x, y, color)
            {
                Radius = radius;
                StartAngle = startAngle;
                SweepAngle = sweepAngle;
            }
            

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Color))
                {
                    g.FillPie(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2, StartAngle, SweepAngle);
                }
            }
        }
    }
}