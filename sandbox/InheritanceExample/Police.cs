class Police : Person
{
    private string _weapons;
    public Police(string firstName, string lastName, int age, string weapons) :base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"Weapons: {_weapons}, {GetPersonInfo()}";
    }

    public override string GetPersonInfo()
    {
        return $"I am a police man, my favorite weapon is: {_weapons}, and my info is: {base.GetPersonStats()}";
    }
}