#include <iostream>

using namespace std;

long tmp, sum = 0;

int main()
{
	cin >> tmp;
	tmp = abs(tmp);
	while (tmp)
	{
		sum += tmp % 10;
		tmp /= 10;
	}
	cout << sum << endl;
}