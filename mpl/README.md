# MPL FILES

- pyhton exercises

- pyh2

This Python script calculates the approximate value of Pi ($\pi$) using two famous mathematical infinite series: the Leibniz formula and the Euler formula (also known as the Basel problem). It also measures how many iterations each method requires to reach a specific level of precision.

1. Leibniz Formula for Pi ( leibnitz_pi(n))How it works: This function approximates Pi using the Gregory-Leibniz infinite series, which mathematically looks like this: $\pi = 4 \times (1 - \frac{1}{3} + \frac{1}{5} - \frac{1}{7} + \frac{1}{9} - ...)$.Implementation in code: It iterates n + 1times, alternating the sign for each odd denominator, adds the fractions together, and multiplies the final sum by 4.

```python
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
```

2. Euler's Formula for Pi ( euler_pi(n))How it works: This function uses Euler's solution to the Basel problem, which states that the sum of the reciprocals of the squares of the natural numbers equals$\frac{\pi^2}{6}$.Implementation in code: It iterates ntimes, adding up$\frac{1}{i^2}$for each step. At the end, it multiplies the total sum by 6 and calculates the square root ( ** 0.5) to isolate Pi.

3. Convergence Testing (The whileloops)Target Accuracy: The script defines a target precision limit ( diff = 0.0001) and compares the formula results against a hardcoded accurate Pi constant ( accurate_pi = 3.141592653589).Finding the Iteration Count: It uses whileloops to continuously increase an iteration counter ( i += 1) and recalculate Pi until the difference between the formula's output and the accurate Pi is smaller than the target difference.Output: It prints i, showing exactly how many iterations it took for the series to converge to that 0.0001accuracy level. This demonstrates that Euler's method converges much faster than Leibniz's method.

