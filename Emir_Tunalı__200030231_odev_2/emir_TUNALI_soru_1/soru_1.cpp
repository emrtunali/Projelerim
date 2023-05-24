#ifndef _NONCIRCULARSINGLYLINKEDLIST_H
#define _NONCIRCULARSINGLYLINKEDLIST_H

#include <iostream>
using namespace std;

struct node {
	string value;
	node* next = NULL; // Ba�lang��ta bo� olan bir sonraki d���m 
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

// Yap�c� fonksiyon, ba�lang��ta bo� bir liste olu�turuyor.
NonCircularSinglyLinkedList::NonCircularSinglyLinkedList()
{
	head = NULL;
}

// Listeye yeni bir d���m ekleyen fonksiyon
bool NonCircularSinglyLinkedList::addNode(string n)
{
	node* newNode = new node;
	newNode->value = n;
	newNode->next = NULL;

	if (head == NULL) // E�er listenin ba�lang�c� bo� ise, yeni d���m� ba�lang�� olarak ayarla
	{
		head = newNode;
	}
	else { // E�er listenin ba�lang�c� bo� de�ilse, son d���m� bulana kadar ilerleyerek yeni d���m� ekleyin
		node* ptr = head;
		while (ptr->next != NULL)
		{
			ptr = ptr->next;
		}
		ptr->next = newNode;
	}
	return true;
}

// �stenilen d���m� listeden silen fonksiyon
bool NonCircularSinglyLinkedList::deleteNode(string n)
{
	node* ptr = head;

	if (ptr != NULL && ptr->value == n) { // E�er listenin ba�lang�c� do�ru ise, onu silin ve yeni ba�lang�c� ayarlay�n.
		head = ptr->next;
		delete ptr;
		return true;
	}

	while (ptr != nullptr) { // Ba�lang��ta olan bir d���m de�ilse, listede gezinin ve istenilen d���m� bulunca silin. 
		if (ptr->next->value == n) {
			node* temp = ptr->next;
			ptr->next = ptr->next->next;
			cout << "Silinen Dugum:" << temp->value << endl;
			delete temp;
			return true;
		}
		ptr = ptr->next;
	}

	return false; // E�er listede d���m yoksa false d�nd�r�n
}

// Listenin t�m elemanlar�n� yazd�ran fonksiyon
void NonCircularSinglyLinkedList::printList()
{
	if (head == NULL)
	{
		cout << "Liste bo�." << endl;
		return;
	}

	node* ptr = head;
	while (ptr != NULL)
	{
		cout << "Eleman: " << ptr->value << endl;
		ptr = ptr->next;
	}
}

// �stenilen d���m�n listede olup olmad���n� kontrol eden fonksiyon
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

// Listenin t�m elemanlar�n� silen fonksiyon
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
	myList.addNode("Bilgisayar M�hendisli�i");
	myList.addNode("Yaz�l�m M�hendisli�i");
	myList.addNode("Bilgisayar Programlama");
	myList.addNode("Siber G�venlik");

	myList.deleteNode("Yaz�l�m M�hendisli�i");
	myList.searchList("Siber G�venlik");
	myList.printList();

	return 0;
}
