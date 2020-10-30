#include <iostream>
#include<string>
#include<fstream>
#include<Windows.h>
#include<math.h>
#include<vector>
#include<ctime>
#include<typeinfo>
#include<memory>
using namespace std;
int main(int argc, char*argv[]) { 
	cout << "argc = " << argc << endl;
	for (int i = 0; i < argc; i++) {
		cout << argv[i] << endl;
	}
	system("pause");
	return 0;
}