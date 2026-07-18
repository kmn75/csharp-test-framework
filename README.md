# C# Test Framework для Google.com

Минималистичный фреймворк для автоматизации тестирования веб-приложений на C# + Selenium + NUnit.

## Цели
- Готовый шаблон для быстрого старта в новом проекте.
- Демонстрация архитектуры Page Object Model.

## Технологии
- .NET 8 + C#
- Selenium WebDriver
- NUnit (фреймворк для тестов)
- Newtonsoft.Json (работа с конфигами)
- ScreenRecorderLib (запись видео только для упавших тестов)

## Структура проекта
csharp-test-framework/
├── Core/
│   └── WebDriverFactory.cs        Фабрика WebDriver (один драйвер на все тесты)
├── Utils/
│   ├── ConfigReader.cs            Чтение appsettings.json
│   └── Waiters.cs                 Умные ожидания (вместо Thread.Sleep)
├── Pages/
│   ├── BasePage.cs                Базовый класс (скриншоты, видео при падении)
│   └── GoogleSearchPage.cs        Страница поиска Google
├── Tests/
│   ├── BaseTest.cs                Настройка драйвера и авто-видео при падении
│   └── GoogleSearchTests.cs       Тесты поиска
├── appsettings.json               Конфигурация (URL, браузер, таймауты)
└── README.md

## Для настройки с нуля

1. Создать проект (делал в самом начале, в дальнейшем уже без этого шага):
dotnet new nunit -n MyTestFramework
cd MyTestFramework

2. Установить зависимости (делал в самом начале, в дальнейшем уже без этого шага):
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package Newtonsoft.Json
dotnet add package ScreenRecorderLib

3. Запустить тесты:
dotnet test
