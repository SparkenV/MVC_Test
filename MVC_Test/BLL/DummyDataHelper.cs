using BLL.Models;
using System;

namespace BLL
{
    public static class DummyDataHelper
    {
        public static List<SelectableItem> GetSelectableItems(int count)
        {
            var items = new List<SelectableItem>();

            for (int i = 0; i < count; i++)
            {
                items.Add(GetSelectableItem(i));
            }

            return items;
        }

        public static SelectableItem GetSelectableItem(int index = 0)
        {
            return new SelectableItem()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Faker.Name.FullName(),
                Description = Faker.Lorem.Sentence(),
                Type = Faker.Lorem.GetFirstWord(),
                Selected = false // new Random().Next(2) == 1
            };
        }
    }
}