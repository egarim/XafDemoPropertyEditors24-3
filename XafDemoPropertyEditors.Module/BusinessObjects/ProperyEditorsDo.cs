using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafDemoPropertyEditors.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://docs.devexpress.com/eXpressAppFramework/112701/business-model-design-orm/data-annotations-in-data-model).
    public class ProperyEditorsDo : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://docs.devexpress.com/eXpressAppFramework/113146/business-model-design-orm/business-model-design-with-xpo/base-persistent-classes).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ProperyEditorsDo(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.SliderValue = 30;
            // Place your initialization code here (https://docs.devexpress.com/eXpressAppFramework/112834/getting-started/in-depth-tutorial-winforms-webforms/business-model-design/initialize-a-property-after-creating-an-object-xpo?v=22.1).
        }

        int sliderValue;
        string apellidos;
        string nombre;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get => nombre;
            set => SetPropertyValue(nameof(Nombre), ref nombre, value);
        }
        [EditorAlias("MyTextboxPropertyEditor")]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Apellidos
        {
            get => apellidos;
            set => SetPropertyValue(nameof(Apellidos), ref apellidos, value);
        }
        //HACK como asignar un property editor //https://supportcenter.devexpress.com/Ticket/Details/KA18907/how-to-specify-an-xaf-property-editor-for-properties-and-types#:~:text=Specify%20a%20property%20editor%20alias%20by%20applying%20EditorAliasAttribute,editors%20have%20aliases%20declared%20in%20the%20DevExpress.ExpressApp.Editors.EditorAliases%20struct.
        [EditorAlias("JquerySliderPropertyEditor")]
        //[ModelDefault("PropertyEditorType", "XafDemoPropertyEditors.Blazor.Server.Editors.JquerySliderPropertyEditor")]
        public int SliderValue
        {
            get => sliderValue;
            set => SetPropertyValue(nameof(SliderValue), ref sliderValue, value);
        }
    }
}