using System;
using System.Threading.Channels;
using Learning02.classfile;
using Learning02.classinclassfile;

class Program
{
    static void Main(string[] args)
    {
        JobData job1 = new();
        job1._title = "Renegade";
        job1._company = "The Government";
        job1._startYear = 1444;
        job1._endYear = 2222;

        JobData job2 = new();
        job2._title = "Pacifist";
        job2._company = "Indus Industries";
        job2._startYear = -4;
        job2._endYear = 1;

        Resume resume = new();
        resume._name = "Bond, James Bond";
        resume._jobList = [job1, job2];

        resume.PrintResume();
    }
}