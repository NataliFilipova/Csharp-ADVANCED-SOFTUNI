#include <iostream>
using namespace std;


int binaryInsertionSort(int * , int );
int binarySearch(int* , int, int);
int printArray(int arr[], unsigned n) {

    for (unsigned i = 0; i < n; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;
    return 0;
}

int main()
{

	const int N = 7;
	int arr[N] = { 4, 2, 5, -3, 4, 6 ,2 };

    printArray(arr, N);
    binaryInsertionSort(arr, N);
    printArray(arr, N);

}

int binarySearch(int* arr, int currIndex, int countOfOrderedElemets)
{
    int left = 0;
    int mid = 0;
    int right = countOfOrderedElemets;

    while (left < right) {
        mid = (left + right) / 2;

        if (arr[mid] == currIndex) {
            return mid + 1;
        }

        if (currIndex > arr[mid]) left = mid + 1;
        else right = mid - 1;

    }
    if (currIndex > arr[left]) {
        return (left + 1);
    }
    else {
        return left;
    }
}


int binaryInsertionSort(int * arr , int countOfElements)
{
    for (int i = 1; i < countOfElements; i++)
    {
        int index = i;
        int element = arr[i];

        int wantedIndex = binarySearch(arr, arr[i], i);

        for (int j = i; j >= wantedIndex; j--) {
            arr[j] = arr[j - 1];
        }
        arr[wantedIndex] = element;
    }

	return 0;
}

