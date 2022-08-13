public class Hanoi {

    /**
           * Количество ходов
     */
    static int m = 0;

    public static void Main() {
        int n = 3;
        char a = 'A';
        char b = 'B';
        char c = 'C';
        
        hanoi(n, a, b, c);
        
       System.Console.WriteLine("Переместите все диски от А до С, всего "+ m + " Время.");
    }

    /**
           * Ханойская башня
     *
           * @ param n количество тарелок
           * @ парам столбца А
           * @парам б столб B
           * @param c   C
     */
    public static void hanoi(int n, char a, char b, char c) {
        if (n == 1) {
            move(1, a, c);
        } else {
            // Рекурсивно расположите слой n-1 над стойкой A от A, через C, до B
            hanoi(n - 1, a, c, b);
            move(n, a, c);
            // Рекурсивно нанести слой n-1 на столб B из B, через A, в C
            hanoi(n - 1, b, a, c);
        }
    }

    /**
           * Шаг
     *
           * @param n количество дисков
           * @ param I позиция перед переездом
           * @парам j позиция после перемещения
     */
    public static void move(int n, char i, char j) {
        m++;
        System.Console.WriteLine(" " + m + " Время:" + n + " Номер диска:" + i + " -> " + j);
    }
}