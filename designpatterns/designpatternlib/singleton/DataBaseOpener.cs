using System;

namespace designpatternlib.singleton;

public class DataBaseOpener
{
    private static Lock _lock=new();
    private static DataBaseOpener _dbOpener;
    public static DataBaseOpener GetInstance()
    {
        lock(_lock)
        {
            if(_dbOpener == null)
            {
                _dbOpener = new();
            }
            return _dbOpener;
        }
    }

}
