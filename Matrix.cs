namespace csharp_homework8;

public class Matrix
{
    private int[,] _matrix;
    public int Rows{get; private set;}
    public int Cols{get; private set;}

    public Matrix()
    {
        Rows = 1;
        Cols = 1;
        _matrix = new int[Rows, Cols];
    }
    public Matrix(int rows, int cols)
    {
        if (rows <= 0 || cols <= 0)
            throw new ArgumentOutOfRangeException("[EXCEPTION] Rows and Columns must be positive number");
        
        Rows = rows;
        Cols = cols;
        _matrix = new int[Rows, Cols];
    }

    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Rows)
                throw new IndexOutOfRangeException("[EXCEPTION] Invalid row index!");
            if (col < 0 || col >= Cols)
                throw new IndexOutOfRangeException("[EXCEPTION] Invalid column index!");
            return _matrix[row, col];
        }
        set
        {
            if (row < 0 || row >= Rows)
                throw new IndexOutOfRangeException("[EXCEPTION] Invalid row index!");
            if (col < 0 || col >= Cols)
                throw new IndexOutOfRangeException("[EXCEPTION] Invalid column index!");
            _matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string s = string.Empty;
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                s += _matrix[i, j] + "\t";
            }

            s += "\n";
        }
        return s;
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            throw new ArgumentException("Matrices must have the same dimensions!");
        
        Matrix result = new Matrix(m1.Rows, m1.Cols);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                result[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return result;
    }
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            throw new ArgumentException("Matrices must have the same dimensions!");
        
        Matrix result = new Matrix(m1.Rows, m1.Cols);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                result[i, j] = m1[i, j] - m2[i, j];
            }
        }
        return result;
    }
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.Cols != m2.Rows)
            throw new ArgumentException("Columns of the first matrix must equal rows of the second matrix!");
        
        Matrix result = new Matrix(m1.Rows, m2.Cols);
        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m2.Cols; j++)
            {
                for (int k = 0; k < m1.Cols; k++)
                {
                    result[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        return result;
    }
    public static Matrix operator *(Matrix m, int value)
    {
        Matrix result = new Matrix(m.Rows, m.Cols);
        for (int i = 0; i < m.Rows; i++)
        {
            for (int j = 0; j < m.Cols; j++)
            {
                result[i, j] = m[i, j] * value;
                
            }
        }
        return result;
    }
    public static Matrix operator *(int value, Matrix m)
    {
        return m * value;
    }

    public static bool operator ==(Matrix m1, Matrix m2)
    {
        if (ReferenceEquals(m1, m2))
            return true;
        if (m1 is null || m2 is null)
            return false;
        if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            return false;

        for (int i = 0; i < m1.Rows; i++)
        {
            for (int j = 0; j < m1.Cols; j++)
            {
                if (m1[i, j] != m2[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static bool operator !=(Matrix m1, Matrix m2)
    {
        return !(m1 == m2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Matrix m)
            return false;
        return this == m;
    }

    public override int GetHashCode()
    {
        HashCode hash = new HashCode();
        hash.Add(Rows);
        hash.Add(Cols);
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                hash.Add(_matrix[i, j]);
            }
        }
        return hash.ToHashCode();
    }
}