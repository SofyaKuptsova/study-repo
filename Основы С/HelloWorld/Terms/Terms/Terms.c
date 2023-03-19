#include "Terms.h"
#include <stdio.h>
#include <locale.h>
#pragma warning(disable : 4996)

int main() {
	setlocale(LC_ALL, "Rus");

	char answer;
	/*printf("Do you want me to salute you? (y/n)");
	scanf("%c", &answer);
	if (answer == 'y') {
		printf("Hello, user!");
	} else if(answer == 'n') {
		printf("I didn't want to salut you anyway!");
	} else {
		printf("I can't understand your input!");
	}*/

	int a = 10;
	int b = 15;

	a = (a > b) ? b : 0;
	if (a > b)
		a = b;
	else
		a = 0;

	printf("\n%s", (1 > 0) ? "true" : "false");

	// > < >= <= ==
	// && || ! ^
	if (1 && 0) printf("false");
	if (1 || 0) printf("true");
	if (!(1)) printf("false");
	if (1 ^ 1) printf("false");

	/*
	if (1) {
		if (1) {
			//...
		}
	}
	*/
	
	printf("\n");
	int x = 7;
	if ((x >= 0) && (x <= 10)) {
		printf("X Fits!");
	}

	getchar();
	return 0;
}
