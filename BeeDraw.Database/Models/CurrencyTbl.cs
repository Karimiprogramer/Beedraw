using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class CurrencyTbl: EntityBase
{
    public required string Name { get; set; }  //"USD", "BTC"

    public ICollection<WalletBalanceTbl>? WalletBalances { get; set; }
}