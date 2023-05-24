#ifndef CIRCULARDOUBLYLINKEDLIST_H
#define CIRCULARDOUBLYLINKEDLIST_H
#include <iostream>
using namespace std;

// düðüm yapýsý tanýmý
struct node {
    string info;
    node* prev = NULL;
    node* next = NULL;
};

// çift yönlü dairesel baðlý liste sýnýfý tanýmý
class circularDoublyLinkedList {
private:
    node* head;

public:
    // yapýcý fonksiyon
    circularDoublyLinkedList();

    // düðüm ekleme fonksiyonu
    bool addNode(string n);

    // düðüm silme fonksiyonu
    bool deleteNode(string n);

    // listede arama yapma fonksiyonu
    bool searchList(string n);

    // listeyi ekrana yazdýrma fonksiyonu
    void printList();

    // listedeki tüm düðümleri silme fonksiyonu
    void deleteList();

    // yýkýcý fonksiyon
    ~circularDoublyLinkedList()
    {
        deleteList();
    }
};

// yapýcý fonksiyonun tanýmý
circularDoublyLinkedList::circularDoublyLinkedList() {
    head = NULL;
}

// düðüm ekleme fonksiyonunun tanýmý
bool circularDoublyLinkedList::addNode(string n) {
    // yeni bir düðüm oluþturulur ve deðer atanýr
    node* newNode = new node;
    newNode->info = n;
    newNode->prev = NULL;
    newNode->next = NULL;

    // liste boþsa, yeni düðüm listenin tek düðümü olur
    if (head == NULL)
    {
        head = newNode;
        newNode->prev = head;
        newNode->next = head;
    }
    else {
        // liste doluysa, son düðümün next'i yeni düðüm yapýlýr ve head ile baðlantýlar güncellenir
        node* ptr = head;
        while (ptr->next != head)
        {
            ptr = ptr->next;
        }
        newNode->prev = ptr->prev;
        newNode->next = head;
        ptr->next = newNode;
        head->prev = newNode;
    }
    return true;
}

// listede arama yapma fonksiyonunun tanýmý
bool circularDoublyLinkedList::searchList(string n)
{
    node* ptr = head;
    while (ptr->info != n)
    {
        ptr = ptr->next;
    }

    cout << "Aradiginiz Node :" << ptr->info << endl;
    return true;
}

// düðüm silme fonksiyonunun tanýmý
bool circularDoublyLinkedList::deleteNode(string n) {
    if (head == NULL) {
        return false;
    }

    // silinecek düðüm bulunana kadar liste gezilir
    node* ptr = head;
    while (ptr->info != n && ptr->next != head) {
        ptr = ptr->next;
    }

    // eðer silinecek düðüm bulunamazsa hata mesajý verilir
    if (ptr->info != n) {
        cout << "Silinecek Node Bulunamadi" << endl;
        return false;
    }

    // silinecek düðümün baðlantýlarý koparýlýr
    ptr->prev->next = ptr->next;
    ptr->next->prev = ptr->prev;

    // eðer silinecek düðüm listenin baþýndaysa, head güncellenir
    if (ptr == head) {
        head = ptr->next;
    }

    cout << "Sildiginiz Node: " << ptr->info << endl;
    delete ptr; // düðüm bellekten silinir
    return true;
}

// listeyi ekrana yazdýrma fonksiyonunun tanýmý
void circularDoublyLinkedList::printList() {
    if (head == NULL) {
        cout << "Liste BOÞ" << endl;
        return;
    }

    node* ptr = head;
    do {
        cout << ptr->info << endl;
        ptr = ptr->next;
    } while (ptr != head);
}

// listedeki tüm düðümleri silme fonksiyonunun tanýmý
void circularDoublyLinkedList::deleteList() {
    if (head == NULL)
        return;

    node* current = head;
    while (current->next != head) {
        node* temp = current;
        current = current->next;
        delete temp;
    }
    delete current;
    head = NULL;
    cout << "Butun Liste Silindi!" << endl;
}
#endif;
int main() {
    // yeni bir çift yönlü dairesel baðlý liste nesnesi oluþturulur
    circularDoublyLinkedList myList;

    // listenin içine 4 eleman eklenir: Istanbul, Trabzon, Ankara, Mugla
    myList.addNode("Istanbul");
    myList.addNode("Trabzon");
    myList.addNode("Ankara");
    myList.addNode("Mugla");

    // "Trabzon" elemaný listeden silinir
    myList.deleteNode("Trabzon");

    // "Mugla" elemaný aranýr ve bulunduðunda ekrana yazdýrýlýr
    myList.searchList("Muðla");

    // listenin tüm elemanlarý ekrana yazdýrýlýr
    myList.printList();

    return 0;
}