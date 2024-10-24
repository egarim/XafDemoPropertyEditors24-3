using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;

namespace XafDemoPropertyEditors.Blazor.Server.Editors
{
    public class MyTextboxPropertyEditorModel : ComponentModelBase
    {
        public string Value
        {
            get => GetPropertyValue<string>();
            set => SetPropertyValue(value);
        }
        public EventCallback<string> ValueChanged
        {
            get => GetPropertyValue<EventCallback<string>>();
            set => SetPropertyValue(value);
        }
        public Expression<Func<string>> ValueExpression
        {
            get => GetPropertyValue<Expression<Func<string>>>();
            set => SetPropertyValue(value);
        }
        public override Type ComponentType => typeof(MyTextbox);
    }
}
