public class Movement
{
    public Player player;

    public Movement(Player player)
    {
        this.player = player;
    }

    public void Move(string direction)
    {
        direction = direction.ToUpper();

        switch (direction)
        {
            case "N":
                if (player.CurrentLocation?.LocationToNorth != null)
                {
                    player.CurrentLocation = player.CurrentLocation.LocationToNorth;
                }

                else
                {
                    Console.WriteLine("You cannot go north!");                    
                }
                break;

            case "S":
                if (player.CurrentLocation?.LocationToSouth != null)
                {
                    player.CurrentLocation = player.CurrentLocation.LocationToSouth;
                }
                else
                {
                    Console.WriteLine("You cannot go south!");   
                }
                break;

            case "E":
                if (player.CurrentLocation?.LocationToEast != null)
                {
                    player.CurrentLocation = player.CurrentLocation.LocationToEast;
                }

                else
                {
                    Console.WriteLine("You cannot go east!");
                }

                break;

            case "W":
                if (player.CurrentLocation?.LocationToWest != null)
                {
                    player.CurrentLocation = player.CurrentLocation.LocationToWest;
                }  

                else
                {
                    Console.WriteLine("You cannot go west!");
                }
                break;

            default:
                Console.WriteLine("Invalid direction! Use N, S, E, or W.");
                break;
        }
    }
    public void ShowCompass()
    {
        player.CurrentLocation?.ShowCompass();
    }
}
