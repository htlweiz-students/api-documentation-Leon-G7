namespace AverageCalculator;

public class AverageCalculator
{
    private List<double> werte = new List<double>();

    public void Add(double value)
    {
        werte.Add(value);
    }

    public void Add(double[] values)
    {
        foreach (double v in values)
        {
            werte.Add(v);
        }
    }

    public double GetAverage()
    {
        if (werte.Count == 0)
        {
            return 0;
        }

        double summe = 0;

        foreach (double v in werte)
        {
            summe += v;
        }

        return summe / werte.Count;
    }

    public double[] GetElements()
    {
        return werte.ToArray();
    }

    public int Count()
    {
        return werte.Count;
    }
}
