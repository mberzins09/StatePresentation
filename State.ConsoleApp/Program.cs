using State.ConsoleApp;

var songs = MusicList.GetSongs();

MusicPlayer player = new MusicPlayer(new StopState(), songs);
var isPlaying = true;
while (isPlaying)
{
    Console.WriteLine("\nEnter command \nPlay : 1 \nNext : 2 \nPrevious : 3 \nStop : 4 \nPower Off : 5");
    string command = Console.ReadLine();

    switch (command)
    {
        case "1":
            player.SetState(new PlayState());
            break;

        case "2":
            player.SetState(new NextState());
            break;

        case "3":
            player.SetState(new PreviousState());
            break;

        case "4":
            player.SetState(new StopState());
            break;

        case "5":
            isPlaying = false;
            break;

        default:
            Console.WriteLine("Invalid command. Please enter 1, 2, 3, or 4.");
            continue;
    }

    player.Request();
}
