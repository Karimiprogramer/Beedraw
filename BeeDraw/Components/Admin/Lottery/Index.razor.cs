using BeeDraw.Components.Shared.Admin.Dialogs;
using BeeDraw.Core.Services.Interfaces.Lottery;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BeeDraw.Components.Admin.Lottery
{
    public partial class Index
    {
        AdminDialog a= new AdminDialog();
        [Inject]
        ILotteryService LotteryService { get; set; }

        [Inject]
        IJSRuntime JSRuntime { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        //This method invokes when page loades
        protected override Task OnInitializedAsync()
        {
            
            return base.OnInitializedAsync();
        }

        #region (C)reate
        //Open Add entity modal
        async Task OpenAddDialog()
        {
            a.Open();
        }

        //Apply changes to Database
        async Task<int> AddEntity()
        {
            return 0;
        }
        #endregion

        #region (R)ead
        async Task UpdateTable()
        {

        }
        #endregion

        #region (U)pdate
        async Task OpenEditDialog()
        {

        }

        async Task UpdateEntity()
        {

        }
        #endregion

        #region (D)elete
        async Task OpenRemoveDialog()
        {

        }

        async Task RemoveEntity()
        {

        }
        #endregion
    }
}