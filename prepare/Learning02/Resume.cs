public class Resume
{
    public string _name = "";
    public List<Job> _listOfJobs = new List<Job>();

    public Resume()
    {

    }

    public void ResumeInfo()
    {
        Console.WriteLine($"Name: {_name} ");
        Console.WriteLine($"Jobs: ");
        
        foreach (Job job in _listOfJobs)
        {
            job.JobInfo();
        }
    }
}
