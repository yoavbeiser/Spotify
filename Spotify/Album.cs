using System;
using System.Collections.Generic;

namespace Spotify
{
    public class Album
    {
        private readonly string _name;
        private readonly IList<Song> _songs;
        public Album(string name, IList<Song> songs)
        {
            _name = name;
            _songs = songs;
        }

        public void AddSong(Song song)
        {
            if (!_songs.Contains(song))
                _songs.Add(song);
            else
                throw new Exception();
        }

        public void RemoveSong(Song song)
        {
            if (_songs.Contains(song))
                _songs.Remove(song);
            else
                throw new Exception();
        }

        public static implicit operator Album(List<Song> v)
        {
            throw new NotImplementedException();
        }
    }
}
