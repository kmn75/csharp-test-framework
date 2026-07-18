C# Test Framework на Selenium + NUnit

Минималистичный тестовый фреймворк для автоматизации тестирования веб-приложений на C# + Selenium + NUnit.

Цель проекта:
- Готовый шаблон для быстрого старта в новом проекте.
- Демонстрация архитектуры Page Object Model.

Технологии:
- .NET 8 + C#
- Selenium WebDriver
- NUnit (фреймворк для тестов)
- Newtonsoft.Json (работа с конфигами)

Структура проекта:

csharp-test-framework/
├── Core/
│   └── WebDriverFactory.cs        # Фабрика WebDriver (один драйвер на все тесты)
├── Utils/
│   ├── ConfigReader.cs            # Чтение appsettings.json
│   └── Waiters.cs                 # Умные ожидания (без Thread.Sleep)
├── Pages/
│   ├── BasePage.cs                # Базовый класс (скриншоты при падении)
│   └── InputsPage.cs              # Страница /inputs (The-Internet)
├── Tests/
│   ├── BaseTest.cs                # Настройка драйвера и скриншоты при падении
│   └── InputsTests.cs             # Тесты для страницы ввода чисел
├── appsettings.json               # Конфигурация (URL, браузер, таймауты)
└── README.md

Запуск тестов:
dotnet test

Настройка с нуля:
# 1. Создать проект
dotnet new nunit -n MyTestFramework
cd MyTestFramework

# 2. Установить зависимости
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package Newtonsoft.Json
