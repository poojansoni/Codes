# Exercise 11 WAP to normalize the data values
from sklearn import preprocessing
import numpy as np
import pandas as pd

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\Social_Network_Ads.csv')
print ("Data Head : \n", df.head()) 
 

# normalize the data attributes
x_array = np.array(df['Age'])
normalized_arr = preprocessing.normalize([x_array])
print(normalized_arr)
