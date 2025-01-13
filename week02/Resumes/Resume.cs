using System;

public class Resume
{
    public string _name;

    //I ensure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //I'm conscious of the use of custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            //This calls the Display method on each job
            job.Display();
        }
    }
}