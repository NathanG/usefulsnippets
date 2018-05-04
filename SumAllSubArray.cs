long arrayX(int[] numberArray, int targetSum)
{
    var sumArray = new int[targetSum + 1];
    sumArray[0] = 1;
    foreach (var subElement in numberArray)  {
        for (int i = targetSum + 1; i > subElement;)
            // sumArray[0] = 1; => first sumArray[subElement] = 1
            sumArray[--i] += sumArray[i - subElement];
    }

    return sumArray[targetSum];
}