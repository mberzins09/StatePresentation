namespace State.ConsoleApp
{
    public class MusicPlayer(IMusicPlayerState initialState, string[] songs)
    {
        private IMusicPlayerState _state = initialState;
        private readonly string[] _songs = songs;
        private int _currentSongIndex = 0;

        public string CurrentSong => _songs[_currentSongIndex];

        public void SetState(IMusicPlayerState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        public void NextSong()
        {
            _currentSongIndex = (_currentSongIndex + 1) % _songs.Length;
        }

        public void PreviousSong()
        {
            _currentSongIndex = (_currentSongIndex - 1 + _songs.Length) % _songs.Length;
        }
    }
}
