using System;

namespace BirdSimulator
{
    interface IBird
    {
        void Fly();
        void Swim();
        void MakeSound();

    }

    interface IWalk
    {
        void Walk();
    }
    class Duck : IBird,IWalk
    {
        public void Fly()
        {
            Console.WriteLine("duck cannot fly");
        }
        public void Swim()
        {
            Console.WriteLine("duck can swim");
        }
        public void MakeSound()
        {
            Console.WriteLine("duck quacks");
        }
        public void Walk()
        {
            Console.WriteLine("duck walks");
        }
    }
    class Parrot : IBird
    {
        public void Fly()
        {
            Console.WriteLine("parrot can fly");
        }
        public void Swim()
        {
            Console.WriteLine("parrot cannot swim");
        }
        public void MakeSound()
        {
            Console.WriteLine("parrot screeches");
        }
    }
    class Crow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("crow can fly");
        }
        public void Swim()
        {
            Console.WriteLine("crow cannot swim");
        }
        public void MakeSound()
        {
            Console.WriteLine("crow caws");
        }
    }
    class Kiwi : IBird, IWalk
    {
        public void Fly()
        {
            Console.WriteLine("kiwi cannot fly");
        }
        public void Swim()
        {
            Console.WriteLine("kiwi cannot swim");
        }
        public void MakeSound()
        {
            Console.WriteLine("kiwi cries");
        }
        public void Walk()
        {
            Console.WriteLine("kiwi walks");
        }
    }

    enum BirdChoice
    {
        Duck=1,
        Parrot,
        Crow,
        Kiwi
    }
    class Program
    {
        static void ToWalk(int choice)
        {
            if(choice==1)
            {
                Duck Temp = new Duck();
                Temp.Walk();
            }
            else if (choice == 4)
            {
                Kiwi Temp = new Kiwi();
                Temp.Walk();
            }
            else
            {
                Console.WriteLine("walk not applicable to the chosen bird");
            }
        }
        static void Menu(IBird b, int choice)
        {
            int menuChoice;
            
                Console.WriteLine("What action do you wish to perform\n1.fly\t2.display\t3.swim\t4.make a sound\n5.walk(Only for duck and kiwi)\t");
                menuChoice = Convert.ToInt32(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    b.Fly();
                    break;
                case 2:
                    Console.WriteLine("Displaying " + (BirdChoice)choice);
                    break;
                case 3:
                    b.Swim();
                    break;
                case 4:
                    b.MakeSound();
                    break;
                case 5:
                    ToWalk(choice);
                    break;
                default:
                    Console.WriteLine("enter a valid choice");
                    break;
            }
            
            
        }

        static void Main(string[] args)
        {
            char continueChoice = 'y';
            while((continueChoice=='y')||(continueChoice=='Y'))
            {
                int choice;
                Console.WriteLine("Choose your bird\n1.Duck\n2.Parrot\n3.Crow\n4.Kiwi\nEnter your choice\t");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (int)BirdChoice.Duck:
                        IBird d=new Duck();
                        Menu(d,choice);
                        break;
                    case (int)BirdChoice.Parrot:
                        IBird p=new Parrot();
                        Menu(p,choice);
                        break;
                    case (int)BirdChoice.Crow:
                        IBird c= new Crow();
                        Menu(c,choice);
                        break;
                    case (int)BirdChoice.Kiwi:
                        Kiwi k=new Kiwi();
                        Menu(k,choice);
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        break;
                }

                Console.WriteLine("Do you wish to continue?(Y/N)");
                continueChoice=Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
