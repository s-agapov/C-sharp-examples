// See https://aka.ms/new-console-template for more information
using FundsOperationConsole;

WithdrawFundsUI ui = new();
//WithDrawFundsWorkflow workflow = new();


ui.enterCard();

Console.WriteLine("Номер вашей карты: " + ui.card);
bool valid = false;
if (ui.card != "")
{    
    valid = ui.enterPIN();
}

if (valid)
{
    Console.WriteLine("Session start");
    Console.WriteLine("Customer: " + ui.workflow.customer);
    ui.workflow.getAccounts("Accounts.txt");
    ui.displayAccounts();
    ui.selectAccount();

    double res = ui.enterAmount();
    ui.workflow.withdraw(res);
    ui.displayAccounts();
    Console.WriteLine("Session end");
} else
{
    Console.WriteLine("Incorrect PIN. Session end");
    return;
}

