//BSCP_CS_62_114 Charitha 

using System.Text;

class MyPolynomial
{
    private double[] _coeffs;

    // Constructor that accepts variable number of coefficients
    public MyPolynomial(params double[] coeffs)
    {
        _coeffs = new double[coeffs.Length];
        for (int i = 0; i < coeffs.Length; i++)
        {
            _coeffs[i] = coeffs[i];
        }
    }

    // Method to get the degree of the polynomial
    public int GetDegree()
    {
        return _coeffs.Length - 1;      //_coeffs array - 1 = length
    }


    // Override the ToString method to provide a string representation of the polynomial
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        int degree = GetDegree();

        for (int i = degree; i >= 0; i--)
        {
            if (_coeffs[i] != 0)
            {
                if (i == degree)
                {
                    result.Append($"{_coeffs[i]}x^{i}");
                }
                else
                {
                    result.Append($" + {_coeffs[i]}x^{i}");
                }
            }
        }

        return result.ToString();
    }

     // Method to evaluate the polynomial for a given value of x
    public double Evaluate(double x)
    {
        double result = 0;
        int degree = GetDegree();

        for (int i = 0; i <= degree; i++)
        {
            result += _coeffs[i] * Math.Pow(x, i);
        }

        return result;
    }

     // Method to add two polynomials
    public MyPolynomial Add(MyPolynomial another)
    {
        int maxDegree = Math.Max(GetDegree(), another.GetDegree());
        double[] newCoeffs = new double[maxDegree + 1];

        for (int i = 0; i <= maxDegree; i++)
        {
            newCoeffs[i] = (_coeffs.Length > i ? _coeffs[i] : 0) + (another._coeffs.Length > i ? another._coeffs[i] : 0);
        }

        return new MyPolynomial(newCoeffs);
    }

     // Method to multiply two polynomials
    public MyPolynomial Multiply(MyPolynomial another)
    {
        int newDegree = GetDegree() + another.GetDegree();
        double[] newCoeffs = new double[newDegree + 1];

        for (int i = 0; i <= GetDegree(); i++)          // Multiply the polynomials using polynomial multiplication
        {
            for (int j = 0; j <= another.GetDegree(); j++)
            {
                newCoeffs[i + j] += _coeffs[i] * another._coeffs[j];
            }
        }

        return new MyPolynomial(newCoeffs);
    }
}
