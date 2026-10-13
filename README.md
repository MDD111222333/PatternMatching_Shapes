# C_Sharp_PatternMatching_Records

## C#_PatternMatching_Records

### Задание «Геометрические фигуры через записи»

Вариант 1. Геометрические фигуры через записи
1. public record Point(double X, double Y);
2. public record Circle(Point Center, double Radius);
3. public record Rectangle(Point TopLeft, Point BottomRight);
4. Метод string Classify(object shape) через switch-выражение:
   - Circle { Center: { X: 0, Y: 0 } } → "окружность в начале координат".
   - Circle { Radius: 0 } → "вырожденная окружность (точка)".
   - Circle c → строка с радиусом.
   - Rectangle r when r.TopLeft == r.BottomRight → "вырожденный прямоугольник (точка)".
   - Rectangle r → строка с размерами.
   - _ → "неизвестная фигура".


Результаты и проверочные ключи:
<img width="1703" height="393" alt="изображение" src="https://github.com/user-attachments/assets/388ce34b-c8c9-4305-a2dc-fa57188b0ca9" />


Результат работы:

<img width="1211" height="542" alt="изображение" src="https://github.com/user-attachments/assets/418ab472-9fe7-41ca-b68a-a651371b8ce7" />


