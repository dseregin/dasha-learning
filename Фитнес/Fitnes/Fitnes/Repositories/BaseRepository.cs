using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnes.Repositories
{
    public class BaseRepository
    {
        private FitnesDataBase _fitnesDataBase;
        public BaseRepository()
        {
            _fitnesDataBase = new FitnesDataBase();
        }
    }
}
