
using System;


public class Square_Matrix
{
    private int _size;
    

   private double[,] _array;

    public Square_Matrix()
    {
      _size = size;
        _array = new double[size, size];
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {

                _array[i, j] = 0;
            }
        }
    }
    public static Square_Matrix Add(Square_Matrix a, Square_Matrix b)
    {
        try
        {
            if (a.Get_size() != b.Get_size())
            {
                throw new Exception("Wrong size");
            }
        }
        catch
        {
            Console.WriteLine("Wrong size");
        }
        Square_Matrix c = new Square_Matrix(a.Get_size());

        for (int i = 0; i < a.Get_size(); i++)
        {
            for (int j = 0; j < a.Get_size(); j++)
            {
                c._array[i, j] = a._array[i, j] + b._array[i, j];
            }
        }
        return c;

    }
  public static Square_Matrix Multiply(Square_Matrix a, Square_Matrix b)
    {
        try
        {
            if (b._size != a._size)
            {
                throw new Exception("Wrong size");
            }
        }
        catch
        {
            Console.WriteLine("Wrong size");
        }
        Square_Matrix c = new Square_Matrix(a.Get_size());
        for (int i = 0; i < a._size; i++)
        {
            for (int j = 0; j < a._size; j++)
            {
                for (int k = 0; k < a._size; k++)
                {
                    {
                        c._array[i, j] += b._array[i, k] * a._array[k, j];

                    }
                }

            }
        }
        return c;
    }
    public void Invert()
    {
       double t;
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                t=_array[i, j];
                _array[i, j] = _array[j, i];
                _array[j, i] = t;
            }
        }

    }
    public int Get_size()
    {
        return _size;

    }
    public void Set_size(int value)
    {

        {
            if (value >= 0)
            {
                _size = value;
            }
        }

    }
    public void Set_element(int i, int j, int value)
    {

        _array[i, j] = value;
    }


    public int[] array
    {
        get
        {
            return array;
        }
    }
    public double GetElement(int i, int j)
    {
        return _array[i, j];
    }
      public override string ToString()
    {
        string t = "";
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                t = t + "#" + _array[i, j].ToString();
            }
        }
        return t;
    }
    public bool Equals(Square_Matrix a, Square_Matrix b)
    {
        if (b._size != a._size)
            return false;
        for (int j = 0; j < a._size; j++)
        {
            for (int k = 0; k < a._size; k++)
            {
                {
                    if(a._array[k, j] != b._array[k, j])
                    {
                        return false;
                    }
                   

                }
            }

        }
        return true;    

    }

    public void SetOneValue(double v)
    {
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                _array[i,j]=v;
            }
        }
    }

}














