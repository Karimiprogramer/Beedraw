using BeeDraw.Database.SeedWorks.Base;

namespace BeeDraw.Database.Models;

public class WalletBalanceTbl: EntityBase 
{
    public decimal Balance { get; set; }  
    
    public int WalletId { get; set; }  
    public WalletTbl? Wallet { get; set; }
    
    public int CurrencyId { get; set; }  
    public CurrencyTbl? Currency { get; set; }
}