using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;
using XafDemoPropertyEditors.Module.BusinessObjects;

namespace XafDemoPropertyEditors.Blazor.Server.Editors
{
    public class PictureItemListViewModel : ComponentModelBase
    {
        public IEnumerable<IPictureItem> Data
        {
            get => GetPropertyValue<IEnumerable<IPictureItem>>();
            set => SetPropertyValue(value);
        }
        public EventCallback<IPictureItem> ItemClick
        {
            get => GetPropertyValue<EventCallback<IPictureItem>>();
            set => SetPropertyValue(value);
        }
        public override Type ComponentType => typeof(PictureItemListView);
    }
}
