using System;  
namespace Resumes{
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Zeedoch";
        job1._startYear = 2013;
        job1._applicationYear = 2012;

        Job job2=new Job();
        job2._jobTitle = "Peer Mentor";
        job2._companyName = "BYU PATHWAY WORLDWIDE";
        job2._startYear= 2023;
        job2._applicationYear=2023;

        Resume myResume = new Resume();
        myResume._name = "Emmanuel Kelikume";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}
}