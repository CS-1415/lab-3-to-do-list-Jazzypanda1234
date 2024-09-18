// Mathew Olsen 9/18/24 Lab 3 - ToDo List

List<Task> tasks = new() {new Task("Homework", "Calculus Homework", false, 1), new Task("Laundry", "Pants and Shirts", true, 2)};
    
Console.WriteLine("This is a to do list. You can modify the list to add tasks, mark tasks as complete, or view a tasks information.");

while (true){
    Console.WriteLine("ID Task\n --------------------------");

    foreach(var item in tasks){
        Console.WriteLine(item.DisplayTask());
    }

    Console.WriteLine("Press '+' to add a task. Press 'x' to toggle whether or not the task is complete. Press 'i' to view a task's information.");
    char Choice = char.Parse(Console.ReadLine());
    
    if (Choice == '+'){
        int Id = tasks.Count()+1;
        Console.WriteLine("Please Input a Title: ");
        string Title = Console.ReadLine();
        Console.WriteLine("Please Input a Description: ");
        string Description = Console.ReadLine();
        tasks.Add(new Task(Title, Description, false, Id));
    }
    else if (Choice == 'i'){
        Console.WriteLine("Please input the task Id: ");
        int IdChoice = int.Parse(Console.ReadLine());
        Console.WriteLine(tasks[IdChoice-1].DisplayDescription());
        
    }
    else if (Choice == 'x'){
        Console.WriteLine("Input task Id to toggle: ");
        int IdChoice = int.Parse(Console.ReadLine());
        tasks[IdChoice-1].MarkAsCompleted();
    }
    else{
        Console.WriteLine("Please try again.");
    }
}
   


public class Task
{
    public string Title;
    public string Description;
    public bool IsComplete;
    public int Id;

    public Task(string Title, string Description, bool IsComplete, int Id) {
        this.Title = Title;
        this.Description = Description;
        this.IsComplete = IsComplete;
        this.Id = Id;
    }
    
    public string DisplayTask() {
        return $"[{(IsComplete ? 'x' : ' ')}] {Id} {Title}";
    }
    public string DisplayDescription(){
        return Description;
    }
    public void MarkAsCompleted(){
        IsComplete = IsComplete ? false : true;
    }
}
