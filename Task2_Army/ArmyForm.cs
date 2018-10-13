using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Army_Library;

namespace Task2_Army
{
    public partial class ArmyForm : Form
    {
        FirstLevelClass class1 = new FirstLevelClass();
        SecondLevelClass class2 = new SecondLevelClass();

        public ArmyForm()
        {
            InitializeComponent();
        }

        private void Class1CreateButton_Click(object sender, EventArgs e)
        {        
            if (textBox1.Text == "")
                MessageBox.Show("Укажите тип войск!");
            else
                class1.TypeOfTroops = textBox1.Text;

            if (textBox2.Text == "")
                MessageBox.Show("Укажите численность войск!");
            else
            {
                if (Convert.ToInt32(textBox2.Text) > 0)
                    class1.StrengthInPhousands = Convert.ToInt32(textBox2.Text);
                else
                    MessageBox.Show("Численность войск должна быть не меньше нуля!");
            }

            if (textBox3.Text == "")
                MessageBox.Show("Укажите вооружённость!");
            else
            {
                if (Convert.ToInt32(textBox3.Text) >= 0 && Convert.ToInt32(textBox3.Text) <= 10)
                    class1.Armament = Convert.ToInt32(textBox3.Text);
                else
                    MessageBox.Show("Вооружённость должна быть от 0 до 10!");
            }
        }

        private void Class1ShowInfoButton_Click(object sender, EventArgs e)
        {
            textBox8.Text = class1.Info();
        }

        private void Class2CreateButon_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                MessageBox.Show("Укажите тип войск!");
            else
                class2.TypeOfTroops = textBox6.Text;

            if (textBox5.Text == "")
                MessageBox.Show("Укажите численность войск!");
            else
            {
                if (Convert.ToInt32(textBox5.Text) > 0)
                    class2.StrengthInPhousands = Convert.ToInt32(textBox5.Text);
                else
                    MessageBox.Show("Численность войск должна быть не меньше нуля!");
            }

            if (textBox4.Text == "")
                MessageBox.Show("Укажите вооружённость!");
            else
            {
                if (Convert.ToInt32(textBox4.Text) >= 0 && Convert.ToInt32(textBox4.Text) <= 10)
                    class2.Armament = Convert.ToInt32(textBox4.Text);
                else
                    MessageBox.Show("Вооружённость должна быть от 0 до 10!");
            }

            if (textBox7.Text == "")
                MessageBox.Show("Укажите опыт!");
            else
            {
                if (Convert.ToInt32(textBox7.Text) > 0)
                    class2.P = Convert.ToInt32(textBox7.Text);
                else
                    MessageBox.Show("Опыт должен быть не меньше нуля!");
            }
        }

        private void Class2ShowInfoButton_Click(object sender, EventArgs e)
        {
            textBox9.Text = class2.Info();
        }
    }
}
