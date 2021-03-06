#A) Write a Program to demonstrate list and tuple in python.
#B Write a program using a for loop that loops over a sequence.
#C) Write a program using a while loop that asks the user for a number, and prints a
#countdown from that number to zero..

list1 = [1, 2, 3, 4, 5] #list
tup1 = (1, 2, 3, 4, 5) #Tuple

print("List is = ", list1, "\nTuple is = ", tup1,"\n") #A)

for i in list1:  #B)
    print("Loop running", i)

flag = int(input("\nEnter a no,"))   #c)
while flag>=0:
    print("Count Down", flag)
    flag = flag -1