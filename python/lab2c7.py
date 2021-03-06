#7) WAP to  read the data from the file using Pandas'
import pandas as pd

df = pd.read_csv(r'C:\Users\sonip\OneDrive\Documents\Codes\python\Social_Network_Ads.csv')  ####  exp 7
print(df)

print("Shape",df.shape)
mean1 = df['Age'].mean()
sum1 = df['Age'].sum()
max1 = df['Age'].max()
min1 = df['Age'].min()
count1 = df['Age'].count()
median1 = df['Age'].median() 
                                            ####  Exp 8
print ('Mean Age: ' + str(mean1))
print ('Sum of Age: ' + str(sum1))
print ('Max Age: ' + str(max1))
print ('Min Age: ' + str(min1))
print ('Count Age: ' + str(count1))
print ('Median Age: ' + str(median1))

# list of name, degree, score                   ####EXP 9
nme = ["aparna", "pankaj", "sudhir", "Geeku"] 
deg = ["MBA", "BCA", "M.Tech", "MBA"] 
scr = [90, 40, 80, 98] 
   
# dictionary of lists  
dict = {'name': nme, 'degree': deg, 'score': scr}  
     
df = pd.DataFrame(dict) 
  
# saving the dataframe 
df.to_csv('new.csv') 