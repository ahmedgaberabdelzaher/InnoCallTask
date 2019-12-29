using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Task.Models;
using Xamarin.Essentials;

namespace Task.ViewModels
{
    class HomeViewModel:BindableBase
    {
        string _StatusText;
        public string StatusText { get { return _StatusText; } set { _StatusText = value; RaisePropertyChanged(); } }   
        
        bool _IsMessageVisible;
        public bool IsMessageVisible { get { return _IsMessageVisible;} set { _IsMessageVisible = value; RaisePropertyChanged(); } }     
        
        CallHistoryModel _CallSelected { get; set; }
        public CallHistoryModel CallSelected { get { return _CallSelected; } set { _CallSelected = value; RaisePropertyChanged(); } }
        public  DelegateCommand LogoutCommand { get; set; }
        public  DelegateCommand CallCommand { get; set; }
        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand OnlineOfLineCommand { get; set; }
        public DelegateCommand CallSelectionCommand { get; set; }

        IPageDialogService _pageDialogService;
        INavigationService _navigationService;

        ObservableCollection<CallHistoryModel> _CallHistoryList { get; set; }
        public ObservableCollection<CallHistoryModel> CallHistoryList { get { return _CallHistoryList; } set { _CallHistoryList = value; RaisePropertyChanged(); } }
        public HomeViewModel(IPageDialogService pageDialogService,INavigationService navigationService)
        {
            StatusText = "OnLine";
            _pageDialogService = pageDialogService;
            _navigationService = navigationService;
            LogoutCommand = new DelegateCommand(Logout);
            OnlineOfLineCommand = new DelegateCommand(OnlineOfLine);
            OkCommand = new DelegateCommand(Ok);
            CallCommand = new DelegateCommand(Call);
            CallSelectionCommand = new DelegateCommand(CallSelection);
            GetCallHistory();
        }

        private void CallSelection()
        {
            if (CallSelected!=null)
            {
            var old =  CallHistoryList.Where(c => c.IsCall).First();
            old.IsCall = false;
            CallSelected.IsCall = true;
            CallSelected = null;
            }


        }

        private void Call()
        {
            PhoneDialer.Open("78945632150");
        }

        private void GetCallHistory()
        {
            CallHistoryList = new ObservableCollection<CallHistoryModel>() { 
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="MissedCallImage",IsCall=true},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="OutCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="RecivedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="MissedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="OutCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="RecivedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="MissedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="OutCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="RecivedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="MissedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="OutCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="RecivedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="MissedCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="OutCallImage"},
            new CallHistoryModel(){PhoneNumber="5549812316+4",image="RecivedCallImage"}
            };

        }

        private void Ok()
        {
            IsMessageVisible = false;
        }
        
        private void OnlineOfLine()
        {
            IsMessageVisible = true;
            if (StatusText == "OnLine")
            {
                StatusText = "OffLine";

            }
            else
            {
                StatusText = "OnLine";
            }
            
        }

        private void Logout()
        {
            _navigationService.GoBackAsync();
        }
    }
}
