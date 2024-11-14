using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////////////////////////
        Job job1 = new Job();
        job1._jobTitle  = "Software Engineer";
        job1._company   = "Microsoft";
        job1._startYear = "2019";
        job1._endYear   = "2022";
        //job1.JobInfo();
        
        //////////////////////////////////////
        Job job2 = new Job();
        job2._jobTitle  = "Junior Developer";
        job2._company   = "Linux";
        job2._startYear = "2022";
        job2._endYear   = "2023";
        //job2.JobInfo();

        //////////////////////////////////////
        Job job3 = new Job();
        job3._jobTitle  = "Senior Developer";
        job3._company   = "Linux";
        job3._startYear = "2023";
        job3._endYear   = "current";
        //job3.JobInfo();
    

        //////////////////////////////////////
        Resume myResume = new Resume();
        myResume._name = "Omar Manantan";
        myResume._listOfJobs.Add(job1);
        myResume._listOfJobs.Add(job2);
        myResume._listOfJobs.Add(job3);
        myResume.ResumeInfo();
    }
}