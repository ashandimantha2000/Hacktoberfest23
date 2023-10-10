clear all;

%array creation
A = [2 100 4 11]
B = [2,0,5,1]

%3*3 matrix
c = [4 3 1; 3 3 2; 9 1 0]

%create a matrix is to use a function
zero = zeros(3,1)
one = ones(3,2)

%matrix and array operations
OP = A + 3

%transpose a matrix
OP1 = OP'

%concatenation, joining arrays to make larger ones
NewArray = [A,B]

%returns an n-by-n matrix with equal row and coloumn sums
Col_Row_Equal = magic(4)

%calling functions
Max_Col=max(Col_Row_Equal) % returns the maximum elements of an array
Min_FirstCol=min(Col_Row_Equal (1:2,1)) % returns the minimum element of first column.
Min_FirstRow=min(Col_Row_Equal (1,:)); % returns the minimum element of row
Mat_Size=size(Col_Row_Equal) % returns a row vector whose elements are the lengths of the corresponding dimensions of matrix

mean_dataset=mean(A)
% let’s create a new vector to implement Variance and standard_deviation
vector=[2, 1.8, 1.5 ,1.9]
Variance=var(vector)
standard_deviation=std(vector)

x = [0 2 9 2 5 8 7 3 1 9 4 3 5 8 10 0 1 2 9 5 10]
figure (1)
hist(x)


nbins = 5
figure (2)
hist(x,nbins)
