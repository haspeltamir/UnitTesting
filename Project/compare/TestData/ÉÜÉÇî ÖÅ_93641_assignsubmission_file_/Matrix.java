// netanel shen 31839492 + noam cohen 20956289

public class Matrix {

    int n;
    double[][] matrix;

    public Matrix(int n) {
        this.n = n;
        if (n == 0)
            throw new IllegalArgumentException("Matrix dimensions are 0");
        matrix = new double[n][n];
        setZeroMatrix();
    }

    public static Matrix matrixAdd (Matrix matrix1, Matrix matrix2)
    {
        matrixCheckN(matrix1.getN(), matrix2.getN()); // check dimensions

        var matrix = new Matrix (matrix1.getN());
        matrix.setMatrix(add(matrix1.getMatrix(), matrix2.getMatrix()));

        return matrix;
    }

    public static Matrix matrixSub (Matrix matrix1, Matrix matrix2)
    {
        matrixCheckN(matrix1.getN(), matrix2.getN()); // check legal dimensions
        var matrix = new Matrix (matrix1.getN());
        matrix.setMatrix(sub(matrix1.getMatrix(), matrix2.getMatrix()));
        return matrix;
    }

    public static Matrix matrixMult(Matrix matrix1, Matrix matrix2)
    {
        int newN = matrix1.getN();
        matrixCheckN(matrix1.getN(), matrix2.getN()); // check dimensions

        // if power of 2
        if (isPowerOfTwo(matrix1.getN())) {
            var matrix = new Matrix(matrix1.getN());
            matrix.setMatrix(multiply(matrix1.getMatrix(), matrix2.getMatrix()));
            return matrix;
        }

        //get the closest power of 2
        while (!isPowerOfTwo(newN))
            newN++;

        var matrix = new Matrix(newN); // matrix with new dimensions
        var returnMatrix = new Matrix(matrix1.getN()); // a return matrix to fit original dimensions
        var matrixNew1 = new Matrix(newN); // matrix1 in bigger dimensions
        var matrixNew2 = new Matrix(newN); // matrix2 in bigger dimensions

        // initializing new matrices to fit algorithm
        for (int i = 0; i < matrix1.getN(); i++)
        {
            for (int j = 0; j< matrix1.getN(); j++)
            {
                matrixNew1.setIJ(i,j,matrix1.getIJ(i,j));
                matrixNew2.setIJ(i,j,matrix2.getIJ(i,j));
            }
        }

        //multiply new matrices
        matrix.setMatrix(multiply(matrixNew1.getMatrix(), matrixNew2.getMatrix()));

        //setting up matrix with original dimensions
        for (int i = 0; i < matrix1.getN(); i++)
        {
            for (int j = 0; j< matrix1.getN(); j++)
            {
               returnMatrix.setIJ(i,j,matrixNew1.getIJ(i,j));
            }
        }

        return returnMatrix;
    }

    private static void matrixCheckN(int n1, int n2)
    {
        if (n1 != n2)
            throw new IllegalArgumentException("Matrix dimensions aren't equal.");
    }

    private static boolean isPowerOfTwo(int n)
    {
        return (int)(Math.ceil((Math.log(n) / Math.log(2))))
                == (int)(Math.floor(((Math.log(n) / Math.log(2)))));
    }

    private void setZeroMatrix() {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                matrix[i][j] = 0.0;
            }
        }
    }

    public void setIJ(int i, int j, double value) {
        matrix[i][j] = value;
    }

    public int getN() {
        return n;
    }

    public double getIJ(int i, int j) {
        return matrix[i][j];
    }

    public double[][] getMatrix() {
        return matrix;
    }

    public void setMatrix(double[][] matrix)
    {
        n = matrix.length;
        this.matrix = matrix;

    }

    @Override
    public String toString() {
        String sr = "";
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                sr += matrix[i][j] + " ";
            }
            sr += "\n";
        }
        return sr;
    }

    private static double[][] multiply(double[][] matrixA, double[][] matrixB) //recursive multiplication function
    {
        int n = matrixA.length;

        //exit condition
        double[][] MatrixRes = new double[n][n];
        if (n == 1) {
            MatrixRes[0][0] = matrixA[0][0] * matrixB[0][0];
            return MatrixRes;
        }

        //split to 4 matrices
            double[][] A11 = new double[n / 2][n / 2];
            double[][] A12 = new double[n / 2][n / 2];
            double[][] A21 = new double[n / 2][n / 2];
            double[][] A22 = new double[n / 2][n / 2];

            double[][] B11 = new double[n / 2][n / 2];
            double[][] B12 = new double[n / 2][n / 2];
            double[][] B21 = new double[n / 2][n / 2];
            double[][] B22 = new double[n / 2][n / 2];

            split(matrixA, A11, 0, 0);
            split(matrixA, A12, 0, n / 2);
            split(matrixA, A21, n / 2, 0);
            split(matrixA, A22, n / 2, n / 2);

            split(matrixB, B11, 0, 0);
            split(matrixB, B12, 0, n / 2);
            split(matrixB, B21, n / 2, 0);
            split(matrixB, B22, n / 2, n / 2);

            double[][] M1 = multiply(add(A11, A22), add(B11, B22));

            double[][] M2 = multiply(add(A21, A22), B11);

            double[][] M3 = multiply(A11, sub(B12, B22));

            double[][] M4 = multiply(A22, sub(B21, B11));

            double[][] M5 = multiply(add(A11, A12), B22);

            double[][] M6 = multiply(sub(A21, A11), add(B11, B12));

            double[][] M7 = multiply(sub(A12, A22), add(B21, B22));

            double[][] C11 = add(sub(add(M1, M4), M5), M7);

            double[][] C12 = add(M3, M5);

            double[][] C21 = add(M2, M4);

            double[][] C22 = add(sub(add(M1, M3), M2), M6);

            join(C11, MatrixRes, 0, 0);
            join(C12, MatrixRes, 0, n / 2);
            join(C21, MatrixRes, n / 2, 0);
            join(C22, MatrixRes, n / 2, n / 2);

        return MatrixRes;

    }

    private static double[][] add(double[][] matrix1, double[][] matrix2) // add 2 array matrices
    {
        int n = matrix2.length;

        double[][] sum = new double[n][n];

        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++)
                sum[i][j] = matrix1[i][j] + matrix2[i][j];
        }

        return sum;
    }

    private static double[][] sub(double[][] matrix1, double[][] matrix2) // sub 2 array matrices
    {
        int n = matrix2.length;

        double[][] sub = new double[n][n];

        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++)
                sub[i][j] = matrix1[i][j] - matrix2[i][j];
        }
        return sub;
    }

    private static void split(double[][] P, double[][] C, int iB, int jB) // split (used for multiplication)
    {

        for (int i1 = 0, i2 = iB; i1 < C.length; i1++, i2++)

            for (int j1 = 0, j2 = jB; j1 < C.length;
                 j1++, j2++)

                C[i1][j1] = P[i2][j2];
    }

    private static void join(double[][] C, double[][] P, int iB, int jB) // join (used for multiplication)

    {

        for (int i1 = 0, i2 = iB; i1 < C.length; i1++, i2++)

            for (int j1 = 0, j2 = jB; j1 < C.length;
                 j1++, j2++)

                P[i2][j2] = C[i1][j1];
    }


}