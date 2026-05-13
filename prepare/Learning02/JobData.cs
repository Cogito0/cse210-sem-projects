namespace Learning02.classfile
{
    public class JobData
    {
        public string _title = "";
        public string _company = "";
        public int _startYear = 0;
        public int _endYear = 0;

        public JobData()
        {
        }

        public void PrintJobInfo()
        {
            Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
        }
    }
}