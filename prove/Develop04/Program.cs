using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        int choice = 0;
        while (choice != 4){
        Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflection Activity\n3. Start Lister Activity\n4. Quit");
        Console.Write("Select Your Choice Form the Menu: ");
        choice = int.Parse(Console.ReadLine());
        if(choice == 1){
            BreathingActivity breath = new BreathingActivity();
            breath.InteractBreathing();
        }
        else if(choice == 2){
            ReflectionActivity reflect = new ReflectionActivity();
            reflect.InteractReflection();
        }
        else if(choice == 3){
            ListerActivity lister = new ListerActivity();
            lister.InteractLister();
        }
        else if(choice == 4){
            break;
        }
        else{
            Console.WriteLine("Incorrect Input. Try Again");
        }
    }
    }
}