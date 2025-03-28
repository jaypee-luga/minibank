using System;
using System.Net.Sockets;

namespace minibank.api.Models;

public class BankEntity
{
    public int EntityId { get; private set; }
    public string Name { get; private set; }
    public string Address { get; set; }
    public bool Status { get; set; }
}
