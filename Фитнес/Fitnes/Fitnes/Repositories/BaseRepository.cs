using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Repositories
{
    public abstract class BaseRepository
    {
        protected static FitnesDataBase _fitnesDataBase;
        public BaseRepository()
        {
            if (_fitnesDataBase == null)
                _fitnesDataBase = new FitnesDataBase();
        }
    }
}
