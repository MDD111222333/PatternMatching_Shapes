# C_Sharp_PatternMatching_Shapes

## C#_PatternMatching_Shapes

### Задание «Контрольная точка №15 — паттерн-матчинг»

Вариант 1. Классификация фигур
1. Используйте классы Circle { double Radius }, Rectangle { double Width, double Height }.
2. Метод string Classify(object shape), возвращающий строку через switch-выражение.
3. Свойственный паттерн: Circle { Radius: 0 } → "точка".
4. Паттерн отношения внутри свойственного: Circle { Radius: > 100 } → "огромный круг".
5. when-условие: для Rectangle с Width == Height → "квадрат".
6. Завершающая ветка _ для всех остальных случаев.

Результаты и проверочные ключи:
<img width="1703" height="393" alt="изображение" src="https://github.com/user-attachments/assets/388ce34b-c8c9-4305-a2dc-fa57188b0ca9" />


Результат работы:

<img width="1211" height="542" alt="изображение" src="https://github.com/user-attachments/assets/418ab472-9fe7-41ca-b68a-a651371b8ce7" />


