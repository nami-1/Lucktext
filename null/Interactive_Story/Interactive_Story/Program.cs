Console.BackgroundColor = ConsoleColor.Magenta;


Console.WriteLine(" Hello, what is your name?");

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}");

Console.WriteLine("You came to the end of the road and now need to choose a path, which path are you choosing right or left?");

string path = Console.ReadLine();



if (path == "right"){
   Console.WriteLine("Now you could decide which drink you enjoy the most fanta or sprite ?");

   string drink = Console.ReadLine();

   if (drink == "fanta") {
      Console.WriteLine("Fanta is a good decision! (End of the story)");
   }

   else if (drink == "sprite"){
      Console.WriteLine("Sprite is a good decsion! (End of the story)");
   }

}


else if (path == "left"){
     Console.WriteLine("Now choose between these two meals: pizza or hamburger");

     String food = Console.ReadLine();

     if (food == "pizza"){
      Console.WriteLine("Pizza is better right? (End of the story)");
     }

     else if (food == "hamburger"){
      Console.WriteLine("Hamburger over pizza? (End of the story)");
     }

}




Console.ReadLine();



