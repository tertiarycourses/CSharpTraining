class Book : Publication {
    private string _author;

    public Book(string name, string author, int pagecount, decimal price)
        : base(name, pagecount, price) {
        _author = author;
    }

    public string Author {
        get => _author;
        set => _author = value;
    }

    // use the override keyword to override a base class method
    public override string GetDescription() {
        return $"{Name} by {Author}, {PageCount} pages";
    }
}

