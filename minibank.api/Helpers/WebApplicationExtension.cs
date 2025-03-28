using System;

namespace minibank.api.Helpers;

public static class WebApplicationExtension
{
    public static WebApplication MapEndPoints(this WebApplication app)
    {
        app.MapGet("/checkBalance", checkBalance);
        app.MapGet("/showAccounts", showAccounts);
        app.MapGet("/", () => "Hello World!");
        return app;
    }

    private static List<string> showAccounts()
    {
        return new List<string>() { "Savings", "Expense", "Payroll" };
    }

    private static int checkBalance(int id)
    {
        return 20000000;
    }

    private static bool balanceTransfer(int srcAccntId, int targetAccntId, long amount, string desc)
    {
        return default;
    }

    private static bool enrollBiller()
    {
        return default;
    }

    private static bool payBiller()
    {
        return default;
    }




}
