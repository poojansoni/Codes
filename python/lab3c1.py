# LAB-3
# Exercise 10 WAP to handle missing values
# Exercise 11 WAP to normalize the data values

import numpy as np 
import pandas as pd 
from sklearn.impute import SimpleImputer

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\ads.csv')

print ("Data Head : \n", df.head()) 
  
print ("\n\nData Describe : \n", df.describe()) 

  
# All rows but all columns except last 
X = df.iloc[:, :-1].values 

# All rows but only last column  
Y = df.iloc[:, 3].values 
  
# Using Imputer function to replace NaN with values of mean  

imputer = SimpleImputer(missing_values=np.nan, strategy='mean') 
                    
# Fitting the data
imputer = imputer.fit(X[:, 1:3]) 
  
print("Input:\n",X)

# fit_transform() will execute those 
# stats on the input ie. X[:, 1:3] 
X[:, 1:3] = imputer.fit_transform(X[:, 1:3]) 
  
# filling the missing value with mean 
print("\n\nNew Input with Mean Value for NaN : \n", X) 