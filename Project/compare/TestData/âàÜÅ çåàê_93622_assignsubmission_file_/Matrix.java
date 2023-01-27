import java.util.Scanner;

import static java.lang.Math.log;

/* class for checking the Matrix class: Defining class instances (matrixes)
   and operations of addition, subtraction and multiplication. */

public class Matrix {
    static Scanner input = new Scanner(System.in);

    private double[][] matrix;

    private final int size;


    public Matrix(int n)
    //A constructor that receives a int parameter N and initializes a matrix filled with zeros of size NxN
    {
        size = n;
        matrix = new double[n][n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                matrix[i][j] = 0;
            }
        }
    }

    public int getN()
    // A method that returns the dimension of the matrix
    {
        return size * size;
    }

    public double getIJ(int i, int j)
    //A method that returns the object in cell (i,j) in the matrix
    {
        return matrix[i][j];
    }

    public void setIJ(int i, int j, double value)
    //A method that places the value value in cell (i, j) in a matrix
    {
        matrix[i][j] = value;
    }

    public String toString() {
        StringBuilder S = new StringBuilder();
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                S.append(String.format("%.1f\t", matrix[i][j]));
            }
            S.append("\n");
        }
        return S.toString();
    }

    public static Matrix matrixAdd(Matrix m1, Matrix m2)
    //A static method that calculates and returns the sum of the matrices
    {
        Matrix new_m = new Matrix(m1.size);

        for (int i = 0; i < m1.size; i++) {
            for (int j = 0; j < m1.size; j++) {
                new_m.setIJ(i,j,m1.getIJ(i,j) + m2.getIJ(i,j));
            }
        }
        return new_m;
    }

    public static Matrix matrixSub(Matrix m1, Matrix m2)
    // A static method that calculates and returns the result of the subtraction of 2 matrix
    {
        {
            Matrix new_m = new Matrix(m1.size);

            for (int i = 0; i < m1.size; i++) {
                for (int j = 0; j < m1.size; j++) {
                    new_m.setIJ(i,j, m1.getIJ(i,j) - m2.getIJ(i,j));
                }
            }
            return new_m;
        }
    }


    public static void divMat(Matrix m1, Matrix m2, int im2, int jm2) {

        //A function that divides a large matrix into small matrices
        //i1 and j1 run from 0 to the size of the small matrix.
        //  im2 ,jm2 run from the parameter that we entered to the limit of the small matrix
        //This way we promise that we will not exceed the size and also that we will put in everything we wanted

        for (int i1 = 0; i1 < m2.size; i1++, im2++) {
            System.arraycopy(m1.matrix[im2], jm2, m2.matrix[i1], 0, m2.size);
        }
    }

    public static void copyMat(Matrix m1, Matrix m2, int im2, int jm2) {

        // A function that puts small matrices into a large one
        // Same as the divMat function
        // Only this time we put all the values of the small matrix into the large matrix in the same method

        for (int i1 = 0; i1 < m1.size; i1++, im2++) {
            System.arraycopy(m1.matrix[i1], 0, m2.matrix[im2], jm2, m1.size);
        }
    }


    public Matrix padMatrix(int exp)
    // Padding the matrix with zeros
    {
        Matrix pad = new Matrix(exp);
        for (int i = 0; i < size; i++) {
            System.arraycopy(matrix[i], 0, pad.matrix[i], 0, size);
        }
        return pad;
    }

    public static Matrix matrixMult(Matrix m1, Matrix m2)
    // A static method that calculates and returns the multiplication of matrices
    {
        int flag = 0;
        int n = m1.size;
        int row = n / 2;
        double exp = log(m1.size) / log(2); // exponent test using log
        Matrix Final_Mat = new Matrix(n);//Create a matrix with the original size for return in case of padding
        Matrix mat1;
        Matrix mat2;
        Matrix c;

        if ((exp % 1) != 0) //Completion of the power for 2
        {
            n = (int) Math.pow(2, Math.ceil(exp));
            row = n / 2;
            mat1 = m1.padMatrix(n);
            mat2 = m2.padMatrix(n);
            flag = 1;
        } else {
            mat1 = m1;
            mat2 = m2;
        }
        c = new Matrix(n);

        if (n == 1) // Conditions for stopping the recursion
        {
            c.setIJ(0,0, mat1.getIJ(0,0) * mat2.getIJ(0,0));
            return c;
            // Multiply A and B and place the result in C
        } else //Dividing the original matrix into quarters
        {
            Matrix A11 = new Matrix(row);
            Matrix A12 = new Matrix(row);
            Matrix A21 = new Matrix(row);
            Matrix A22 = new Matrix(row);
            Matrix B11 = new Matrix(row);
            Matrix B12 = new Matrix(row);
            Matrix B21 = new Matrix(row);
            Matrix B22 = new Matrix(row);

            //Build new matrices in half the size to divide the matrices into quarters

            divMat(mat1, A11, 0, 0);
            divMat(mat1, A12, 0, row);
            divMat(mat1, A21, row, 0);
            divMat(mat1, A22, row, row);
            divMat(mat2, B11, 0, 0);
            divMat(mat2, B12, 0, row);
            divMat(mat2, B21, row, 0);
            divMat(mat2, B22, row, row);

            // Divide into quarters

            Matrix M1;
            Matrix M2;
            Matrix M3;
            Matrix M4;
            Matrix M5;
            Matrix M6;
            Matrix M7;

            // Activation of the recursion by the algorithm formulas

            //M1 = (A11 + A22)*(B11 + B22)
            //M2 = (A21 + A22)*B11
            //M3 = A11*(B12 - B22)
            //M4 = A22*(B21 – B11)
            //M5 = (A11 + A12)*B22
            //M6 = (A21 – A11)*(B11 + B12)
            //M7 = (A12 – A22)*(B21 + B22)

            M1 = matrixMult(matrixAdd(A11, A22), matrixAdd(B11, B22));
            M2 = matrixMult(matrixAdd(A21, A22), B11);
            M3 = matrixMult(A11, matrixSub(B12, B22));
            M4 = matrixMult(A22, matrixSub(B21, B11));
            M5 = matrixMult(matrixAdd(A11, A12), B22);
            M6 = matrixMult(matrixSub(A21, A11), matrixAdd(B11, B12));
            M7 = matrixMult(matrixSub(A12, A22), matrixAdd(B21, B22));

            Matrix C11;
            Matrix C12;
            Matrix C21;
            Matrix C22;

            //C11 = M1 + M4 - M5 + M7
            // C12 = M3 + M5
            // C21 = M2 + M4
            // C22 = M1 - M2 + M3 + M6

            C11 = matrixAdd(matrixSub(matrixAdd(M1, M4), M5), M7);
            C12 = matrixAdd(M3, M5);
            C21 = matrixAdd(M2, M4);
            C22 = matrixAdd(matrixSub(matrixAdd(M1, M3), M2), M6);

            //Consolidation of matrices into one according to the algorithm

            copyMat(C11, c, 0, 0);
            copyMat(C12, c, 0, row);
            copyMat(C21, c, row, 0);
            copyMat(C22, c, row, row);

        }

        if (flag == 1) {

            /* Complete the small matrices after multiplication to the final matrix
             only if the matrix pads
            */
            divMat(c, Final_Mat, 0, 0);
            return Final_Mat;
        }

        //if it didn't pad
        return c;
    }


    public static void main(String[] args) {
        System.out.println("Enter Matrix size: ");
        int n = input.nextInt();

        Matrix M1 = generateMatrix(n, 1);
        Matrix M2 = generateMatrix(n, 2);
        Matrix M3 = new Matrix(n);
        System.out.println("M1:");
        System.out.println(M1);
        System.out.println("M2:");
        System.out.println(M2);

        System.out.println("M1 + M2:");
        M3 = Matrix.matrixAdd(M1, M2);
        System.out.println(M3);
        System.out.println("M1 - M2:");
        M3 = Matrix.matrixSub(M1, M2);
        System.out.println(M3);
        System.out.println("M1 * M2:");
        M3 = Matrix.matrixMult(M1, M2);
        System.out.println(M3);


    } // main

    // Static method for receiving matrix data
    static Matrix generateMatrix(int n, int k) {


        Matrix mat = new Matrix(n);

        System.out.printf("Enter the n,n entries of  matrix %d now:\n", k);

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                mat.setIJ(i, j, input.nextDouble());
            }
        }
        return mat;
    } // generateMatrix

} // MatrixTest

