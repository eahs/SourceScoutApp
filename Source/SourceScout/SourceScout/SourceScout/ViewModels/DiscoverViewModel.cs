using SourceScout.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace SourceScout.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }

        public DiscoverViewModel ()
        {
            Posts = new ObservableRangeCollection<Post>();
            LoadItemsCommand.Execute(null);
        }

        protected override async Task LoadItemsAsync()
        {
            // Basic pattern
            try
            {
                bool success = false;

                // Make async request to obtain data
                success = true;

                await Task.Delay(2500);  // Simulate loading delay 

                Posts.Add(new Post
                {
                    Title = "Hello there"
                });
                Posts.Add(new Post
                {
                    Title = "I have the high ground"
                });

                if (success)
                {
                    IsError = false;
                    DataAvailable = true;
                }
                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }
            }
            catch (Exception e)
            {
                // An exception occurred
                DataAvailable = false;
            }
        }
    }
}
