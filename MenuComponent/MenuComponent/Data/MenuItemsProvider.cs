using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuComponent.Data
{
    public class MenuItemsProvider
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<MenuItem>> GetItemsAsync()
        {
            return Task.FromResult(new List<MenuItem>()
            {
                new MenuItem
                {
                    Key = "1",
                    Value = "1",
                    Children =  new List<MenuItem>()
                    {
                        new MenuItem
                        {
                            Key = "1.1",
                            Value = "Item1.1",
                            Children =  new List<MenuItem>()
                            {
                                new MenuItem { Key = "1.1.1", Value = "Item1.1.1"},
                                new MenuItem { Key = "1.1.2", Value = "Item1.1.2"},
                                new MenuItem { Key = "1.1.3", Value = "Item1.1.3"},
                            }
                        },
                        new MenuItem { Key = "1.2", Value = "Item1.2"},
                        new MenuItem { Key = "1.3", Value = "Item1.3"},
                    }
                },
                new MenuItem
                {
                    Key = "2",
                    Value = "2",
                    Children =  new List<MenuItem>()
                    {
                        new MenuItem { Key = "2.1", Value = "Item2.1"},
                        new MenuItem { Key = "2.2", Value = "Item2.2"},
                        new MenuItem { Key = "2.3", Value = "Item2.3"},
                    }
                },
                new MenuItem
                {
                    Key = "3",
                    Value = "3"
                }
            });

            //var items = new List<MenuItem<MenuItem<string>>
        }

    }
}
