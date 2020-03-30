namespace Sandbox
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private int _TelephoneNumber;
        public Person(string Name, int Age, int TelephoneNumber)
        {
            _Name = Name;
            _Age = Age;
            _TelephoneNumber = TelephoneNumber;
        }
        public string Name
        {
            get{return _Name;}
        }
        public int Age
        {
            get{return _Age;}
        }
        public int TelephoneNumber
        {
            get{return _TelephoneNumber;}
        }
        public void IncreaseAge()
        {
            _Age = _Age + 1;
        }
    }
}