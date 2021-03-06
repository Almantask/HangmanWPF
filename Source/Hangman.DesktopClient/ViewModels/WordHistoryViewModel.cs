﻿using HangmanWPF.Commands;
using HangmanWPF.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HangmanWPF.ViewModels
{
    public class WordHistoryViewModel
    {
        public ObservableCollection<HangmanGameRecord> GameHistoryCollection { get; set; } = new ObservableCollection<HangmanGameRecord>();

        public ICommand OpenInGoogleCommand { get; set; }

        public WordHistoryViewModel()
        {
            OpenInGoogleCommand = new ActionCommand<string>(OpenInGoogle);
            GetHistory();
        }

        private void GetHistory()
        {
            foreach (var item in RepositoryContainer.GameRecords.Get())
            {
                GameHistoryCollection.Add(item);
            }
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
