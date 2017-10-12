using System;

public class Account
{
	private decimal balance = 0;
	
	public void Deposit(decimal amount)
	{
		if (amount == 0)
		{
			throw new ArgumentException("Can not deposit ammount of 0.00");
		}
		balance += amount;
	}

	public void Withdraw(decimal amount)
	{
		if (amount == 0)
		{
			throw new ArgumentException("Can not withdraw ammount of 0.00");
		}
		balance -= amount;
	}

	public void TransferFunds(Account destinationAcc, decimal amount)
	{
		if (destinationAcc == this)
		{
			throw new ArgumentException(
				"Source and destination accounts can not be the same");
		}
		balance -= amount;
		destinationAcc.balance += amount;
	}

	public decimal Balance
	{
		get
		{
			return balance;
		}
	}
}