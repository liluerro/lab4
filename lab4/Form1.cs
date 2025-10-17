using System.Text;
using static lab4.Progression;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            Random rand = new Random();
            StringBuilder resultBuilder = new StringBuilder();

            // --- Частина 1: Арифметична прогресія ---
            resultBuilder.AppendLine("......Арифметична......");
            Child1[] arithmeticArray = new Child1[3];
            for (int i = 0; i < arithmeticArray.Length; i++)
            {
                arithmeticArray[i] = new Child1(rand.Next(1, 5), rand.Next(3, 6), rand.Next(10, 20));
            }

            foreach (var item in arithmeticArray)
            {
                resultBuilder.AppendLine(item.ToString());
            }

            resultBuilder.AppendLine("......різниця......");
            Array.Sort(arithmeticArray);

            foreach (var item in arithmeticArray)
            {
                resultBuilder.AppendLine(item.ToString());
            }

            resultBuilder.AppendLine();

            // --- Частина 2: Геометрична прогресія ---
            resultBuilder.AppendLine("......Геометрична......");
            Child2[] geometricArray = new Child2[3];
            for (int i = 0; i < geometricArray.Length; i++)
            {
                geometricArray[i] = new Child2(rand.Next(1, 3), rand.Next(2, 5), rand.Next(3, 6));
            }

            foreach (var item in geometricArray)
            {
                resultBuilder.AppendLine(item.ToString());
            }

            resultBuilder.AppendLine("......сума членів......");
            Array.Sort(geometricArray);

            foreach (var item in geometricArray)
            {
                resultBuilder.AppendLine(item.ToString());
            }

            outputTextBox.Text = resultBuilder.ToString();
        }
    }
}
