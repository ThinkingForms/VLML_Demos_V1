using System;
using VL.Lib.Collections;

namespace ModelEnums
{
    public class ModelPickDefinition : ManualDynamicEnumDefinitionBase<ModelPickDefinition>
    {
        public static ModelPickDefinition Instance => ManualDynamicEnumDefinitionBase<ModelPickDefinition>.Instance;

        override protected bool AutoSortAlphabetically => false;
    }

    [Serializable]
    public class ModelPick : DynamicEnumBase<ModelPick, ModelPickDefinition>
    {
        public ModelPick(string value) : base(value)
        {
        }

        //this method needs to be imported in VL to set the default
        public static ModelPick CreateDefault() => CreateDefaultBase("No Model Found");
        //{
        //    //use method of base class if nothing special required
        //    return ModelPick CreateDefaultBase() 
        //}
    }
}
