#include <iostream>
#include <string>
#include <ctime>
#include <vector>
#include <stack>
#include <map>
#include <thread>
#include <chrono>
#include <deque>
#include <queue>
#include <list>
#include "Functions.h"
using namespace std;

// передача параметров в поток
/*
void DoWork(int a, int b) {
	this_thread::sleep_for(chrono::milliseconds(2000));
	cout << "=====\t" << "DoWork Started\t======" << endl;

	this_thread::sleep_for(chrono::milliseconds(3000));
	cout << "a + b = " << a + b << endl;

	this_thread::sleep_for(chrono::milliseconds(2000));
	cout << "=====\t" << "DoWork Stopped\t======" << endl;
}
*/

int main() {
	setlocale(LC_ALL, "ru");
	srand(time(NULL));
	// stack
	/*stack<int> st;
	st.push(1);
	st.push(5);
	st.emplace(9); // добавляет элкмент, но быстреее чем push
	cout << st.top() << endl;
	while (!st.empty()) {
		cout << st.top() << endl;
		st.pop();
	}*/
	// передача параметров в поток
	/*
	thread th(DoWork, 2, 3);

	for (size_t i = 0; i < 10; i++) {
		cout << "id = " << this_thread::get_id() << "\tmain\t" << i << endl;
		this_thread::sleep_for(chrono::milliseconds(500));
	}

	th.join();
	*/
	// queue, priority_queue 
	/*
	queue<int> q;
	q.emplace(5);
	q.emplace(10);
	q.emplace(0);
	while (!q.empty()) {
		cout << q.front() << endl;
		q.pop();
	}
	cout << "===============" << endl;
	priority_queue<int> pq; // добавляются согласно приоритетом, сортируются от большого к меньшему
	pq.emplace(5);
	pq.emplace(10);
	pq.emplace(0);
	while (!pq.empty()) {
		cout << pq.top() << endl;
		pq.pop();
	}
	*/
	
	return 0;
}