#include <iostream>

using namespace std;

int a, b;

int gcd(int A, int B)
{
	if (B == 0) return A;
	return gcd(B, A % B);
}

int main()
{
	cin >> a >> b;
	cout << gcd(a, b) << endl;
}