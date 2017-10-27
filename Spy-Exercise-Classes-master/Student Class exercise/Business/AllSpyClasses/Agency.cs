
namespace Student_Class_exercise
{
    public class Agency
  {
   
//constructor
 public Agency()
  {
    Country = "UK";
    AgencyName = "MI6";
   NumberOfAgents = 12;

  }
    //properties
    public string Country { get; set; }
    public string AgencyName { get; set; }
    public int NumberOfAgents { get; set; } 

    //Methods
    public string CountryAgencyName()
    {
      string alldetails = Country + " " + AgencyName;

      return alldetails;
    }

  }
}
