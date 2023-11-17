class BankAccount:
    def __init__(self, int_rate=0.02, balance=0):
        self.int_rate = int_rate
        self.balance = balance

    def deposit(self, amount):
        self.balance += amount
        return self

    def withdraw(self, amount):
        if self.balance >= amount:
            self.balance -= amount
        else:
            print("Insufficient funds: Charging a $5 fee")
            self.balance -= 5
        return self

    def display_account_info(self):
        print(f"Balance: ${self.balance}")
        return self

    def yield_interest(self):
        if self.balance > 0:
        return self


class User:
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.accounts = {}  

    def create_account(self, account_name, int_rate=0.02, balance=0):
        self.accounts[account_name] = BankAccount(int_rate, balance)
        return self

    def make_deposit(self, account_name, amount):
        if account_name in self.accounts:
            self.accounts[account_name].deposit(amount)
        else:
            print("Account not found.")
        return self

    def make_withdrawal(self, account_name, amount):
        if account_name in self.accounts:
            self.accounts[account_name].withdraw(amount)
        else:
            print("Account not found.")
        return self

    def display_user_balance(self, account_name):
        if account_name in self.accounts:
            print(f"{self.name}'s {account_name} account balance:")
            self.accounts[account_name].display_account_info()
        else:
            print("Account not found.")