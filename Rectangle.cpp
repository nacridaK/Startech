#include "Rectangle.h"
#include <iostream>
#include <math.h>
using namespace std;

Rectangle::Rectangle()
{
	a = 1;
	b = 1;
}
Rectangle::Rectangle(const double value)
{
	a = value;
	b = value;
}
Rectangle::Rectangle(const double value1, const double value2)
{
	a = value1;
	b = value2;
}
void Rectangle::SetElementsValue(const double value1, const double value2)
{
	a = value1;
	b = value2;
}
void Rectangle::DisplayElementsValue()
{
	cout << "DisplayElements: " << a << " " << b << endl;
}
double Rectangle::Diagonal()
{
	return sqrt(a*a + b * b);
}
double Rectangle::Area()
{
	return a * b;
}