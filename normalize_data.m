% Generate a random data set of 200 values ranging from 1 to 100
data_set = rand(1, 200) * 199 + 1;
% disp(data_set);

% Plot the data
figure;
% 'o-' specifies that you want markers and lines
plot(data_set, 'o-');
title('Random Dataset');
xlabel('Index');
ylabel('Value');
grid on; % Display grid lines

% Normalize the data set
normalized_data = (data_set - mean(data_set)) / std(data_set);