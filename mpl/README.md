# MPL FILES

## pyhton exercises


This file contains Python solutions for classical mathematical and algorithmic challenges, notably inspired by Project Euler problems, alongside numerical approximation scripts. Below is a detailed description of the scripts included in the notebook:

---

### 📋 Included Code Blocks & Problems

* **Multiples of 3 and 5**
  * **Description**: Finds all natural numbers below 1000 that are multiples of 3 or 5, stores them in a list, and calculates their total sum.
  * **Result**: The sum of all multiples of 3 and 5 below 1000 is **233,168**.

* **Even Fibonacci Numbers**
  * **Description**: Generates Fibonacci sequence terms starting with 1 and 2 up to a threshold of 4,000,000, filtering and summing up only the even-valued terms.
  * **Result**: The sum of all even Fibonacci numbers below 4 million is **4,613,732**.

* **Largest Prime Factor**
  * **Description**: Iteratively divides a composite number ($600,851,475,143$) by its smallest possible divisors to isolate and find its largest prime factor.
  * **Result**: The largest prime factor is **6,857**.

* **Leibniz Pi Approximation (In Progress)**
  * **Description**: A boilerplate function framework (`lebiniz_pi(n)`) designated for approximating the value of Pi using the Leibniz infinite series formula.

## pyh2

This Python script calculates the approximate value of Pi ($\pi$) using two famous mathematical infinite series: the Leibniz formula and the Euler formula (also known as the Basel problem). It also measures how many iterations each method requires to reach a specific level of precision.

1. Leibniz Formula for Pi ( leibnitz_pi(n)) How it works: 
This function approximates Pi using the Gregory-Leibniz infinite series, which mathematically looks like this: $\pi = 4 \times (1 - \frac{1}{3} + \frac{1}{5} - \frac{1}{7} + \frac{1}{9} - ...)$.Implementation in code: It iterates n + 1times, alternating the sign for each odd denominator, adds the fractions together, and multiplies the final sum by 4.

<div align="center">

$$\pi = 4 \times \left(1 - \frac{1}{3} + \frac{1}{5} - \frac{1}{7} + \frac{1}{9} - \dots\right) = 4 \sum_{k=0}^{\infty} \frac{(-1)^k}{2k + 1}$$

</div>

<div align="center">

[Wikipedia – Leibniz formula for π](https://en.wikipedia.org/wiki/Leibniz_formula_for_%CF%80)

</div>
        



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

2. Euler's Formula for Pi ( euler_pi(n)) How it works: 
This function uses Euler's solution to the Basel problem, which states that the sum of the reciprocals of the squares of the natural numbers equals.Implementation in code: It iterates ntimes, adding up for each step. At the end, it multiplies the total sum by 6 and calculates the square root ( ** 0.5) to isolate Pi.

<div align="center">

$$\sum_{n=1}^{\infty} \frac{1}{n^2} = 1 + \frac{1}{2^2} + \frac{1}{3^2} + \frac{1}{4^2} + \dots = \frac{\pi^2}{6} \implies \pi = \sqrt{6 \sum_{n=1}^{\infty} \frac{1}{n^2}}$$

</div>

<div align="center">

[Wikipedia – Euler's Approach on Basel Problem](https://en.wikipedia.org/wiki/Basel_problem#Euler's_approach)

</div>



```python
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
```



3. Convergence Testing (The whileloops)Target Accuracy: The script defines a target precision limit ( diff = 0.0001) and compares the formula results against a hardcoded accurate Pi constant ( accurate_pi = 3.141592653589).Finding the Iteration Count: It uses whileloops to continuously increase an iteration counter ( i += 1) and recalculate Pi until the difference between the formula's output and the accurate Pi is smaller than the target difference.Output: It prints i, showing exactly how many iterations it took for the series to converge to that 0.0001accuracy level. This demonstrates that Euler's method converges much faster than Leibniz's method.

