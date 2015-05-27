using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WordSearcher
{
    /// <summary>
    /// Main class for View Model
    /// TODO: follow guidelines
    /// </summary>
    public class TextViewModel : ITextViewModel
    {
        private readonly IDispatcher _dispatcher;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public TextViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            this.Content = Globals.LoremIpsum;
            this.QueryHistory = new List<string>();
            //this.SelectedMethod = SearchMethods;
        }

        public string Query
        {
            get
            {
                return this.Query;
            }
            set
            {
                if (value != this.Query)
                {
                    this.Query = value;
                    NotifyPropertyChanged("Query");
                }
            }
        }

        public string Content
        {
            get
            {
                return this.Content;
            }
            set
            {
                if (value != this.Content)
                {
                    this.Content = value;
                    NotifyPropertyChanged("Content");
                }
            }
        }

        public System.Windows.Input.ICommand SearchCommand
        {
            get { throw new NotImplementedException(); }
        }

        public string SearchResult
        {
            get
            {
                return this.SearchResult;
            }
            set
            {
                if (value != this.SearchResult)
                {
                    this.SearchResult = value;
                    NotifyPropertyChanged("SearchResult");
                }
            }
        }

        public System.Windows.Input.ICommand SaveSearchesCommand
        {
            get { throw new NotImplementedException(); }
        }

        public ASearcher SelectedMethod
        {
            get
            {
                return this.SelectedMethod;
            }
            set
            {
                if (value != this.SelectedMethod)
                {
                    this.SelectedMethod = value;
                    NotifyPropertyChanged("SelectedMethod");
                };
            }
        }

        public IEnumerable<ASearcher> SearchMethods
        {
            get
            {
                return this.SearchMethods;
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public List<string> QueryHistory { get; set; }
    }
}
