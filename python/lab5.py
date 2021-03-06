#%%
import numpy as np 
import pandas as pd 
import seaborn as sns
from scipy import stats
import matplotlib.pyplot as plt 
from sklearn.metrics import accuracy_score
from sklearn.linear_model import LogisticRegression
from sklearn.naive_bayes import GaussianNB
from sklearn.tree import DecisionTreeClassifier

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\wine.csv', header = None) 

#adding headers
df.columns = [  'name'
                 ,'alcohol'
             	,'malicAcid'
             	,'ash'
            	,'ashalcalinity'
             	,'magnesium'
            	,'totalPhenols'
             	,'flavanoids'
             	,'nonFlavanoidPhenols'
             	,'proanthocyanins'
            	,'colorIntensity'
             	,'hue'
             	,'od280_od315'
             	,'proline'
                ]

print(df)

#checking for missing values
print(df.isnull().any())




X= df.drop(['name','ash'],axis = 1)
print(X.head(2))

Y=df.iloc[:,:1] 
print(Y.head(2))

from sklearn.model_selection import train_test_split
X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.3, random_state=0)

print(X_train.shape)
print(X_test.shape)

#Standardisation
from sklearn.preprocessing import StandardScaler 
sc_X = StandardScaler()
X_train = sc_X.fit_transform(X_train)
X_test = sc_X.transform(X_test)

logreg = LogisticRegression(multi_class='multinomial',solver= 'newton-cg')
logreg.fit(X_train, Y_train)
y_pred = logreg.predict(X_test)

print("Accuracy for Logistic regression:", accuracy_score(Y_test,y_pred))

nb = GaussianNB()
nb.fit(X_train,Y_train)
y_pred = nb.predict(X_test)
print("Accuracy for Naive Baeyes:", accuracy_score(Y_test,y_pred))

tree = DecisionTreeClassifier(random_state=0)
tree.fit(X_train,Y_train)
y_pred = tree.predict(X_test)
print("Accuracy for Decsion Tree Classification:", accuracy_score(Y_test,y_pred))