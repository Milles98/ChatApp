using System.Collections.ObjectModel;
using ChatApp.MVVM.Model;

namespace ChatApp.MVVM.ViewModel;

public class MainViewModel
{
    public ObservableCollection<MessageModel> Messages { get; set; }
    public ObservableCollection<ContactModel> Contacts { get; set; }
    
    // Commands
    
    public ContactModel SelectedContact { get; set; }

    private string _message;

    public string Message
    {
        get => _message;
        set
        {
            _message = value;
        }
    }   
    
    public MainViewModel()
    {
        Messages = new ObservableCollection<MessageModel>();
        Contacts = new ObservableCollection<ContactModel>();
        
        Messages.Add(new MessageModel
        {
            Username = "John Doe", 
            UsernameColor = "#409aff",
            ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
            Message = "Hello, World!",
            Time = DateTime.Today,
            IsNativeOrigin = false,
            FirstMessage = true
        });

        for (int i = 0; i < 3; i++)
        {
            Messages.Add(new MessageModel
            {
                Username = "John Doe", 
                UsernameColor = "#409aff",
                ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
                Message = "Hello, World!",
                Time = DateTime.Today,
                IsNativeOrigin = false,
                FirstMessage = false
            });
        }
        
        for (int i = 0; i < 4; i++)
        {
            Messages.Add(new MessageModel
            {
                Username = "Bunny Doe", 
                UsernameColor = "#409aff",
                ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
                Message = "Hello, World!",
                Time = DateTime.Today,
                IsNativeOrigin = true
            });
        }
        
        Messages.Add(new MessageModel
        {
            Username = "Bunny Doe", 
            UsernameColor = "#409aff",
            ImageSource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
            Message = "Last",
            Time = DateTime.Today,
            IsNativeOrigin = true
        });

        for (int i = 0; i < 5; i++)
        {
            Contacts.Add(new ContactModel
            {
                Username = $"Allison {i}",
                ImageSource = "https://yt3.googleusercontent.com/vw3uP9icAdob-2IT3AW4GKBLbd_aW0MWO2cYIjXUQgWynZEmqNo8Z6HVfK-7UndPt9KwR0WDlA=s900-c-k-c0x00ffffff-no-rj",
                Messages = Messages
            });
        }
    }
}