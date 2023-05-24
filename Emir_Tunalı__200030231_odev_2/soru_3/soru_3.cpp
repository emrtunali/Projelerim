


// Bu kod, çift yönlü baðlantýlý bir listeyi oluþturur ve düðüm eklemeye, düðüm silmeye, liste öðelerini yazdýrmaya ve belirli bir öðeyi aramaya izin verir.
#ifndef _NONCIRCULARDOUBLYLINKEDLIST_H
#define _NONCIRCULARDOUBLYLINKEDLIST_H
#include <iostream>

using namespace std;

// Düðüm yapýsý
struct node {
	string info;
	node* prev = NULL;
	node* next = NULL;
};

// DoubleLinkedList sýnýfý
class nonCircularDoublyLinkedList
{
private:
	node* head; // Listenin baþlangýç düðümü

public:
	nonCircularDoublyLinkedList(); // Kurucu fonksiyon
	bool addNode(string n); // Yeni bir düðüm ekler
	bool deleteNode(string n); // Belirtilen düðümü siler
	void printList(); // Listeyi yazdýrýr
	bool searchList(string n); // Belirli bir düðümün varlýðýný kontrol eder
	void deleteList(); // Tüm listeyi siler
	~nonCircularDoublyLinkedList() // Yok edici fonksiyon
	{
		deleteList();
	}
};

// DoubleLinkedList sýnýfýnýn kurucu fonksiyonu
nonCircularDoublyLinkedList::nonCircularDoublyLinkedList()
{
	head = NULL;
}

// Yeni bir düðüm ekleyen fonksiyon
bool nonCircularDoublyLinkedList::addNode(string n)
{
	node* newNode = new node;
	newNode->info = n;
	newNode->prev = NULL;
	newNode->next = NULL;

	if (head == NULL)
	{
		head = newNode;
	}
	else {
		node* ptr = head;
		while (ptr->next != NULL)
		{
			ptr = ptr->next;
		}
		newNode->prev = ptr;
		newNode->next = NULL;
		ptr->next = newNode;
	}

	return true;
}

// Belirtilen düðümü silen fonksiyon
bool nonCircularDoublyLinkedList::deleteNode(string n)
{
	if (head == NULL)
	{
		cout << "Listeniz BOMBOÞ" << endl;
		return false;
	}

	node* ptr = head;
	while (ptr->info != n)
	{
		ptr = ptr->next;
	}

	ptr->prev->next = ptr->next;
	ptr->next->prev = ptr->prev;
	if (ptr == head)
	{
		head = ptr->next;
	}
	cout << "Sildiginiz Node:" << ptr->info << endl;
	delete ptr;

	return true;
}

// Liste öðelerini yazdýran fonksiyon
void nonCircularDoublyLinkedList::printList()
{
	if (head == NULL)
	{
		cout << "Liste BOMBOÞ" << endl;
		return;
	}

	node* ptr = head;
	while (ptr != NULL)
	{
		cout << ptr->info << endl;
		ptr = ptr->next;
	}
}

// Belirli bir düðümün varlýðýný kontrol eden fonksiyon
bool nonCircularDoublyLinkedList::searchList(string n)
{
	node* ptr = head;
	while (ptr->info != n)
	{
		ptr = ptr->next;
	}
	cout << "Aradiginiz Node:" << ptr->info << endl;

	return true;
}

// Tüm listeyi silen fonksiyon
void nonCircularDoublyLinkedList::deleteList()
{
	node* current = head;
	while (current != NULL)
	{
		node* nextNode = current->next;
		delete current;
		current = nextNode;
	}

	head = NULL;
	cout << "Butun Liste Silindi" << endl;
}
#endif;
// main fonksiyonu
int main()
{
	nonCircularDoublyLinkedList myList;
	myList.addNode("araba");
	myList.addNode("ev");
	myList.addNode("yazlik");
	myList.addNode("ofis");

	myList.deleteNode("ev");
	myList.searchList("ofis");
	myList.printList();

	return 0;
}