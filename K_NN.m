% Create random generated dataset
xmin = 10;
xmax = 20;
n = 200;

x = xmin + rand(1, n) * (xmax - xmin);
x = x';

xmin = 25;
xmax = 50;
y = xmin + rand(1, n) * (xmax - xmin);
y = y';

% Apply data to the dataset
dataset = [x y];