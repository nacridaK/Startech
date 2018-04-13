#include <iostream>
#include "Rectangle.h"
using namespace std;

int main()
{
	Rectangle rc;
	rc.DisplayElementsValue();
	cout << "Diagonal: " << rc.Diagonal() << endl << "Area: " << rc.Area() << endl << endl;
	rc.SetElementsValue(1.5, 2.5);
	rc.DisplayElementsValue();
	cout << "Diagonal: " << rc.Diagonal() << endl << "Area: " << rc.Area() << endl << endl;
	system("pause");
}