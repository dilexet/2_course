package com.senla.grsu.pm;

public class Main {
    public static void main(String[] args) {

        Ship ship = new Ship();

        Container container1 = new Container(ContainerSize.Big);
        Container container2 = new Container(ContainerSize.Small);
        Container container3 = new Container(ContainerSize.Big);
        Container container4 = new Container(ContainerSize.Small);

        container1.AddWater(600);
        container2.AddWater(200);
        container3.AddWater(600);

        container4.AddWater(200);



        ship.AddContainer(container1);
        ship.AddContainer(container2);
        ship.AddContainer(container3);

        ship.AddContainer(container4);

        var litersWater = ship.UnloadShip();
    }
    /*
    Есть порт для хранения воды. Порт может принять 10 кораблей.
    Корабли состоят из двух палуб.
    Каждая палуба может содержать либо большой контейнер, либо 2 маленьких. Итого корабль может перевозить:
    1 или 2 больших контейнера
    от 1 до 4 маленьких контейнера
    1 большой и 1 или 2 маленьких контейнера
    Корабль может быть загружен не полностью.

    В контейнер помещается:
    В большой 1000 литров воды
    В маленький 450 литров воды

    Корабли по прибытию в порт сразу выгружают воду в порт.

    Создать консольное приложение для создания и наполнения кораблей контейнерами с водой и загрузки кораблей в порт.
    Меню приложения должно позволять:

    1. Посмотреть сколько воды в порту
    2. Посмотреть список кораблей в порту
    3. Удалить корабль из порта (вода остаётся в порту)
    4. Создать корабль -> наполнить корабль контейнерами с водой
    5. Посмотреть список кораблей, ожидающих прибытия в порт -> посмотреть инормацию по конкретному кораблю
    6. Загрузить корабль в порт
    7. Выйти из программы

    Задание можно выполнять в группах до 3х человек, можно индивидуально.
    -> обозначает подменю
    */
}