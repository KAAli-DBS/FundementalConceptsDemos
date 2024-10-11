//3. Using Symbol (Semi-Private Properties)
//You can also achieve a sort of pseudo-encapsulation using the Symbol data type. 
//Properties defined with Symbol are harder to access and modify from outside the object, 
//although they are not fully private.

//Making two different attributes private by usinh Symbol
// 1. Balance 2. Deposit Amount 

const secretKey = Symbol('secretKey');

class BankAccount {
  constructor(owner, balance) {
    this.owner = owner;          // Public property
    this[secretKey] = balance;   // Symbol-based "private" property
  }

  getBalance() {
    return this[secretKey];
  }

  deposit(amount) {
    this[secretKey] += amount;
  }
}

const account = new BankAccount('Alice', 1000);
//console.log(account.owner);           
//console.log(account.getBalance());    
account.deposit(500);
//console.log(account.getBalance());    
//console.log(account.secretKey);   
console.log(account[secretKey]);    