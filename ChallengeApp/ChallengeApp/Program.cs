Console.WriteLine("Привет, я могу посчитать твой ИМТ. Для начала представься.");
string Name = Console.ReadLine();
Console.WriteLine("Рад знакомству, " + Name + ". А теперь подай свой рост в сантиметрах");


int height = int.Parse(Console.ReadLine());

if (height >= 185)
{
    Console.WriteLine("Это на растишке так? Неплохо, неплохо... А какой у тебя вес?");
}
else if (height <= 155)
{
    Console.WriteLine("Кто-то забыл совсем кашу есть по утрам.. окей. А какой у тебя вес?");
}
else
{
    Console.WriteLine("Неплохо. А какой у тебя вес?");
}



int weight = int.Parse(Console.ReadLine());

if (weight <= 50 && height <= 166)
{
    Console.WriteLine("Маловато. Перейдем к результатам? Напиши Да");
}
else if (weight >= 51 && weight <= 70 && height >= 167 && height <= 182)
{
    Console.WriteLine("Неплохо. К результатам? Напиши Да");
}
else if (weight >= 71 && weight <= 100 && height >= 183 && height <= 363)
{
    Console.WriteLine("Хорошечно. К результам? Напиши Да");
}
else if (height >= 363)
{
    Console.WriteLine("Ля ты дылда. Сам считай");
}
else
{
    Console.WriteLine("Смело... К результам? Напиши Да");
}

double heightMeters = height / 100.0;
double IMT = weight / (heightMeters * heightMeters);

string Answer =  Console.ReadLine();
if (Answer == "Да")
{
    Console.WriteLine("Пизда ахахахахах. Вот твои результаты. Твой ИМТ = " + IMT);
}
else if (Answer == "Нет")
{
    Console.WriteLine("Говна пакет. До видзеня.");
}
else
{
    Console.WriteLine("Писать научись блять");
}
Console.WriteLine("Недостаточная масса тела: ИМТ менее 18.5\r\nНормальная масса тела: ИМТ 18.5-24.9\r\nИзбыточная масса тела: ИМТ 25-29.9\r\nОжирение: ИМТ 30 и более");
if (IMT < 18.5)
{
    Console.WriteLine("Мало кушаешь");
}
else if (IMT >= 18.5 && IMT <= 24.9)
{
    Console.WriteLine("Хорошечный индекс как видишь");
}
else if (IMT >= 25 &&  IMT <= 29.9)
{
    Console.WriteLine("Кто-то любит поесть");
}
else
{
    Console.WriteLine("Явное ожирение получается");
}