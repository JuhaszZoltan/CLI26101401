class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public int BirthYear { get; set; }
    public List<string> FavFoods { get; set; }
    public bool Gender { get; set; }
    public int Age => DateTime.Now.Year - BirthYear;

    public override string ToString() => $"{Name} ({Species})";
}