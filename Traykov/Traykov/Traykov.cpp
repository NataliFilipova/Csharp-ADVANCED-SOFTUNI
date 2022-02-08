
#include <iostream>

using namespace std;


int main()
{	
	int n = 3;
   
	int sum = 0;
	for (int i = 0; i < n; i++) {
		cout << i << endl;
		for (int j = 0; j < n; j++) {
			cout << j << endl;
			if (i == j)
				for (int k = 0; k < n; k++) {
					cout << k << endl;
					sum++;
				}
		}
	}
}
