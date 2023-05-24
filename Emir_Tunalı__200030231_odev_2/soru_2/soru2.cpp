#ifndef _CIRCULARSINGLYLINKEDLIST_H
#define _CIRCULARSINGLYLINKEDLIST_H

#include <iostream>
using namespace std;

// D���m yap�s� tan�mlan�r
struct node {
    string value;
    node* next = NULL;
};

class CircularSinglyLinkedList
{
private:
    node* head; // Listenin ba�lang�� d���m� tutulur

public:
    // Constructor tan�mlan�r ve head de�eri NULL olarak atan�r
    CircularSinglyLinkedList();
    // Yeni bir d���m olu�turarak listenin sonuna ekler
    bool addNode(string n);
    // Parametre olarak gelen de�ere sahip olan d���m� listeden siler
    bool deleteNode(string n);
    // Listedeki t�m d���mlerin de�erlerini yazd�r�r
    void printList();
    // Parametre olarak gelen de�ere sahip olan d���m�n varl���n� kontrol eder
    bool searchList(string n);
    // Listedeki t�m d���mleri siler
    void deleteList();
    // Destructor tan�mlan�r, listenin tamam�n�n silinmesi i�in deleteList fonksiyonu �a�r�l�r
    ~CircularSinglyLinkedList()
    {
        deleteList();
    }
};

// Constructor tan�mlan�r, head de�eri NULL olarak atan�r
CircularSinglyLinkedList::CircularSinglyLinkedList()
{
    head = NULL;
}

// Yeni bir d���m olu�turarak listenin sonuna ekler
bool CircularSinglyLinkedList::addNode(string n)
{
    node* kutu = new node;
    kutu->value = n;
    kutu->next = NULL;

    if (head == NULL)
    {
        head = kutu;
        head->next = head;
    }
    else {
        node* ptr = head;
        while (ptr->next != head)
        {
            ptr = ptr->next;
        }
        ptr->next = kutu;
        kutu->next = head;
    }
    return true;
}

// Parametre olarak gelen de�ere sahip olan d���m� listeden siler
bool CircularSinglyLinkedList::deleteNode(string n)
{
    if (head == NULL)
    {
        return false;
    }

    node* current = head;

    // Listenin sadece bir eleman� varsa ve o eleman silinmek istenirse, head de�eri NULL olarak atanarak tek elemanl� listenin silinmesi sa�lan�r.
    if (current->value == n && current->next == head)
    {
        delete current;
        head = NULL;
        return true;
    }

    // E�er silinmek istenen eleman head ise, son d���me kadar gidilerek sonraki d���m head olarak atan�r.
    if (current->value == n)
    {
        while (current->next != head)
        {
            current = current->next;
        }
        current->next = head->next;
        delete head;
        head = current->next;
        return true;
    }

    // D���mler kontrol edilir ve silinmek istenen d���m bulunursa silinir.
    while (current->next != head)
    {
        if (current->next->value == n)
        {
            node* temp = current->next;
            current->next = temp->next;
            cout << "Silinen Node:" << temp->value << endl;
            delete temp;
            return true;
        }
        current = current->next;
    }

    return false;
}

// Listedeki t�m d���mlerin de�erlerini yazd�r�r
void CircularSinglyLinkedList::printList()
{
    if (head == NULL)
    {
        cout << "Liste bos." << endl;
        return;
    }

    node* ptr = head;
    do {
        cout << ptr->value << " ";
        ptr = ptr->next;
    } while (ptr != head);
    cout << endl;
}

// Parametre olarak gelen de�ere sahip olan d���m�n varl���n� kontrol eder
bool CircularSinglyLinkedList::searchList(string n)
{
    if (head == NULL)
    {
        cout << "Liste bos." << endl;
        return false;
    }

    node* ptr = head;
    do {
        if (ptr->value == n)
        {
            cout << "Aradiginiz Deger : " << ptr->value << endl;
            return true;
        }
        ptr = ptr->next;
    } while (ptr != head);

    cout << "Aradiginiz Deger Listede Yok" << endl;
    return false;
}

// Listedeki t�m d���mleri siler
void CircularSinglyLinkedList::deleteList()
{

    if (head == NULL)
    {
        return;
    }

    node* current = head;
    node* next = NULL;

    do {
        next = current->next;
        delete current;
        current = next;
    } while (current != head);

    head = NULL;
}

#endif

int main()
{
    // Test i�in �rnek bir liste olu�turulur ve d���mler eklenir.
    CircularSinglyLinkedList myList;
    myList.addNode("emir");
    myList.addNode("turker");
    myList.addNode("serhat");
    myList.addNode("abdulkadir");

    // �stenen d���m silinir ve yeni listenin hali yazd�r�l�r
    myList.deleteNode("t�rker");
   
    myList.printList();
    myList.searchList("abdulkadir");
   
    return 0;
}

