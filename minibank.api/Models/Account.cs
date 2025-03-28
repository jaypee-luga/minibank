using System;

namespace minibank.api.Models;

public class Account
{
    public int AccountId { get; set; }
    public int BankEntityId { get; set; }
    public string AccountName { get; set; }
    public long Balance { get; set; }

}
