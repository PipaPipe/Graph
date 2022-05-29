using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Graph
{

    class Graph
    {
        // дейкстру

        
        private int[,] mainAdjacencyMatrix;

        // геттер для матрицы
        public int[,] getMainAdjacencyMatrix()
        {
            return mainAdjacencyMatrix;
        }

        // Метод для перевода матрицы инциденций 
        // В матрицу смежности
        public void ToAdjacencyFromIncidence(string path)
        {
            int[,] adjacencyMatrixFromIncidence; // Массив для матрицы смежности

            string[] lines = path.Split('\n'); // Массив для строк матрицы инциденций

            string elementsInLine;
            int firstIncidentPeek = -1;
            int secondIncidentPeek = -1;
            // кол-во строк в матрице инциденций 
            // равно кол-ву вершин в графе
            // исходя из этого мы можем задать размерность
            // для матрицы смежности
            int rowCount = lines.Length; // Получаем кол-во строк в матрице смежности
            int columnCount = lines[0].Split().Length - 1; // Получаем кол-во столбцов в матрице смежности

            adjacencyMatrixFromIncidence = new int[rowCount, rowCount];

            for (int i = 0; i < columnCount; ++i)
            {
                for (int j = 0; j < rowCount; ++j)
                {
                    // Матрица инцидентности состоит из рёбер и вершин
                    // Пройдя по каждому ребру и запомнив, те вершины, 
                    // Которые связаны этими ребрами
                    // Производится построение матрицы смежности
                    elementsInLine = lines[j].Split()[i];

                    // Поиск тех вершин, которые соединены ребром
                    // Их мы запоминаем в переменные firstIncidentPeek, secondIncidentPeek
                    if (elementsInLine == "1" && firstIncidentPeek == -1 && secondIncidentPeek == -1)
                    {
                        firstIncidentPeek = j;
                    }
                    if (elementsInLine == "1" && firstIncidentPeek != -1)
                    {
                        secondIncidentPeek = j;
                    }
                    // Найдя две инцидентные вершины
                    // Переносим их в матрицу смежности
                    if (secondIncidentPeek != -1 && firstIncidentPeek != -1 && firstIncidentPeek != secondIncidentPeek)
                    {
                        adjacencyMatrixFromIncidence[firstIncidentPeek, secondIncidentPeek] = 1;
                        adjacencyMatrixFromIncidence[secondIncidentPeek, firstIncidentPeek] = 1;
                    }
                }
                // "Обнуляем" для поиска 
                firstIncidentPeek = -1;
                secondIncidentPeek = -1;
            }
            mainAdjacencyMatrix = adjacencyMatrixFromIncidence;
        }

        // Получаем матрицу смежности из ввода
        // Передаём в метод строку с матрицей
        // На выходе получаем матрциу смежности
        public void GetAdjacencyMatrix(string path)
        {
            int[,] adjacencyMatrix; // Массив для матрицы смежности

            string[] lines = path.Split('\n'); // Разбиваем текст матрицы на строчки 

            int row = lines.Length; // Размерность матрицы по строкам/столбцам
            string[] elementsInLine; // Вспомогательный массив для элементов в строке 
            adjacencyMatrix = new int[row, row]; // Задаём размерность матрицы

            for (int i = 0; i < row; ++i)
            {
                elementsInLine = lines[i].Split(); // Считываем элементы из строки

                for (int j = 0; j < row; ++j)
                {
                    adjacencyMatrix[i, j] = Convert.ToInt32(elementsInLine[j]); // Считываем строку в матрицу
                }
            }
            mainAdjacencyMatrix = adjacencyMatrix;
        }

        // Список смежности 
        public void GetAdjacencyList(string path)
        {
            string[] line = path.Split('\n'); // Вспомогательный массив для строчки
            string[] elementsInLine; // Вспомогательный массив для элементов в строке

            int countPeeks = Convert.ToInt32(line[0]); // Кол-во вершин в графе

            mainAdjacencyMatrix = new int[countPeeks, countPeeks];

            for (int i = 1; i < line.Length; ++i)
            {
                elementsInLine = line[i].Split();

                for (int j = 1; j < elementsInLine.Length; ++j)
                {
                    if(elementsInLine[j] != "")
                    {
                        mainAdjacencyMatrix[i - 1, Convert.ToInt32(elementsInLine[j]) - 1] = 1;
                    }                    
                }
            }
        }

        // Получения списка рёбер
        public void GetEdgesList(string path)
        {
            // Вспомогательныt массивы 
            string[] Rows = path.Split('\n');
            string[] peeksInRow;

            int matrixSize = 0;
            for(int i = 0; i < Rows.Length; i++)
            {
                peeksInRow = Rows[i].Split();
                if(matrixSize < Convert.ToInt32(peeksInRow[0]))
                {
                    matrixSize = Convert.ToInt32(peeksInRow[0]);
                }
                else if(matrixSize < Convert.ToInt32(peeksInRow[1]))
                {
                    matrixSize = Convert.ToInt32(peeksInRow[1]);
                }
            }

            // Размерность матрицы смежности определяется исходя из
            // Кол-ва вершин. В списке рёбер мы можем найти кол-во вершин
            // По формуле: Кол-во строк = ориентированые + 2 * неориентированные
            mainAdjacencyMatrix = new int[matrixSize, matrixSize];

            // Заполняем матрицу смежности
            // Проходя по каждому ребру
            for (int i = 0; i < Rows.Length; ++i)
            {
                peeksInRow = Rows[i].Split();

                mainAdjacencyMatrix[Convert.ToInt32(peeksInRow[0]) - 1, Convert.ToInt32(peeksInRow[1]) - 1] = 1;
            }
        }

        // Реализация нерекурсивного обхода в глубину
        // Используем стэк
        public string DepthFirstSearch(int startPeek)
        {
            startPeek--;
            string resultPathDFS = ""; // Выходной параметр

            Stack<int> stack = new Stack<int>(); // Стэк
            stack.Push(startPeek); // Помещаем стартовую вершину в стэк для обхода

            
            HashSet<int> visitedPeeks = new HashSet<int>(); // Список посещённых вершин
            visitedPeeks.Add(startPeek); // Помечаем первую вершину, как пройденную

            while (stack.Count != 0) // Пока стэк не пустой
            {
                int topPeek = stack.Peek(); // Смотрим верхний элемент стэка
                resultPathDFS += Convert.ToString(topPeek + 1) + " "; // Добавляем его к результату

                stack.Pop(); // Удаляем его из стэка
                for (int i = mainAdjacencyMatrix.GetLength(0) - 1; i >= 0; --i)
                {
                    // Если находим ребро между вершинами
                    if (mainAdjacencyMatrix[topPeek, i] != 0)
                    {
                        // Помечаем вершину, как пройденную
                        if (!visitedPeeks.Contains(topPeek))
                        {
                            visitedPeeks.Add(topPeek);
                        }
                        // Проходим соседние вершины 
                        // Помечаем их, как пройденные
                        // Добавляем в стэк, совершаем 
                        // Обход в глубину
                        if (!visitedPeeks.Contains(i))
                        {
                            visitedPeeks.Add(i);
                            stack.Push(i);
                        }
                    }
                }
            }
            return resultPathDFS;
        }



        // Реализация нерекурсивного обхода в ширину
        // Используем "очередь" 
        public string BreadthFirstSearch(int startPeek)
        {
            startPeek--;
            string resultPathBFS = ""; // Выходной параметр 

            Queue<int> queue = new Queue<int>(); // Очередь
            queue.Enqueue(startPeek); // Помещаем стартовую вершину в очередь для обхода

            HashSet<int> visitedPeeks = new HashSet<int>(); // Список посещенных вершин
            visitedPeeks.Add(startPeek); // Помечаем первую вершину, как пройденнную

            while (queue.Count != 0) // Пока очередь не пуста
            {
                int topPeek = queue.Peek(); // Смотрим первый элемент очереди
                resultPathBFS += Convert.ToString(topPeek + 1) + " ";

                queue.Dequeue(); // Убираем первый элемент из очереди
                for (int i = 0; i < mainAdjacencyMatrix.GetLength(0); ++i)
                {
                    // Если находим ребро между вершинами
                    if (mainAdjacencyMatrix[topPeek, i] != 0)
                    {
                        // Помечаем вершину, как пройденную
                        if (!visitedPeeks.Contains(topPeek))
                        {
                            visitedPeeks.Add(topPeek);
                        }
                        // Проходим все соседние вершины
                        // Помечаем их, как пройденные
                        // Добавляем их в очередь для обхода
                        if (!visitedPeeks.Contains(i))
                        {
                            visitedPeeks.Add(i);
                            queue.Enqueue(i);
                        }
                    }
                }
            }
            return resultPathBFS;
        }

        // Алгоритм Дейкстры
        // Алгоритм поиска наикратчайшего расстояния между 
        // Двумя точками
        public string DijkstraAlgorithm(string path)
        {
            // Сначала находим длины  путей
            // дальше ищем кратчайший путь

            int startPeek = Convert.ToInt32(path.Split()[0]) - 1;
            int lastPeek = Convert.ToInt32(path.Split()[1]) - 1;

            string resultPath = "Кратчайший путь: ";
            bool[] used = new bool[mainAdjacencyMatrix.GetLength(0)];

            int[] ver = new int[mainAdjacencyMatrix.GetLength(0)];
            for(int i=0;i< mainAdjacencyMatrix.GetLength(0); ++i)
            {
                ver[i] = Int32.MaxValue;
            }
            ver[startPeek] = 0;

            int min;
            int cur = Int32.MaxValue;
            int temp;
            do
            {
                min = Int32.MaxValue; // делаем большие значения, чтобы при сравнении с весом вершин, вес вершин был ТОЧНО меньше 9999 (иначе выход из цикла)
                cur = Int32.MaxValue;
                for (int j = 0; j < mainAdjacencyMatrix.GetLength(0); j++)
                    if (used[j] == false && ver[j] < min) // ищем минимальное значение среди непосещенных вершин
                    {
                        min = ver[j]; // запоминаем вес этой вершины
                        cur = j; // запоминаем идекс текущей вершины, с которой будем дальше работать
                    }
                if (cur != Int32.MaxValue) // если мы нашли ещё не посещенную веришину
                {
                    for (int i = 0; i < mainAdjacencyMatrix.GetLength(0); i++)
                    {
                        if (mainAdjacencyMatrix[cur, i] > 0) // если две вершины связаны между собой ребром, или если вершина не связана сама с собой
                        {
                            temp = min + mainAdjacencyMatrix[cur, i];
                            if (ver[i] > temp) // если сумма минимальной вершины и расстояния от текущей вершины до соседней оказалось меньше веса соседней вершины,
                            {
                                ver[i] = temp; // то нашли меньшее растояние до соседней вершины => присваиваем соседней вершине вес равный сумме
                            }
                        }
                    }
                    used[cur] = true; // данную вершину мы посетили и больше к ней не возвращаемся
                }
            } while (cur < Int32.MaxValue); // когда все вершины будут посещены, то cur останется равной 9999 => выходим из цикла

            // когда нашли все пути
            // ищем кратчайший

            int weightOfPath = ver[lastPeek];

            int[] pathPeek = new int[mainAdjacencyMatrix.GetLength(0)];
            pathPeek[0] = lastPeek + 1;

            int w = ver[lastPeek];
            temp = 0;
            int index = 1;

            while (lastPeek != startPeek) // цикл завершится, когда конечная вершина будет равна начальной
            {
                for (int i = 0; i < mainAdjacencyMatrix.GetLength(0); i++)
                {
                    if (mainAdjacencyMatrix[i, lastPeek] > 0) // если у конечной вершины есть соседи
                    {
                        temp = w - mainAdjacencyMatrix[i, lastPeek]; // вычитаем из веса конечной вершины вес ребра, которое соединяет конечной вершины с соседней
                        if (temp == ver[i]) // если эта разность совпала с весом соседней вершины, то это значит, что мы нашли предыдущую вершину (следующую с конца)
                        {
                            w = temp; // запоминаем вес это вершины
                            lastPeek = i; // запоминаем индекс этой вершины и конечной вершиной теперь становится данная вершина
                            pathPeek[index] = i + 1; // записываем найденную вершину в массив
                            index++;
                        }
                    }
                }
            }

            for(int i = index-1; i > -1; --i)
            {
                resultPath += pathPeek[i] + " ";
            }

            resultPath +="\nДлина пути: " + weightOfPath;
            return resultPath;
        }
    }
}
