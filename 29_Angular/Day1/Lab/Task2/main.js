class Account {
    constructor(accnum, balance) {
        this.Accnum = accnum;
        this.Balance = balance;
    }
    DepitAmount() {
        console.log("depit amount");
    }
    CreditAmount() {
        console.log("Credit amount");
        return true;
    }
    get getBalance() {
        return this.Balance;
    }
}
class CurrentAccount extends Account {
    constructor(accNum, balnce, interstRate = 0, DOP) {
        super(accNum, balnce);
        this.interstRate = interstRate;
        this.DateOfOpening = DOP;
    }
    CreditAmount() {
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
class SavingAccount extends Account {
    constructor(accNum, balnce, MinBalance = 0, DOP) {
        super(accNum, balnce);
        this.MinBalance = MinBalance;
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
var MainAccount = new Account(1500, 300);
console.log(MainAccount.getBalance);
MainAccount.CreditAmount();
MainAccount.DepitAmount();
var CurrAccount = new CurrentAccount(1690, 5076, 5, new Date("1995-3-3"));
CurrAccount.CreditAmount();
CurrAccount.addCustomer();
var SavAccount = new SavingAccount(2369, 4, 5, new Date("1669-6-13"));
console.log("saveAccount Date: " + SavAccount.DateOfOpening);
SavAccount.removeCustomer();
SavAccount.DepitAmount();
