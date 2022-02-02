class EmpWage
{

    static void Main(string[] args)
    {
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        Random random = new Random();
        int randomInput = random.Next(0, 3);
        int totalWage = 0;
        int empHrs = 0;
        int EMP_RATE_PER_HOUR = 20;



        switch (randomInput)
        {
            case FULL_TIME:
                empHrs = 8;
                Console.WriteLine("FullTime Employee is present");
                break;
            case PART_TIME:
                empHrs = 4;
                Console.WriteLine("PartTime Employee is present");
                break;
            default:
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
                break;
        }
        //Calculating part for salary
        empWage = EMP_RATE_PER_HOUR * empHrs;
        Console.WriteLine("Employee wage for Day {0} is :{1}", day, empWage);
        totalWage += empWage;

    }
    Console.WriteLine();
    Console.WriteLine("Total Wage for {0}Days is : {1}",MAX_WORKING_DAYS, totalWage);
    Console.ReadLine();
}