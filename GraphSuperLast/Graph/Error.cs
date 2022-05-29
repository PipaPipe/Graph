using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    // описание структуры, которая будет
    // хранить информацию об ошибках
    public struct SingleError
    {
        public int[] ErrorPosition; // массив с координатами ошибки {строка, столбец}
        public int ErrorCode; // код ошибки для словаря

        public SingleError(int[] ErrorPosition, int ErrorCode) // конструктор структуры
        {
            this.ErrorPosition = ErrorPosition;
            this.ErrorCode = ErrorCode;
        }
    }


    public class Error
    {
        public List<SingleError> SingleErrorList; // список со структурами ошибок 
        private int[] pos; // массив с координатами ошибок

        public Error() { }

        private string[] CorrectLine(string path) // привод строки к корректному виду
        {
            string[] lines = path.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim('\r');
            }

            return lines;
        }

        public void smException(string path) // проверка корректности матрицы смежности 
        {
            SingleError se; // структура
            SingleErrorList = new List<SingleError>(); // новый список ошибок

            bool ok = true;
            string[] lines = CorrectLine(path); // массив строк
            string[] elementsOfLine; // массив элементов строки

            //размерность матрицы
            int row = lines.Length; // кол-во строк
            int column = lines[0].Split().Length; // кол-во столбцов
            int number; // неиспользуемая переменная


            // Проверка количества вершин (не боольше 8)
            if (row > 8 || column > 8)
            {
                pos = new int[] { -1, -1 };
                se = new SingleError(pos, 8);
                SingleErrorList.Add(se);
                return;
            }

            // Проверка на совпадение количества строк и столбцов
            if(row != column)
            {
                pos = new int[] { -1, -1 };
                se = new SingleError(pos, 11);
                SingleErrorList.Add(se);
                ok = false;
            }

            // базовые проверки 
            for (int i = 0; i < row; i++) // проходимся по всем строкам
            {
                elementsOfLine = lines[i].Split(); // заполняем массив элементов

                elementsOfLine = (from num in elementsOfLine where num != "" select num).ToArray(); // удаляем пустые строки из массива элементов

                if (elementsOfLine.Length != column) // проверка совпадения длины строки с длиной столбца
                {
                    pos = new int[] { i, -1 }; // записываем позицию ошибки 
                    se = new SingleError(pos, 1);
                    SingleErrorList.Add(se);
                    ok = false;

                }

                if (elementsOfLine[i] != '0'.ToString()) // проверка элементов главной диагонали
                {
                    pos = new int[] { i, i };
                    se = new SingleError(pos, 2);
                    SingleErrorList.Add(se);
                    ok = false;
                }

                for (int j = 0; j < elementsOfLine.Length; j++)
                {
                    if (!int.TryParse(elementsOfLine[j], out number)) // если строка содержит не число 
                    {
                        pos = new int[] { i, j };
                        se = new SingleError(pos, 10);
                        SingleErrorList.Add(se);
                        ok = false;
                    }
                }
            }


            if (ok) // если с матрицей смежности все ок - мы проверяем её смежность 
            {
                string[,] mas = new string[row, column];

                // заполнение массива элементов для проверки симметричности 
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        mas[i, j] = lines[i].Split()[j];
                    }
                }

                // проверка симметричности матрицы смежности 
                for (int i = 0; i < row; i++)
                {
                    for (int j = i; j < column; j++)
                    {
                        if (mas[i, j] != mas[j, i]) // если не матрица симметрична - записываем позиций элементов
                        {
                            pos = new int[] { i, j };
                            se = new SingleError(pos, 3);
                            SingleErrorList.Add(se);

                            pos = new int[] { j, i };
                            se = new SingleError(pos, 3);
                            SingleErrorList.Add(se);
                        }
                    }
                }
            }
        }


        public void incidenceException(string path) // проверка матрицы инцидентности
        {
            SingleError se;
            SingleErrorList = new List<SingleError>();

            string[] lines = CorrectLine(path); // массив строк
            string[] elementsOfLine; // массив элементов строки
            int row = lines.Length; // количество строк
            int columns = lines[0].Split().Length; // количество столбцов
            int number;
            bool ok = true;

            // проверка количества вершин (не более 8)
            if (row > 8)
            {
                pos = new int[] { -1, -1 };
                se = new SingleError(pos, 8);
                SingleErrorList.Add(se);
                return;
            }

            // первичные проверки матрицы инцидентности 
            for (int i = 0; i < row; i++)
            {
                elementsOfLine = lines[i].Split();
                elementsOfLine = (from num in elementsOfLine where num != "" select num).ToArray(); // очистка 
                for (int j = 0; j < elementsOfLine.Length; j++)
                {
                    if (lines[i].Split().Length != columns) // если в строке меньше или больше элементов, чем должно быть
                    {
                        pos = new int[] { i, -1 };
                        se = new SingleError(pos, 1);
                        SingleErrorList.Add(se);
                        ok = false;
                    }

                    if (!int.TryParse(elementsOfLine[j], out number)) // если строка содержит не число
                    {
                        pos = new int[] { i, j };
                        se = new SingleError(pos, 10);
                        SingleErrorList.Add(se);
                        ok = false;
                    }
                }
            }



            if (ok)
            {
                string[,] mas = new string[row, columns]; // матрица инциденции
                // заполнение матрицы инциденции
                for (int i = 0; i < row; i++)
                {
                    elementsOfLine = lines[i].Split();
                    for (int j = 0; j < columns; j++)
                    {
                        mas[i, j] = elementsOfLine[j];
                    }
                }

                // проверка количества единиц в столбце (их доолжно быть ровно 2)
                int count = 0;
                for (int j = 0; j < columns; j++)
                {
                    for (int i = 0; i < row; i++)
                    {
                        if (mas[i, j] == '1'.ToString())
                        {
                            count++; // количество единиц в столбце
                        }
                    }

                    if (count != 2) // если не две единицы
                    {
                        pos = new int[] { -1, j };
                        se = new SingleError(pos, 4);
                        SingleErrorList.Add(se);
                    }
                    count = 0;
                }
            }
        }


        public void spSmejException(string path) // список смежности 
        {
            SingleError se;
            SingleErrorList = new List<SingleError>();

            string[] lines = CorrectLine(path); // массив строк
            string[] elementsOfLine; // массив элементов строки
            int number;


            List<List<string>> ver = new List<List<string>>();
            bool ok = true;
            // проверка первой строки на количество элементов
            if (lines[0].Length != 1)
            {
                pos = new int[] { 0, -1 };
                se = new SingleError(pos, 5);
                SingleErrorList.Add(se);
                ok = false;
            }
            else
            {
                // проверка на соответствие заданного количества вершин
                // и описанных вершин
                int n; // количество вершин в первой строке
                bool isNum = int.TryParse(lines[0], out n); //Проверка первого числа на корректность

               
                if (n > 8)
                {
                    pos = new int[] { 0, -1 };
                    se = new SingleError(pos, 8);
                    SingleErrorList.Add(se);
                    ok = false;
                }
                else if (lines.Length - 1 != n) // если количество заданых вершин не соответствует количеству описанных вершин 
                {
                    pos = new int[] { 0, -1 };
                    se = new SingleError(pos, 6);
                    SingleErrorList.Add(se);
                    ok = false;
                }

                for (int i = 0; i < lines.Length; i++)
                {
                    elementsOfLine = lines[i].Split();
                    elementsOfLine = (from num in elementsOfLine where num != "" select num).ToArray();
                    for (int j = 0; j < elementsOfLine.Length; j++)
                    {
                        if (!int.TryParse(elementsOfLine[j], out number))
                        {
                            pos = new int[] { i, j };
                            se = new SingleError(pos, 10);
                            SingleErrorList.Add(se);
                            ok = false;
                        }
                    }
                }
            }

            if (ok)
            {
                // добавление списков элементов 
                for (int i = 0; i < lines.Length; i++)
                {
                    ver.Add(new List<string>());
                    foreach (string str in lines[i].Split())
                    {
                        ver[i].Add(str);
                    }
                }

                // проверка взаимной смежности
                for (int i = 1; i < ver.Count; i++)
                {
                    ver[i].Remove(ver[i][0]);
                    foreach (string str in ver[i])
                    {
                        if (Convert.ToInt32(str) > lines.Length - 1)
                        {
                            pos = new int[] { i, -1 };
                            se = new SingleError(pos, 12);
                            SingleErrorList.Add(se);
                        }
                        else if (!ver[Convert.ToInt32(str)].Contains(i.ToString()))
                        {
                            pos = new int[] { i, -1 };
                            se = new SingleError(pos, 7);
                            SingleErrorList.Add(se);
                        }
                    }
                }
            }
        }


        public void spEdge(string path) // Список ребер 
        {
            SingleError se;
            SingleErrorList = new List<SingleError>();

            string[] lines = CorrectLine(path); // массив строк
            string[] elementsOfLine; // массив элементов строки
            int number;
            bool ok = true;

            if (lines.Length > 64) // верхняя граница числа строк  
            {
                pos = new int[] { -1, -1 };
                se = new SingleError(pos, 8);
                SingleErrorList.Add(se);
                return;
            }

            // проверка на наличие символов 
            for (int i = 0; i < lines.Length; i++)
            {
                elementsOfLine = lines[i].Split();
                elementsOfLine = (from num in elementsOfLine where num != "" select num).ToArray();
                for (int j = 0; j < elementsOfLine.Length; j++)
                {
                    if (!int.TryParse(elementsOfLine[j], out number))
                    {
                        pos = new int[] { i, j };
                        se = new SingleError(pos, 10);
                        SingleErrorList.Add(se);
                        ok = false;
                    }
                }
            }

            for (int i = 0; i < lines.Length; i++) // проверка количетва элементов (должно быть 2)
            {
                elementsOfLine = lines[i].Split();
                elementsOfLine = (from num in elementsOfLine where num != "" select num).ToArray();
                if (elementsOfLine.Length != 2)
                {
                    pos = new int[] { i, -1 };
                    se = new SingleError(pos, 5);
                    SingleErrorList.Add(se);
                    ok = false;
                }
            }

            if (ok)
            {
                char[] revLine; // массив для переворота
                string revStr;  // перевернутая строка
                for (int i = 0; i < lines.Length; i++)
                {
                    revLine = lines[i].ToCharArray(); // перевожу строку элементов в массив char
                    Array.Reverse(revLine); // переворачиваю массив
                    revStr = new string(revLine); // перевожу перевернутый массив в строку

                    // проверяю: содержит ли исходная строка
                    // (которая пришла параметром) перевернутый элемент
                    if (!path.Contains(revStr))
                    {
                        pos = new int[] { i, -1 };
                        se = new SingleError(pos, 9);
                        SingleErrorList.Add(se);
                    }
                }
            }
        }


        public string GetError() // вывод строки с ошибками
        {
            string output = "";
            foreach (SingleError se in SingleErrorList)
            {
                if (se.ErrorPosition[0] == -1 && se.ErrorPosition[1] != -1) // вывод без номера строки с ошибкой
                {
                    output += $"В столбце - {se.ErrorPosition[1] + 1} ошибка: {CodeForError[se.ErrorCode]}\n";
                }
                else if (se.ErrorPosition[1] == -1 && se.ErrorPosition[0] != -1) // вывод без номера столбца с ошибкой
                {
                    output += $"В строке - {se.ErrorPosition[0] + 1} ошибка: {CodeForError[se.ErrorCode]}\n";
                }
                else if (se.ErrorPosition[0] == -1 && se.ErrorPosition[1] == -1) // вывод ошибки без локализации 
                {
                    output += $"Ошибка: {CodeForError[se.ErrorCode]}\n";
                }
                else // вывод полной координаты ошибки 
                {
                    output += $"В строке - {se.ErrorPosition[0] + 1}  столбце - {se.ErrorPosition[1] + 1} ошибка: {CodeForError[se.ErrorCode]}\n";
                }
            }

            return output;
        }


        // слоаврь с ошибками 
        private Dictionary<int, string> CodeForError = new Dictionary<int, string>
        {
            // Универсальные ошибки
            {1,"Количество элементов не соответствует размерности матрицы"},
            {8,"Вы ввели недопустимое количество вершин. Максимальное число вершин 8" },
            {10,"Вы ввели недопустимый символ" },

            // Ошибки для матрицы смежности
            {2,"Вершина не может быть смежна сама с собой"},
            {3,"Матрица смежности не симметрична" },
            {11, "Количество строк не совпадает с количеством столбцов" },

            //Ошибки для матрицы инцидентности
            {4,"В столбце не допустимое количество единиц. Ожидается ровно две единицы"},

            //Ошибки списка смежности
            {5,"Указано некорректное количество вершин"},
            {6,"Заданное количество вершин не совпадает с количеством описанных вершин"},
            {7,"Невзаимная смежность" },
            {12, "Введена некорректная вершина" },

            //Ошибки для списка ребер
            {9,"Отсутствует описание смежной вершины" }
        };
    }
}
