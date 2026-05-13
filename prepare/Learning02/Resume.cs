using Learning02.classfile;
namespace Learning02.classinclassfile;
public class Resume
{
    public string _name = "";
    public List<JobData> _jobList = new();

    public void PrintResume()
    {
        Console.WriteLine(_name);
        foreach (JobData j in _jobList)
        {
            j.PrintJobInfo();
        }
    }
}