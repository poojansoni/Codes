#Write a program to demonstrate basic data type in python.

a = 5 #int
print("Type of a: ", a,type(a)) 
  
b = 5.0 #float
print("\nType of b: ",b, type(b)) 

c = float(a)
print("\nType of c: ",c, type(c)) #typecast int to float 
  
c = 2 + 4j #complex
print("\nType of c: ", c, type(c))

str1 = 'Hello World' #string
print("\nType of str1: ", str1, type(str1))  

flag = True
print("flag is set to = ", flag, type(flag))