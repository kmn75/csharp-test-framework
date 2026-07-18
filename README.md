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
Core/WebDriverFactory.cs - Фабрика WebDriver
Utils/ConfigReader.cs - Чтение appsettings.json
Utils/Waiters.cs - Умные ожидания
Pages/BasePage.cs - Базовый класс (скриншоты)
Pages/InputsPage.cs - Страница /inputs
Tests/BaseTest.cs - Настройка драйвера
Tests/InputsTests.cs - Тесты для страницы ввода чисел
appsettings.json - Конфигурация
README.md

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
