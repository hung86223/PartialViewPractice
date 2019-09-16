using System;
using System.Collections.Generic;
using PartialViewPractice.Models;

namespace PartialViewPractice.Service
{
    public class DataService
    {
        private readonly Random _random = new Random();
        private Random RandomGenerator()
        {
            return _random;
        }

        public List<MoneyListViewModel> GetRandomMoneyListData()
        {
            var moneyListViewModels = new List<MoneyListViewModel>();

            for (int i = 0; i < 50; i++)
            {
                var moneyListViewModel = new MoneyListViewModel
                {
                    Id = i + 1, Type = "支出",
                    Cost = RandomCost(),
                    Date = RandomDate(),
                };

                moneyListViewModels.Add(moneyListViewModel);
            }
            return moneyListViewModels;
        }

        private DateTime RandomDate()
        {
            var start = new DateTime(2019,1,1);
            var end = new DateTime(2019,12,31);

            var range = (end - start).Days;
            var randomDate = start.AddDays(RandomGenerator().Next(range));

            return randomDate;
        }

        private int RandomCost()
        {
            return RandomGenerator().Next(0, 5000);
        }
    }
}