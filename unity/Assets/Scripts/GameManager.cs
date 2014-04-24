using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class GameManager
    {
        private static volatile GameManager _inst = null;
        private static volatile object _sync = new object();

        public static GameManager Instance
        {
            get
            {
                lock (_sync)
                {
                    if (_inst == null)
                        _inst = new GameManager();
                }
                return _inst;
            }
        }

        public int CurrentScore { get; private set; }

        public void AddScore(float amount)
        {
            CurrentScore = CurrentScore + (int)amount;
        }
    }
}
