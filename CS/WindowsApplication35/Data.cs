using System;
// ...

namespace WindowsApplication35 {
    class Data {
        public Data() {
        }
        private int _id;
        private string _name;
        private DateTime _date;
        public int Id {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }
        public DateTime Date {
            get { return this._date; }
            set { this._date = value; }
        }
    }
}
