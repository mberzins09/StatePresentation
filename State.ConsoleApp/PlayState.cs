namespace State.ConsoleApp
{
    public class PlayState : IMusicPlayerState
    {
        public void Handle(MusicPlayer player)
        {
            Console.WriteLine($"Playing: {player.CurrentSong}");
        }
    }

    public class NextState : IMusicPlayerState
    {
        public void Handle(MusicPlayer player)
        {
            player.NextSong();
            Console.WriteLine($"Playing next song: {player.CurrentSong}");
            player.SetState(new PlayState()); 
        }
    }

    public class PreviousState : IMusicPlayerState
    {
        public void Handle(MusicPlayer player)
        {
            player.PreviousSong();
            Console.WriteLine($"Playing previous song: {player.CurrentSong}");
            player.SetState(new PlayState()); 
        }
    }

    public class StopState : IMusicPlayerState
    {
        public void Handle(MusicPlayer player)
        {
            Console.WriteLine("Music stopped.");
        }
    }
}
