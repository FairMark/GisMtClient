<img alt="FairMark Client Logo" src="https://raw.githubusercontent.com/FairMark/FairMarkClient/master/FairMark.Docs/FairMarkGlitchyLogo.gif" width="100" />

# FairMark

[![FairMark Client v3.05](https://img.shields.io/badge/честный%20знак-v3.06.1-yellowgreen)](https://честныйзнак.рф/upload/iblock/07f/ru_API_OMS-CLOUD.pdf)
[![.NET Framework 4.62](https://img.shields.io/badge/.net-v4.62-yellow)](https://www.microsoft.com/ru-RU/download/details.aspx?id=53321)
[![FairMarkClient on NuGet.org](https://img.shields.io/nuget/v/FairMarkClient.svg)](https://www.nuget.org/packages/FairMarkClient)
[![FairMarkClient on fuget.org](https://www.fuget.org/packages/FairMarkClient/badge.svg)](https://www.fuget.org/packages/FairMarkClient)

Неофициальная клиентская библиотека .NET для API-сервисов Честного Знака: True API, API СУЗ Облако и API ЭДО Lite.
Список возможностей на текущий момент:

* Авторизация с помощью УКЭП (требуется установленный криптопровайдер КриптоПро)
* Трассировка всех запросов и ответов, проходящих через библиотеку, в текстовом виде
* SUZ Api: Отправка подписанных заказов на эмиссию кодов маркировки в СУЗ Облако
* SUZ Api: Получение получение буферов заказа, блоков, кодов, повторное получение кодов
* SUZ Api: Отправка отчёта о нанесении + получение статуса отчёта
* SUZ Api: Создание аггрегации
* TrueApi: Получение списка товаров + получение подробной информации о товарах
* TrueApi: Создание аггрегаций (через метод единой подачи документов)
* TrueApi: Отправка отчёта о вводе в оборот (через метод единой подачи документов)

[Примеры использования](https://github.com/FairMark/FairMarkClient/wiki/Examples)

## Disclaimer

Работа над библиотекой не завершена. Работоспособность не гарантируется. Используйте на свой страх и риск.

## Contributing

Любые дополнения приветствуются, пулл-реквесты с благодарностью принимаются.
Проще всего помочь с документацией: добавление и редактирование страничек в вики не требует выдачи прав.
Чтобы программисту подключиться к работе над проектом, можно реализовать один из тикетов, помеченных ярлыком
[good-first-issue](https://github.com/FairMark/FairMarkClient/issues?q=is%3Aissue+is%3Aopen+sort%3Aupdated-desc+label%3A%22good+first+issue%22).

## Список реализованных методов

* [СУЗ Облако](FairMark.Docs/oms_methods.txt)
* [True API](FairMark.Docs/true_methods.txt)
* [ЭДО Lite](FairMark.Docs/edo_methods.txt)

## Официальная документация Честного Знака

* [Краткое руководство по работе с API](https://xn--80ajghhoc2aj1c8b.xn--p1ai/upload/Краткое_руководство_по_работе_с_API.pdf)
* [СУЗ Облако. Руководство программиста](https://xn--80ajghhoc2aj1c8b.xn--p1ai/upload/iblock/07f/ru_API_OMS-CLOUD.pdf)
* [True API. Руководство программиста](https://xn--80ajghhoc2aj1c8b.xn--p1ai/upload/TRUE_API.pdf)
* [Описание API ЭДО Lite](https://xn--80ajghhoc2aj1c8b.xn--p1ai/upload/API%20ЭДО%20lite.pdf)

## Прочая документация

* [Форматы документов ЭДО](FairMark.Docs/DocumentFormats.md)

## Участники и спонсоры разработки

| [![image](https://user-images.githubusercontent.com/672878/119223004-cb968c00-baff-11eb-9758-338f7763d5f3.png)](https://www.met.ru/) | [![image](https://user-images.githubusercontent.com/672878/119222534-8bcea500-bafd-11eb-875a-b6268998e93d.png)](http://k-solutions.ru/) | [![image](https://user-images.githubusercontent.com/672878/119222970-9722d000-baff-11eb-9cfb-ce003e44e963.png)](https://diasparbusiness.com/) |
| ------------- | ------------- | ------------- |

### Информационный партнёр проекта 

Ассоциация Альянс Форта (telegram-канал: @markirovka_solutions)

[![image](https://user-images.githubusercontent.com/79666979/120494970-f10b7b80-c3c4-11eb-941e-9ab810583d7d.png)](https://fourta.org/)

