#ifndef _NONCIRCULARSINGLYLINKEDLIST_H
#define _NONCIRCULARSINGLYLINKEDLIST_H

#include <iostream>
using namespace std;

struct node {
	string value;
	node* next = NULL; // Baþlangýçta boþ olan bir sonraki düðüm 
};

class NonCircularSinglyLinkedList
{
private:
	node* head;

public:
	NonCircularSinglyLinkedList();
	bool addNode(string n);
	bool deleteNode(string n);
	void printList();
	bool searchList(string n);
	void deleteList();
	~NonCircularSinglyLinkedList()
	{
		deleteList();
	}
};

// Yapýcý fonksiyon, baþlangýçta boþ bir liste oluþturuyor.
NonCircularSinglyLinkedList::NonCircularSinglyLinkedList()
{
	head = NULL;
}

// Listeye yeni bir düðüm ekleyen fonksiyon
bool NonCircularSinglyLinkedList::addNode(string n)
{
	node* newNode = new node;
	newNode->value = n;
	newNode->next = NULL;

	if (head == NULL) // Eðer listenin baþlangýcý boþ ise, yeni düðümü baþlangýç olarak ayarla
	{
		head = newNode;
	}
	else { // Eðer listenin baþlangýcý boþ deðilse, son düðümü bulana kadar ilerleyerek yeni düðümü ekleyin
		node* ptr = head;
		while (ptr->next != NULL)
		{
			ptr = ptr->next;
		}
		ptr->next = newNode;
	}
	return true;
}

// Ýstenilen düðümü listeden silen fonksiyon
bool NonCircularSinglyLinkedList::deleteNode(string n)
{
	node* ptr = head;

	if (ptr != NULL && ptr->value == n) { // Eðer listenin baþlangýcý doðru ise, onu silin ve yeni baþlangýcý ayarlayýn.
		head = ptr->next;
		delete ptr;
		return true;
	}

	while (ptr != nullptr) { // Baþlangýçta olan bir düðüm deðilse, listede gezinin ve istenilen düðümü bulunca silin. 
		if (ptr->next->value == n) {
			node* temp = ptr->next;
			ptr->next = ptr->next->next;
			cout << "Silinen Dugum:" << temp->value << endl;
			delete temp;
			return true;
		}
		ptr = ptr->next;
	}

	return false; // Eðer listede düðüm yoksa false döndürün
}

// Listenin tüm elemanlarýný yazdýran fonksiyon
void NonCircularSinglyLinkedList::printList()
{
	if (head == NULL)
	{
		cout << "Liste boþ." << endl;
		return;
	}

	node* ptr = head;
	while (ptr != NULL)
	{
		cout << "Eleman: " << ptr->value << endl;
		ptr = ptr->next;
	}
}

// Ýstenilen düðümün listede olup olmadýðýný kontrol eden fonksiyon
bool NonCircularSinglyLinkedList::searchList(string n)
{
	node* ptr = head;
	while (ptr != nullptr && ptr->value != n)
	{
		ptr = ptr->next;
	}
	if (ptr == nullptr)
	{
		cout << "Aradiginiz Deger Listedeki Yok" << endl;
		return false;
	}
	cout << "Aradiginiz Deger : " << ptr->value << endl;
	return true;
}

// Listenin tüm elemanlarýný silen fonksiyon
void NonCircularSinglyLinkedList::deleteList()
{
	node* ptr;
	while (head != NULL)
	{
		ptr = head->next;
		delete head;
		head = ptr;
	}
}
#endif;


int main()
{
	NonCircularSinglyLinkedList myList;
	myList.addNode("Bilgisayar Mühendisliði");
	myList.addNode("Yazýlým Mühendisliði");
	myList.addNode("Bilgisayar Programlama");
	myList.addNode("Siber Güvenlik");

	myList.deleteNode("Yazýlým Mühendisliði");
	myList.searchList("Siber Güvenlik");
	myList.printList();

	return 0;
}
