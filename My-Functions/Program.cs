#nullable disable
Console.Clear();

List<int> mynums = new List<int>() { 6, 4, 5, 0, 2 };

// Linebreak Method
void br()
{
    Console.WriteLine();
}

// Make
static Boolean contains(List<int> aList, int item)
{
    for (int i = 0; i < aList.Count; i++)
    {
        if (aList[i] == item)
        {
            return true;
        }
    }
    return false;
}

// Run contains
if (contains(mynums, 8))
{
    Console.WriteLine("8 is inside the list");
}
else
{
    Console.WriteLine("8 is not in the list");
}

br();

// Make indexOf
int indexOf(List<int> aList, int item)
{
    for (int i = 0; i < aList.Count; i++)
    {
        if (aList[i] == item)
        {
            return i;
        }
    }
    return -1;
}


int index = indexOf(mynums, 4);
// run indexOf
if (index != -1)
{
    Console.WriteLine($"8 IN list at index: {index}");
}
else
{
    Console.WriteLine("8 NOT in list");
}

br();

// Make Reverse List Order
List<int> reverse(List<int> aList)
{
    for (int i = 0; i < aList.Count / 2; i++)
    {
        int el = aList[i];
        aList[i] = aList[aList.Count - i - 1];
        aList[aList.Count - i - 1] = el;
    }
    return aList;
}

// Call Reverse Function
List<int> reversedNums = (reverse(mynums));
for (int i = 0; i < reversedNums.Count; i++)
{
    Console.WriteLine(reversedNums[i]);
}


// reversedNums -> [10, 8, 6, 4, 2]

br();


// Swap Index Function
List<int> swap(List<int> aList, int index1, int index2)
{
    int el = aList[index1];
    aList[index1] = aList[index2];
    aList[index2] = el;
    return aList;
}

// Call Swap Function
swap(mynums, 2, 4);
for (int i = 0; i < mynums.Count; i++)
{
    Console.WriteLine(mynums[i]);
}

br();

// i = position of min 
// Find Index of Smallest Value
int indexOfMin(List<int> aList)
{
    for (int i = 0; i < aList.Count - 1; i++)
    {
        int min_pos = i;
        for (int j = i + 1; j < aList.Count; j++)
        {
            if (aList[min_pos] > aList[j])
            {
                min_pos = j;
            }
        }
        int el = aList[min_pos];
        aList[min_pos] = aList[i];
        aList[i] = el;
        return min_pos;
    }
    return 1000;
}

// // Dispaly Index of Smallest Value
int minIndex = indexOfMin(mynums);
Console.WriteLine(minIndex);


// function selectionSort(anArray) {
//   for (every fill slot from first position to second last position) {
//     // Search for minimum
//     set min position to the current fill slot
//     for (every element after the fill slot) {
//       if (current element is smaller than the value at min position) {
//         set min position to the position of the current element
//       }
//     }
//     Swap the values at the min position and the fill slot
//   }
// }