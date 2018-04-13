class Rectangle
{
public:
	Rectangle();
	Rectangle(const double value);
	Rectangle(const double value1, const double value2);

	void SetElementsValue(const double value1, const double value2);
	void DisplayElementsValue();

	double Diagonal();
	double Area();
private:
	double a;
	double b;
};