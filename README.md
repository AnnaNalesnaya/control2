gin init
Инициализируем папку "контрольная"
Создаем репозиторий на GitHab
git remote add origin https://github.com/AnnaNalesnaya/control2.git
git branch -M main

Задаем массив.
string[] myArray = { "Елена", "Яна", "Ольга", "Ада", "Зоя", "Мария", "Ая" };
git add .
git commit -am "Создание первоначального массива"
Новый массив создаем путем выбора из первоначального массива
string[] newArray = CreatNewArray(myArray);
Метод выбора нового массива из перврначального.
string[] CreatNewArray(string[] array)
В переменную "j" складываем слова в которых три или меньше символов. j переменная, счетчик
  if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
git add .
git commit -am "Создание метода сборки нового массива"
Метод вывода на экран массива
void PrintArray(string[] array)  
git add .
git commit -am "Создание метода вывода на экран массива"
Вывод первоначального массива
PrintArray(myArray);  
Вывод нового массива
PrintArray(newArray);
git add .
git commit -am "Задание выполненно, программа работает"
Файл с блок-схемой алгоритма находится  в папке "контрольная"
Запушиваем задание на GitHab
