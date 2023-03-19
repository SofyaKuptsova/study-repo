#include "Cyrcles.h"
#include <stdio.h>
#include <locale.h>
#include <math.h>
#pragma warning(disable : 4996)

int main() {
	setlocale(LC_ALL, "Rus");
	int a = 10;
	int b = 20;
	int even = 0;
	while (a < b)
	{
		if (a % 2 == 0) 
			even++;
		a++;
	}
	printf("There are %d even numbers in sequence\n", even);
/*
	int input;
	do {
		printf("Enter a divider for 100 (remember, that you can't divide by zero)\n");
		scanf("%d", &input);
	} while (input == 0);

	printf("100 / %d = %d\n", input, 100 / input);
	printf("and the remainder will be %d, by the way", 100 % input);
*/
	
	int number = 71;
	printf("Input a number, please\n");
	//scanf("%d", &number);
	printf("\n");
	int d = 0, i = 1;
	while (i <= number) {
		if (number % i++ == 0)
			d++;
		else
			continue;

		if (d == 3) break;
	}
	printf("Введенное число %d %sявляется простым \n", number, (d == 2) ? "" : "не ");

	int significative = 10;
	int base = 2;
	int result = 1;
	for (i = 0; i < significative; i++) {
		result *= base;
	}
	printf("%d powered by %d is %d \n", base, significative, result);

	getchar();
	return 0;
}
