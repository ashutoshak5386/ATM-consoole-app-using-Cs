using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(String cardNum, int pin, string firstName, string lastName, double balance)
    
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newfirstName)
    {
        firstName = newfirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void main(String[] args){

        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposite");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposite: ");
            double deposite = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thankyou for your $$. Your new balance is: "+ currentUser);
        }
        void Withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            if(currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You're good to go! Thank you:)");

            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: "+ currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4532772818527395",1234,"John","griffith",150.31));
        cardHolders.Add(new cardHolder("4532772452613845",5386,"Ravi","kumar",321.13));
        cardHolders.Add(new cardHolder("4541561842814828",8775,"Rahul","Sah",105.59));
        cardHolders.Add(new cardHolder("4532772841257287",4527,"Ashu","Kumar",851.84));
        cardHolders.Add(new cardHolder("4532772818542254",1428,"Ritik","Roshan",54.27));

        Console.WriteLine("Welcome to Simple ATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        
        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstorDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) {break;}
                else{ Console.WriteLine("Card not recognised. Please try agian");}
            }
            catch {Console.WriteLine("Card not recognised. Please try agian");}   
        }
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while(true)
        {
             try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) {break;}
                else{ Console.WriteLine("Incorrect Pin. Please try again");}
            }
            catch {Console.WriteLine("Incorrect Pin. Please try again");}
        }

        Console.WriteLine("Welcome" + currentUser.getFirstName()+ ":)");
        int option = 0;
        do
        {
            printOptions();
            try{
                option = int.Parse(Console.ReadLine());
            }
            catch{ }
            if(option == 1) { deposit(currentUser);}
            else if(option == 2) {withdraw(currentUser);}
            else if(option == 3) { balance(currentUser); }
            else if(option == 4) {break; }
            else {option == 0;}
        } 
        while (option !=4);
        Console.WriteLine("Thankyou! Have a nice day :) ");
        
    }


}
    
