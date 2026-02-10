using System;
using System.Windows.Forms;

namespace SimpleGUIApp
{
    public partial class MainForm : Form
    {
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Настройка формы
            this.Text = "Простое приложение";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Элемент 1: Надпись (Label)
            Label infoLabel = new Label();
            infoLabel.Text = "Нажмите кнопку, чтобы увеличить счётчик:";
            infoLabel.Location = new System.Drawing.Point(20, 20);
            infoLabel.AutoSize = true;
            this.Controls.Add(infoLabel);

            // Элемент 2: Текстовое поле для отображения счётчика (TextBox)
            TextBox counterBox = new TextBox();
            counterBox.Location = new System.Drawing.Point(20, 50);
            counterBox.Size = new System.Drawing.Size(100, 20);
            counterBox.ReadOnly = true;
            counterBox.Text = "0";
            counterBox.Name = "counterBox";
            this.Controls.Add(counterBox);

            // Элемент 3: Кнопка (Button)
            Button actionButton = new Button();
            actionButton.Text = "Увеличить";
            actionButton.Location = new System.Drawing.Point(20, 80);
            actionButton.Size = new System.Drawing.Size(100, 30);
            actionButton.Click += (sender, e) =>
            {
                counter++;
                counterBox.Text = counter.ToString();

                // Дополнительная обратная связь при достижении 10
                if (counter == 10)
                {
                    MessageBox.Show("Поздравляем! Вы достигли 10 нажатий!", "Достижение");
                }
            };
            this.Controls.Add(actionButton);

            // Элемент 4: Кнопка сброса (дополнительный элемент управления)
            Button resetButton = new Button();
            resetButton.Text = "Сбросить";
            resetButton.Location = new System.Drawing.Point(130, 80);
            resetButton.Size = new System.Drawing.Size(100, 30);
            resetButton.Click += (sender, e) =>
            {
                counter = 0;
                counterBox.Text = "0";
                MessageBox.Show("Счётчик сброшен!", "Сброс");
            };
            this.Controls.Add(resetButton);

            // Элемент 5: Надпись с инструкцией (Label)
            Label instructionLabel = new Label();
            instructionLabel.Text = "Нажмите 'Сбросить' чтобы обнулить счётчик";
            instructionLabel.Location = new System.Drawing.Point(20, 120);
            instructionLabel.AutoSize = true;
            this.Controls.Add(instructionLabel);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
} //heeeeeeeeeeeeeпавваelp
//fsdfdsfds
//fsdfsfds
//fddfdf
//dsfdd
//sadasd
//dsadsada