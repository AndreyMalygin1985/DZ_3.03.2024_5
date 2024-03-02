using static System.Console;

// Создайте класс «Журнал». Необходимо хранить в полях класса: название журнала, год основания,
// описание журнала, контактный телефон, контактный e-mail. Реализуйте методы класса для ввода
// данных, вывода данных, реализуйте доступ к отдельным полям через методы класса.

class Journal
{
    private string journalName;
    private int foundationYear;
    private string description;
    private string contactPhone;
    private string contactEmail;

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetFoundationYear(int year)
    {
        foundationYear = year;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public void SetDescription(string desc)
    {
        description = desc;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetContactEmail(string email)
    {
        contactEmail = email;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }

    public void InputData()
    {
        WriteLine("Введите название журнала:");
        journalName = ReadLine();

        WriteLine("Введите год создания:");
        foundationYear = Convert.ToInt32(ReadLine());

        WriteLine("Введите описание журнала:");
        description = ReadLine();

        WriteLine("Введите контактный телефон:");
        contactPhone = ReadLine();

        WriteLine("Введите Email:");
        contactEmail = ReadLine();
    }

    public void DisplayData()
    {
        WriteLine($"Название журнала:    {journalName}");
        WriteLine($"Год создания:        {foundationYear}");
        WriteLine($"Описание журнала:    {description}");
        WriteLine($"Контактный телефон:  {contactPhone}");
        WriteLine($"Email:               {contactEmail}");
    }
}

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        myJournal.InputData();
        WriteLine("\nОписание журнала:");
        myJournal.DisplayData();
    }
}