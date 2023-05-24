#ifndef CIRCULARDOUBLYLINKEDLIST_H
#define CIRCULARDOUBLYLINKEDLIST_H
#include <iostream>
using namespace std;

// d���m yap�s� tan�m�
struct node {
    string info;
    node* prev = NULL;
    node* next = NULL;
};

// �ift y�nl� dairesel ba�l� liste s�n�f� tan�m�
class circularDoublyLinkedList {
private:
    node* head;

public:
    // yap�c� fonksiyon
    circularDoublyLinkedList();

    // d���m ekleme fonksiyonu
    bool addNode(string n);

    // d���m silme fonksiyonu
    bool deleteNode(string n);

    // listede arama yapma fonksiyonu
    bool searchList(string n);

    // listeyi ekrana yazd�rma fonksiyonu
    void printList();

    // listedeki t�m d���mleri silme fonksiyonu
    void deleteList();

    // y�k�c� fonksiyon
    ~circularDoublyLinkedList()
    {
        deleteList();
    }
};

// yap�c� fonksiyonun tan�m�
circularDoublyLinkedList::circularDoublyLinkedList() {
    head = NULL;
}

// d���m ekleme fonksiyonunun tan�m�
bool circularDoublyLinkedList::addNode(string n) {
    // yeni bir d���m olu�turulur ve de�er atan�r
    node* newNode = new node;
    newNode->info = n;
    newNode->prev = NULL;
    newNode->next = NULL;

    // liste bo�sa, yeni d���m listenin tek d���m� olur
    if (head == NULL)
    {
        head = newNode;
        newNode->prev = head;
        newNode->next = head;
    }
    else {
        // liste doluysa, son d���m�n next'i yeni d���m yap�l�r ve head ile ba�lant�lar g�ncellenir
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

// listede arama yapma fonksiyonunun tan�m�
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

// d���m silme fonksiyonunun tan�m�
bool circularDoublyLinkedList::deleteNode(string n) {
    if (head == NULL) {
        return false;
    }

    // silinecek d���m bulunana kadar liste gezilir
    node* ptr = head;
    while (ptr->info != n && ptr->next != head) {
        ptr = ptr->next;
    }

    // e�er silinecek d���m bulunamazsa hata mesaj� verilir
    if (ptr->info != n) {
        cout << "Silinecek Node Bulunamadi" << endl;
        return false;
    }

    // silinecek d���m�n ba�lant�lar� kopar�l�r
    ptr->prev->next = ptr->next;
    ptr->next->prev = ptr->prev;

    // e�er silinecek d���m listenin ba��ndaysa, head g�ncellenir
    if (ptr == head) {
        head = ptr->next;
    }

    cout << "Sildiginiz Node: " << ptr->info << endl;
    delete ptr; // d���m bellekten silinir
    return true;
}

// listeyi ekrana yazd�rma fonksiyonunun tan�m�
void circularDoublyLinkedList::printList() {
    if (head == NULL) {
        cout << "Liste BO�" << endl;
        return;
    }

    node* ptr = head;
    do {
        cout << ptr->info << endl;
        ptr = ptr->next;
    } while (ptr != head);
}

// listedeki t�m d���mleri silme fonksiyonunun tan�m�
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
    // yeni bir �ift y�nl� dairesel ba�l� liste nesnesi olu�turulur
    circularDoublyLinkedList myList;

    // listenin i�ine 4 eleman eklenir: Istanbul, Trabzon, Ankara, Mugla
    myList.addNode("Istanbul");
    myList.addNode("Trabzon");
    myList.addNode("Ankara");
    myList.addNode("Mugla");

    // "Trabzon" eleman� listeden silinir
    myList.deleteNode("Trabzon");

    // "Mugla" eleman� aran�r ve bulundu�unda ekrana yazd�r�l�r
    myList.searchList("Mu�la");

    // listenin t�m elemanlar� ekrana yazd�r�l�r
    myList.printList();

    return 0;
}