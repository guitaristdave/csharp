// В интервале [0, 2 c] с шагом 0.1с вычисляются координаты y = V0 t – g t^2 / 2
// и скорости V = V0 – g t мячика, брошеного вертикально вверх с начальной
// скоростью V0 (V0 вводится с клавиатуры, цикл for).

Console.Write("Введите v0: ");
double v0 = Convert.ToDouble(Console.ReadLine());
double g = 9.8;


for (double i = 0; Math.Round(i, 1) <= 2; i += 0.1)
{
    Console.WriteLine($"Координаты мячика при t = {Math.Round(i, 1)}: {Math.Round((v0 * i - g * i * i / 2), 2)}");
}