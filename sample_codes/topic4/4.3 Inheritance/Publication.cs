   class Publication
    {
        private string _name;
        public Publication(string name, int pagecount, decimal price) {
           _name = name;
           PageCount = pagecount;
           Price = price;
        }
        public int PageCount {
            get; set;
        }
        public decimal Price {
            get; set;
        }
        public string Name {
            // return the name
            get { return _name; }
            
            // use the setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }
        public virtual string GetDescription() {
            return $"{Name}, {PageCount} pages";
        }
    }

    