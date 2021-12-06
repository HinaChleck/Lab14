using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        /*Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

        абстрактное свойство - название животного.
        В классе Animal нужно определить следующие методы:

        конструктор, устанавливающий значение по умолчанию для названия;
        абстрактный метод Say(), который выводит звук, который издает животное;
        неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
        Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

        свойство – название животного;
        метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
        Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.

        */
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.Say();
            Console.WriteLine();
            cat.ShowInfo();

            Console.WriteLine();

            Animal dog = new Dog();
            dog.Say();
            Console.WriteLine();
            dog.ShowInfo();



            Console.ReadKey();
        }
     
    }
    abstract class Animal
    {
        
        public abstract string Name { get; set; }

        public  Animal(string name = "Неизвестное животное")
        {
            Name=name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }  
          
    }
    class Cat : Animal
    {
        string name;
        public override string Name 
        { 
            get
            { 
                return name;
            }                
            set
            {
                name = "Кошка";
            } 
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        string name;
        public override string Name 
        { 
            get
            { 
                return name;
            }                
            set
            {
                name = "Собака";
            } 
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
    
}
