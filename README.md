Задача - написать клиент-серверное приложение-конструктор для создания юнитов и, впоследствии, армий для настольных варгеймов.

на данный момент реализовано:

- Возможность создания/редактирования/просмотра/удаления пользователем элементов базы данных.
С точки зрени UI наиболее полно проработана категория "Типы рекрутов"

- Расчет стоимостей элементов снаряжения и юнитов 
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Models/Unit.cs
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Models/PricesCalc.cs
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Models/RecrutType.cs

- Сортировка элементов снаряжения и юнитов по нескольким параметрам
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Controllers/UnitsController.cs

- Динамический расчет цен и валидация параметров снаряжения и юнитов на стороне клиента
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Scripts/recruttypepricecalculator.js
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Scripts/shieldpricecalculator.js

- Поиск элементов снаряжения и юнитов в базе
https://github.com/1OldPony/Army-Constractor/blob/ArmyConstractor.005/Army%20Constractor/Controllers/ArmyConstractorController.cs

Файлы базы данных лежат в корне ветви, в папке App_Data
https://github.com/1OldPony/Army-Constractor/tree/ArmyConstractor.005/App_Data
Ее необходимо вручную переместить в корневой каталог приложения
https://github.com/1OldPony/Army-Constractor/tree/ArmyConstractor.005/Army%20Constractor
