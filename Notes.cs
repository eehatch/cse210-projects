using System;

class Notes
{
    static void Main(string[] args)
    {
        private string _name = "hi"; {get; set;}; // DO NOT DO THIS    DO THE BELOW FORMAT
        private string _name;

        public string GetName()
        {
            return _name;
        }
        public string SetName(string s)
        {
            _name = s;
        }
    }
}