﻿namespace AddressBook
{
    public class Recipe : IMatchATerm
    {
        public Recipe(string title)
        {
            _title = title;
        }

        public bool Matches(string term)
        {
            return _title.ToLower().Contains(term.ToLower());
        }

        public override string ToString()
        {
            return _title;
        }

        private string _title;
    }
}
