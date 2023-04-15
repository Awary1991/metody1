// Вызываем метод создания массива и его заполнение случайными числами
int[] GenerateArray(int length)
{
    int[] array = new int[length]; 

    Random random = new Random(); 

    for (int i = 0; i< length; i++) 
    {
        array[i] = random.Next(99, 1000); 
    }

    return array; 
}


// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}



//Метод определения минимального значения в массиве
double FindMinNumberArray (double[] array)
{
    double min = 100; 

    for(int i = 0; i < array.Length; i++) 
    {
        if (min > array[i]) 
        {
            min = array[i]; 
        }
    }
    
    return min; 
}

//Метод определения максимального значения в массиве
double FindMaxNumberArray (double[] array)
{
    double max = 0; 

    for(int i = 0; i < array.Length; i++) 
    {
        if (max < array[i]) 
        {
            max = array[i]; 
        }
    }
    
    return max; 
}


// ввод в консоль переменной с проверкой что это не буквы
bool isParsed = int.TryParse(Console.ReadLine(), out int size);



// проверка что введены числа
if (!isParsed) 
{
    Console.WriteLine("Введено не число");
    return; 
}

 // если в качестве размера массива введен 0
if (size == 0) 
{
    Console.WriteLine("Размер массива должен быть больше 0");ь
    return;
}

