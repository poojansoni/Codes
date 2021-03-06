#Write a program to compute distance between two points taking input from the user
import math
inp = input("Calculate distance between two points.\nEnter X1 Y1 and X2 Y2\n")
res = [int(i) for i in inp.split() if i.isdigit()]  

dist = math.sqrt((res[0]-res[2])**2 + (res[1]-res[3])**2)

print("Distance is: ", dist)
