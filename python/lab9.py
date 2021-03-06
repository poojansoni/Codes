#%%
import pandas as pd
import numpy as np

import matplotlib.pyplot as plt
df  = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\tsla.csv')
print(df.head())

df = df[['Date','Close']]
df = df.rename(columns = {'Date':'ds', 'Close':'y'})
print(df.head(), "\n",df.info())

from fbprophet import Prophet

m = Prophet()
m.fit(df)

future = m.make_future_dataframe(periods=365)
pred = m.predict(future)

m.plot(pred)
plt.title("Prediction of Tesla stock price")
plt.xlabel("Date")
plt.ylabel("Stock price")
plt.show()

m.plot_components(pred)
plt.show()