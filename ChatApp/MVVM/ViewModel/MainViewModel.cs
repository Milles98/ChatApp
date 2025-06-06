﻿using System.Collections.ObjectModel;
using ChatApp.Core;
using ChatApp.MVVM.Model;

namespace ChatApp.MVVM.ViewModel;

public class MainViewModel : ObservableObject
{
    public ObservableCollection<MessageModel> Messages { get; set; }
    public ObservableCollection<ContactModel> Contacts { get; set; }
    
    /*
     * This a great simple styling tut for me.
     * Using the MVVM Community Toolkit package from Microsoft eliminates the Core folder.
     * It saves so much time inheriting the ObservableObject class and using the source
     * generated attributes [ObservableProperty] and [RelayCommand].
     */

    // Commands
    public RelayCommand SendCommand { get; set; }

    private ContactModel _selectedContact;

    public ContactModel SelectedContact
    {
        get => _selectedContact;
        set
        {
            _selectedContact = value;
            OnPropertyChanged();
        }
    }

    private string _message;

    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        Messages = new ObservableCollection<MessageModel>();
        Contacts = new ObservableCollection<ContactModel>();

        SendCommand = new RelayCommand(o =>
        {
            Messages.Add(new MessageModel
            {
                Message = Message,
                FirstMessage = false
            });
            Message = "";
        });


        Messages.Add(new MessageModel
        {
            Username = "John Doe",
            UsernameColor = "#409aff",
            ImageSource =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
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
                ImageSource =
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
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
                ImageSource =
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
                Message = "Hello, World!",
                Time = DateTime.Today,
                IsNativeOrigin = true
            });
        }

        Messages.Add(new MessageModel
        {
            Username = "Bunny Doe",
            UsernameColor = "#409aff",
            ImageSource =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnzc4pyjJSRrR9s3boT_97OC7t2ItfdFGd2A&s",
            Message = "Last",
            Time = DateTime.Today,
            IsNativeOrigin = true
        });

        for (int i = 0; i < 5; i++)
        {
            Contacts.Add(new ContactModel
            {
                Username = $"Allison {i}",
                ImageSource =
                    "https://yt3.googleusercontent.com/vw3uP9icAdob-2IT3AW4GKBLbd_aW0MWO2cYIjXUQgWynZEmqNo8Z6HVfK-7UndPt9KwR0WDlA=s900-c-k-c0x00ffffff-no-rj",
                Messages = Messages
            });
        }
    }
}