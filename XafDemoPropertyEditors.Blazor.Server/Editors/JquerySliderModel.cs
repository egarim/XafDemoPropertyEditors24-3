using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.XtraRichEdit.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel;
using System.Linq.Expressions;
namespace XafDemoPropertyEditors.Blazor.Server.Editors
{

    //HACK https://docs.devexpress.com/eXpressAppFramework/402189/ui-construction/view-items-and-property-editors/property-editors/implement-a-property-editor-based-on-custom-components-blazor#component-model
    //Create a ComponentModelBase descendant and name it InputTextModel.
    //In this class, declare properties that you will set in the underlying InputText component.
    //The properties must have the same type and name as their counterparts in the component.
    //In this example, use Value, ValueChanged, and ValueExpression properties.
    //Override the ComponentType method and return the type of the component.
    //XAF automatically creates a RenderFragment﻿ to render InputText based on properties and component type specified in the Component Model.
    public class JquerySliderModel : ComponentModelBase
    {
        public int Value
        {
            get => GetPropertyValue<int>();
            set
            {
                SetPropertyValue(value);
            }
        }
        public EventCallback<int> ValueChanged
        {
            get => GetPropertyValue<EventCallback<int>>();
            set
            {
                SetPropertyValue(value);
            }
        }
        //public Expression<Func<int>> ValueExpression
        //{
        //    get => GetPropertyValue<Expression<Func<int>>>();
        //    set
        //    {
        //        SetPropertyValue(value);
        //    }
        //}
        public override Type ComponentType => typeof(JquerySliderComponent);
    }
}
