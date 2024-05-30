using System;
using System.Collections.Generic;
/*
1

На вход: номер телефона, даты разговора, времени начала разговора, кол-ва минут

Необходимо выдать месячный отчёт по общей сумме разговоров (минут) каждого номера

Данные подаются ровно за один месяц

Сами данные считываем в очередь

Используем чтобы подсчитать сумму минут с помощью словаря и хештаблицы

В качестве ключа номер телефона

В качестве значения кол-во минут соответствующей данному номеру телефона

На выход выдать данные из словаря и хештаблицы

Они должны совпадать

Можем считывать построчно

Если с классами то номер и минуты, но не обязательно

2

Данные приходят также

Суммарное время разговоров по каждому дню по всем номерам

Теперь ключ - дата, значение - кол-во разговоров

Использование словаря и таблицы
*/
class Program
{
    static void Main(string[] args)
    {
        var zvonki = new List<(string, string, int)>
        {
            ("8913КОЛЯ", "13.09.24", 3),
            ("8913ДЕНИС", "13.09.24", 5),

            ("8913КОЛЯ", "15.09.24", 1),
            ("8913ДЕНИС", "15.09.24", 6),
            ("8913КОЛЯ", "15.09.24", 9),

            ("8913КОЛЯ", "17.09.24", 7),
            ("8913ДЕНИС", "17.09.24", 3),
            ("8913КОЛЯ", "17.09.24", 5),
            ("8913КОЛЯ", "17.09.24", 5),
         };

        Console.WriteLine("1");
        Dictionary<string, int> mesyac_Dict = new Dictionary<string, int>();
        Dictionary<string, int> mesyac_HashTable = new Dictionary<string, int>();

        foreach (var zvonok in zvonki)
        {
            string phoneNumber = zvonok.Item1;
            int minutes = zvonok.Item3;

            if (mesyac_Dict.ContainsKey(phoneNumber))
            {
                mesyac_Dict[phoneNumber] += minutes;
            }
            else
            {
                mesyac_Dict[phoneNumber] = minutes;
            }
            string key = phoneNumber;
            if (mesyac_HashTable.ContainsKey(key))
            {
                mesyac_HashTable[key] += minutes;
            }
            else
            {
                mesyac_HashTable[key] = minutes;
            }
        }
        Console.WriteLine("Словарь:");
        foreach (var zvonok in mesyac_Dict)
        {
            Console.WriteLine($"Телефон: {zvonok.Key} Сумма минут: {zvonok.Value}");
        }

        Console.WriteLine("Хэш-таблица:");
        foreach (var zvonok in mesyac_HashTable)
        {
            Console.WriteLine($"Телефон: {zvonok.Key}, Сумма минут: {zvonok.Value}");
        }


        Console.WriteLine("2");
        Dictionary<string, int> day_Dict = new Dictionary<string, int>();
        Dictionary<string, int> day_HashTable = new Dictionary<string, int>();

        foreach (var call in zvonki)
        {
            string date = call.Item2;
            int mins = call.Item3;

            if (day_Dict.ContainsKey(date))
                day_Dict[date] += mins;
            else
                day_Dict[date] = mins;

            if (day_HashTable.ContainsKey(date))
                day_HashTable[date] += mins;
            else
                day_HashTable[date] = mins;
        }

        Console.WriteLine("Словарь:");
        foreach (var zvonok in day_Dict)
        {
            Console.WriteLine($"Дата: {zvonok.Key} Сумма минут: {zvonok.Value}");
        }

        Console.WriteLine("Хэш-таблица:");
        foreach (var zvonok in day_HashTable)
        {
            Console.WriteLine($"Дата: {zvonok.Key}, Сумма минут: {zvonok.Value}");
        }
    }
}