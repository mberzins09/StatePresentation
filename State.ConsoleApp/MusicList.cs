namespace State.ConsoleApp
{
    public static class MusicList
    {
        private static List<string>? _songs;
        public static string[] GetSongs()
        {
            _songs =
            [
                "Blinding Lights",
                "Shape of You",
                "Uptown Funk",
                "Despacito",
                "Closer",
                "Someone You Loved",
                "Senorita",
                "Bad Guy",
                "Old Town Road",
                "Perfect",
                "Believer",
                "Rockstar",
                "Havana",
                "Dance Monkey",
                "Sunflower",
                "God's Plan",
                "Thank U, Next",
                "Lucid Dreams",
                "Shallow",
                "Sicko Mode"
            ];

            return _songs.ToArray();
        }
    }
}
