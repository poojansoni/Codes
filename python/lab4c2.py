#scatter plot
#%%
import numpy as np
import pandas as pd
import matplotlib.pyplot as pt

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\Social_Network_Ads.csv')
print(df.head())

df.plot(kind = 'scatter', x = 'Age', y = 'EstimatedSalary', c = 'red')
pt.show()
