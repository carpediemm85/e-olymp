#include <iostream>

int main() {
	int t, num, max, n;
	scanf("%d", &t);
	while (t--) {
		scanf("%d%d", &num, &n);
		max = n;
		while (n != 1) {
			if (n % 2) n = n * 3 + 1;
			else n >>= 1;
			if (max < n) max = n;
		}
		printf("%d %d\n", num, max);
	}
	return 0;
}