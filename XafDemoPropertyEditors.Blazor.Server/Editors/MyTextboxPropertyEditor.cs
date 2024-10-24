using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Microsoft.AspNetCore.Components;

namespace XafDemoPropertyEditors.Blazor.Server.Editors
{

    
    [PropertyEditor(typeof(string), "MyTextboxPropertyEditor", false)]
    public class MyTextboxPropertyEditor : BlazorPropertyEditorBase
    {
        public MyTextboxPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        public override MyTextboxPropertyEditorModel ComponentModel => (MyTextboxPropertyEditorModel)base.ComponentModel;
        protected override IComponentModel CreateComponentModel()
        {
            var model = new MyTextboxPropertyEditorModel();
            model.ValueExpression = () => model.Value;
            model.ValueChanged = EventCallback.Factory.Create<string>(this, value =>
            {
                model.Value = value;
                OnControlValueChanged();
                WriteValue();
            });
            return model;
        }
        protected override void ReadValueCore()
        {
            base.ReadValueCore();
            ComponentModel.Value = (string)PropertyValue;
        }
        protected override object GetControlValueCore() => ComponentModel.Value;
        protected override void ApplyReadOnly()
        {
            base.ApplyReadOnly();
            ComponentModel?.SetAttribute("readonly", !AllowEdit);
        }
    }
}
