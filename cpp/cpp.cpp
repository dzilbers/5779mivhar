// cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <cmath>

using namespace std;

const int THE_NUMBER = 100;

void f1(int& num) {
	num = 9;
	std::cout << num << std::endl;
}

void f2(const int& num) {
	//num = 9;
	std::cout << num << std::endl;
}

//void swap(int i, int j) {
//	int temp = i;
//	i = j;
//	j = temp;
//}

void swap(int& i, int& j) {
	int temp = i;
	i = j;
	j = temp;
}

void swap(int* pi, int* pj) {
	int temp = *pi;
	*pi = *pj;
	*pj = temp;
}

int main() {
	int i = 10;
	f1(i);
	/*f1(THE_NUMBER);
	f1(i + 2);*/

	f2(i);
	f2(THE_NUMBER);
	f2(i + 2);
	f2(10);

	int k = 8, l = 10;
	swap(k, l);
	std::cout << k << std::endl;

	swap(&k, &l);
	std::cout << k << std::endl;

	std::cout << sqrt(4) << pow(3.5, 4.2) << std::endl;
}
//	enum WeekDays { SUN = 1, MON, TUE, WED, THU, FRI, SHABBAT };
//	WeekDays weekDays[7] = { SUN, MON, TUE, WED, THU, FRI, SHABBAT };
//	const char* weekDayNames[8] = {
//		"",
//		"Sunday",
//		"Monday",
//		"Tuesday",
//		"Wednesday",
//		"Thursday",
//		"Friday",
//		"Shabbat"
//	};
//
//	int question;
//	cin >> question;
//	WeekDays day = SHABBAT;  // weekDays[question - 1];
//	cout << day << ": " << weekDayNames[day];
//
//	day = (WeekDays)3;
//	day = FRI;
//	if (day == 5)
//
//		switch (day) {
//		case SUN:
//			cout << "Sunday";
//			break;
//		case MON:
//			cout << "Monday";
//			break;
//		case TUE:
//			cout << "Tuesday";
//			break;
//		case WED:
//			cout << "Sunday";
//			break;
//		case FRI:
//		case SHABBAT:
//			cout << "Weekend";
//		default:
//			cout << "Error";
//		}
//	enum MonthLength { JAN = 31, FEB = 28 };
//	int choice;
//	switch (choice) {
//	case 1:
//		cout << JAN << " days\n";
//		break;
//	}
//	double a = 2;
//	double b = 0.0;
//	a = 3 / b;
//	std::cout << a << " " << b << std::endl;
//
//start:
//	if (a > 4) goto end;
//	cout << "Still here\n";
//	goto start;
//end:
//
	//int num = 2;
	//cout << num++ << num;

