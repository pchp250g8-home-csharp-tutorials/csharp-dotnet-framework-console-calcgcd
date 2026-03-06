CalcGcd. C# Tutorials. DotNet Framework Platform. Algorithms. Simple Input/Output. Console Application.
A console application in the C# programming language. 
The program does the following:
  1. Prompts the user for two integers whose greatest common divisor needs to be found.
  2. Compares each to zero. If at least one of them is zero, the program displays a message stating that the numbers must not be zero-valued and terminates.
  3. If the numbers are not equal to zero, the two temporary variables are assigned their absolute values.
  4. In a loop with a precondition, the Euclidean algorithm is executed:
    4.1. The numbers are checked to see if they are equal. If so, the loop ends and the program moves to step 5.
    4.2. In the loop, it is determined which number is greater (the conditional branching operator is executed).
    4.3. If the first number is greater than the second, then the second number is subtracted from the first; otherwise, the first number is subtracted from the second.
  5. The entered numbers and their greatest common divisor are displayed on the screen.
Developed in the Microsoft Visual Studio integrated environment.

CalcGcd. Занятия по С#. Платформа DotNet Framework. Алгоритмы. Простой ввод/вывод. Консольное приложение.
Консольное приложение написанное на языке программирования C#. 
Программа делает следующее:
  1. Запрашивает у пользователя два целых числа, наибольший общий делитель которых нужно найти.
  2. Сравнивает каждое с нулём. Если хотя бы одно из них равно нулю, программа выводит сообщение о том, что числа не должны быть рамными нулю и завершает работу.
  3. Если числа не равны нулю, двум временным переменным присваиваются их абсолютные величины (модули).
  4. В цикле с предусловием выполняется алгоритм Евклида:
      4.1. Проверяется равны ли числа между собой. Если да, цикл завершается и программа переходит к пункту 5.
      4.2. В цикле выясняется какое число больше (выполняется условный оператор ветвления).
      4.3. Если первое число больше чем второе, то из первого числа вычитается второе, в противном случае из второго - первое.   
  5. На экран выводятся введённые числа и их наибольший общий делитель.       
Разработано в интегрированной среде Microsoft Visual Studio.
