using BLL.Models;
using BLL.Models.Selectable;
using System;

namespace BLL
{
    public static class DummyDataHelper
    {
        public static List<SelectableItemViewModel<object>> GetSelectableItems(int count)
        {
            var items = new List<SelectableItemViewModel<object>>();

            for (int i = 0; i < count; i++)
            {
                items.Add(GetSelectableItem());
            }

            return items;
        }

        public static SelectableItemViewModel<object> GetSelectableItem()
        {
            return new SelectableItemViewModel<object>()
            {
                IsSelected = true,
                ItemType = typeof(Message),
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