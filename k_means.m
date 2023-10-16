clear all clc,close all

% 1- Generate a training data set using three distributions.
rng('default') % For responsibility
X = [randn(100,2)*0.75+ones(100,2);
    randn(100,2)*0.5-ones(100,2);
    randn(100,2)*0.75];

[idx,C] = kmeans(X,3);

figure
gscatter(X(:,1),X(:,2),idx,'bgm')
hold on
plot(C(:,1),C(:,2),'kx')
legend('Cluster 1','Cluster 2','Cluster 3','Cluster Centroid')

Xtest = [randn(10,2)*0.75+ones(10,2);
    randn(10,2)*0.5-ones(10,2);
    randn(10,2)*0.75];

[~,idx_test] = pdist2(C,Xtest,'euclidean','Smallest',1);



gscatter(Xtest(:,1),Xtest(:,2),idx_test,'bg','o')
legend('Cluster 1','Cluster 2','Cluster 3','Cluster Centroid', ...
    'Data classified to Cluster 1','Data classified to Cluster 2', ...
    'Data classified to Cluster 3')