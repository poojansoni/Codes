#%%
import numpy as np
import pandas as pd
import matplotlib.pyplot as pt

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\Social_Network_Ads.csv')
print(df.head())


# pt.hist(np.array(df['Age']), ec= "red")
df['Age'].plot(kind= "hist", ec = 'red')
pt.ylabel('freq')
pt.xlabel('age')
pt.title("Population age count")
pt.show()

df['EstimatedSalary'].plot(kind= "hist", ec = "green")
pt.ylabel('freq')
pt.xlabel('sal')
pt.show()