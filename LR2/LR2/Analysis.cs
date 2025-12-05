using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Analysis
    {
        static public void SortGames(List<string> games, List<int> counts) // сортировка игр по количеству скачиваний
        {
            // Используем Linq для сортировки списков по количеству скачиваний
            var sortedList = games.Select((game, index) => new { Game = game, Count = counts[index] })
                                  .OrderByDescending(x => x.Count)
                                  .ToList();

            // Обновляем исходные списки
            games.Clear();
            counts.Clear();
            foreach (var item in sortedList)
            {
                games.Add(item.Game);
                counts.Add(item.Count);
            }
        }

        static public double CalculateAverage(List<int> counts) // расчет среднего количества скачиваний
        {
            if (counts == null || counts.Count == 0)
                return 0;

            return counts.Average();
        }
    }
}