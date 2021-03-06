


def function(st1, st2): 
    
    l = len(st1) 
      
    dist = 0
      
    for i in range(l): 
        if(st1[i] != st2[i]):
            dist = dist + ord(st1[i]) - ord(st2[i])
  
    return dist
  
  
# Driver function 
st1 = "heard"
st2 = "hears"
print(function(st1,st2))