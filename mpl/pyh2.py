accurate_pi = 3.141592653589
def leibnitz_pi(n):
    sign = 1
    pi = 0
    for i in range( n + 1):
        sign *= (-1)
        #print(sign * 1/(2 * i + 1))
        pi += sign * 1/(2 * i + 1)
       
    return pi * 4

# print(f"pi = {leibnitz_pi(10)}")
#print(f"pi = {leibnitz_pi(1000)}")
#print(f"pi difference = {leibnitz_pi(1000) - accurate_pi}")

diff = 0.0001
i=1
while(abs(leibnitz_pi(n) - accurate_pi) > diff):
    #print(diff, leibnitz_pi(i))
    i += 1
print(i)
    
    
accurate_pi = 3.141592653589
def euler_pi(n):
    pi = 0
    for i in range( 1 , n+1):
       
        #print (1/(i*i))
        pi += 1/(i*i)
       
    return (pi * 6) ** 0.5

print (euler_pi(10))

diff = 0.0001
i=1
while(abs(euler_pi(i) - accurate_pi) > diff):
    #print(diff, leibnitz_pi(i))
    i += 1
print(i)
