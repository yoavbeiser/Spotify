using System;
using System.Collections.Generic;

namespace Spotify
{
    public class Spotify
    {
        private readonly Album _likedSongs;
        private readonly Album _history;
        private bool _isPlaying;
        private Song _playedsong;
        private User _user;
        public Spotify(User user)
        {
            _user = user;
            _isPlaying = false;
            _history = new Album("First album", new List<Song>());
        }

        public void Play(Song song)
        {
            if (GetIsPlaying())
                throw new Exception("Playing already");
            else
            {
                _playedsong = song;
                _isPlaying = true;
                _history.AddSong(_playedsong);
            }
        }

        public void Stop()
        {
            if (!GetIsPlaying())
                throw new Exception("Not playing");
            else
                _isPlaying = false;
        }

        public void Next(Song song)
        {
            if (!GetIsPlaying())
                throw new Exception("Not playing");
            else
            {
                _playedsong = song;
                _history.AddSong(_playedsong);
            }
        }
        public void Like(Song song)
        {
            song.Like();
            _likedSongs.AddSong(song);
        }
        public void UnLike(Song song)
        {
            song.UnLike();
            _likedSongs.RemoveSong(song);
        }
        public bool GetIsPlaying()
        {
            return _isPlaying;
        }
    }
}
