using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form2 : Form
    {
        Graph workedGraph; // Экземпляр класса
        int wayOfFill; // Переменная для запоминания способа заполнения
        int chosenAlgorithm; // Переменная для запоминания алгоритма
        bool isWeightGraph; // Переменная, определяющая, выбрали мы взвешенный граф или нет
        bool isMatrixInputCorrect = true; // Переменная, определяющая, правильно ли заполнено поле ввода

        public Form2()
        {
            InitializeComponent();
        }

        public void ProgramHasErrors(Error error) // Метод для проверки наличия ошибок в программе
        {
            DialogResult r = MessageBox.Show(error.GetError(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            isMatrixInputCorrect = false;
        }

        public void NormalizeMatrix() // Метод, который приводит данные пользователя в матрицу смежности(нормализует их) и вызывает ошибки при их наличии
        {
            workedGraph = new Graph();
            Error error = new Error();

            // Матрица смежности
            if (wayOfFill == 1)
            {
                error.smException(matrixInput.Text); //Проверка на наличие ошибок в матрице смежности
                if (error.SingleErrorList.Count == 0)
                {
                    workedGraph.GetAdjacencyMatrix(matrixInput.Text); //формируем матрицу
                }
                else
                {
                    ProgramHasErrors(error); //формируем сообщение об ошибке
                }
            }

            // Матрица инциденций
            else if (wayOfFill == 2)
            {
                error.incidenceException(matrixInput.Text); //Проверка на наличие ошибок в матрице инциденций
                if (error.SingleErrorList.Count == 0)
                {
                    workedGraph.ToAdjacencyFromIncidence(matrixInput.Text); //формируем матрицу
                }
                else
                {
                    ProgramHasErrors(error); //формируем сообщение об ошибке
                }

            }

            // Список смежности
            else if (wayOfFill == 3)
            {
                error.spSmejException(matrixInput.Text); //Проверка на наличие ошибок в списке смежности
                if (error.SingleErrorList.Count == 0)
                {
                    workedGraph.GetAdjacencyList(matrixInput.Text); //формируем матрицу
                }
                else
                {
                    ProgramHasErrors(error); //формируем сообщение об ошибке
                }

            }

            // Список рёбер
            else if (wayOfFill == 4)
            {
                error.spEdge(matrixInput.Text); //Проверка на наличие ошибок в списке ребер
                if (error.SingleErrorList.Count == 0)
                {
                    workedGraph.GetEdgesList(matrixInput.Text); //формируем матрицу
                }
                else
                {
                    ProgramHasErrors(error); //формируем сообщение об ошибке
                }
            }
        }
        
        private Bitmap DrawNumbers(int[,] graph, Bitmap bmp, Graphics g) //метод, рисующий номера вершин графа
        {
            Dictionary<int, int[]> coordinates = new Dictionary<int, int[]>();// Словарь для хранения х и у координаты номеров вершин
            Font font = new Font("Arial", 26, FontStyle.Regular); // Стили шрифта

            //координаты всех номеров вершин
            coordinates[1] = new int[] { 180, 0 };
            coordinates[2] = new int[] { 350, 0 };
            coordinates[3] = new int[] { 100, 100 };
            coordinates[4] = new int[] { 415, 100 };
            coordinates[5] = new int[] { 99, 235 };
            coordinates[6] = new int[] { 416, 235 };
            coordinates[7] = new int[] { 181, 335 };
            coordinates[8] = new int[] { 334, 335 };

            HashSet<int> graphHasVertex = new HashSet<int>(); // хэшсет для хранения использующиъся вершин

            //цикл для поиска имеющихся вершин
            for (int k = 0; k < graph.GetLength(0); k++)
            {
                for (int l = k + 1; l < graph.GetLength(1); l++)
                {
                    if (graph[k, l] != 0)
                    {
                        //добавляем 2 смежных вершины
                        graphHasVertex.Add(k + 1); 
                        graphHasVertex.Add(l + 1);
                    }
                }
            }

            //цикл для рисования номеров вершин из хэшсета
            foreach (var coordinate in graphHasVertex)
            {
                g.DrawString(coordinate.ToString(), font, Brushes.White, coordinates[coordinate][0] + 17, coordinates[coordinate][1] + 15); // отрисовка номера вершины
            }

            coordinates.Clear();
            return bmp;
        }

        private Bitmap DrawGraph(int[,] graph, Bitmap bmp, Graphics g)
        {
            Dictionary<int, int[]> coordinates = new Dictionary<int, int[]>();// Словарь для хранения х и у координаты  вершин
            HashSet<int> graphHasVertex = new HashSet<int>(); // хэшсет для хранения использующихся вершин
            Size size = new Size(70, 70); // Размер кружка
            SolidBrush brush = new SolidBrush(Color.Black); // Определяем кисть черного цвета
            Pen pen = new Pen(Color.Black, 2); // Объект для рисования ребер (черный цвет, толщина 2px)
            Point xy; // Пара координат
            Point[] masOfxy = new Point[graph.GetLength(0)]; // Массив пар координат
            Rectangle square; //площадь для отрисовки круга

            //координаты всех вершин
            coordinates[1] = new int[] { 180, 0 };
            coordinates[2] = new int[] { 350, 0 };
            coordinates[3] = new int[] { 100, 100 };
            coordinates[4] = new int[] { 415, 100 };
            coordinates[5] = new int[] { 99, 235 };
            coordinates[6] = new int[] { 416, 235 };
            coordinates[7] = new int[] { 181, 335 };
            coordinates[8] = new int[] { 334, 335 };

            //цикл для поиска имеющихся вершин
            for (int k = 0; k < graph.GetLength(0); k++)
            {
              for(int l = k + 1; l < graph.GetLength(1); l++)
                {
                    if(graph[k,l] != 0)
                    {
                        //добавляем 2 смежных вершины
                        graphHasVertex.Add(k + 1);
                        graphHasVertex.Add(l + 1);
                    }
                }
            }
            
            //цикл для рисования вершин из хэшсета
            foreach (var coordinate in graphHasVertex)
            {
                xy = new Point(coordinates[coordinate][0], coordinates[coordinate][1]); //пара координат для окружности
                square = new Rectangle(xy, size); //площадь для окружности в определенных координатах определенного размера
                g.DrawEllipse(pen, square); //рисуем окружность
                g.FillEllipse(brush, square); //заливаем окружность 
            }

            //цикл для рисования ребер смежных вершин
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(0); j++)
                {
                    if (graph[i, j] != 0)
                    {
                        Point xy1 = new Point(coordinates[i + 1][0] + 35, coordinates[i + 1][1] + 35); //координаты первой смежной вершины
                        Point xy2 = new Point(coordinates[j + 1][0] + 35, coordinates[j + 1][1] + 35); //координаты второй смежной вершины
                        g.DrawLine(pen, xy1, xy2); //рисуем ребро между смежными вершинами
                    }
                }
            }
            coordinates.Clear();
            return bmp;
        }

        private Bitmap DrawWeight(int[,] graph, Bitmap bmp, Graphics g) //метод, рисующий вес ребер графа
        {
            Dictionary<string, int[]> coordinates = new Dictionary<string, int[]>(); //Словарь для хранения х и у координаты весов вершин (ключ - пара смежных вершин)
            Font font = new Font("Avenir Next", 12, FontStyle.Regular); // Стили шрифта

            //координаты всех весов
            coordinates["12"] = new int[] { 285, 15 };
            coordinates["13"] = new int[] { 155, 70 };
            coordinates["14"] = new int[] { 270, 45 };
            coordinates["15"] = new int[] { 172, 90 };
            coordinates["16"] = new int[] { 340, 145 };
            coordinates["17"] = new int[] { 195, 140 };
            coordinates["18"] = new int[] { 270, 145 };
            coordinates["23"] = new int[] { 220, 100 };
            coordinates["24"] = new int[] { 413, 70 };
            coordinates["25"] = new int[] { 290, 83 };
            coordinates["26"] = new int[] { 405, 185 }; 
            coordinates["27"] = new int[] { 260, 220 };
            coordinates["28"] = new int[] { 350, 195 };
            coordinates["34"] = new int[] { 340, 115 };
            coordinates["35"] = new int[] { 110, 195 };
            coordinates["36"] = new int[] { 250, 168 };
            coordinates["37"] = new int[] { 165, 200 };
            coordinates["38"] = new int[] { 220, 205 };
            coordinates["45"] = new int[] { 315, 170 };
            coordinates["46"] = new int[] { 457, 195 };
            coordinates["47"] = new int[] { 320, 235 };
            coordinates["48"] = new int[] { 380, 275 };
            coordinates["56"] = new int[] { 220, 250 };
            coordinates["57"] = new int[] { 155, 325 };
            coordinates["58"] = new int[] { 220, 290 };
            coordinates["67"] = new int[] { 295, 315 };
            coordinates["68"] = new int[] { 410, 325 };
            coordinates["78"] = new int[] { 285, 375 };

            //цикл для отрисовки веса ребер смежных вершин
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = i + 1; j < graph.GetLength(1); j++)
                {
                    if (graph[i, j] != 0)
                    {
                        string keyNumber = Convert.ToString(i + 1) + Convert.ToString(j + 1); //формирование ключа - двух смежных вершин
                        g.DrawString(Convert.ToString(graph[i, j]), font, Brushes.Black, coordinates[keyNumber][0], coordinates[keyNumber][1]); //отрисовываем вес ребра
                    }
                }
            }

            coordinates.Clear();
            return bmp;
        }



        private void isAlgorithmChosen() //метод который проверяет, выбрал ли пользователь в самом начале работы программы способ задания графа
        {
            if(chooseMethod.Visible == false) // включаем все кнопки в меню выбора алгоритма, если пользователь выбрал способ задания графа
            {
                algGoWide.Enabled = true;
                algGoDeep.Enabled = true;
            }
        }

        private void someMethodChosed(string header) //метод, отображающий или скрывающий элементы управления при выборе метода заполнения.
        {
            chooseMethod.Visible = false; //скрываем подсказку "Выберите способ задания графа" в левом меню
            matrixInput.Visible = true; //отображаем поле для ввода матрицы
            headerOfInput.Visible = true; //отображаем заголовок выбранного способа задания графа 
            enterInput.Visible = true; //отоброжаем сообщение о вводе
            printGraph.Visible = true; //отображаем кнопку "построить граф"
            clearButton.Visible = true; //отображаем кнопку "очистить"
            textAbout.Visible = false; //скрываем приветственный текст в правом окне
            logoAbout.Visible = false; //скрываем приветственный логотип в правом окне
            matrixInput.Text = ""; //очищаем поле ввода матрицы при смене выобра метода заполнения

            headerOfInput.Text = header; //Параметр - строка "выбранный аглоритм". Подставляем строку с информацией о выбранном алгоритме
            enterInput.Text = "Ввод: "; 
        }

        private void someAlgorithmChosed(string result, string enter) //метод, отоброжающий или скрывающий элементы управления при выборе алгоритма. 
        {
            algorithmInput.Visible = true; //отображаем поле для ввода алгоритма
            enterAlgorithm.Visible = true; //отображаем строку для пользователя о том, какую информацию нужно ввести для этого алгоритма
            resultOfAlgorithm.Visible = true; //отображаем кнопку "результат алгоритма"
            resultOfAlgButton.Visible = true; //отображаем строку для результата алгоритма

            algorithmInput.Text = ""; //очищаем поле для ввода алгоритма
            resultOfAlgorithm.Text = result; //Параметр - заголовок названия алгоритма, в последующем там и будет его результат
            enterAlgorithm.Text = enter; // Параметр - строка для пользователя о том, какую информацию нужно ввести для этого алгоритма
        }

        private void clearAll()
        {
            enterAlgorithm.Visible = false; //скрываем строку для пользователя о том, какую информацию нужно ввести для этого алгоритма
            matrixInput.Text = ""; //очищаем поле для ввода матрицы
            matrixInput.Text = ""; //очищаем поле для ввода матрицы
            algorithmInput.Text = "";
            resultOfAlgorithm.Visible = false; //скрываем  "результат алгоритма"
            algorithmInput.Visible = false; //скрываем поле для ввода алгоритма
            resultOfAlgButton.Visible = false; //скрываем кнопку "результат алгоритма"

            Bitmap bmp = new Bitmap(pictureOfGraph.Width, pictureOfGraph.Height);
            pictureOfGraph.Image = bmp;
        }

        private void NotWeightGraph_Click(object sender, EventArgs e) //способ задания невзвешенного графа
        {
                isWeightGraph = false;

                someMethodChosed("Матрица смежности");

                wayOfFill = 1;

                isAlgorithmChosen();

                algDijkstra.Enabled = false;
        }

        private void WeightGraph_Click(object sender, EventArgs e) //способ задания взвешенного графа
        {
                someMethodChosed("Матрица смежности");

                wayOfFill = 1;

                isAlgorithmChosen();

                isWeightGraph = true;
                algDijkstra.Enabled = true;
        }

        private void matrixInc_Click(object sender, EventArgs e) //способ задания графа матрицей инциденции
        {
                isWeightGraph = false;

                someMethodChosed("Матрица инциденции");

                wayOfFill = 2;

                isAlgorithmChosen();

                algDijkstra.Enabled = false;
        }

        private void listSmej_Click(object sender, EventArgs e) //способ задания графа списком смежности
        {
                isWeightGraph = false;

                someMethodChosed("Список смежности");

                wayOfFill = 3;

                isAlgorithmChosen();

                algDijkstra.Enabled = false;
        }

        private void listRebra_Click(object sender, EventArgs e) //способ задания графа списком ребер
        {
                isWeightGraph = false;

                someMethodChosed("Список ребер");

                wayOfFill = 4;

                isAlgorithmChosen();

                algDijkstra.Enabled = false;
        }


        private void algGoWide_Click(object sender, EventArgs e) //обход графа в ширину
        {
            someAlgorithmChosed("Обход графа в ширину: ", "Введите начальную\nвершину обхода");

            chosenAlgorithm = 1;
        }

        private void algGoDeep_Click(object sender, EventArgs e) //обход графа в глубину
        {
            someAlgorithmChosed("Обход графа в глубину: ", "Введите начальную\nвершину обхода");

            chosenAlgorithm = 2;
        }

        private void algDijkstra_Click(object sender, EventArgs e) //поиск кратчайшего пути
        {
            someAlgorithmChosed("Кратчайший путь:\nДлина пути:", "Введите через пробел\nначало и конец пути");

            chosenAlgorithm = 3;
        }

        private void menuAlgorithms_Click(object sender, EventArgs e) //при нажатии на кнопку "Алгоритмы" в меню если у нас не выбран способ задания графа, выскакивает информационное сообщение
        {
            if (chooseMethod.Visible == true) //если не выбрали способ задания графа (заголовок "выберите способ задания графа" видим)
            {
                MessageBox.Show("Выберите способ задания графа в верхнем меню", "Внимание!",MessageBoxButtons.OK ,MessageBoxIcon.Warning); //всплывает окно с подсказкой
            }
        }

        private void clearButton_Click(object sender, EventArgs e) //кнопка очистить
        {
            clearAll(); // вызывает метод очистки окна приложения
        }

        private void printGraph_Click(object sender, EventArgs e) //кнопка построить граф
        {
            NormalizeMatrix();

            if (isMatrixInputCorrect)
            {
                Bitmap bmp = new Bitmap(pictureOfGraph.Width, pictureOfGraph.Height); //экземпляр класса Bitmap с заданными размерами - "полотно"
                Graphics g = Graphics.FromImage(bmp); // создаем графический объект

                bmp = DrawGraph(workedGraph.getMainAdjacencyMatrix(), bmp, g); //отрисовка вершин и ребер графа
                bmp = DrawNumbers(workedGraph.getMainAdjacencyMatrix(), bmp, g); //отрисовка номеров вершин графа
                if (isWeightGraph)
                {
                    bmp = DrawWeight(workedGraph.getMainAdjacencyMatrix(), bmp, g); //отрисовка взвешенного графа
                }

                pictureOfGraph.Image = bmp; //создаем изображение на основе "полотна"
            }

            isMatrixInputCorrect = true; // после нажатия кнопки "построить граф" устанавливаем стандартное значение переменной true 
        }

        private void resultOfAlgButton_Click(object sender, EventArgs e) //кнопка найти результат алгоритма
        {
            NormalizeMatrix(); 

            // реализация алгоритма в зависимости от выбора
            if (chosenAlgorithm == 1)
            {
                resultOfAlgorithm.Text = "Обход графа в ширину: " + workedGraph.BreadthFirstSearch(Convert.ToInt32(algorithmInput.Text));
            }
            else if (chosenAlgorithm == 2)
            {
                resultOfAlgorithm.Text = "Обход графа в глубину: " + workedGraph.DepthFirstSearch(Convert.ToInt32(algorithmInput.Text));
            }
            else if(chosenAlgorithm == 3)
            {
                resultOfAlgorithm.Text = workedGraph.DijkstraAlgorithm(algorithmInput.Text); 
            }
        }

        private void exit_Click(object sender, EventArgs e) //кнопка Завершение работы
        {
            DialogResult r = MessageBox.Show("Вы действительно хотите завершить работу?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (r == DialogResult.Yes) //если результат диалогового окна - нажатие кнопки "Да" 
            {
                Application.Exit(); //завершение работы приложения
            }
        }
    }
}
