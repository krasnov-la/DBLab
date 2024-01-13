

namespace Generation;
public class NormalDist
{
    int _delta;
    int _initValue;
    int _iterations;
    Random _rand = new Random(DateTime.Now.Microsecond);

    public int Delta { get { return _delta; } }
    public int InitValue { get { return _initValue; } }

    public NormalDist(int init, int delta, int iterations)
    {
        _iterations = iterations;
        _initValue = init;
        _delta = delta;
    }

    public int Generate()
    {
        int res = _initValue;
        for (int i = 0; i < _iterations; i++)
        {
            if (_rand.Next(2) == 1) res += _delta;
            else res -= _delta;
        }

        return res;
    }
}
