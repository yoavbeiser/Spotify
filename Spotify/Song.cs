using System;
namespace Spotify
{
    public class Song
    {
        private readonly string _name;
        private readonly string _nameWriter;
        private readonly int _time;
        private bool _isLiked;
        public Song(string name, string nameWriter, int time)
        {
            _name = name;
            _nameWriter = nameWriter;
            _time = time;
            _isLiked = false;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetNameWriter()
        {
            return _nameWriter;
        }
        public int GetTime()
        {
            return _time;
        }
        public void Like()
        {
            _isLiked = true;
        }
        public void UnLike()
        {
            _isLiked = false;
        }
    }
}
