# TadosTest

#### Описание
Приложение состоит из трёх проектов: сервер, клиент и описание WCF сервиса.
Сервер - self-hosted WCF service, SQL DataBase + SQL Command
Сервер выступает в качестве брокера: 
	- с одной стороны клиент и его запросы;
	- с другой источник данных (БД).

Клиент - WinForms, MVP.

![image](/Pictures/MainForm.png)

#### Задуманная идея

![image](/Pictures/IdealStructure.png)

Запрос в начальной идее

![image](/Pictures/IdealRequest.png)


#### Текущее решение

![image](/Pictures/CurrentStructure.png)

Путь запроса

![image](/Pictures/CurrentRequest.png)

#### Недостатки текущего решения

- Нет пересылки ошибок от сервера клиенту. Нет обработки ошибок. 
- Весь функционал на одной форме (View).
- Избыточный функционал обработки сервиса не сервере. Сервер значет, что источник данных - БД, коннектор к БД знает о выдаваемом типе.
- Сильная связанность Presenter и ClientProxy.
- Не написаны тесты.
- Клиент не запустится, если нет соединения с сервером.
