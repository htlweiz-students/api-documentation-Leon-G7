namespace AverageCalculator;

public class Class1
{
    private List<double> werte = new List<double>();

    public void Add(double value)
    {
        werte.Add(value);
    }

    public void add(double[] values)
    {
        foreach (double v in values)
        {
            werte.Add(v);
        }
    }

    public double getAverage()
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

    public double[] getElements()
    {
        return werte.ToArray();
    }

    public int count()
    {
        return werte.Count;
    }
}
