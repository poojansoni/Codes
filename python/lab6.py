
#%%
import numpy as np 
import pandas as pd 
import matplotlib.pyplot as plt 

from sklearn.metrics import accuracy_score 

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\kc_house_data.csv')
print(df.head(4))

space=df['sqft_living'] #tuple
price=df['price']

x = np.array(space).reshape(-1, 1)
y = np.array(price)

#Splitting the data into Train and Test
from sklearn.model_selection import train_test_split
xtrain, xtest, ytrain, ytest = train_test_split(x,y,test_size=1/3, random_state=0)

#Fitting simple linear regression to the Training Set
from sklearn.linear_model import LinearRegression 
regressor = LinearRegression()
regressor.fit(xtrain, ytrain)

#Predicting the prices
pred = regressor.predict(xtest)

#Visualizing the training Test Results 
plt.scatter(xtrain, ytrain, color= 'yellow')
plt.plot(xtrain, regressor.predict(xtrain), color = 'red')
plt.title ("Visuals for Training Dataset")
plt.xlabel("Space")
plt.ylabel("Price")
plt.show()

#Visualizing the Test Results 
plt.scatter(xtest, ytest, color= 'yellow')
plt.plot(xtrain, regressor.predict(xtrain), color = 'red')
plt.title("Visuals for Test DataSet")
plt.xlabel("Space")
plt.ylabel("Price")
plt.show()
