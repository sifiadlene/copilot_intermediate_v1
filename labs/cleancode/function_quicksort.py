# Create a quicksort function that sorts a list of numbers in ascending order.
# The function should take a list of numbers as input and return a new list with the numbers sorted in ascending order.
# You can use the quicksort algorithm to implement the function.

def quicksort(numbers):
    if len(numbers) <= 1:
        return numbers
    pivot = numbers[0]
    left = [x for x in numbers[1:] if x < pivot]
    right = [x for x in numbers[1:] if x >= pivot]
    return quicksort(left) + [pivot] + quicksort(right)