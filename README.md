<h1>Тестовое задание для Mindbox.</h1>

<h2>Content</h2>
<ul>
  <li>GeometryTools.Console - Консольное приложение для демонстрации библиотеки.</li>
  <li>GeometryTools.Contracts - Выделил в отдельную библиотеку интерфейсы, для возможности использовать только их если нет необходимости в основных фигурах, которые поставляются библиотекой.</li>
  <li>GeometryTools.Core - Библиотека с основными фигурами</li>
  <li>GeometryTools.Tests - Проект с юнит тестами</li>
</ul>

<h2>Вторая часть задачи:</h2>

```SQL
SELECT p.ProductName, ISNULL(c.CategoryName, 'No Category') AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
```
