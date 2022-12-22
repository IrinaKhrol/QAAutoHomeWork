//Подсчитайте и выведите на экран средний бал

int[] myArray = { 10, 9, 8, 6, 7, 8, 9, 8, 9, 8 };
float sum = 0;
for (int i = 0; i < myArray.Length; i++)
    sum += myArray[i];

Console.WriteLine(sum / myArray.Length);

Console.WriteLine();

// Создайте и произвольно заполните массив типа int для хранения оценок по предметам

int[] array = new int[10];
array[0] = 10;
array[1] = 9;
array[2] = 8;
array[3] = 7;
array[4] = 7;
array[5] = 8;
array[6] = 9;
array[7] = 10;
array[8] = 9;
array[9] = 8;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(array[i]);
    Console.WriteLine();

}


// Найдите максимальную и минимальную оценку в массиве

int[] numbers = { 10, 9, 8, 6, 7, 8, 9, 8, 9, 8 };

int minNumber = numbers[0];
int maxNumber = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }

    if (numbers[i] > maxNumber)
        maxNumber = numbers[i];
}

Console.WriteLine(minNumber);
Console.WriteLine(maxNumber);


