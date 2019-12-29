using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class CallHistoryModel:BindableBase
    {
        public string PhoneNumber { get; set; }
        public string image { get; set; }
        public DateTime date { get { return DateTime.Now; } }
        bool _IsCall;
        public bool IsCall { get { return _IsCall; } set { _IsCall = value; RaisePropertyChanged(); } }
    }
}
