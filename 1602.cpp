#include <iostream>

using namespace std;

long a, b;


long gcd(long A, long B)
{
	return B ? gcd(B, A % B) : A;
}

int main()
{
	cin >> a >> b;
	cout << a*b / gcd(a, b) << endl;;
}