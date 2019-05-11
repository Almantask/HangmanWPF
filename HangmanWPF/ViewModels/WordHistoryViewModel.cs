﻿using HangmanWPF.Commands;
using HangmanWPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HangmanWPF.ViewModels
{
    public class WordHistoryViewModel
    {
        public ObservableCollection<HangmanGameRecord> GameHistory { get; set; } = new ObservableCollection<HangmanGameRecord>();

        public ICommand OpenInGoogleCommand { get; set; }

        public WordHistoryViewModel()
        {
            OpenInGoogleCommand = new ActionCommand<string>(this.OpenInGoogle);

            GetHistory();
        }

        private void GetHistory()
        {

        }

        private void OpenInGoogle(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return;
            }

            string searchterm = $"DEFINE: {word}";

            string url = $"http://google.com/search?q={searchterm}";

            System.Diagnostics.Process.Start(url);
        }
    }

}
