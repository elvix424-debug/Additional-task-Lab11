int[] list = { 1, 6, 3, 8, 9, 12, 64, 85, 234 };
int target = 12;
bool flag = false;

for(int i = 0; i < list.Length && !flag; i++)
{
    for(int j = i + 1; j < list.Length; j++)
    {
        if (list[i] + list[j] == target)
        {
            Console.WriteLine($"Индексы пары: {i} и {j}");
            flag = true;
            break;
        }
    }
}

if (!flag)
{
    Console.WriteLine("Не найдено");
}