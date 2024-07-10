# CSC_295_HW-2

Binary search helps us efficiently find elements in a sorted array by repeatedly dividing the search interval in half. In our case, we need to check elements in pairs to locate the single element. If an element at an even index is equal to the next element, the single element is further along in the array. If the element at an even index is not equal to the next element, the single element is either at this index or before it.

To implement this, we start with left at 0 and right at the last index of the array. While left is less than right, we calculate the middle index mid. To ensure we always start with an even index, we decrement mid by 1 if it is odd. If the element at mid is not equal to the element at mid + 1, the single element is at mid or before it, so we set right to mid. If the element at mid is equal to the element at mid + 1, the single element is further along in the array, so we set left to mid + 2. This process continues until left equals right, at which point the single element is found.

For example, with this array [1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9]. Using the binary search method, we initially set left at 0 and right at the end of the array. By calculating mid, adjusting it if necessary, and comparing elements to decide the next interval to search, it eventually identifies 7 as the single element. This binary search approach makes sure of an efficient solution which is best for large arrays, by taking advantage of the sorted array and pattern of pairs.

Challenges faced were figuring out that I’d have to “If” statements inside of the while loop. 
