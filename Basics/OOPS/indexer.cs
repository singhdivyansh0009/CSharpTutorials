using System;

class Properties
{
    private string empNo;
    private string empName;
    private double salary;

    // 🔽 Indexer to access private fields using string keys
    // It allows accessing and modifying values like an array: obj["EmpNo"], obj["Salary"], etc.
    public object this[string key]
    {
        // 🟩 GET accessor: returns the value based on the key
        get
        {
            key = key.ToUpper(); // Convert key to uppercase for case-insensitive matching

            if (key == "EMPNO")           // If key is "EMPNO", return empNo
                return empNo;
            else if (key == "EMPNAME")    // If key is "EMPNAME", return empName
                return empName;
            else if (key == "SALARY")     // If key is "SALARY", return salary
                return salary;
            else
                throw new ArgumentException("Invalid key"); // Throw exception if key doesn't match
        }

        // 🟥 SET accessor: sets the value based on the key
        set
        {
            key = key.ToUpper(); // Convert key to uppercase for case-insensitive matching

            if (key == "EMPNO")               // Set empNo field
                empNo = value.ToString();
            else if (key == "EMPNAME")        // Set empName field
                empName = value.ToString();
            else if (key == "SALARY")         // Set salary field (converted to double)
                salary = Convert.ToDouble(value);
            else
                throw new ArgumentException("Invalid key"); // Throw exception for unknown key
        }
    }
}


class TestProperty
{
    public static void Main(string[] args)
    {
        try
        {
            Properties obj = new Properties();

            obj["EmpNo"] = "101";
            obj["EmpName"] = "John";
            obj["Salary"] = 50000.0;

            Console.WriteLine(obj["EmpNo"]);     // Output: 101
            Console.WriteLine(obj["EmpName"]);   // Output: John
            Console.WriteLine(obj["Salary"]);    // Output: 50000
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
