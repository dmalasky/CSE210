public class EmployeeCommission : Employee
{
    Dictionary<string, float> Jobs = new Dictionary<string, float>();
    public float CurrentPayTotal { get; private set; }

    public EmployeeCommission()
    {
        
    }
    
    public EmployeeCommission(float currentPayTotal)
    {
        CurrentPayTotal = currentPayTotal;
    }

    public EmployeeCommission(string fName, string lName, string phone, string email, int employeeID) : base(fName, lName, phone, email, employeeID)
    {

    }

    // "Calculates" pay for a commission worker.
    public override float CalculatePay()
    {
        return CurrentPayTotal;
    }

    // Formatting for saving data.
    public override string SaveEmployeeFormat()
    {
        return $"{base.SaveEmployeeFormat()}~{CurrentPayTotal}";
    }
    
    // fills in the list of jobs and calcs total pay at a certain point.
    public float AddJobs()
    {
        Console.WriteLine("Enter payment amount for each job, (type '0' to finish):");
        int count = 1;
        while (true)
        {
        
            string key = $"Job {count}";

            Console.Write($"{key} - $ ");
            float.TryParse(Console.ReadLine(), out float value);
            
            if (value == 0)
            {
                break;
            }

            Jobs[key] = value;

            count++;
        }

        float total = 0;
        foreach (var kvp in Jobs)
        {
            total += kvp.Value;
        }
        Console.WriteLine($"\nTotal: ${total}");

        CurrentPayTotal = total;
        
        return CurrentPayTotal;
    }
   

    
}