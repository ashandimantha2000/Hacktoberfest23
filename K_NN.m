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

% Plot the randomly generated data set
plot(dataset(:, 1), dataset(:, 2), 'go');
title 'Randomly Generated Data';
for i = 1:size  (dataset, 1)
    if i <= 100
        Class_Lab(i) = 1;
    else
        Class_Lab(i) = 2;
    end
end

Class_Lab = Class_Lab'; 
dataset(:, 3) = Class_Lab;

% Cross varidatation (train 60%, test:  40%)
cv = cvpartition(size(dataset, 1));
idx = cv.test;

% separate to training and test data
dataTrain = dataset(~idx, :);
dataTest = dataset(idx, :);

    Training_Dataset2=Training_Dataset(:,1:2);
    Testing_Dataset2=Testing_Dataset(:,1:2);
    Class_Lab_Training=Training_Dataset(:,3);

    k=3;

    Model = fitcknn(Training_Dataset2,Class_Lab_Training,'NumNeighbors',k);
    classification =predict(Model,Testing_Dataset2(19,:));
    figure;
    hold on
    plot(dataset(Class_Lab==1,1),dataset(Class_Lab==1,2),'b.','MarkerSize',12)
    plot(dataset(Class_Lab==2,1),dataset(Class_Lab==2,2),'g.','MarkerSize',12)
    plot(Testing_Dataset2(19,1),Testing_Dataset2(19,2),'KX','MarkerSize',20)