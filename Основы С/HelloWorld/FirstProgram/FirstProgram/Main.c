#include "Main.h"
#include <stdio.h>
#include <locale.h>
#pragma warning(disable : 4996)

int main() {
	setlocale(LC_ALL, "Rus");

	// \n \t \0
	printf("Hello\0 World!\n");
	printf("This is a new \trow with tab\n");
	printf("This is a new row with \\ symbol\n");

	//�����������
	// %d %s %c %p %f %lf %x %%
	// %2.f
	// %05d
	int a = 50;
	printf("text and%5d%%\n", a);

	// ����������
	short sh = 345; // 2 bytes -32768...32767
	int number = -56; // 4 bytes -2.147.000000...+2.147.000000
	unsigned int uint = 4000000000; // 4 bytes 0...+4.294.000.000
	unsigned char symbol = 'A'; //0...255
	float real = 5.345f; // 4 bytes
	double realdouble = 5.345; // 8 bytes long float
	//no bool type
	int true = 1;
	int false = 0;
	char sym = 75; // 1 byte -128...127

	printf("���������� � ����� ��������: %d \n", a);
	printf("���������� � �������� �� ������: %p \n", &a);

	int input;
	printf("�������, ����������, �����:");
	scanf("%d", &input);
	printf("�� ����� ����� %d, �� ������� ��� ��� ���: %d\n", input, input*2);

	// + - * /
	// & | ! ^ << >>
	int variable = 70;
	printf("��������� variable %d\n", variable);
	variable = variable + 50;
	variable += 50;
	printf("� ���������� ���� ������ ���������� 50 � ���������� %d\n", variable);
	variable = variable / 4; //������� ����� ����� ���������������
	printf("������������� ������� ���������� �� 4 ����� %d\n", variable);

	int reminder = variable % 4;
	printf("������� �� ������� 170 �� 4: %d\n", reminder);
	reminder++;
	printf("���������: %d\n", reminder);

	return 0;
}