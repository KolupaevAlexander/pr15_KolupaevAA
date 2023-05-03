using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вектор
{
    public partial class Vectros : Form
    {
        public Vectros()
        {
            InitializeComponent();
        }
        
        public bool VectorExist(TextBox vectorX, TextBox vectorY, TextBox vectorZ, out double x, out double y, out double z)
        {
            var coord_x = Double.TryParse(vectorX.Text, out x);
            var coord_y = Double.TryParse(vectorY.Text, out y);
            var coord_z = Double.TryParse(vectorZ.Text, out z);
            return coord_x && coord_y && coord_z;
        }
        public void GetAnswer()
        {
            double x, y, z;
            Vector vectorA;
            Vector vectorB;
            if (VectorExist(VectorAX, VectorAY, VectorAZ, out x, out y, out z))
            {
                vectorA = new Vector(x, y, z);

                if (VectorExist(VectorBX, VectorBY, VectorBZ, out x, out y, out z))
                { 
                    vectorB = new Vector(x, y, z);
                    Vector vector;
                    switch (operationChanger.SelectedIndex)
                    {
                        case 0:
                            vector = vectorA + vectorB;
                            result.Text = $"Координаты вектора: ({vector.X};{vector.Y};{vector.Z})";
                            break;
                        case 1:
                            vector = vectorA - vectorB;
                            result.Text = $"Координаты вектора: ({vector.X};{vector.Y};{vector.Z})";
                            break;
                        case 2:
                            result.Text = $"Скалярное произведение: {vectorA * vectorB}";
                            break;
                        case 3:
                            result.Text = $"Угол: {Math.Round(Vector.Angle(vectorA, vectorB) * 180 / Math.PI, 2)}";
                            break;
                        case 4:
                            result.Text = $"Длина вектора А: {vectorA.Length()}";
                            break;
                        case 5:
                            vector = vectorA - vectorB;
                            result.Text = $"Длина вектора В: {vectorB.Length()}";
                            break;
                        default:
                            break;
                    }
                }
            }
                else result.Text = "Ошибка ввода координат";
        }

        private void VectorAX_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void VectorAY_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void VectorAZ_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void VectorBX_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void VectorBY_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void VectorBZ_TextChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
        private void operationChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAnswer();
        }
    }
}
