public class Location
{
    public int ID {get;}
    public string Name {get;}
    public string Description {get;}
    public Location LocationToNorth {get; set;}
    public Location LocationToEast {get; set;}
    public Location LocationToSouth {get; set;}
    public Location LocationToWest {get; set;}


    public Location(int Id, string name, string description, Location north = null, Location south = null, Location east = null, Location west = null)
    {
        this.ID = Id;
        this.Name = name;
        this.Description = description;
    }

}