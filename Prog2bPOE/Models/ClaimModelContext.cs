using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class MyDatabaseContext : DbContext
{
    public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
        : base(options)
    {
    }

    // Define your DbSets (tables) here, e.g.:
    public DbSet<Claim> Claims { get; set; }

    //Add your other classes you create here inside a DbSet<YourClassName> like above
    //Run Add-Migration *MigrationName* after adding new DbSets to this DBContext
    //Make sure you do more research to ensure that the database will be created on Byrons device if it isn't visible
    //
}

// Example entity class
public class Claim
{
    /// <summary>
    /// Troubleshooting Database stuff
    /// If your database isn't up to date or giving you kak errors that you think is wrong => delete Migrations
    /// This will drop all data from the database
    /// Then run Add-Migration *Your migration name*
    /// 
    /// If your last migration was kak => Remove-Migration *your migration name*
    /// 
    /// After running Add-Migration, run  Update-Database
    /// 
    /// All of this should automatically point to your database
    /// </summary>

    [Key]// every class in the dbcontext must have a [Key]
    public int LecturerID { get; set; }

    [Required(ErrorMessage = "Description is required.")] //Use this for error messages when you try validate data
    [DataType(DataType.DateTime)]//Set a datatype for complex types: anything more complex than a number or string
    public DateTime SubmissionDate { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")] //Set acceptable min and max values for numbers
    public int HoursWorked { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
    public double HourlyRate { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
    public double TotalHours { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
    public double TotalClaimAmount { get; set; }
    public string? AddNotes { get; set; }

    public byte[]? Document { get; set; }



    // Add other properties as needed
}
