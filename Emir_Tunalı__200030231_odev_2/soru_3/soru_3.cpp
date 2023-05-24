


// Bu kod, �ift y�nl� ba�lant�l� bir listeyi olu�turur ve d���m eklemeye, d���m silmeye, liste ��elerini yazd�rmaya ve belirli bir ��eyi aramaya izin verir.
#ifndef _NONCIRCULARDOUBLYLINKEDLIST_H
#define _NONCIRCULARDOUBLYLINKEDLIST_H
#include <iostream>

using namespace std;

// D���m yap�s�
struct node {
	string info;
	node* prev = NULL;
	node* next = NULL;
};

// DoubleLinkedList s�n�f�
class nonCircularDoublyLinkedList
{
private:
	node* head; // Listenin ba�lang�� d���m�

public:
	nonCircularDoublyLinkedList(); // Kurucu fonksiyon
	bool addNode(string n); // Yeni bir d���m ekler
	bool deleteNode(string n); // Belirtilen d���m� siler
	void printList(); // Listeyi yazd�r�r
	bool searchList(string n); // Belirli bir d���m�n varl���n� kontrol eder
	void deleteList(); // T�m listeyi siler
	~nonCircularDoublyLinkedList() // Yok edici fonksiyon
	{
		deleteList();
	}
};

// DoubleLinkedList s�n�f�n�n kurucu fonksiyonu
nonCircularDoublyLinkedList::nonCircularDoublyLinkedList()
{
	head = NULL;
}

// Yeni bir d���m ekleyen fonksiyon
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

// Belirtilen d���m� silen fonksiyon
bool nonCircularDoublyLinkedList::deleteNode(string n)
{
	if (head == NULL)
	{
		cout << "Listeniz BOMBO�" << endl;
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

// Liste ��elerini yazd�ran fonksiyon
void nonCircularDoublyLinkedList::printList()
{
	if (head == NULL)
	{
		cout << "Liste BOMBO�" << endl;
		return;
	}

	node* ptr = head;
	while (ptr != NULL)
	{
		cout << ptr->info << endl;
		ptr = ptr->next;
	}
}

// Belirli bir d���m�n varl���n� kontrol eden fonksiyon
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

// T�m listeyi silen fonksiyon
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