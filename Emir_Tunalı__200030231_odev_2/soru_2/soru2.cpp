#ifndef _CIRCULARSINGLYLINKEDLIST_H
#define _CIRCULARSINGLYLINKEDLIST_H

#include <iostream>
using namespace std;

// Düðüm yapýsý tanýmlanýr
struct node {
    string value;
    node* next = NULL;
};

class CircularSinglyLinkedList
{
private:
    node* head; // Listenin baþlangýç düðümü tutulur

public:
    // Constructor tanýmlanýr ve head deðeri NULL olarak atanýr
    CircularSinglyLinkedList();
    // Yeni bir düðüm oluþturarak listenin sonuna ekler
    bool addNode(string n);
    // Parametre olarak gelen deðere sahip olan düðümü listeden siler
    bool deleteNode(string n);
    // Listedeki tüm düðümlerin deðerlerini yazdýrýr
    void printList();
    // Parametre olarak gelen deðere sahip olan düðümün varlýðýný kontrol eder
    bool searchList(string n);
    // Listedeki tüm düðümleri siler
    void deleteList();
    // Destructor tanýmlanýr, listenin tamamýnýn silinmesi için deleteList fonksiyonu çaðrýlýr
    ~CircularSinglyLinkedList()
    {
        deleteList();
    }
};

// Constructor tanýmlanýr, head deðeri NULL olarak atanýr
CircularSinglyLinkedList::CircularSinglyLinkedList()
{
    head = NULL;
}

// Yeni bir düðüm oluþturarak listenin sonuna ekler
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

// Parametre olarak gelen deðere sahip olan düðümü listeden siler
bool CircularSinglyLinkedList::deleteNode(string n)
{
    if (head == NULL)
    {
        return false;
    }

    node* current = head;

    // Listenin sadece bir elemaný varsa ve o eleman silinmek istenirse, head deðeri NULL olarak atanarak tek elemanlý listenin silinmesi saðlanýr.
    if (current->value == n && current->next == head)
    {
        delete current;
        head = NULL;
        return true;
    }

    // Eðer silinmek istenen eleman head ise, son düðüme kadar gidilerek sonraki düðüm head olarak atanýr.
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

    // Düðümler kontrol edilir ve silinmek istenen düðüm bulunursa silinir.
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

// Listedeki tüm düðümlerin deðerlerini yazdýrýr
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

// Parametre olarak gelen deðere sahip olan düðümün varlýðýný kontrol eder
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

// Listedeki tüm düðümleri siler
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
    // Test için örnek bir liste oluþturulur ve düðümler eklenir.
    CircularSinglyLinkedList myList;
    myList.addNode("emir");
    myList.addNode("turker");
    myList.addNode("serhat");
    myList.addNode("abdulkadir");

    // Ýstenen düðüm silinir ve yeni listenin hali yazdýrýlýr
    myList.deleteNode("türker");
   
    myList.printList();
    myList.searchList("abdulkadir");
   
    return 0;
}

