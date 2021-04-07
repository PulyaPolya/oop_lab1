
using System;


public class Square_Matrix
{
    private int _size;
    

    private double[,] _array = new double[100, 100];

    public Square_Matrix()
    {
        _size = 3;
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {

                _array[i, j] = 0;
            }
        }
    }
    public void Add(Square_Matrix a)
    {
        int s = a.Get_size();

        try
        {
            if (s != _size)
            {
                throw new Exception("Wrong size");
            }
        }
        catch
        {
            Console.WriteLine("Wrong size");
        }


        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                _array[i, j] = a._array[i, j] + _array[i, j];
            }
        }


    }
    public void Multiply(Square_Matrix a)
    {
        try
        {
            if (Get_size() != a._size)
            {
                throw new Exception("Wrong size");
            }
        }
        catch
        {
            Console.WriteLine("Wrong size");
        }
        for (int i = 0; i < a._size; i++)
        {
            for (int j = 0; j < a._size; j++)
            {
                for (int k = 0; k < a._size; k++)
                {
                    {
                        _array[i, j] += _array[i, k] * a._array[k, j];

                    }
                }

            }
        }
    }
    public void Invert()
    {
        double[,] temp = new double[100, 100];
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                temp[i, j] = _array[i,j];
            }
        }
        for (int i = 0; i < _size; i++)
        {
            for (int j = 0; j < _size; j++)
            {
                _array[i, j] = temp[j, i];
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
    public string Get_String()
    {
        string t="";
        double k;
        for (int i = 0; i < _size; i++)
        { for (int j = 0; j < _size; j++)
            {
                k = _array[i, j];
                t =t+"#"+ Convert.ToString(k);
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














