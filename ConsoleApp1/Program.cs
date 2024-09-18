using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System;
using System.Threading.Channels;
using System.Collections;

namespace ConsoleApp1
{


    class Employee {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0 && value < 120)
                    this.age = value;
            }
        }



    }

    class TestClass {
        private int rodata;
        public int ROdata
        {
            get { return rodata; }
        }
    }


    class TestPropClass {
        public int Age
        {
            get { return 3; }
            set { }
        }
    }


    class TestStackOverflow
    {
        private int age;
        public int Age
        {
            get { return age; }
            set {
                this.Age = value;
            }
        }
    }

    class Test2 {
        public int Age { get; set; }
    }

    class ChatRobot {
        private int fulllevel;
        public string Name { get; set; }

        public void SayHello() {
            Console.WriteLine("My name is {0}", Name );
        }

        public void Feed(int foodCount) {
            if (fulllevel > 100) return;
            fulllevel += foodCount;

        }

        public void Speak(string str) {
            if (fulllevel <= 0) {
                Console.WriteLine("can't speak, I need to be fed");
                return;
            }
            if (str.Contains("name"))
            {
                this.SayHello();
            }
            else if (str.Contains("girl"))
            {
                Console.WriteLine("I'm too young to have gf");
            }
            else {
                Console.WriteLine("don't understand");
            }

            fulllevel--;
        }
    }


    class Student {
        public int Age { get; set; }
        public string Name { get; set; }
        public Student() {
            Age = 18;
            Name = "New Student";
        }
        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return this.Name +"," +this.Age;
        }
    }


    class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void SayHi() {
            Console.WriteLine("Person {0} is saying HI", Name);
        }
    }

    class Chinese : Person
    {
        public string HuKou { get; set; }
        public void KongFu() {
            Console.WriteLine("Chinese {0} doing KongFu", this.Name);
        }
        public override void SayHi() {
            Console.WriteLine("Chinese sayhi");
        }
    }

    class Korean : Person
    {
        public string Fanliang { get; set; }
        public void MakePaoCai() {
            Console.WriteLine("Korean {0} making PaoCai", this.Name);
        }
        public override void SayHi()
        {
            //base.SayHi();  //可以调用父类中的方法
            Console.WriteLine("Korean sayhi");
        }
    }

    class Japanese : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Japanese sayhi");
        }
    }


    class American : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("American sayhi");
        }
    }


    abstract class Animal {
        public abstract void Bark();
    }

    class Dog : Animal {
        public override void Bark()
        {
            Console.WriteLine("Dog Wangwang..");
        }
    }

    class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("Cat Miaomiao..");
        }
    }

    abstract class AbstractBase {
        public abstract int MyProperty { get; set; }
    }

    class D : AbstractBase {
        public override int MyProperty { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }


    class Computer {
        public void Read(StorageDevice device) {
            device.Read();
        }
        public void Write(StorageDevice device) {
            device.Write();
        }
    }

    abstract class StorageDevice {
        public abstract void Read();
        public abstract void Write();
    }

    class USB : StorageDevice {
        public override void Read()
        {
            Console.WriteLine("USB Reading...");
        }

        public override void Write()
        {
            Console.WriteLine("USB Writing...");
        }
    }

    class HardDisk : StorageDevice
    {
        public override void Read()
        {
            Console.WriteLine("HardDisk Reading...");
        }

        public override void Write()
        {
            Console.WriteLine("HardDisk Writing...");
        }
    }


    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
