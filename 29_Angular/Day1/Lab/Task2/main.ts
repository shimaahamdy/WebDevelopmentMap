class Account{
    Accnum:number;
    Balance:number;

    constructor(accnum:number,balance:number)
    {
        this.Accnum = accnum;
        this.Balance = balance;
    }

    DepitAmount():void
    {
        console.log("depit amount");
    }
    CreditAmount():boolean{
        
        console.log("Credit amount")
        return true;
    }
    get getBalance()
    {
        return this.Balance;
    }

}
interface IAccount
{
    DateOfOpening:Date;

    addCustomer():boolean;
    removeCustomer():boolean;
}

class CurrentAccount extends Account implements IAccount
{
    DateOfOpening:Date;
    constructor(accNum:number,balnce:number,public interstRate=0,DOP:Date)
    {
        super(accNum,balnce)
        this.DateOfOpening = DOP;
    }
   
    CreditAmount(): boolean {
        console.log("current account override creditAmount");
        return true;
    }

    addCustomer() {
        console.log("currentAccount override addCustomer");
        return true;
    }
    removeCustomer() {
        console.log("currentAccount override RemoveCustomer");
        return true;
    }

}

class SavingAccount extends Account implements IAccount
{
    DateOfOpening: Date;
    constructor(accNum:number,balnce:number,public MinBalance=0,DOP:Date)
    {
        super(accNum,balnce);
        this.DateOfOpening = DOP;
    }
    

    addCustomer() {
        console.log("savingAccount override addCustomer");
        return true;
    }
    removeCustomer() {
        console.log("saving Account override RemoveCustomer");
        return true;
    }

}

// ************************************************ */
var MainAccount  = new Account(1500,300);
console.log(MainAccount.getBalance);
MainAccount.CreditAmount();
MainAccount.DepitAmount();

var CurrAccount = new CurrentAccount(1690,5076,5,new Date("1995-3-3"));
CurrAccount.CreditAmount();
CurrAccount.addCustomer();


var SavAccount = new SavingAccount(2369,4,5,new Date("1669-6-13"));
console.log("saveAccount"+SavAccount.DateOfOpening);
SavAccount.removeCustomer();
SavAccount.DepitAmount();

