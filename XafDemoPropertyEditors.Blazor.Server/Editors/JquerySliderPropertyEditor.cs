using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace XafDemoPropertyEditors.Blazor.Server.Editors
{
    [PropertyEditor(typeof(int), "JquerySliderPropertyEditor", false)]
    public class JquerySliderPropertyEditor : BlazorPropertyEditorBase
    {
        public JquerySliderPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model) { }
        public override JquerySliderModel ComponentModel => (JquerySliderModel)base.ComponentModel;
        protected override IComponentModel CreateComponentModel()
        {
   

            var model = new JquerySliderModel();
            //HACK this is not needed, its only needed because the component they use in the documentation need it 
            //https://docs.devexpress.com/eXpressAppFramework/402189/ui-construction/view-items-and-property-editors/property-editors/implement-a-property-editor-based-on-custom-components-blazor#component-model
            //model.ValueExpression = () => model.Value;
            model.ValueChanged = EventCallback.Factory.Create<int>(this, value =>
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
            ComponentModel.Value = (int)PropertyValue;
        }
        protected override object GetControlValueCore() => ComponentModel.Value;
        protected override void ApplyReadOnly()
        {
            base.ApplyReadOnly();
            ComponentModel?.SetAttribute("readonly", !AllowEdit);
        }
    }
}
