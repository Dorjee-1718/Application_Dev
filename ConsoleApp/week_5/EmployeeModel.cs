using System;
namespace ConsoleApp.week_5
{
    public class EmployeeModel
    {
        
            public Guid Id { get; set; } = Guid.NewGuid();
            public String Name { get; set; }
            public int Age { get; set; }
            public String Address { get; set; }
            public DateTime DoB { get; set; }
            public bool IsMarried { get; set; }
            public DateTime JoinedDate { get; set; } = DateTime.Now;

    }
    
}

