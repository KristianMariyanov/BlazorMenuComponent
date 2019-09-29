using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuComponent.Data
{
    public class MenuItemsProvider
    {
        public Task<List<MenuItem>> GetItemsAsync()
        {
            return Task.FromResult(new List<MenuItem>()
            {
                new MenuItem
                {
                    Key = "1",
                    Value = "Item 1",
                    Children =  new List<MenuItem>()
                    {
                        new MenuItem
                        {
                            Key = "1.1",
                            Value = "Item 1.1",
                            Children =  new List<MenuItem>()
                            {
                                new MenuItem { Key = "1.1.1", Value = "Item 1.1.1"},
                                new MenuItem { Key = "1.1.2", Value = "Item 1.1.2"},
                                new MenuItem { Key = "1.1.3", Value = "Item 1.1.3"},
                            }
                        },
                        new MenuItem {
                            Key = "1.2",
                            Value = "Item 1.2",
                            Children =  new List<MenuItem>()
                            {
                                new MenuItem {
                                    Key = "1.2.1",
                                    Value = "Item 1.2.1",
                                    Children =  new List<MenuItem>()
                                    {
                                        new MenuItem { Key = "1.2.1.1", Value = "Item 1.2.1.1"},
                                        new MenuItem { Key = "1.2.1.2", Value = "Item 1.2.1.2"},
                                        new MenuItem { Key = "1.2.1.3", Value = "Item 1.2.1.3"},
                                    }
                                },
                                new MenuItem { Key = "1.2.2", Value = "Item 1.2.2"},
                                new MenuItem { Key = "1.2.3", Value = "Item 1.2.3"},
                            }},
                        new MenuItem { Key = "1.3", Value = "Item 1.3"},
                    }
                },
                new MenuItem
                {
                    Key = "2",
                    Value = "Item 2",
                    Children =  new List<MenuItem>()
                    {
                        new MenuItem { Key = "2.1", Value = "Item 2.1"},
                        new MenuItem { Key = "2.2", Value = "Item 2.2"},
                        new MenuItem { Key = "2.3", Value = "Item 2.3"},
                    }
                },
                new MenuItem
                {
                    Key = "3",
                    Value = "Item 3"
                }
            });
        }

    }
}
