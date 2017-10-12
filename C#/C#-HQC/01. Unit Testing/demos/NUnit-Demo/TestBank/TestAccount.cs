using System;
using NUnit.Framework;

[TestFixture]
public class TestAccount
{
	[Test]
	public void TestDeposit()
	{
		Account acc = new Account();
		acc.Deposit(200.00m);
		decimal balance = acc.Balance;
		Assert.AreEqual(balance, 200F);
	}

	[Test]
	[ExpectedException(typeof(ArgumentException))]
	public void TestDepositZero()
	{
		Account acc = new Account();
		acc.Deposit(0);
	}

	[Test]
	public void TestDepositNegative()
	{
		Account acc = new Account();
		acc.Deposit(-150.30m);
        decimal balance = acc.Balance;
		Assert.AreEqual(balance, -150.30F);
	}

	[Test]
	public void TestWithdraw()
	{
		Account acc = new Account();
		acc.Withdraw(138.56m);
		decimal balance = acc.Balance;
		Assert.AreEqual(balance, -138.56F);
	}

	[Test]
	[ExpectedException(typeof(ArgumentException))]
	public void TestWithdrawZero()
	{
		Account acc = new Account();
		acc.Withdraw(0);
	}

	[Test]
	public void TestWithdrawNegative()
	{
		Account acc = new Account();
		acc.Withdraw(-3.14m);
        decimal balance = acc.Balance;
		Assert.AreEqual(balance, 1000F);
	}

	[Test]
	public void TestTransferFunds()
	{
		Account source = new Account();
		source.Deposit(200.00m);
		Account dest = new Account();
		dest.Deposit(150.00m);
		source.TransferFunds(dest, 100.00m);
		Assert.AreEqual(250.00F, dest.Balance);
		Assert.AreEqual(100.00F, source.Balance);
	}

	[Test]
	[ExpectedException(typeof(NullReferenceException))]
	public void TestTransferFundsFromNullAccount()
	{
		Account source = null;
		Account dest = new Account();
		dest.Deposit(200.00m);
		source.TransferFunds(dest, 100.00m);
	}

	[Test]
	[ExpectedException(typeof(NullReferenceException))]
	public void TestTransferFundsToNullAccount()
	{
		Account source = new Account();
		source.Deposit(200.00m);
		Account dest = null;
		source.TransferFunds(dest, 100.00m);
	}

	[Test]
	[ExpectedException(typeof(ArgumentException))]
	public void TestTransferFundsSameAccount()
	{
		Account source = new Account();
		source.Deposit(200.00m);
		Account dest = source;
		source.TransferFunds(dest, 100.00m);
	}

	[Test]
	public void TestDepositWithdrawTransferFunds()
	{
		Account source = new Account();
		source.Deposit(200.00m);
		source.Withdraw(100.00m);

		Account dest = new Account();
		dest.Deposit(150.00m);
		dest.Withdraw(50.00m);

		source.TransferFunds(dest, 100.00m);
		Assert.AreEqual(0.00F, source.Balance);
		Assert.AreEqual(200.00F, dest.Balance);
	}
}
