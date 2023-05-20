#include<iostream>
#include <string>
using namespace std;

int main()
{
	 
	string s = "comfortable";
	string ss = "";

	string rest;
	int i = 0;
	cout << s << endl << endl;
	do
	{
		i = s.find(ss, i);	if (i == -1) break;
		cout << "index " << i << endl;
		rest.assign(s, i, s.size());
		cout << rest << endl << endl;
		++i;
	} while (i != -1);

	return 0;
}