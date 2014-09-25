https://projecteuler.net/problem=31

Coin sums
Problem 31
In England the currency is made up of pound, £, and pence, 
p, and there are eight coins in general circulation:

1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
It is possible to make £2 in the following way:

1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
How many different ways can £2 be made using any number of coins?

1: 1
2: 1 1, 2
3: 1 1 1, 2 1
4: 1 1 1 1, 2 2, 2 1 1 = 3
5: 1 1 1 1 1, 2 1 1 1, 2 2 1, 5 = 4
6: 1 1 1 1 1 1, 2 1 1 1 1, 2 2 1 1, 2 2 2, 5 1 = 5
7: 1111111, 2 11111, 2 2 111, 2 2 21, 5 1 1, 5 2 = 6

TODO: use array to cache prev results