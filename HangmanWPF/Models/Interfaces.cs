﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWPF.Models
{
    public interface IWordDataBase
    {

        int WordCount { get; }

        IEnumerable<string> GetRandomSetOfWords(int amount);
    }
}
