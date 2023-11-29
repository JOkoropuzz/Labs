
class Tariff 
{
    public string Name;
    public double CoefficientBefore;
    public double CoefficientAfter;
    public int ShiftTime;

    public Tariff(string name, double coef1, double coef2, int min)
    {
        Name = name;
        CoefficientBefore = coef1;
        CoefficientAfter = coef2;
        ShiftTime = min;
    }
    public Tariff(string name)
    {
        Name = name;
        CoefficientBefore = 1;
        CoefficientAfter = 1;
        ShiftTime = 0;
    }

    public double Withdraw(Call someCall)
    {
        double withdrawSum=0;
        if (someCall.CallTime < ShiftTime)
        {
            if (someCall.CallType == 'Г')
            {
                withdrawSum = 5 * someCall.CallTime * CoefficientBefore;
            }
            else if (someCall.CallType == 'М')
            {
                withdrawSum = someCall.CallTime * CoefficientBefore;
            }
        }
        else
        {
            if (someCall.CallType == 'Г')
            {
                withdrawSum = (5 * ShiftTime * CoefficientBefore) + (5*(someCall.CallTime - ShiftTime)*CoefficientAfter);
            }
            else if (someCall.CallType == 'М')
            {
                withdrawSum = (5 * ShiftTime * CoefficientBefore) + (5 * (someCall.CallTime - ShiftTime) * CoefficientAfter);
            }
        }
        return withdrawSum;
    }
}
