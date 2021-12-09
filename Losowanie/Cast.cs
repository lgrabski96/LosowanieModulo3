using System;

public class Cast
{
    private const int castMin = 1;
    private const int castMax = 20;
    public int value { get; set; }
    public string name { get; set; }

    Random _random = new Random();

    public Cast(string inputName, int inputValue)
    {
        name = inputName;
        value = inputValue;
    }

    public int RandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }

    public void SetRandomValue()
    {
        int _randomValue = RandomNumber(castMin, castMax);
        this.value = _randomValue;
    }
}
