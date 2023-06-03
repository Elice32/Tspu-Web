#include <iostream>
using namespace std;
// шаблонная функция
template < class T > unsigned int index_max_element(const T* p, const size_t size)
{
	int ind = 0;
	unsigned int i;
	T max = p[0];
	for (i = 1; i < size; i++)
		if (p[i] > max) { max = p[i]; ind = i; }
	return ind;
}
template < class T >	void view(const T* p, const size_t size)
{
	for (int i = 0; i < size; i++)
		cout << p[i] << '\t';
	cout << endl;
}
// главная функция
int main() {
	int ia[] = { 1, -3, 0, -9, 2, 7, 0, -19 };
	double da[] = { 0.0875, 1.25, -3, 0.0, -7.986 };
	long la[] = { 1L, -2L, 3L, -100L };
	float fa[] = { -2.12, 1.5, -3.25, -17.2 };
	char s[] = "Vivat!";
	cout << "\nint Array\n";
	view(ia, sizeof(ia) / sizeof(int));
	printf("Index maksimalnogo elementa -> %d\n", index_max_element(ia, sizeof(ia) / sizeof(int)) + 1);
	cout << "\ndouble Array\n";
	view(da, sizeof(da) / sizeof(double));
	printf("Index maksimalnogo elementa -> %d\n", index_max_element(da, sizeof(da) / sizeof(double)) + 1);
	cout << "\nlong Array\n";
	view(la, sizeof(la) / sizeof(long));
	printf("Index maksimalnogo elementa -> %d\n", index_max_element(la, sizeof(la) / sizeof(long)) + 1);
	cout << "\nfloat Array\n";
	view(fa, sizeof(fa) / sizeof(float));
	printf("Index maksimalnogo elementa -> %d\n", index_max_element(fa, sizeof(fa) / sizeof(float)) + 1);
	cout << "\nchar Array\n";
	view(s, strlen(s));
	printf("Index maksimalnogo elementa -> %d\n", index_max_element(s, sizeof(s) / sizeof(char)) + 1); 							// 1
	system("pause");
	return 0;
}