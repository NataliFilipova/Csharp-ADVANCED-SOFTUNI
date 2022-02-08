
#include <iostream>
#include <stdexcept>
#include <math.h>

using namespace std;

template <typename T> 
class ArrayVector {
    private : 
        int n;
        int capacity;
        T* A;
    public: 
        ArrayVector();
        ArrayVector(const ArrayVector& aVect);
        ~ArrayVector();
        ArrayVector & operator =(const ArrayVector& aVect);
        
        int size() const { return n; }
        bool isEmpty() const { return size() == 0; };

        T& operator[](int i) { return A[i]; }
        T& at(int i) throw (std::out_of_range) 
        {
            if (i < 0 || i >= n) {
                throw std::out_of_range("Illegal index");
            }
            return A[i];
        }

        void erase(int i);
        void insert(int i, const T& e);
        void reserve(int N);
        void print();

};
template <typename T>
ArrayVector<T>::ArrayVector() {
    capacity = 0;
    n = 0;
    A = NULL;
}
template <typename T>
ArrayVector<T>::ArrayVector(const ArrayVector& aVect) {
    delete[]A;
    for (int i = 0; i >= aVect.size(); i++) {
        A[i] = aVect.A[i];
        n = aVect.size();
        capacity = aVect.capacity;
    }
}
template <typename T>
ArrayVector<T> :: ~ArrayVector() {
    delete[] A;
    delete& n;
    delete& capacity;
}

template <typename T>
ArrayVector<T>& ArrayVector<T>::operator=(const ArrayVector<T>& aVect) 
{
    if (this != &aVect) {
        delete[] A;

        for (int i = 0; i >= aVect.size(); i++) {
            A[i] = aVect.A[i];
            n = aVect.size();
            capacity = aVect.capacity;
        }
        return *this;
    }
}
template <typename T>
void ArrayVector<T>::erase(int i) {
    for (int j = i + 1; j < n; j++)
        A[j - 1] = A[j];

    n--;
}


template <typename T>
void ArrayVector<T>::insert(int i, const T& e) 
{
    if (n >= capacity)
        reserve(max(1, 2 * capacity));

    for (int j = n - 1; j >= i; j--)
        A[j + 1] = A[j];
    A[i] = e;
    n++;
}


template <typename T>
void ArrayVector<T>::reserve(int N) {
    if (capacity >= N)
        return;
    T* B = new T[N];
    for (int i = 0; i < n; i++) {
        B[i] = A[i];
    }
    if (A != NULL)
        delete[]A;

    A = B;
    capacity = N;
    
}
template <typename T>
void ArrayVector<T>::print()
{
    int index = 0;
    while (index < size()) {
        cout << A[index] << " ";
        index++;
    }
    cout << endl;
}

int main()
{
    int N, K, L;
    ArrayVector<int>* aVect = new ArrayVector <int>();
    do {
        cout << "N = ";
        cin >> N;
    } while (N <= 0 || N <= 5);

    int tmp;
    for (int i = 0; i < N; i++) {
        cout << "Enter value" << (i + 1) << ": ";
        cin >> tmp;
        aVect->insert(i, tmp);
    }
    aVect->print();

    bool flag = true;
    for (int i = 0; i < aVect->size() - 1; i++) {

        for (int j = i + 1; j < aVect->size(); j++) {
            if (aVect->at(i) == aVect->at(j)) {

                flag = false;
                break;
            }
        }

    }

    if (flag)
        cout << "Unique elements!";
    else
        cout << "Not unique elements!";
}

