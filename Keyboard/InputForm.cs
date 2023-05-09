using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class InputForm : Form
    {
        public const int InputSize = 33;
        public int Level;
        public int Second;
        public int ErrorsCount;
        public int CurrentChar;
        public int CorrectChars;
        public int CurrentString;
        public string Input;
        public string[] lines;
        public InputForm()
        {
            InitializeComponent();

        }
        private void InputForm_Shown(object sender, EventArgs e)
        {
            Second = 0;
            CurrentChar = 0;
            CurrentString = 0;
            ErrorsCount = 0;
            CorrectChars = 0;
            timer.Enabled = false;
            string Path = Application.StartupPath;

            if (Level == 0)
            {
                Path += "\\easy.txt";
                LevelLabel.Text = "Складність: Легка";
            }
            if (Level == 1)
            {
                Path += "\\medium.txt";
                LevelLabel.Text = "Складність: Середня";
            }
            if (Level == 2)
            {
                Path += "\\hard.txt";
                LevelLabel.Text = "Складність: Висока";
            }
            lines = System.IO.File.ReadAllLines(Path, Encoding.GetEncoding(1251));
            TaskString.Text = lines[CurrentString];
            InputString.Text = "";
            Input = "";
            SecondLabel.Text = "Час: " + Second.ToString() + " сек";
            ErrorsLabel.Text = "Помилки: " + ErrorsCount.ToString();
            StringNumberLabel.Text = "Рядок: " + (CurrentString + 1).ToString() + "/" + lines.Count().ToString();
            SpeedLabel.Text = "Швидкість: 0 сим/хв";
            AccuracyLabel.Text = "Точність: " + "100%";
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Second++;
            SecondLabel.Text = "Час: " + Second.ToString() + " сек";
            int InputSpeed = (int)(CorrectChars / (float)Second * 60);
            if (InputSpeed < 1)
                SpeedLabel.Text = "Швидкість: 0 сим/хв";
            else
                SpeedLabel.Text = "Швидкість: " + InputSpeed.ToString() + " сим/хв";
        }

        private void InputForm_KeyPress(object sender, KeyPressEventArgs e)
        {

            timer.Enabled = true;
            if (!timer.Enabled) return;
            if (e.KeyChar.ToString() == lines[CurrentString][CurrentChar].ToString())
            {
                Input += e.KeyChar.ToString();
                InputString.Text = Input;
                TaskString.Text = lines[CurrentString];

                if (CurrentChar > InputSize)
                {
                    InputString.Text = Input.Substring(CurrentChar - InputSize);
                    TaskString.Text = lines[CurrentString].Substring(CurrentChar - InputSize);
                }
                
                CurrentChar++;
                CorrectChars++;
                int InputSpeed = (int)(CorrectChars / (float)Second * 60);
                if (InputSpeed < 1)
                    SpeedLabel.Text = "Швидкість: 0 сим/хв";
                else
                    SpeedLabel.Text = "Швидкість: " + InputSpeed.ToString() + " сим/хв";
            }
            else
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"error.wav");
                player.Play();
                ErrorsCount++;
                ErrorsLabel.Text = "Помилки: " + ErrorsCount.ToString();
            }
            if (CurrentChar != 0)
            {
                int Accuracy = (100 - (100 * ErrorsCount / CorrectChars));
                if (Accuracy < 1)
                    AccuracyLabel.Text = "Точність: " + 0 + "%";
                else
                    AccuracyLabel.Text = "Точність: " + Accuracy.ToString() + "%";
            }
            if (CurrentChar == lines[CurrentString].Length)
            {
                CurrentChar = 0;
                CurrentString++;
                if (CurrentString == lines.Count())
                {
                    timer.Enabled = false;
                    if (MessageBox.Show("Кінець. Зберегти результати?", "Успіх!", MessageBoxButtons.OKCancel) == DialogResult.OK)   
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                        {                          
                            string[] SaveLines = { LevelLabel.Text, SecondLabel.Text, ErrorsLabel.Text, SpeedLabel.Text, AccuracyLabel.Text };
                            System.IO.File.WriteAllLines(saveFileDialog.FileName, SaveLines);
                        }
                    this.Close();
                }
                else
                {
                    TaskString.Text = lines[CurrentString];
                    InputString.Text = "";
                    Input = "";
                }
                StringNumberLabel.Text = "Рядок: " + (CurrentString + 1).ToString() + "/" + lines.Count().ToString();
            }
        }
    }
}
