using HW2.Base;
using HW2.WorkWtihFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Menu 
    {
        public void MenuS()
        {

            
            Exep exep = new Exep();
            
            
            Base.BaseConnect baseConnect = new();
            

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Что вы хотите сделать?");

            Console.WriteLine("1. Прочитать из файла (Файл должен находться по адресу: C:\\tmp\\Sample.txt)" +
                              "\n2. Записать в файл (Файл должен находться по адресу: C:\\tmp\\Sample1.txt)" +
                              "\n3. Вывод n-го члена последовательности Фибоначчи" +
                              "\n4. Завершить программу" +
                              "\n5. Чтение из базы" +  //TODO необходимо реализовать отдельное меню для работы с базой
                              "\n6. Сделать запись в таблицу PC" +
                              "\n7. Удалить запись из таблицы" +
                              "\n8. Изменить запись в таблице");

            do
            {
                Console.Write("Седлайте свой выбор введя номер пункта меню: ");

                switch (exep.CheckExeption())
                {
                    case 1:
                        ReadFile readFile = new ReadFile();
                        Console.WriteLine("Сколько строк файла хотите прочитать?");
                        readFile.Read(exep.CheckExeption());
                        break;

                    case 2:
                        WriteFile writeFile = new WriteFile();
                        Console.WriteLine("Введите адрес сайта для записи данных:");
                        writeFile.WriteF();
                        break;

                    case 3:
                        Fib fib = new Fib();
                        Console.Write("Введите n-й член последовательности: ");
                        Console.WriteLine(fib.Fibonachi(exep.CheckExeption()));
                        break;

                    case 4:
                        Console.WriteLine("Программа завершена, спасибо за использование!");
                        Environment.Exit(0);
                        break;

                    case 5:
                        Console.WriteLine("Чтение данных из таблицы PC");
                        baseConnect.ReadData();
                        break;

                    case 6:
                        Console.WriteLine("Запись в таблицу PC");
                        PCSpec pCSpec = new PCSpec();
                        //todo Добавить заполнение остальных полей(RAM,HD,CD) и убрать в отдельный класс
                        Console.WriteLine("Model");
                        pCSpec.model = Console.ReadLine();
                        
                        Console.WriteLine("Speed");
                        pCSpec.speed = int.Parse(Console.ReadLine());

                        Console.WriteLine("Price");
                        pCSpec.price = double.Parse(Console.ReadLine());

                        baseConnect.WriteNewData(pCSpec);
                        break;

                    case 7:
                        PCSpec pCSpec1 = new PCSpec();
                        baseConnect.ReadData();
                        Console.WriteLine("Введите CODE записи которую хотите удалить");
                        baseConnect.DeleteData(exep.CheckExeption(), pCSpec1);
                        break;

                    case 8:
                        PCSpec pCSpec2 = new PCSpec();
                        //TODO Все проверки необходимо убрать из меню
                        
                        Console.Write("Введите code записи которую хотите изменить: ");
                        int code = exep.CheckExeption();
                        
                        Console.Write("Введите название поля, которое хотите изменить: ");
                        string field = Console.ReadLine();
                        while (true)
                        {
                            //todo переделать условие с ипользванием кортежей
                            if (field != "model" )//|| field != "speed" || field != "ram" || field != "hd" || field != "cd" || field != "price") 
                            {
                                Console.Write("Вы ввели не верное имя столбца, попробуйте еще раз:");
                                field = Console.ReadLine();
                            }
                            else { break; }
                        }
                        Console.Write("Введите новые данные для поля model: ");
                        var data = Console.ReadLine(); //TODO не вводить никакие значения кроме string нужно по полю field делать проверку вводимых значений if(field == "ram"){ data = int.TryParse(Console.ReadLine());} итд...
                        baseConnect.UpdateData(code,field,data,pCSpec2);
                        break;
                }
            }
            while (true);
        }
    }
}
