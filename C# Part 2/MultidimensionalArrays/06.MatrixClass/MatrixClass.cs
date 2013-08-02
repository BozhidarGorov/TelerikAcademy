using System;

class MatrixClass
{

    private int[,] matrix;

    public MatrixClass(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        { 
            return this.matrix.GetLength(0); 
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static MatrixClass operator +
        (MatrixClass first, MatrixClass second)
    {
        MatrixClass result = new MatrixClass(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] 
                    + second[row, col];
            }
        }

        return result;
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += matrix[row, col] + " ";
            }

            result += Environment.NewLine;
        }

        return result;
    }
}



