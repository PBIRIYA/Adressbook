using System;



namespace AddressBook

{

    public class contact

    {

        String FirstName;

        String LastName;

        String PhoneNumber;

        String Address;

        String zipCode;

        String Email;



        public contact(String FirstName, String LastName, String PhoneNumber, String Address, String zipCode, String Email)

        {

            this.FirstName = FirstName;

            this.LastName = LastName;

            this.PhoneNumber = PhoneNumber;

            this.Address = Address;

            this.zipCode = zipCode;

            this.Email = Email;

        }



        public class Person

        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string PhoneNumber { get; set; }

            public string Address { get; set; }

            public string zipCode { get; set; }

            public string Email { get; set; }

        }

        static void Main(string[] args)

        {

            contact person = new contact("divya", "singh", "1234", "seoni", "462003", "abcd@gmail.com");

            Console.WriteLine("Enter Your First Name" + person.FirstName);

            Console.WriteLine("Enter Your Last Name" + person.LastName);

            Console.WriteLine("Enter PhoneNumber" + person.PhoneNumber);

            Console.WriteLine("Enter Your Zipcode" + person.zipCode);

            Console.WriteLine("Enter Your Email" + person.Email);





        }

        public void add()

        {

            Console.WriteLine("Would you like to  add a person in your Address Book? (add)");

            string response = Console.ReadLine();

            if (response.ToLower() == "add")

            {

                this.addToAddressBook();

            }

            else

            {

                Console.WriteLine("Your must enter 'add' to continue");

                this.add();

            }

        }

        public void addToAddressBook()

        {

            Console.WriteLine("Enter the first name");

            string FirstName = Console.ReadLine();



            Console.WriteLine("Enter the last name");

            string LastName = Console.ReadLine();



            Console.WriteLine("Enter the phone number");

            string PhoneNumber = Console.ReadLine();



            Console.WriteLine("Enter the ZipCode");

            string zipCode = Console.ReadLine();



            Console.WriteLine("Enter the address");

            string Address = Console.ReadLine();



            Console.WriteLine("Enter the email address");

            string Email = Console.ReadLine();



            contact person = new contact(FirstName, LastName, PhoneNumber, zipCode, Address, Email);



            Console.WriteLine("");

            Console.WriteLine("We have added - " + person.FirstName + " " + person.LastName + " to the database");

            Console.WriteLine("");





            this.add();



        }



    }

}
