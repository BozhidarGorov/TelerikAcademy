using System;

class TheCompany
{
    static void Main()
    {
        string name = Console.ReadLine();
        string addres = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        int phoneNumber = int.Parse(Console.ReadLine());
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        int managerPhoneNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Firm name: {0} \nFirm addres: {1}",name,addres);
        Console.WriteLine("Firm Fax Number: {0} \nFirm Phone Number: {1}",faxNumber,phoneNumber);
        Console.WriteLine("Firm Website: {0} \nManager First Name: {1}",webSite,managerFirstName);
        Console.WriteLine("Manager Last Name: {0} \nManager age: {1} \nManagr Phone Number: {2}"
            ,managerLastName,managerAge,managerPhoneNumber);
    }
}

