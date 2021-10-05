﻿#include <iostream>
using namespace std;
int N; //инициализируем массив
class queue { //создаем класс “Очередь”
private: //эти члены класса будут закрытыми
    int* arr; //сделаем указатель на массив
    int head; //переменная для начала очереди(головы)
    int tail; //переменная для конца очереди(хвоста)
public: //эти члены класса будут открытыми

    queue(int m)
    {
        head = 0;
        tail = 0;
        arr = new int[m];
    }
    ~queue() //деструктор для освобождения памяти
    {
        delete[] arr;
    }
    void add_item(int a) //функция добавления элемента
    {
        if (head == (tail + 1) % N) //проверяем наличие места в очереди
            cout << "Очередь переполнена!!!" << endl;
        else
        {
            arr[tail] = a; //записываем значение в массив
            tail = (tail + 1) % N; //присваиваем нашему “хвосту” номер последнего эл - та
        }
    }
    void extract_item() //функция извлечения элемента
    {
        if (head != tail) //проверяем наличие элементов в очереди
        {
            cout << arr[head]; //выводим на экран последний в очереди элемент
            head = (head + 1) % N; //присваиваем нашей “голове” номер следующего эл - та
        }
        else
            cout << "Очередь пуста!!!";
    }
};
int main()
{
    setlocale(LC_ALL, "Russian");
    int znach;
    bool r; //укажем логический тип данных для проверки логических условий
    cout << "Сколько будет элементов в очереди: ";
    cin >> N;
    queue one(N);
    do {
        cout << "Для добавление введите 1, для извлечения 0: ";
        cin >> r;
        if (r)
        {
            cout << "Введите значение: ";
            cin >> znach;
            one.add_item(znach);
        }
        else
        {
            cout << "Значение равно: ";
            one.extract_item();
            cout << endl;
        }
    } while (true);
    return 0;
}
