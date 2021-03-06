#%%
import numpy as np
import pandas as pd
import apyori 
from matplotlib import pyplot as plt

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\store_data.csv', header= None)
print(df.head())

records = []
for i in range(0, 7501):
    records.append([str(df.values[i,j]) for j in range(0, 20)])

association_rules = apyori.apriori(records, min_support=0.0045, min_confidence=0.2, min_lift=3)
association_results = list(association_rules)

print(len(association_results))
print("\n1st Rule: ",association_results[0])

for item in association_results:

    # first index of the inner list
    # Contains base item and add item
    pair = item[0] 
    items = [x for x in pair]
    print("Rule: " + items[0] + " -> " + items[1])

    #second index of the inner list
    print("Support: " + str(item[1]))

    #third index of the list located at 0th
    #of the third index of the inner list

    print("Confidence: " + str(item[2][0][2]))
    print("Lift: " + str(item[2][0][3]))
    print("=====================================")
