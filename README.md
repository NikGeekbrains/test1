## Описание решения
>1. Начальные данные
1. string Massive[10] //Начальный массив
2. int dlina = 0 // Счетчик массива
3. int count = 0 // Счетчик элементов массива, удовлетворяющих условию <= 3 символам


>2. Введение значений элементов массива
1. Пока dlina < Massive.Length - Ввести значение элемента 

>3. Обнулить dlina

>4. Посчитать количество элементов, удовлетворяющих условию <= 3 символа, и установить длину нового массива, состоящего из элементов удовлетворяющих условию.
1. Пока dlina < Massive.Length 
а) если элемент удовлетворяет условию <= 3 символа - увеличить значение count на один
 
>5. Создать массив с длиной count, обнулить dlina, ввести счетчик для элементов нового массива

>6. Присвоить элементам нового массива все значения элементов старого массива, удовлетворяющих условию <= 3 символа
1. Пока dlina < Massive.Length 
а) если элемент удовлетворяет условию <= 3 символа - присвоить его значение элементу нового массива и увеличить счетчик на один (i++)

>7. Вывести на экран новый массив
