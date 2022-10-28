
Type typeDate = typeof(DateTime); //получение типа DateTime в переменной typeDate

foreach (var prop in typeDate.GetProperties()) //пока prop в пределах свойств DateTime
                                               //.GetProperties() возвращает ВСЕ свойства структуры 
    Console.WriteLine(prop.Name); //выводим названия свойств

Console.ReadKey(); //для красоты
