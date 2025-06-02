namespace dyreinternat___library.Models;

public class Account
{
    // Unik identifikator for kontoen.
    public int AccountID { get; set; }

    // Navn på kontoejeren.
    public string Name { get; set; }

    // E-mailadresse til kontoejeren.
    public string Email { get; set; }

    // Telefonnummer til kontoejeren.
    public string Tlf { get; set; }

    // Initialiserer en ny instans af Account-klassen med angivne værdier.
    // accountID: Unikt ID for kontoen.
    // name: Navn på kontoejeren.
    // email: E-mailadresse til kontoejeren.
    // tlf: Telefonnummer til kontoejeren.
    public Account(int accountID, string name, string email, string tlf)
    {
        AccountID = accountID;
        Name = name;
        Email = email;
        Tlf = tlf;
    }

    // Parameterløs constructor til Account-klassen.
    public Account() { }
}


