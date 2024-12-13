using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        if (A.GetLength(0) != 4 || A.GetLength(1) != 4) return answer;
        // code here
        for (int i = 0;i<4;i++)
        {
            for (int j = 0;j<4;j++)
            {
                if (i==j)
                    answer += A[i,j];
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) return null;
        int[] answer = new int [4];

        // code here 
        for (int i = 0; i < 4; i++)
        {
            int min = A[i, 0];
            int indmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    indmax = j;
                }
            }
            answer[i] = indmax;
        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        int p = 0;
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null ;
        for (int i=0; i<5; i++)
        {
            
            int max = A[i, 0];
            int index = -1;
            for (int j=0; j<7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            A[i,index]=A[i,0];
            A[i, 0] = max;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 || A.GetLength(1) != 7) return null;
        int max = -10000;
        int n = -1;
        int m = -1;
        int[,] NewA = new int[5, 6];
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > max)
                {
                    n = i; m = j;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (i < n)
                {
                    NewA[i, j] = A[i, j];
                }
                if (i >= n)
                {
                    NewA[i, j] = A[i + 1, j];
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (j < m)
                {
                    NewA[i, j] = A[i, j];
                }
                if (j >= m)
                {
                    NewA[i, j] = A[i, j + 1];
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        for (int i = 0;i<A.GetLength(0); i++)
        {
            int maxind = 0;
            int max=A[i,0];
            for (int j = 0;j<A.GetLength(1); j++)
            {
                if (A[i,j]>max)
                {
                    max=A[i,j];
                    maxind = j;
                }
            }
            A[i,maxind] = max*(i+1);
        }

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        if (D.GetLength(0) != n || D.GetLength(1) != m)
            return null;

        for (int i = 0; i < D.GetLength(0); i++)
        {
            int max = int.MinValue, maxindexj = -1, negindexj1 = -1, negindexj2 = -1;


            for (int j = D.GetLength(1) - 1; j >= 0; j--)
            {
                if (D[i, j] < 0) { negindexj2 = j; break; }
            }


            for (int j = 0; j < D.GetLength(1); j++)
            {
                if (D[i, j] < 0) { negindexj1 = j; break; }
            }

            if (negindexj1 == -1) continue;

            for (int j = 0; j < negindexj1; j++)
            {
                if (D[i, j] > max)
                {
                    max = D[i, j];
                    maxindexj = j;
                }
            }

            if (maxindexj != -1)
            {
                int temp = D[i, maxindexj];
                D[i, maxindexj] = D[i, negindexj2];
                D[i, negindexj2] = temp;
            }
        }

        return D;
        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        if (H.GetLength(0) != 5 || H.GetLength(1) != 7) return null;
        for (int i = 3;i<5;i++)
        {
            for (int j = 5;j<7;j++)
            {
                H[i + 1, j + 1] = H[i, j];
            }
        }
        for (int i = 0; i < 5; i++)
        {
            int max=H[i,0];
            int ind = 0;
            for (int j = 0; j < 7; j++)
            {
                if (H[i,j]>max)
                {
                    max = H[i,j];
                    ind = j; 
                }
            }
            H[3,5] = max;
        }
        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        if (Y.GetLength(0) != 6 || Y.GetLength(1) != 5) { return null; }

        for (int i = 0; i < Y.GetLength(0); i++)
        {
            double max = Y[i, 0];
            int indexj = -1;
            for (int j = 0; j < Y.GetLength(1); j++)
            {
                if (max < Y[i, j]) 
                { 
                    max = Y[i, j]; 
                    indexj = j; 
                }
            }

            double sum = 0;
            int count = 0;
            for (int j = indexj + 1; j < Y.GetLength(1); j++)
            {
                if (Y[i, j] > 0)
                {
                    sum += Y[i, j];
                    count++;
                }
            }
            double avaragesum=0;
            if (count == 0) 
            { 
                avaragesum = 0; 
            }

            else avaragesum = sum / count;

            for (int j = 0; j < indexj; j++)
            {
                if (Y[i, j] < 0) 
                    Y[i, j] = avaragesum;
            }

        }
        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 5 || B.GetLength(1) != 7) return null;


        int[] maxarray = new int[B.GetLength(0)];

        for (int i = 0; i < B.GetLength(0); i++)
        {
            int max = B[i, 0];
            for (int j = 1; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max) 
                { 
                    max = B[i, j];
                }
            }
            maxarray[i] = max;
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            B[i, 3] = maxarray[B.GetLength(0) - 1 - i];
        }

        return B;


    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 5 && B.GetLength(1) != 5) return null;
        int indnegi = -1;
        int indmaxi = 0;
        for (int i = 0;i<B.GetLength(0);i++)
        {
            int max=B[i, 0];
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (i==j && B[i,j]>max)
                { indmaxi = i; max = B[i, j]; }
                if (i == 3 && B[i, j] < 0)
                { indnegi = i; break; }

            }
        
        }
        if (indnegi == -1)
            return B;
        for (int j = 0; j < B.GetLength(1); j++)
        {
            int temp = B[indnegi, j];
            B[indnegi, j] = B[indmaxi, j];
            B[indmaxi, j] = temp;
        }

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        int len = 0;
        int[] array = new int[len];
        for (int i = 0;i<A.GetLength(0);i++)
        {
            for (int j = 0;j<A.GetLength(1);j++)
            {
                if (A[i,j] < 0)
                { len++; }
            }
        }
        int index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < 0)
                {
                    array[index] = A[i, j];
                    index++;
                }
            }
        }
        return array;

    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        for (int i = 0;i<A.GetLength(0);i++)
        {
            double max = A[i,0];
            int indexmaxj = 0;
            double min = A[i, 0];
            int indexmin= 0;
            for (int j = 0;j<A.GetLength(1);j++)
            {
                if (A[i,j] < max)
                {
                    max = A[i,j];
                    indexmaxj = j;
                }
                
            }
            if (indexmaxj==0 && A[i, 1]>0)
            {
                A[i, 1] = A[i, 1] * 2;
            }
            if (indexmaxj == 6 && A[i, 1] > 0)
            {
                A[i, 6] = A[i, 6] * 2;
            }
            if (indexmaxj == 0 && A[i, 1] <= 0)
            {
                A[i, 1] = (A[i, 1]) / (2.0);
            }
            if (indexmaxj == 6 && A[i, 1] <= 0)
            {
                A[i, 6] =(A[i, 6]) / (2.0);
            }
            for (int k=0;k<indexmaxj;k++)
            {
                if (A[i,k]>min)
                { min = A[i,k]; indexmin = k; }
            }
            if (A[i,indexmin]>=0)
                A[i, indexmin] = 2* A[i, indexmin];
            if (A[i, indexmin] <= 0)
                A[i, indexmin] = A[i, indexmin]/2.0;
        }
        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) { return null; }

        for (int j = 0; j < m; j++)
        {
            int kfc = A[0, j];
            int chepchik71 = 0;
            int pickme = 0, nikepro = 0;

            for (int i = 0; i < n; i++)
            {
                if (kfc < A[i, j])
                {
                    kfc = A[i, j];
                    chepchik71 = i;
                }

                if (A[i, j] > 0) nikepro++;
                else if (A[i, j] < 0) pickme++;
            }

            if (nikepro > pickme) { A[chepchik71, j] = 0; }
            else { A[chepchik71, j] = chepchik71; }
        }

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 10 || m != 5) { return null; }

        for (int j = 0; j < m; j++)
        {
            int max = A[0, j];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (index < n / 2)
            {
                int sum = 0;
                for (int i = index + 1; i < n; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
        }

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5 || B.Length != 5) { return null; }

        for (int j = 0; j < A.GetLength(1); j++)
        {
            int max = A[0, j];
            int index = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = i;
                }
            }

            if (A[index, j] < B[j]) { A[index, j] = B[j]; }
        }
        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 7 || m != 5) { return null; }
        for (int j = 0; j < m; j++)
        {
            double goyda = 0;
            double shovel = A[0, j];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] > shovel)
                { shovel = A[i, j]; index = i; }
                goyda = (A[0, j] + A[6, j]) / 2;

            }
            if (shovel < goyda)
            {
                A[index, j] = goyda;
            }
            if (shovel >= goyda)
            {
                A[index, j] = j;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return answer;
        }
        answer = new int[n, n * 3];
        int k = answer.GetLength(0);
        int m = answer.GetLength(1);
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < m; j++)
            {
                answer[i, j] = 0;
            }
        }

        int count = -1;
        for (int i = 0; i < k; i++)
        {
            count++;
            for (int j = count; j < m;)
            {
                answer[i, j] = 1;
                j += 3;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0), m = A.GetLength(1);
        if (n != 6 || m != 6) { return null; }
        int indexi = 0;
        int index = 0;
        for (int i = 0;i<n;i++)
        {
            int max=A[i,0];
            for (int j = 0;j<m;j++)
            {
                if (i==j && A[i,j]> max)
                {
                    max= A[i,j];
                    index= j;
                    indexi = i;
                }
            }
        }
        for (int i = 0;i<indexi+1;i++)
        {
            for (int j = 0; j<index;j++)
            {
                A[i,j] = 0;
            }
        }
        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 6 || m != 6) { return null; }
        for (int i = 0;i<n;i++)
        {
            int max1=B[i,0];
            int indexmax1 = 0;
            int max2=B[i+1,0];
            int indexmax2 = 0;
            for (int j = 0;j<m ;j++)
            {
                if (B[i,j]>max1)
                {
                    max1= B[i,j];
                    indexmax1= j;
                }
                if (B[i+1, j] > max2)
                {
                    max2 = B[i+1, j];
                    indexmax2 = j;
                }
                int temp = B[i, indexmax1];
                B[i, indexmax1] = B[i + 1, indexmax2];
                B[i + 1, indexmax2] = temp;
            }
            
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 6 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                int temp = A[i, j];
                A[i, j] = A[i, m - j - 1];
                A[i, m - j - 1] = temp;
            }
        }
        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != 7 || cols != 5) return default(int[,]);
        int[] indexes = new int[rows], elems = new int[rows];
        int[,] new_matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int min_elem = 0;
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] < min_elem) min_elem = matrix[i, j];
            }
            indexes[i] = i; elems[i] = min_elem;
        }

        for (int i = 1, j = i + 1; i < rows;)
        {
            if (i == 0 || elems[i] <= elems[i - 1])
            {
                i = j;
                j++;
            }
            else if (elems[i] > elems[i - 1])
            {
                int temp = elems[i];
                elems[i] = elems[i - 1];
                elems[i - 1] = temp;
                int temp_index = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for (int i = 0; i < rows; i++) Console.Write(elems[i] + " ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                new_matrix[i, j] = matrix[indexes[i], j];
            }
        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        if (n != m) return default(int[]);
        int[] vector = new int[2 * n - 1];

        for (int i = n - 1, index = 0; i >= 0; i--, index++)
        {
            int k = i, h = 0, sum_left = 0, sum_right = 0;
            while (k < n && h < m)
            {
                sum_left += matrix[k, h];
                sum_right += matrix[h, k];
                k++; h++;
            }
            vector[index] = sum_left;
            vector[2 * n - 2 - index] = sum_right;
        }
        for (int i = 0; i < n; i++) Console.Write(vector[i] + " ");
        answer = vector;
        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        if (rows != cols || k <= 0) return default(int[,]);
        int max_row = 0, max_col = 0; k=k-1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (Math.Abs(matrix[i, j]) > Math.Abs(matrix[max_row, max_col]))
                {
                    max_row = i;
                    max_col = j;
                }
        }

        if (max_col != k)
        {
            for (int i = 0; i < cols; i++)
            {
                int temp = matrix[i, max_col];
                matrix[i, max_col] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }

        if (max_row != k)
        {
            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[max_row, j];
                matrix[max_row, j] = matrix[k, j];
                matrix[k, j] = temp;
            }
        }
        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here
        int n=matrix.GetLength(0);
        int m=matrix.GetLength(1);
        if (n != 5 || m != 7) return null;
        int[,] new_matrix = new int[n, m];
        int[] indexes = new int[m], negative_counts = new int[m];
        for (int i = 0;i<m;i++)
        {
            int abayudna = 0;
            for (int j = 0;j<n;j++)
            {
                if (matrix[i,j] < 0)
                    abayudna++;
            }
            indexes[i] = i; negative_counts[i] = abayudna;

        }
        for (int i = 1, j = i + 1; i < m;)
        {
            if (i == 0 || negative_counts[i] >= negative_counts[i - 1])
            {
                i = j;
                j++;
            }
            else if (negative_counts[i] < negative_counts[i - 1])
            {
                int temp = negative_counts[i];
                negative_counts[i] = negative_counts[i - 1];
                negative_counts[i - 1] = temp;
                int temp_index = indexes[i];
                indexes[i] = indexes[i - 1];
                indexes[i - 1] = temp_index;
                i--;
            }
        }

        for (int i = 0; i < m; i++) Console.Write(negative_counts[i] + " ");

        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                new_matrix[i, j] = matrix[i, indexes[j]];
            }
        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here
        int n = matrix.GetLength(0), m = matrix.GetLength(1), count_0 = 0;
        int[] indexes = new int[n];

        for (int i = 0, index = 0; i < n; i++)
        {
            bool flag = true;
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == 0)
                {
                    count_0++;
                    flag = false;
                    break;
                }
            if (!flag) indexes[index++] = i;
        }

        int[,] new_matrix = new int[n - count_0, m];

        for (int i = 0, index = 0; i < n; i++)
        {
            if (i == indexes[index]) index++;
            else
                for (int j = 0; j < m; j++) new_matrix[i, j] = matrix[i, j];

        }
        matrix = new_matrix;
        // end

        return matrix;
    }
    #endregion
}