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
                items.Add(GetSelectableItem());
            }

            return items;
        }

        public static SelectableItem GetSelectableItem()
        {
            return new SelectableItem()
            {
                IsSelected = true,
                ItemData = new Message {
                    Id = Guid.NewGuid().ToString(),
                    Name = Faker.Name.FullName(),
                    Description = Faker.Lorem.Sentence(),
                    Type = Faker.Lorem.GetFirstWord()
                }
            };
        }
    }
}